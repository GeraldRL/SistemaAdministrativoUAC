using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Asignatura
    {
        // Declaración de atributos
        private string nombre;
        private string numeroAporte;
        private string docente;
        private string notas;
        private string tareasEntregadas;

        // Propiedades para los atributos
        // Propiedad de lectura GET - GETTER
        // Propiedad de escritura SET - SETTER
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string NumeroAporte
        {
            get { return numeroAporte; }
            set { numeroAporte = value; }
        }
        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }
        public string Notas
        {
            get { return notas; }
            set { notas = value; }
        }
        public string TareasEntregadas
        {
            get { return tareasEntregadas; }
            set { tareasEntregadas = value; }
        }

        // Declaración de los métodos u operaciones
        public string Aprobar()
        {
            return "El método Aprobar recién será implementado";
        }
        public string Desaprobar()
        {
            return "El método Desaprobar recién será implementado";
        }
        public string Almacenar()
        {
            return "El método Almacenar recién será implementado";
        }
        public string Promediar()
        {
            return "El método Promediar recién será implementado";
        }
        public string Eseniar()
        {
            return "El método Enseniar recién será implementado";
        }
    }
}
