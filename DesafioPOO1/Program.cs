using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono t = new Telefono("123123dsaa", "IPHONE");

            Console.WriteLine("Estado del telefono");
            Console.WriteLine("El numero telefonico es de: ");
            t.NumTelefono = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo de operador(1,2,3)");
            t.codOpe = int.Parse(Console.ReadLine());
            Console.WriteLine("La marca es: " + t.Telmarca + " Y el modelo es: " + t.modelo);

            Console.WriteLine(t.Llamar());

       

            Console.WriteLine("Ingrese la persona la que desea llamar: ");
            t.TelContacto = Console.ReadLine();

            Console.WriteLine(t.Llamar(t.TelContacto));
            



            Console.ReadKey();


        }
    }
}
