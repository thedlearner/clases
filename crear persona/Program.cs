using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crear_persona
{
    internal class Program
    {
        //este algoritmo crea la clase persona con dos atributos nombre y edad de tipo string e int respectivamente. luego, crea persona1, llama a las funciones _edad y _nombre e imprime los datos en pantalla


        class Persona
        {
            string nombre;
            int edad;

            public void _edad (int edad)
            {
                Console.WriteLine("ingrese edad");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine(edad);
            }

            public void _nombre(string nombre)
            {
                Console.WriteLine(nombre);
            }
        }





        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1._nombre("benjamin");
            persona1._edad(13);

            Console.ReadKey();





        }
    }
}
