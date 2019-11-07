using System;
using Actividad2.Clases;
namespace Actividad2
{
    class Program
    {

        static void Main(string[] args)
        {
            Pila pila = new Pila();
            pila.Cima = -1;
            Console.WriteLine("PILA\n");
            pila.Apilar(5);
            pila.Apilar(3);
            pila.Apilar(9);
            pila.Apilar(8);
            pila.Apilar(3);
            pila.Apilar(7);
            mostrarpila();
            Console.WriteLine();
            pila.desapilar();
            mostrarpila();
            pila.Apilar(10);
            Console.WriteLine();
            mostrarpila();

            
            Cola cola = new Cola();
            cola.Primero = -1;
            cola.Ultimo = - 1;
            Console.WriteLine("\nCOLA\n");
            cola.agregaralacola(5);
            cola.agregaralacola(3);
            cola.agregaralacola(2);
            cola.agregaralacola(9);
            cola.agregaralacola(7);
            cola.agregaralacola(0);
            mostrarcola();
            cola.desencolar();
            Console.WriteLine();
            mostrarcola();

            void mostrarpila()
            {
                for (int i = pila.Cima; i >-1; i--)
                {
                    Console.WriteLine(pila.Datos[i]);
                }
            }
            void mostrarcola()
            {
                for (int i = cola.Primero; i < cola.Datos.Length; i++)
                {
                    Console.WriteLine(cola.Datos[i]);
                }
            }
        }
    }
}
