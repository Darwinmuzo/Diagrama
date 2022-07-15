using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    //PARA CREAR UNA CLASE ABSTRACTA 
    public abstract class Creator
    {

        public abstract Iproduct createProduct();

        public void someOperation()
        {
            Console.WriteLine("HACIENDO ALGO EN Creator");

            Iproduct p = createProduct();
            p.doStuff();


        }


    }
}
