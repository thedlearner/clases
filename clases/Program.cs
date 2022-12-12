using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Program
    {
        //este algoritmo creara objeto circulo y calculara area

        class Circulo
        {
            // definimos atributos
            double pi = 3.1416;

            //definimos metodo o funcion del objeto
            public double CalculoArea (int radio)
            {

                return pi * radio* radio;

            }
        }

        static void Main(string[] args)
        {
            Circulo circulo1; //creamos la variable de objeto circulo, circulo1
            
            circulo1 = new Circulo(); //creamos o instanciamos la variable circulo1

            Console.WriteLine(circulo1.CalculoArea(5));

            Console.ReadKey();
        }
    }
}
