using Avaya.ClientServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreezeClientSDK
{
    public class ApplicationClientDelegate
    {

       public void client_UserCreated(object sender, UserEventArgs e)
        {
            Console.WriteLine("El Cliente se ha creado");
        }

        public void client_UserRemoved(object sender, UserEventArgs e)
        {
            Console.WriteLine("El Usuario se ha cerrado correctamente");
        }

        public void client_ShutdownCompleted(object sender, EventArgs e)
        {
            Main.ActiveForm.Close();
        }
    }
}
