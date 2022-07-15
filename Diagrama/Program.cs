using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagrama
{
    class Program
    {
        public static void Main(String[] args)
        {

            CreatorA creadorA = new CreatorA();
            CreatorB creadorB = new CreatorB();
            CreatorC creadorC = new CreatorC();

            Console.WriteLine("CREAR LISTA DE PRODUCTOS");

            List<Iproduct> listaProductos = new List<Iproduct>();

            listaProductos.Add(creadorA.createProduct());
            listaProductos.Add(creadorA.createProduct());
            listaProductos.Add(creadorB.createProduct());
            listaProductos.Add(creadorB.createProduct());
            listaProductos.Add(creadorB.createProduct());
            listaProductos.Add(creadorC.createProduct());
            listaProductos.Add(creadorC.createProduct());


            foreach (Iproduct product in listaProductos)
            {

                product.doStuff();

            }

            //CREACION DE LA LISTA CON SOMOOPERATION

            Console.WriteLine("========= LISTA CON CREATOR ========");
            List<Creator> listaCreator = new List<Creator>();

            listaCreator.Add(new CreatorA());
            listaCreator.Add(new CreatorA());
            listaCreator.Add(new CreatorB());
            listaCreator.Add(new CreatorB());
            listaCreator.Add(new CreatorC());
            listaCreator.Add(new CreatorC());

            foreach (Creator creator in listaCreator)
            {

                creator.someOperation();

            }

        }
    }
}
