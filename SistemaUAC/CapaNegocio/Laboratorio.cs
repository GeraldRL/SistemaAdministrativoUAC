using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Laboratorio
    {
        // Declaración de atributos
        private string ubicacion;
        private string aniosFundacion;
        private string cantidadDocentes;
        private string instrumentos;
        private string practicantesCiclo;
        
        // Propiedades para los atributos
        // Propiedades de lectura GET - GETTER
        // Propiedades de escritura SET - SETTER
        public string Ubicacion
        {
            get { return ubicacion; }
            set { ubicacion = value; }
        }
        public string AniosFundacion
        {
            get { return aniosFundacion; }
            set { aniosFundacion = value; }
        }
        public string CantidadDocentes
        {
            get { return cantidadDocentes; }
            set { cantidadDocentes = value; }
        }
        public string Instrumentos
        {
            get { return instrumentos; }
            set { instrumentos = value; }
        }
        public string PracticantesCiclo
        {
            get { return practicantesCiclo; }
            set { practicantesCiclo = value; }
        }

        // Declaración de métodos u operaciones
        public string Investigar()
        {
            return "El método Investigar recién será implementado";
        }
        public string Practicar()
        {
            return "El método Practicar recién será implementado";
        }
        public string Experimentar()
        {
            return "El método Experimentar recién será implementado";
        }
        public string Examinar()
        {
            return "El método Examinar recién será implementado";
        }
        public string Analizar()
        {
            return "El método Analizar recién será implementado";
        }
    }
}
