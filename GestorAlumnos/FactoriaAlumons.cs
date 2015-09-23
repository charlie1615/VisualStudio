using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos
{
    class FactoriaAlumons
    {
        IList<Alumno> alumnos = new List<Alumno>();

        private void CargarDatos()
        {
            Alumno al = new Alumno();
            al.Nombre = "Jon";
            al.Apellidos = "Perez Gutierrez";
            
            alumnos.Add(al); //AddAlumno(al);
        }

        public FactoriaAlumons()
        {
            CargarDatos();
        }

        // Mostrar alumnos
        public IList<Alumno> MostrarAlumnos()
        {                  
            return alumnos; 
        }

        // Añadir alumno
        public void AddAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);          
        }

        // Borrar alumno
        public void RemoveAlumno(Alumno alumno)
        {
            alumnos.Remove(alumno);
        }


    }
}
