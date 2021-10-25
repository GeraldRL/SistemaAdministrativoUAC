using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Alumno
    {
        // Declaración de atributos
        private string apellidos;
        private string nombres;
        private string celular;
        private string codigo;
        private string correo;
        private string semestreInicio;
        private string escuelaProfesional;
        // Propiedades para los atributos
        // Propiedades de lectura (GET - GETTER)
        // Propiedades de escritura (SET - SETTER)
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string SemestreInicio
        {
            get { return semestreInicio; }
            set { semestreInicio = value; }
        }
        public string EscuelaProfesional
        {
            get { return escuelaProfesional; }
            set { escuelaProfesional = value; }
        }

        // Declaración de métodos u operaciones
        public string Matricular()
        {
            return "El método Matricular recien será implementado";
        }
        public string Estudiar()
        {
            return "El método Estudiar recien será implementado";
        }
        public string Aprobar()
        {
            return "El método Aprobar recien será implementado";
        }
        public string Aprender()
        {
            return "El método Aprender recien será implementado";
        }
        public string Repasar()
        {
            return "El método Repasar recién será implementado";
        }
        public string Anotar()
        {
            return "El método Anotar recién será implementado";
        }
        public string TrabajarEquipo()
        {
            return "El método TrabajarEquipo recién será implementado";
        }
        public string SolucionarProblemas()
        {
            return "El método SolucionarProblemas recién será implementado";
        }
        public string HacerDeporte()
        {
            return "El método HacerDeporte recién será implementado";
        }
    }
}
