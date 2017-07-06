using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class datos
    {


        public String text
        {
            set;
            get;
        }
        public int num1
        {
            set;
            get;
        }

        public int num2
        {
            set;
            get;
        }
    }

    public class metodos : datos
    {


        datos datos1 = new datos();
        public String mensaje()
        {
            datos1.text = "nuevo texto";
            datos1.num1 = 1;
            datos1.num2 = 2;
            
            return "Los datos son: "+datos1.text+" "+datos1.num1+" "+datos1.num2;
        }
    }

}
