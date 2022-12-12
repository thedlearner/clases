using System;

namespace clase_mascota
{
    internal class Program
    {

        public class Mascota
        {
            public string nombre;
            public string dueño;
            public int edad;

            public void ObtenerNombre(string nombre)
            {
                Console.WriteLine(nombre);
            }

            public void AsignarEdad (int edad)
            {
                Console.WriteLine(edad);
                
            }

        }

        static void Main(string[] args)
        {
            Mascota mascota1 = new Mascota(); //creamos e inicializamos un objeto
            mascota1.ObtenerNombre ("quinto");
            mascota1.AsignarEdad (13);

            Console.ReadKey();
        }
    }
}
