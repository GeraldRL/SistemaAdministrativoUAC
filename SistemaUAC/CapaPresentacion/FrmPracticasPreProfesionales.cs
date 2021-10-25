using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Llamar a la CapaNegocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmPracticasPreProfesionales : Form
    {
        public FrmPracticasPreProfesionales()
        {
            InitializeComponent();
        }

        // Declarar un objeto a partir de la clase
        PracticasPreProfesionales practicasPreProfesionales = new PracticasPreProfesionales();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer Datos
            string direccion = txtDireccion.Text.Trim();
            string especializacion = txtEspecializacion.Text.Trim();
            string areaTrabajo = txtAreaTrabajo.Text.Trim();
            string horaPracticas = txtHoraPracticas.Text.Trim();
            string duracionPracticas = txtDuracionPracticas.Text.Trim();
            // Escribir los datos del laboratorio en el objeto
            practicasPreProfesionales.Direccion = direccion;
            practicasPreProfesionales.Especializacion = especializacion;
            practicasPreProfesionales.AreaTrabajo = areaTrabajo;
            practicasPreProfesionales.HoraPracticas = horaPracticas;
            practicasPreProfesionales.DuracionPracticas = duracionPracticas;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtDireccion.Clear();
            txtEspecializacion.Clear();
            txtAreaTrabajo.Clear();
            txtHoraPracticas.Clear();
            txtDuracionPracticas.Clear();
            // Hacer que el mouse esté en dirección
            txtDireccion.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto
            string direccion = practicasPreProfesionales.Direccion;
            string especializacion = practicasPreProfesionales.Especializacion;
            string areaTrabajo = practicasPreProfesionales.AreaTrabajo;
            string horaPracticas = practicasPreProfesionales.HoraPracticas;
            string duracionPracticas = practicasPreProfesionales.DuracionPracticas;
            MessageBox.Show("Datos de las Prácticas Pre Profesionales" + "\n" + "Dirección: " + direccion + "\n" +
                            "Especialización: " + especializacion + "\n" + "Área de trabajo: " + areaTrabajo + "\n" +
                            "Hora práticas: " + horaPracticas + "\n" + "Duración de práCtica: " + duracionPracticas);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(practicasPreProfesionales.Practicar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practicasPreProfesionales.Investigar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practicasPreProfesionales.Experimentar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practicasPreProfesionales.Aprender());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(practicasPreProfesionales.TomarExperiencia());
        }
    }
}
