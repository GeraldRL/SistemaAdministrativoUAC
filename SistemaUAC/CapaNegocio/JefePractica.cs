using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class JefePractica
    {
        // Declaración de los atributos
        private string nombres;
        private string apellidos;
        private string experienciaLaboral;
        private string numeroTelefonico;
        private string profesion;

        // Propiedades para los atributos
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
        public string ExperienciaLaboral
        {
            get { return experienciaLaboral; }
            set { experienciaLaboral = value; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }
        public string Profesion
        {
            get { return profesion; }
            set { profesion = value; }
        }

        // Declaración de métodos u operaciones
        public string SupervisarPractica()
        {
            return "El método SupervisarPractica recién será implementado";
        }
        public string Calificar()
        {
            return "El método Calificar recién será implementado";
        }
        public string Diseniar()
        {
            return "El método Diseniar recién será implementado";
        }
        public string Capacitar()
        {
            return "El método Capacitar recién será implementado";
        }
        public string Coordinar()
        {
            return "El método Coordinar recién será implemetnado";
        }

    }
}
