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
        TransportType transport;
        public Form1()
        {
            InitializeComponent();
            //configsdk();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarajustes();
        }


        public void cargarajustes()
        {
            bool rememberme;
            bool checktls;
            string extension;
            string pass;
            string sip;
            string domain;
            int port;


            rememberme = Properties.Settings.Default.remember;
            checktls = Properties.Settings.Default.tls;

            if (rememberme == true)
            {
                extension = Properties.Settings.Default.usuario;
                pass = Properties.Settings.Default.password;
                user_txt.Text = extension;
                pass_txt.Text = pass;

            }
            else
            {
                Console.WriteLine("Sin guardar datos");
               
            }
            sip = Properties.Settings.Default.sipcontroller;
            domain = Properties.Settings.Default.sipdomain;
            port = Int32.Parse(Properties.Settings.Default.puerto);

            sip_txt.Text = sip;
            domain_txt.Text = domain;
            puerto_txt.Text = port.ToString();
            if (checktls == true)
            {
                tls_chk.Checked = true;
            }
            else
            {
                tls_chk.Checked = false;
            }

        }

        public void guardarajustes()
        {


        }

        public void configsdk()
        {
            //Creamos las Variables para reconocimiento de nuestra APP
            //Obtenemos el Sistema Operativo
            string os = Environment.OSVersion.Version.ToString();
            //Obtenemos la ruta de Mis documentos
            string path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //Definimos un Nombre de Prodcuto
            string prodname = "TestAlam";
            //Asignamos la versión

            string prodversion = "294.0.30";
            string platform = "Windows 10";
            string osv = "Microsoft Windows NT";
            string builv = "6.2.9200.0001";
            string uuid;
            string extension = user_txt.Text;
            string pass = pass_txt.Text;
            string sip;
            string domain;
            int port;

            sip = Properties.Settings.Default.sipcontroller;
            domain = Properties.Settings.Default.sipdomain;
            port = Int32.Parse(Properties.Settings.Default.puerto);
            Console.WriteLine(os + " " + path);
            clientConfiguration = new ClientConfiguration(path, prodname, prodversion, platform, osv, builv,"Avaya Inc.");
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
                Console.WriteLine("Se ha generado UUID: "+ uuid);
                //Lo Guardamos en los Settings
                Properties.Settings.Default.uuid = uuid;
                Console.WriteLine("Se ha guardado UUID");
            }
            //Asignamos el UUId al Configuración del cliente
            clientConfiguration.UserAgentInstanceId = uuid;
           
            //Declaramos una Instancia de la Clase Applicationclientdelegate (Listeners)
            ApplicationClientDelegate clientDelegate = new ApplicationClientDelegate();

       
            //Creamos el cliente pasandole las configuracion
            //es importante agregar al momento de crear el cliente el Dispatcher que no viene referenciado en 
            //DevConnect de Avaya
            client = new Client(clientConfiguration, Dispatcher.CurrentDispatcher);
            SecurityPolicyConfiguration securityPolicyConfig = new SecurityPolicyConfiguration();
            securityPolicyConfig.PrivateTrustStoreEnabled = true;
        
         
            securityPolicyConfig.TrustStoreMode = TrustStoreMode.PrivateAndSystem;

            List<X509Certificate2> trustedAnchors = new List<X509Certificate2>();
            if (client.CertificateManager.IsCertificateStoreInUse())
            {
                client.CertificateManager.DeleteCertificateStore();
                client.CertificateManager.SetCertificates(trustedAnchors);
            }

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
            bool tls_status = tls_chk.Checked;
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
            sipUserConfig.CredentialProvider = new UserNamePasswordCredentialProvider(extension,pass, domain);
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

        private void login_btn_Click(object sender, EventArgs e)
        {
            configsdk();
        }
    }
}
