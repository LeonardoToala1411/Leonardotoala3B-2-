using System;
using System.Collections.Generic;
using System.Text;

namespace Actividad2.Clases
{
    class Pila
    {
        private int[] datos = new int[6];

        public int[] Datos
        {
            get { return datos; }
            set { datos = value; }
        }

        private int cima;

        public int Cima
        {
            get { return cima; }
            set { cima = value; }
        }

        public void Apilar(int numero)
        {
            if (cima == datos.Length - 1)
            {
                throw new Exception("Pila llena");
            }
            else
            {
                cima += 1;
                Datos[cima] = numero;

            }
        }

         public void desapilar()
        {
            if (cima==-1)
            {
                throw new Exception("Pila vacia");
            }
            else
            {
                cima -= 1;
            }
        }
    }
}
