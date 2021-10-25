using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Docente
    {
        // Declaración de Atributos
        private string dni;
        private string nombres;
        private string apellidos;
        private string correo;
        private string fechaNacimiento;
        private string numeroTelefonico;
        private string asignatura;

        // Propiedades para los Atributos
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
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
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }
        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        // Declaración de los Metodos u Operaciones
        public string Enseniar()
        {
            return "El método Enseniar recien será implementado";
        }
        public string Aprobar()
        {
            return "El método Aprobar recien será implementado";
        }
        public string Desaprobar()
        {
            return "El método Desaprobar recien será implementado";
        }
        public string Calificar()
        {
            return "El método Calificar recien será implementado";
        }
        public string Apoyar()
        {
            return "El método Apoyar recien será implementado";
        }
        public string LlamarLista()
        {
            return "El método LlamarLista recien será implementada";
        }
        public string Corregir()
        {
            return "El método Corregir recien será implementado";
        }
        public string CompartirConocimiento()
        {
            return "El método CompartirConocimiento recien será implementado";
        }
    }
}
