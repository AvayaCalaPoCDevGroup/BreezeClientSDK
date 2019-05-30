using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreezeClientSDK
{
    public partial class AsuntoViewer : Form
    {
        public AsuntoViewer()
        {
            InitializeComponent();
        }

        private void AsuntoViewer_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://maps.google.com/maps?q="+Main.GlobalSubject);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
