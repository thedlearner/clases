using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crear_clases_asignaturas
{
    internal class Program
    {

        class Asignatura
        {
            public string nombre;
            public string alumno;
            public string semestre;

        }



        static void Main(string[] args)
        {
            Asignatura asignatura1 = new Asignatura();
            asignatura1.nombre = "lenguaje";
            asignatura1.alumno = "benjamin";
            asignatura1.semestre = "Q1, 2023";

            Console.WriteLine(asignatura1.nombre);
            Console.WriteLine(asignatura1.alumno);
            Console.WriteLine(asignatura1.semestre);

            Console.ReadKey();



        }
    }
}
