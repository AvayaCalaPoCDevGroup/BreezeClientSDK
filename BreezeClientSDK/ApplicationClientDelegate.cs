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
            // Called to report the specified user has 
            // been removed
            // Add code here to handle user removed
        }

        public void client_ShutdownCompleted(object sender, EventArgs e)
        {
            // Called to report Client shutdown has been completed
            // Add code here to handle shutdown of the Client
        }
    }
}
