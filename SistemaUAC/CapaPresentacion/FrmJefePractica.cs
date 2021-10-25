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
    public partial class FrmJefePractica : Form
    {
        public FrmJefePractica()
        {
            InitializeComponent();
        }

        // Declarar un objeto a partir de una clase
        JefePractica jefePractica = new JefePractica();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string experienciaLaboral = txtExperienciaLaboral.Text.Trim();
            string numeroTelefonico = txtNumeroTelefonico.Text.Trim();
            string profesion = txtProfesion.Text.Trim();
            // Escribir los datos del JefePractica en el objeto
            jefePractica.Nombres = nombres;
            jefePractica.Apellidos = apellidos;
            jefePractica.ExperienciaLaboral = experienciaLaboral;
            jefePractica.NumeroTelefonico = numeroTelefonico;
            jefePractica.Profesion = profesion;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombres.Clear();
            txtApellidos.Clear();
            txtExperienciaLaboral.Clear();
            txtNumeroTelefonico.Clear();
            txtProfesion.Clear();
            // Hacer que el mouse esté en Nombres
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto
            string nombres = jefePractica.Nombres;
            string apellidos = jefePractica.Apellidos;
            string experienciaLaboral = jefePractica.ExperienciaLaboral;
            string numeroTelefonico = jefePractica.NumeroTelefonico;
            string profesion = jefePractica.Profesion;
            MessageBox.Show("Datos del Jefe de Práctica" + "\n" + "Nombres: " + nombres + "\n" + "Apellidos: " +
                            apellidos + "\n" + "Experiencia laboral: " + experienciaLaboral + "\n" +
                            "Número telefónico: " + numeroTelefonico + "\n" + "Profesión: " + profesion);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(jefePractica.SupervisarPractica());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Calificar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Diseniar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Capacitar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Coordinar());
        }
    }
}
