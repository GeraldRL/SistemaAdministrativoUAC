using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class PracticasPreProfesionales
    {
        // Declaración de los atributos
        private string direccion;
        private string especializacion;
        private string areaTrabajo;
        private string horaPracticas;
        private string duracionPracticas;

        // Propiedades para los atibutos
        // Propiedad de lectura GET
        // Propiedad de escritura SET
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Especializacion
        {
            get { return especializacion; }
            set { especializacion = value; }
        }
        public string AreaTrabajo
        {
            get { return areaTrabajo; }
            set { areaTrabajo = value; }
        }
        public string HoraPracticas
        {
            get { return horaPracticas; }
            set { horaPracticas = value; }
        }
        public string DuracionPracticas
        {
            get { return duracionPracticas; }
            set { duracionPracticas = value; }
        }

        // Declaaración de los métodos u operaciones
        public string Practicar()
        {
            return "El método Practicar recién será implementado";
        }
        public string Investigar()
        {
            return "El método Investigar recién será implementado";
        }
        public string Experimentar()
        {
            return "El método Experimentar recién será implementado";
        }
        public string Aprender()
        {
            return "El método Aprender recién será implementado";
        }
        public string TomarExperiencia()
        {
            return "El método TomarExperiencia recién será implementado";
        }
    }
}
