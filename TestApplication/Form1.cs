using PushSharp.Google;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using dotAPNS;
using Newtonsoft.Json.Linq;
using PushSharp.Apple;

namespace TestApplication
{
    public partial class Form1 : Form
    {
        private delegate void SafeCallDelegate(string text);
        private delegate void SafeCallDelegateAndroid(string text);

        public Form1()
        {
            InitializeComponent();
        }

        private bool stopPushAndroid = false;
        private GcmServiceBroker brokerAndroid = null;
        private void button1_Click(object sender, EventArgs e)
        {
            var config = new GcmConfiguration(senderAuthTokenTextBox.Text.Trim());
            config.GcmUrl = "https://fcm.googleapis.com/fcm/send";
            brokerAndroid = new GcmServiceBroker(config);
            brokerAndroid.OnNotificationFailed += (notification, exception) => {

            };
            brokerAndroid.OnNotificationSucceeded += (notification) => {

            };

            brokerAndroid.Start();

            brokerAndroid.QueueNotification(new GcmNotification
            {
                RegistrationIds = new List<string> {
                    regIdTextBox.Text.Trim()
                },
                Data = JObject.Parse("{\"message\" : \"" + androidMessageTextBox.Text + "\"}")
            });

            brokerAndroid.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num++;
            broker.QueueNotification(new ApnsNotification
            {
                DeviceToken = deviceTokenTextBox.Text.Trim(),
                Payload = JObject.Parse("{ \"aps\" : { \"alert\" : \"test\" } }")
            });
        }

        private ApnsServiceBroker broker;
        private void StartBrokerIos()
        {
            // Vecchia versione di invio per IOS
            System.Security.Cryptography.X509Certificates.X509Certificate2 v_XC = null;
            var debug = debugComboBox.Text.Equals("true");

            var cert = certComboBox.Text;

            v_XC = new System.Security.Cryptography.X509Certificates.X509Certificate2(
                File.ReadAllBytes(cert), "",
                System.Security.Cryptography.X509Certificates.X509KeyStorageFlags.MachineKeySet);

            var config = new PushSharp.Apple.ApnsConfiguration(
                debug
                    ? ApnsConfiguration.ApnsServerEnvironment.Sandbox
                    : ApnsConfiguration.ApnsServerEnvironment.Production, v_XC, false);

            broker = new ApnsServiceBroker(config);
            broker.OnNotificationFailed += (notification, exception) =>
            {
                //Http2: BadDeviceToken

                // Http2: InvalidPushType => verificare se sandbox o prod
                var error = exception?.InnerException?.Message;
                WriteResult($"Ko old {notification.Tag} - {exception?.InnerException?.Message} - " +
                            $"{exception?.InnerException?.InnerException?.Message}");
            };
            broker.OnNotificationSucceeded += (notification) =>
            {
                WriteResult($"OK old {notification.Tag} id:{notification.DeviceToken}");
            };

            broker.Start();

            //https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/sending_notification_requests_to_apns
            /*If you set this push type, the apns-topic header field must use your app’s bundle ID with .voip appended to the end*/


        }

        private void StopBrokerIos()
        {
            broker.Stop();
        }

        private void WriteResult(string text)
        {
            if (resultTextBoxt.InvokeRequired)
            {
                var d = new SafeCallDelegate(WriteResult);
                resultTextBoxt.Invoke(d, new object[] { text });
            }
            else
            {
                received++;
                resultTextBoxt.Text = text + Environment.NewLine + resultTextBoxt.Text;
                countLabel.Text = $"Inviate {num} / {received}";
            }
        }

        private bool stopPush = false;
        private ApnsHttp2ServiceBroker brokerIos = null;
        private void startButton_Click(object sender, EventArgs e)
        {
           startBrokerIosHttp2();

           startButton.Enabled = false;
           progressBar1.Style = ProgressBarStyle.Marquee;
           progressBar1.MarqueeAnimationSpeed = 30;
           stopPush = false;
           while (stopPush)
           {
               Thread.Sleep(1000);
           }
        }

        private void startBrokerIosHttp2()
        {
            System.Security.Cryptography.X509Certificates.X509Certificate2 v_XC = null;
            var debug = debugComboBox.Text.Equals("true");

            var cert = certComboBox.Text;

            v_XC = new System.Security.Cryptography.X509Certificates.X509Certificate2(
                System.IO.File.ReadAllBytes(cert), "",
                System.Security.Cryptography.X509Certificates.X509KeyStorageFlags.MachineKeySet);

            if (v_XC.NotAfter < DateTime.Now)
            {
                expireLabel.Text = $"EXPIRED on {v_XC.NotAfter.ToShortDateString()} !!";
                expireLabel.ForeColor = Color.Red;
            }
            else
            {
                expireLabel.Text = $"Expire on {v_XC.NotAfter.ToShortDateString()}";
                expireLabel.ForeColor = Color.Black;
            }

            var config2 = new ApnsHttp2Configuration(
                debug
                    ? ApnsHttp2Configuration.ApnsServerEnvironment.Sandbox
                    : ApnsHttp2Configuration.ApnsServerEnvironment.Production, v_XC);

            brokerIos = new ApnsHttp2ServiceBroker(config2);
            brokerIos.OnNotificationFailed += BrokerOnOnNotificationFailed;
            brokerIos.OnNotificationSucceeded += BrokerOnOnNotificationSucceeded;

            brokerIos.Start();
        }

        private void BrokerOnOnNotificationSucceeded(ApnsHttp2Notification notification)
        {
            WriteResult($"OK {notification.Tag} id:{notification.DeviceToken}");
        }

        private void BrokerOnOnNotificationFailed(ApnsHttp2Notification notification, AggregateException exception)
        {
            //Http2: BadDeviceToken
            // Chiamata a SSPI non riuscita. Vedere l'eccezione interna. - Il certificato ricevuto è scaduto
            // Http2: InvalidPushType => verificare se sandbox o prod
            // Http2: BadExpirationDate la proprietà Expiration settata sul ApnsHttp2Notification non è valida
            // Http2: DeviceTokenNotForTopic

            WriteResult($"{notification.Tag} - {exception?.InnerException?.Message} - " +
                        $"{exception?.InnerException?.InnerException?.Message}");
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopPush = true;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;
            expireLabel.Text = "";

            StopBrokerIosHttp2();
        }

        private void StopBrokerIosHttp2()
        {
            brokerIos.Stop();
        }

        private int num = 0;
        private int received = 0;
        private void Add_Click(object sender, EventArgs e)
        {
            //https://developer.apple.com/documentation/usernotifications/setting_up_a_remote_notification_server/sending_notification_requests_to_apns
            /*If you set this push type, the apns-topic header field must use your app’s bundle ID with .voip appended to the end*/
            var bundleId = bundleIdComboBox.Text.Trim();
            var voip = pushTypeComboBox.Text.Equals("voip");
            var topic = voip ? $"{bundleId}.voip" : bundleId;

            var voipPayload = @"{
                    'aps' : {
                        'alert' : '',
                        'badge' : 0,
                        'sound' : ''
                    },
                    'custom-field-1' : 'IC_MSG',
                    'custom-field-2' : '1234'
                }";

            var alertPayload = "{ \"aps\" : { \"alert\" : \"" + messageTextBox.Text + "\" } }";
            num++;
            countLabel.Text = $"Inviate {num} / {received}";
            brokerIos.QueueNotification(new ApnsHttp2Notification
            {
                DeviceToken = deviceTokenTextBox.Text.Trim(),
                Payload = JObject.Parse(voip ? voipPayload : alertPayload),
                Topic = topic,
                PushType = voip ? "voip" : "alert",
                Tag = $"Num {num}"
                //Expiration = DateTime.Now.AddDays(1),
            });

        }

        private void startAndroidButton_Click(object sender, EventArgs e)
        {
            var config = new GcmConfiguration(senderAuthTokenTextBox.Text.Trim());
            config.GcmUrl = "https://fcm.googleapis.com/fcm/send";
            brokerAndroid = new GcmServiceBroker(config);
            brokerAndroid.OnNotificationFailed += (notification, exception) => {
                WriteResultAndroid(exception?.InnerException?.Message);
            };
            brokerAndroid.OnNotificationSucceeded += (notification) => {
                WriteResultAndroid($"OK");
            };

            brokerAndroid.Start();

            startAndroidButton.Enabled = false;
            androidProgressBar.Style = ProgressBarStyle.Marquee;
            androidProgressBar.MarqueeAnimationSpeed = 30;
            stopPushAndroid = false;
            while (stopPushAndroid)
            {
                Thread.Sleep(1000);
            }
        }

        private void stopAndroidButton_Click(object sender, EventArgs e)
        {
            brokerAndroid.Stop();
            startAndroidButton.Enabled = true;
            stopPushAndroid = true;
            androidProgressBar.Style = ProgressBarStyle.Continuous;
            androidProgressBar.MarqueeAnimationSpeed = 0;
        }

        private void addAndroidButton_Click(object sender, EventArgs e)
        {
            brokerAndroid.QueueNotification(new GcmNotification
            {
                RegistrationIds = new List<string> {
                    regIdTextBox.Text.Trim()
                },
                Data = JObject.Parse("{\"message\" : \"" + androidMessageTextBox.Text + "\"}")
            });
        }

        private void WriteResultAndroid(string text)
        {
            if (resultAndroidTextBox.InvokeRequired)
            {
                var d = new SafeCallDelegateAndroid(WriteResultAndroid);
                resultAndroidTextBox.Invoke(d, new object[] { text });
            }
            else
            {
                resultAndroidTextBox.Text = text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var d = new DirectoryInfo(@"certs");
            var certs = d.GetFiles("*.p12");

            foreach (var cert in certs)
            {
                certComboBox.Items.Add(cert.FullName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartBrokerIos();

            button2.Enabled = false;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            stopPush = false;
            while (stopPush)
            {
                Thread.Sleep(1000);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StopBrokerIos();

            button2.Enabled = true;
            stopPush = true;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;
            expireLabel.Text = "";
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var options = new ApnsJwtOptions() { BundleId = "" };
            var cert = certComboBox.Text;
            var apns = ApnsClient.CreateUsingCert(cert);

            var push = new ApplePush(ApplePushType.Voip)
                .AddVoipToken("123")
                .AddToken(deviceTokenTextBox.Text);


            var response1 = await apns.SendAsync(push);

            resultTextBoxt.Text = response1.ReasonString + " - " + response1.Reason;
        }
    }
}
