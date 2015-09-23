using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos
{
    class Program
    {
        //mostrar alumnos
        //añadir alumnos
        static FactoriaAlumons fa =  null;

        static void Main(string[] args)
        {      
            int opcion = 0;
            fa = new FactoriaAlumons();
            opcion = MostrarMenu();
            EjecutarOpciones(opcion);
                                  
            Console.ReadKey();

        }
        private static void EjecutarOpciones(int opcion)
        {
            switch (opcion)
            {               
                case 1:
                    {
                        MostrarAlumnos();
                        //Console.WriteLine("As elejido mostrar alumnos:");
                        break;
                    }
                case 2:
                    {
                        //Console.WriteLine("As elejido añadir alumno:");
                        break;
                    }
                case 3:
                    {
                        //Console.WriteLine("As elejido borrar alumno:");
                        break;
                    }
            }
        }
        // Crear alumno
        private static void AddAlumno()
        {
            Alumno al = new Alumno();
            fa.AddAlumno(al);
        }
        // Mostrar alumnos
        private static void MostrarAlumnos()
        {
            IList<Alumno> alumnos = fa.MostrarAlumnos();
            Alumno al = null;
            for(int i=0; i < alumnos.Count; i++)
            {
                al =alumnos.ElementAt(i);
                Console.WriteLine(al.Nombre + "" + al.Apellidos);
            }
        }

        private static int MostrarMenu()
        {
            int opcion = 0;

            Console.WriteLine("1 - Mostrar Alumnos");
            Console.WriteLine("2 - Añadir Alumno");
            Console.WriteLine("3 - Borrar Alumno");

            opcion = Int32.Parse(Console.ReadLine());

            return opcion;
        }
        
    }
}
