using Avaya.ClientServices;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace BreezeClientSDK
{

    public partial class Main : MetroFramework.Forms.MetroForm
    {
        ClientConfiguration clientConfiguration;
        Client client;
        UserConfiguration userConfiguration;
        SipUserConfiguration sipConfiguration;
        Call call;
        TransportType transport;
        CallService callService;
        User m_User;
    

        public Main()
        {
            cofigsdk();
            InitializeComponent();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cofigsdk()
        {
            {
                //Creamos las Variables para reconocimiento de nuestra APP
                //Obtenemos el Sistema Operativo
                string os = Environment.OSVersion.Version.ToString();
                //Obtenemos la ruta de Mis documentos
                string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //Definimos un Nombre de Prodcuto
                string prodname = "Avaya Communicator";
                //Asignamos la versión
          
                string prodversion = "3.0";
                string platform = "Microsoft Windows NT 6.2.9200.0";
                string osv = "Microsoft Windows NT";
                string builv = "3.5.0.52.37";
                string uuid;
                string extension;
                string pass;
                string sip;
                string domain;
                int port;
                extension = Properties.Settings.Default.usuario;
                pass = Properties.Settings.Default.password;
                sip = Properties.Settings.Default.sipcontroller;
                domain = Properties.Settings.Default.sipdomain;
                port = Int32.Parse(Properties.Settings.Default.puerto);
                Console.WriteLine(os + " " + path);
                clientConfiguration = new ClientConfiguration(path, prodname, prodversion, platform, osv, builv, "Avaya");
                //Obtenemos nuestro UUID  (RFC 5626) que hemos guardado en los Settings
                uuid = Properties.Settings.Default.uuid;
                //Lo imprimimos
                Console.WriteLine(uuid);
                //Verificamos si es Nulo
                bool check1 = string.IsNullOrEmpty(uuid);
                Console.WriteLine(check1);
                if (check1 == false)
                {
                    Console.WriteLine("Ya existe una instancia de UUID");
                    Console.WriteLine(uuid);
                }
                else
                {
                    //Si no existe UUID
                    Console.WriteLine("No existe UUID");
                    //Generamos UUID
                    uuid = Guid.NewGuid().ToString();
                    Console.WriteLine("Se ha generado UUID: " + uuid);
                    //Lo Guardamos en los Settings
                    Properties.Settings.Default.uuid = uuid;
                    Console.WriteLine("Se ha guardado UUID");
                }
                //Asignamos el UUId al Configuración del cliente
                clientConfiguration.UserAgentInstanceId = uuid;

                //Declaramos una Instancia de la Clase  (Listeners)
                ApplicationClientDelegate clientDelegate = new ApplicationClientDelegate();
                SecurityPolicyConfiguration securityPolicyConfig = new SecurityPolicyConfiguration();
                securityPolicyConfig.PrivateTrustStoreEnabled = true;
                securityPolicyConfig.TrustStoreMode = TrustStoreMode.PrivateAndSystem;
                securityPolicyConfig.RevocationCheckPolicy = SecurityPolicy.Disabled;
                securityPolicyConfig.CertificateStoreDirectory = path;

                clientConfiguration.SecurityPolicyConfiguration = securityPolicyConfig;

                // Instantiate a list of certificates.
                // Populate CA Certificates in the trustedAnchors as required. 

                //Certs

                //Creamos el cliente pasandole las configuracion
                //es importante agregar al momento de crear el cliente el Dispatcher que no viene referenciado en 
                //DevConnect de Avaya
                List<X509Certificate2> trustedAnchors = new List<X509Certificate2>();
                client = new Client(clientConfiguration, Dispatcher.CurrentDispatcher);

                if (client.CertificateManager.IsCertificateStoreInUse())
                {
                    // Remove existing certificates.
                    client.CertificateManager.DeleteCertificateStore();
                    // Add new certificates.
                    client.CertificateManager.SetCertificates(trustedAnchors);
                }

                    // Client certificate has been successfully provisioned. 
                    //Definimos los Handlers

                    client.UserCreated += new EventHandler<UserEventArgs>
                    (clientDelegate.client_UserCreated);
                client.UserRemoved += new EventHandler<UserEventArgs>
                    (clientDelegate.client_UserRemoved);
                client.ShutdownCompleted += new EventHandler
                    (clientDelegate.client_ShutdownCompleted);
                userConfiguration = new UserConfiguration();

                SipUserConfiguration sipUserConfig = userConfiguration.SipUserConfiguration;
                sipUserConfig.Enabled = true;
                bool tls_status = Properties.Settings.Default.tls;
                if (tls_status == true)
                {
                    transport = TransportType.Tls;
                }
                else
                {
                    transport = TransportType.Tcp;
                }


                SignalingServer signalingServer = new SignalingServer(transport, sip, port, FailbackPolicy.Automatic); //5060 - TCP & 5061 -Tls
                SignalingServerGroup sipsignallingServerGroup = new SignalingServerGroup(signalingServer);
                sipUserConfig.ConnectionPolicy = new ConnectionPolicy(sipsignallingServerGroup);
                sipUserConfig.UserId = extension;
                sipUserConfig.Domain = domain;
                sipUserConfig.CredentialProvider = new UserNamePasswordCredentialProvider(extension, pass, domain);
                sipUserConfig.MediaEncryptionTypeArray = new MediaEncryptionType[] { MediaEncryptionType.Aes128Sha1Hmac32, MediaEncryptionType.Aes128Sha1Hmac80, MediaEncryptionType.Aes256Sha1Hmac32, MediaEncryptionType.Aes256Sha1Hmac80, MediaEncryptionType.None };

                client.CreateUser(userConfiguration, (user, error) =>
                {
                    if (error != null)
                    {

                        Console.WriteLine(string.Format("User creation error {0}", error));
                        return;
                    }
                    Console.WriteLine("User created.");
                    m_User = user;


                    // Add event handlers to user object to handle all user related events 


                    m_User.Start();

                    call_btn.Enabled = true;
                    hang_btn.Enabled = true;
                    AppCallServiceDelegate callServiceDelegate = new AppCallServiceDelegate();
                    m_User.CallService.IncomingCallReceived +=
                    new EventHandler<CallEventArgs>(callServiceDelegate.user_IncomingCall);
                    m_User.CallService.CallRemoved +=
                    new EventHandler<CallEventArgs>(callServiceDelegate.user_CallRemoved);


                });
            }

        }

        private void call_btn_Click(object sender, EventArgs e)
        {

            callService = m_User.CallService;
            call = callService.CreateCall();
            call.RemoteAddress = number_txt.Text;

            AppCallDelegate callDelegate = new AppCallDelegate();
            call.Started += new EventHandler(callDelegate.call_Started);
            call.RemoteAlerting +=
            new EventHandler<RemoteAlertingEventArgs>(callDelegate.call_RemoteAlerting);
            call.Established += new EventHandler(callDelegate.call_Established);
            call.Ended += new EventHandler<CallEndedEventArgs>(callDelegate.call_Ended);
            call.Subject = subject_out_txt.Text.ToString();
            Console.WriteLine(call.Subject);

            call.Start();

        }

 

        private void hang_btn_Click(object sender, EventArgs e)
        {
            call.End();

        }

     
        public class AppCallDelegate
        {
            public void call_Started(object sender, EventArgs e)
            {
                Call call = (Call)sender;



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


        public class AppCallServiceDelegate
        {

            public void user_IncomingCall(object sender, CallEventArgs e)
            {
                if (e.Call.Subject.Length == 0)
                {

                    DialogResult result = MessageBox.Show("Datos: \n " + "Numero:"+ e.Call.RemoteNumber + "\n Nombre: " + e.Call.RemoteDisplayName + "\n Asunto: " + e.Call.Subject , "Responder", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        e.Call.Accept();
                    }
                    else if (result == DialogResult.No)
                    {
                        e.Call.Ignore();
                    }
           

                }
                else
                {
                    MessageBox.Show("Asunto:" + e.Call.Subject);
                    e.Call.Accept();
                  

                }

               
           

            }

            public void user_CallRemoved(object sender, CallEventArgs e)
            {
                // Called to report that the call has been removed before 
                // answer.
                // Add code here to handle the removed call, eg, 
                // update UI to remove the call... etc.
            }


        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
