using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorAlumnos
{
    class Alumno
    {
        private string nombre;
        private string apellidos;
        private string telefono;
        private string email;
        private DateTime fechaNacimiento;

        public Alumno ()
            {
            this.Nombre = "";
            this.Apellidos = "";
            this.Telefono = "94";
            this.Email = "";
            this.FechaNacimiento = DateTime.Now;
            }      

        public Alumno(string nombre, string apellidos)
        {
            this.Nombre = "";
            this.Apellidos = "";
            this.Telefono = "94";
            this.Email = "";
            this.FechaNacimiento = DateTime.Now;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("la fecha introducida no es valida");
                }
                else
                {
                    fechaNacimiento = value;
                }

            }
        }
    }
}
