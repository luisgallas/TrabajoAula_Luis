using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrabajoAula_Luis
{
    internal class Program
    {
        static void Main(string[] args)

        {

            /* //List<string> names = new List<string>();
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
              }*/
            // List<int > lista = new List <int >();

            /*LinkedList<int> lista = new LinkedList<int>();//lo nuevo linkedList
            Random randon = new Random();
            for (int i = 0; i < 25; i++)
            {
                lista.AddLast(randon.Next(0, 101));
            }
            int suma = 0;
            foreach (int elemento in lista)
            {
                suma += elemento;
            }

            float promedio = (float)suma / lista.Count;

            Console.WriteLine("Lista de enteros:");
            foreach (int elemento in lista)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Suma de los elementos: " + suma);
            Console.WriteLine("Promedio: " + promedio);
            Console.ReadLine();*/
            // Ejercicio 1: Insertar 25 enteros al azar y calcular la suma y el promedio
            // Ejercicio 1: Insertar 25 enteros aleatorios del 0 al 100 en una lista
            // Ejercicio 1: Insertar 25 enteros aleatorios del 0 al 100 en una lista
            Random rnd = new Random();
            Lista listaEnteros = new Lista();
            for (int i = 0; i < 25; i++)
            {
                int numeroAleatorio = rnd.Next(0, 101);
                listaEnteros.InsertarOrdenado(numeroAleatorio);
            }
            Console.WriteLine("Lista de 25 enteros aleatorios ordenados:");
            listaEnteros.ImprimirLista();

            int suma = listaEnteros.CalcularSuma();
            double promedio = listaEnteros.CalcularPromedio();
            Console.WriteLine($"Suma: {suma}, Promedio: {promedio}");

            // Ejercicio 2: Generar una lista de 10 caracteres y copiarla en orden inverso
            Lista listaCaracteres = new Lista();
            for (int i = 0; i < 10; i++)
            {
                listaCaracteres.InsertarOrdenado(rnd.Next('A', 'Z' + 1));
            }
            Console.WriteLine("Lista de 10 caracteres:");
            listaCaracteres.ImprimirLista();

            Lista listaInversa = listaCaracteres.CopiarListaInversa();
            Console.WriteLine("Lista de 10 caracteres en orden inverso:");
            listaInversa.ImprimirLista();

            // Ejercicio 3: Búsqueda recursiva en una lista
            Console.WriteLine("Introduzca un valor para buscar en la lista de enteros:");
            int valorBuscar = int.Parse(Console.ReadLine());
            Nodo resultadoBusqueda = listaEnteros.BuscaLista(valorBuscar);
            if (resultadoBusqueda != null)
            {
                Console.WriteLine($"Valor {valorBuscar} encontrado en la lista.");
            }
            else
            {
                Console.WriteLine($"Valor {valorBuscar} no encontrado en la lista.");
            }

            // Ejercicio 4: Impresión recursiva de una lista en orden inverso
            Console.WriteLine("Lista de enteros en orden inverso:");
            listaEnteros.ImprimeListaInversa();
            Console.ReadLine(); 
        }
        
    }
}
