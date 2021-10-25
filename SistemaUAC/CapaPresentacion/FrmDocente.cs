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
    public partial class FrmDocente : Form
    {
        public FrmDocente()
        {
            InitializeComponent();
        }

        // Declarar un objeto a partir de la clase
        Docente docente = new Docente();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer Datos
            string dni = txtDni.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string fechaNacimiento = txtFechaNacimiento.Text.Trim();
            string numeroTelefonico = txtNumeroTelefonico.Text.Trim();
            string asignatura = txtAsignatura.Text.Trim();
            // Escribir los datos del docente en el objeto
            docente.Dni = dni;
            docente.Nombres = nombres;
            docente.Apellidos = apellidos;
            docente.Correo = correo;
            docente.FechaNacimiento = fechaNacimiento;
            docente.NumeroTelefonico = numeroTelefonico;
            docente.Asignatura = asignatura;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar o borrar las cajas de texo
            txtDni.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtFechaNacimiento.Clear();
            txtNumeroTelefonico.Clear();
            txtAsignatura.Clear();
            // Hacer que el mouse esté en dni
            txtDni.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto
            string dni = docente.Dni;
            string nombres = docente.Nombres;
            string apellidos = docente.Apellidos;
            string correo = docente.Correo;
            string fechaNacimiento = docente.FechaNacimiento;
            string numeroTelefonico = docente.NumeroTelefonico;
            string asignatura = docente.Asignatura;
            MessageBox.Show("Datos del docente" + "\n" + "Dni: " + dni + "\n" + "Nombres: " + nombres + "\n" +
                            "Apellidos: " + apellidos + "\n" + "Correo: " + correo + "\n" + "Fecha de Nacimiento: " +
                            fechaNacimiento + "\n" + "Número Telefónico: " + numeroTelefonico + "\n" +
                            "Asignatura: " + asignatura);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(docente.Enseniar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Aprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Desaprobar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Calificar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Apoyar());
        }

        private void btnMetodo6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.LlamarLista());
        }

        private void btnMetodo7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Corregir());
        }

        private void btnMetodo8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.CompartirConocimiento());
        }
    }
}
