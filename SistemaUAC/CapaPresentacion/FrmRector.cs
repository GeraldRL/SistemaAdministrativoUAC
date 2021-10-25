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
    public partial class FrmRector : Form
    {
        public FrmRector()
        {
            InitializeComponent();
        }

        // Declarar un objeto a partir de la clase
        Rector rector = new Rector();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer Datos
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string fechaNacimiento = txtFechaNacimiento.Text.Trim();
            string estadoCivil = txtEstadoCivil.Text.Trim();
            string experienciaLaboral = txtExperienciaLaboral.Text.Trim();
            // Escribir los datos del laboratorio en el objeto
            rector.Nombres = nombres;
            rector.Apellidos = apellidos;
            rector.FechaNacimiento = fechaNacimiento;
            rector.EstadoCivil = estadoCivil;
            rector.ExperienciaLaboral = experienciaLaboral;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombres.Clear();
            txtApellidos.Clear();
            txtFechaNacimiento.Clear();
            txtEstadoCivil.Clear();
            txtExperienciaLaboral.Clear();
            // Hacer que el mouse esté en nombres
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto
            string nombres = rector.Nombres;
            string apellidos = rector.Apellidos;
            string fechaNacimiento = rector.FechaNacimiento;
            string estadoCivil = rector.EstadoCivil;
            string experienciaLaboral = rector.ExperienciaLaboral;
            MessageBox.Show("Datos del Rector" + "\n" + "Nombres: " + nombres + "\n" + "Apellidos: " +
                            apellidos + "\n" + "Fecha de nacimiento: " + fechaNacimiento + "\n" + "Estado civil: " +
                            estadoCivil + "\n" + "Experiencia laboral: " + experienciaLaboral);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(rector.Autorizar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Orientar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Representar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Dirigir());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Cumplir());
        }
    }
}
