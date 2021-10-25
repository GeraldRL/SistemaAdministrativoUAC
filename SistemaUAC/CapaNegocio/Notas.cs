using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Notas
    {
        // Declaración de los atributos
        private string promedioFinal;
        private string promedioTrabajos;
        private string promedioExamen;
        private string sustitutorio;
        private string puntos;
        private string nombreCurso;

        // Propiedades para los atributos
        // Propiedad de lectura GET
        // Propiedad de escritura SET
        public string PromedioFinal
        {
            get { return promedioFinal; }
            set { promedioFinal = value; }
        }
        public string PromedioTrabajos
        {
            get { return promedioTrabajos; }
            set { promedioTrabajos = value; }
        }
        public string PromedioExamen
        {
            get { return promedioExamen; }
            set { promedioExamen = value; }
        }
        public string Sustitutorio
        {
            get { return sustitutorio; }
            set { sustitutorio = value; }
        }
        public string Puntos
        {
            get { return puntos; }
            set { puntos = value; }
        }
        public string NombreCurso
        {
            get { return nombreCurso; }
            set { nombreCurso = value; }
        }

        // Declaración de métodos u operaciones
        public string Promediar()
        {
            return "El método Promediar recién será implementado";
        }
        public string Aprobar()
        {
            return "El método Aprobar recién será implementado";
        }
        public string Desaprobar()
        {
            return "El método Desaprobar recién será implementado";
        }
        public string Evaluar()
        {
            return "El método Evaluar recién será implementado";
        }
        public string Determinar()
        {
            return "El método Determinar recién será implementado";
        }
    }
}
