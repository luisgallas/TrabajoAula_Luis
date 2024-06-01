using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAula_Luis
{
    internal class Program
    {
        static void Main(string[] args)

        {
           //List<string> names = new List<string>();
           List<string> names =  new List<string>();
            //Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Add("Ana");
            
            foreach (var name in names)
            {
                Console.WriteLine($"Hola {name.ToUpper()}!");

            }
            Console.WriteLine("");
            Console.WriteLine("Bill a sido sacado de la lista\n");
            Console.WriteLine("");
            names.Remove("Bill");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            

            Console.ReadLine();
        }
    }
}
