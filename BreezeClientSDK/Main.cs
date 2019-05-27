using Avaya.ClientServices;
using Avaya.ClientServices.Media;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Threading;

namespace BreezeClientSDK
{


    public partial class Main : MetroFramework.Forms.MetroForm
    {

        public ClientConfiguration clientConfiguration;
        public Client client;
        public UserConfiguration userConfiguration;
        public Call call;
        public TransportType transport;
        public CallService callService;
        public User m_User;
        public static VideoInterface VideoInterfaceInstance;
        public CameraVideoSource cameraVideoSource;
        public CameraDevice selectedCamera;
        public static MediaServicesInstance mediaServices;
        public static Device mediaDevice;
        public static AudioInterface audioInterface;
        public static int ChannelID = 0;



        public Main()
        {
            cofigsdk();
            InitializeComponent();


        }


        private void cofigsdk()
        {
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
                    client.ShutdownCompleted += new EventHandler(clientDelegate.client_ShutdownCompleted);
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
                    sipUserConfig.MediaEncryptionTypeArray = new MediaEncryptionType[] 
                    {
                        MediaEncryptionType.Aes128Sha1Hmac32,
                        MediaEncryptionType.Aes128Sha1Hmac80,
                        MediaEncryptionType.Aes256Sha1Hmac32,
                        MediaEncryptionType.Aes256Sha1Hmac80,
                        MediaEncryptionType.None
                    };

                    client.CreateUser(userConfiguration, (user, error) => {
                        if (error != null)
                        {

                            Console.WriteLine(string.Format("User creation error {0}", error));
                            return;
                        }
                        Console.WriteLine("User created.");
                        m_User = user;


                        // Add event handlers to user object to handle all user related events 


                        m_User.Start();

                        //Cambios en UI

                        extension_lbl.Text = userConfiguration.SipUserConfiguration.UserId;
                        nombreext_lbl.Text = userConfiguration.SipUserConfiguration.DisplayName;
                        dominio_lbl.Text = userConfiguration.SipUserConfiguration.Domain;

                    
                        call_btn.Enabled = true;
                        hang_btn.Enabled = true;
                        AppCallDelegate callServiceDelegate = new AppCallDelegate();
                        m_User.CallService.IncomingCallReceived +=
                         new EventHandler<CallEventArgs>(callServiceDelegate.user_IncomingCall);
                        m_User.CallService.CallRemoved +=
                         new EventHandler<CallEventArgs>(callServiceDelegate.user_CallRemoved);

                        //Agregamos a la coleccion de camaras
                        cameraVideoSource = new CameraVideoSource();
                        int conteocamaras = cameraVideoSource.Cameras.Count;
                        Console.WriteLine("Camaras Dispoibles" + conteocamaras);

                        DataTable TablaCamaras = new DataTable("camaras");
                        TablaCamaras.Columns.Add("id");
                        TablaCamaras.Columns.Add("nombre");

                        int i = 0;

                        do
                        {
                            Console.WriteLine("Camara: " + cameraVideoSource.Cameras[i].Name );
                            TablaCamaras.Rows.Add(i, cameraVideoSource.Cameras[i].Name);
                            i++;

                        } while (i < conteocamaras);
                    });
                }


            }
        }


        private void call_btn_Click(object sender, EventArgs e)
        {

            callService = m_User.CallService;
            call = callService.CreateCall();
            call.RemoteAddress = number_txt.Text;

            AppCallDelegate callDelegate = new AppCallDelegate();
            call.Started += new EventHandler(callDelegate.call_Started);
            call.RemoteAlerting += new EventHandler<RemoteAlertingEventArgs>(callDelegate.call_RemoteAlerting);
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
            Main mainForm = (Main)Application.OpenForms[1];
            public void call_Started(object sender, EventArgs e)
            {
                Call call = (Call)sender;
                Console.WriteLine("Iniciando Llamada");
                //
                mainForm.call_status_lbl.Text = "Iniciando Llamada";
            }
            public void call_RemoteAlerting(object sender, EventArgs e)
            {

                Call call = (Call)sender;
                // Called to report that an outgoing call is ringing at the far end.
                // Add code here to update the UI as appropriate.
                mainForm.call_status_lbl.Text = "Timbrando";
            }

            public void call_Established(object sender, EventArgs e)
            {
                Call call = (Call)sender;
                // Called to report that an outgoing call has been established 
                // (ie, far end has answered and speechpath has been established).
                // Add code here to update the UI as appropriate.

                mainForm.call_status_lbl.Text = "Llamada Establecida";
                Console.WriteLine("Llamada Establecida");
            }

            public void call_Ended(object sender, CallEndedEventArgs e)
            {
                Call call = (Call)sender;
                // Called to report that call has ended.
                // Add code here to update the UI as appropriate.

                Console.WriteLine("Llamada Terminada");
                mainForm.call_status_lbl.Text = "Llamada Finalizada";
            }

            public void user_IncomingCall(object sender, CallEventArgs e)
            {


                if (e.Call.Subject.Length == 0)
                {
                    DialogResult result = MessageBox.Show("Datos: \n " + "Numero:" + e.Call.RemoteNumber + "\n Nombre: " + e.Call.RemoteDisplayName + "\n Asunto: " + e.Call.Subject, "Responder", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        
                        //mainForm.webBrowser1.Navigate("https://www.google.com/maps/search/?api=1&query=47.5951518,-122.3316393");
                        e.Call.Accept();

                

                    }
                    else if (result == DialogResult.No)
                    {
                        e.Call.Ignore();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Datos: \n " + "Numero:" + e.Call.RemoteNumber + "\n Nombre: " + e.Call.RemoteDisplayName + "\n Asunto: " + e.Call.Subject, "Responder", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        //mainForm.webBrowser1.Navigate("http://maps.google.com/maps?q="+e.Call.Subject);
                        e.Call.Accept();
                        


                        mainForm.subject_in_txt.Text = e.Call.Subject;

                        if (this.mainForm.gmaps_radio.Enabled)
                        {
                            AsuntoViewer gmapsviewer = new AsuntoViewer();
                            gmapsviewer.Show(); 


                        }

                    }
                    else if (result == DialogResult.No)
                    {
                        e.Call.Ignore();
                    }
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

        private void call_status_lbl_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            number_txt.AppendText("1");
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            number_txt.AppendText("2");
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            number_txt.AppendText("3");
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            number_txt.AppendText("4");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            number_txt.AppendText("5");

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            number_txt.AppendText("6");

        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            number_txt.AppendText("7");
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            number_txt.AppendText("8");
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            number_txt.AppendText("9");
        }

        private void metroButton11_Click(object sender, EventArgs e)
        {
            number_txt.AppendText("0");
        }

        private void metroButton13_Click(object sender, EventArgs e)
        {
            if (number_txt.Text.Length > 0)
            {
                number_txt.Text = number_txt.Text.Substring(0, (number_txt.Text.Length - 1));
            }
            else
            {
                MessageBox.Show("No Number.");
            }
        }

        private void video_call_btn_Click(object sender, EventArgs e)
        {

            callService = m_User.CallService;
            call = callService.CreateCall();
            

            //pictureBox2.ImageLocation = VideoRenderer2;
        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gmaps_radio_CheckedChanged(object sender, EventArgs e)
        {
            if (gmaps_radio.Enabled)
            {
                Console.WriteLine("Gmaps Activado");
                gmaps_txt.Enabled = true;
           
            }
            else
            {

            }
        }

        private void notepad_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void other_radio_CheckedChanged(object sender, EventArgs e)
        {

        }
    }


}