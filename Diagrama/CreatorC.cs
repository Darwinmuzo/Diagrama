using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    public class CreatorC : Creator
    {
        public override Iproduct createProduct()
        {
            Console.WriteLine("CREANDO Product B");

            return new ProductA();
        }
    }
}

