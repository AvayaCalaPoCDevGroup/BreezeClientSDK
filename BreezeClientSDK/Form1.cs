using Avaya.ClientServices;
using Avaya.ClientServices.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace BreezeClientSDK
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        ClientConfiguration clientConfiguration;
        Client client;
        UserConfiguration userConfiguration;
        SipUserConfiguration sipConfiguration;
        Call call;

        public Form1()
        {
            InitializeComponent();
            configsdk();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void configsdk()
        {
            //Creamos las Variables para reconocimiento de nuestra APP
            string os = Environment.OSVersion.Version.ToString();
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string prodname = "TestAlam";
            string prodversion = "294.0.30";
            string platform = "Windows 10";
            string osv = "Microsoft Windows NT";
            string builv = "6.2.9200.0001";
            string uuid;

            Console.WriteLine(os + " " + path);
            clientConfiguration = new ClientConfiguration(path, prodname, prodversion, platform, osv, builv,"Avaya Inc.");
            uuid = Properties.Settings.Default.uuid;
            Console.WriteLine(uuid);
            bool check1 = string.IsNullOrEmpty(uuid);
            Console.WriteLine(check1);
            if (check1 == false)
            {
                Console.WriteLine("Ya existe una instancia de UUID");
                Console.WriteLine(uuid);
            }
            else
            {
                Console.WriteLine("No existe UUID");
                uuid = Guid.NewGuid().ToString();
                Console.WriteLine("Se ha generado UUID: "+ uuid);
                Properties.Settings.Default.uuid = uuid;
                Console.WriteLine("Se ha guardado UUID");

            }

            clientConfiguration.UserAgentInstanceId = uuid;
           

            ApplicationClientDelegate clientDelegate = new ApplicationClientDelegate();

          
            //es importante agregar al momento de crear el cliente el Dispatcher que no viene referenciado en 
            //DevConnect de Avaya
            client = new Client(clientConfiguration, Dispatcher.CurrentDispatcher);
            SecurityPolicyConfiguration securityPolicyConfig = new SecurityPolicyConfiguration();
            securityPolicyConfig.PrivateTrustStoreEnabled = true;
        
            // Use the trust anchors from both private and system trust store.
            // For trust anchors to be exclusively used from the private trust store,
            // use TrustStoreMode.PrivateOnly.
            securityPolicyConfig.TrustStoreMode = TrustStoreMode.PrivateAndSystem;

            // Instantiate a list of certificates.
            List<X509Certificate2> trustedAnchors = new List<X509Certificate2>();
            // Populate CA Certificates in the trustedAnchors as required. 

            // Acquire the certificateManager object from the instantiated Client instance

            // PrivateTrustStore is now created and populated.


            //Definimos los Handlers
            if (client.CertificateManager.IsCertificateStoreInUse())
            {
                // Remove existing certificates.
                client.CertificateManager.DeleteCertificateStore();
                // Add new certificates.
                client.CertificateManager.SetCertificates(trustedAnchors);
            }
            client.UserCreated += new EventHandler<UserEventArgs>
                (clientDelegate.client_UserCreated);
            client.UserRemoved += new EventHandler<UserEventArgs>
                (clientDelegate.client_UserRemoved);
            client.ShutdownCompleted += new EventHandler
                (clientDelegate.client_ShutdownCompleted);
             userConfiguration = new UserConfiguration();

            SipUserConfiguration sipUserConfig = userConfiguration.SipUserConfiguration;
            sipUserConfig.Enabled = true;
            SignalingServer signalingServer = new SignalingServer(TransportType.Tls, "sm-213.collaboratory.avaya.com", 5061, FailbackPolicy.Automatic); //5060 - TCP & 5061 -Tls
            SignalingServerGroup sipsignallingServerGroup = new SignalingServerGroup(signalingServer);
            sipUserConfig.ConnectionPolicy = new ConnectionPolicy(sipsignallingServerGroup);
            sipUserConfig.UserId = "2751";
            sipUserConfig.Domain = "collaboratory.avaya.com";
            sipUserConfig.CredentialProvider = new UserNamePasswordCredentialProvider("2760", "9861", "collaboratory.avaya.com");
            sipUserConfig.MediaEncryptionTypeArray = new MediaEncryptionType[] { MediaEncryptionType.Aes128Sha1Hmac32, MediaEncryptionType.Aes128Sha1Hmac80, MediaEncryptionType.Aes256Sha1Hmac32, MediaEncryptionType.Aes256Sha1Hmac80, MediaEncryptionType.None };

            client.CreateUser(userConfiguration, (user, error) =>
            {
                if (error != null)
                {
                    Console.WriteLine(string.Format("User creation error {0}", error));
                    return;
                }
                Console.WriteLine("User created.");
                User m_User = user;

                // Add event handlers to user object to handle all user related events 
     

        m_User.Start();

               


            });
        }

        class AppCallDelegate
        {
            public void call_Started(object sender, EventArgs e)
            {
                Call call = (Call)sender;
                // Called to report that call has started (ie, call is in progress).
                // Add code here to update the UI as appropriate.
            }

            public void call_RemoteAlerting(object sender, EventArgs e)
            {
                Call call = (Call)sender;
                // Called to report that an outgoing call is ringing at the far end.
                // Add code here to update the UI as appropriate.
            }

            public void call_Established(object sender, EventArgs e)
            {
                Call call = (Call)sender;
                // Called to report that an outgoing call has been established 
                // (ie, far end has answered and speechpath has been established).
                // Add code here to update the UI as appropriate.
            }

            public void call_Ended(object sender, CallEndedEventArgs e)
            {
                // Called to report that call has ended.
                // Add code here to update the UI as appropriate.
            }
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }
    }
}
