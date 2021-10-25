using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Rector
    {
        // Declaración de atributos
        private string nombres;
        private string apellidos;
        private string fechaNacimiento;
        private string estadoCivil;
        private string experienciaLaboral;

        // Propiedades de los atributos
        // Propiedad de lectura GET
        // Propiedad de escritura SET
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string EstadoCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }
        public string ExperienciaLaboral
        {
            get { return experienciaLaboral; }
            set { experienciaLaboral = value; }
        }

        // Declaración de los métoods u operaciones
        public string Autorizar()
        {
            return "El método Autorizar recién será implementado";
        }
        public string Orientar()
        {
            return "El método Orientar recién será implementado";
        }
        public string Representar()
        {
            return "El método Representar recién será implementado";
        }
        public string Dirigir()
        {
            return "El método Dirigir recién será implementado";
        }
        public string Cumplir()
        {
            return "El método Cumplir recién será implementado";
        }
    }
}
