using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreezeClientSDK.Clases
{
    class ListaCamaras
    {
        public int id
        {
            get;
            set;
        }
        public string nombre
        {
            get;
            set;
        }
        public string uuid
        {
            get;
            set;
        }
        public ListaCamaras(int r, string n, string g)
        {
            id = r;
            nombre = n;
            uuid = g;
        }
    }
}
