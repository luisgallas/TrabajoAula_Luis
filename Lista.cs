using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoAula_Luis
{
    internal class Lista
    {
        private Nodo cabeza;

        public Lista()
        {
            cabeza = null;
        }

        // Método para insertar un entero en orden
        public void InsertarOrdenado(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if (cabeza == null || cabeza.Dato >= dato)
            {
                nuevoNodo.Siguiente = cabeza;
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null && actual.Siguiente.Dato < dato)
                {
                    actual = actual.Siguiente;
                }
                nuevoNodo.Siguiente = actual.Siguiente;
                actual.Siguiente = nuevoNodo;
            }
        }

        // Método para calcular la suma de los elementos
        public int CalcularSuma()
        {
            int suma = 0;
            Nodo actual = cabeza;
            while (actual != null)
            {
                suma += actual.Dato;
                actual = actual.Siguiente;
            }
            return suma;
        }

        // Método para calcular el promedio de los elementos
        public double CalcularPromedio()
        {
            int suma = CalcularSuma();
            int contador = 0;
            Nodo actual = cabeza;
            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador > 0 ? (double)suma / contador : 0.0;
        }

        // Método para copiar la lista en orden inverso
        public Lista CopiarListaInversa()
        {
            Lista listaInversa = new Lista();
            Nodo actual = cabeza;
            while (actual != null)
            {
                Nodo nuevoNodo = new Nodo(actual.Dato);
                nuevoNodo.Siguiente = listaInversa.cabeza;
                listaInversa.cabeza = nuevoNodo;
                actual = actual.Siguiente;
            }
            return listaInversa;
        }

        // Método para buscar un valor de manera recursiva
        public Nodo BuscaLista(int valor)
        {
            return BuscaListaRecursiva(cabeza, valor);
        }

        private Nodo BuscaListaRecursiva(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                return null;
            }
            if (nodo.Dato == valor)
            {
                return nodo;
            }
            return BuscaListaRecursiva(nodo.Siguiente, valor);
        }

        // Método para imprimir la lista en orden inverso de manera recursiva
        public void ImprimeListaInversa()
        {
            ImprimeListaInversaRecursiva(cabeza);
            Console.WriteLine();
        }

        private void ImprimeListaInversaRecursiva(Nodo nodo)
        {
            if (nodo != null)
            {
                ImprimeListaInversaRecursiva(nodo.Siguiente);
                Console.Write(nodo.Dato + " ");
            }
        }

        // Método para imprimir la lista
        public void ImprimirLista()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Dato + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
            
        }

    }
}
