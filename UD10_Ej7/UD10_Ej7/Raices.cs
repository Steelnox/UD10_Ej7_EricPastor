using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej7
{
    public class Raices
    {
        int a;
        int b;
        int c;

        double resultado1 = 0;
        double resultado2 = 0;
        double discriminante = 0;
        public Raices(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void obtenerRaices()
        {
            resultado1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);
            resultado2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            Console.WriteLine("Los dos resultados son {0} y {1}", resultado1, resultado2);
        }

        public void obtenerRaiz()
        {
            resultado1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / (2 * a);

            Console.WriteLine("El resultado es " + resultado1);
        }

        public double getDiscriminante()
        {
            discriminante = (Math.Pow(b,2)) - 4 * a * c;
            return discriminante;
        }

        public bool tieneRaices()
        {
            if (getDiscriminante() >= 0) return true;
            else return false;
        }

        public bool tieneRaiz()
        {
            if (getDiscriminante() == 0) return true;
            else return false;
        }

        public void calcular()
        {
            if (tieneRaices())
            {
                obtenerRaices();
            }

            else
            {
                obtenerRaiz();
            }
        }

    }
}
