using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad2.Clases
{
    class Cola
    {
        private int[] datos = new int[6];

        public int[] Datos
        {
            get { return datos; }
            set { datos = value; }
        }

        private int primero;

        public int Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        private int ultimo;

        public int Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }

        public void agregaralacola(int numero)
        {
            if (ultimo == -1 && primero == -1)
            {
                primero += 1;
                ultimo += 1;
                Datos[ultimo] = numero;

            }
            else
            {
                if (ultimo < Datos.Length-1)
                {
                    ultimo += 1;
                    Datos[ultimo] = numero;

                }
                else
                {
                    throw new Exception("La cola esta llena");
                }
            }
        }

        public void desencolar()
        {
            if (primero == -1 && ultimo == -1)
            {
                throw new Exception("La cola esta vacia");
            }
            else
            {
                if (primero==ultimo)
                {
                    throw new Exception("Ya no hay elementos en la cola");
                }
                else
                {
                    primero += 1;
                    
                }
            }
        }

    }
}
