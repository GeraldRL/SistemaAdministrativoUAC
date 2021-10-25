using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Lamar a la CapaNegocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmAsignatura : Form
    {
        public FrmAsignatura()
        {
            InitializeComponent();
        }

        // Declarar un objeto a partir de la clase
        Asignatura asignatura = new Asignatura();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos
            string nombre = txtNombre.Text.Trim();
            string numeroAporte = txtNumeroAporte.Text.Trim();
            string docente = txtDocente.Text.Trim();
            string notas = txtNotas.Text.Trim();
            string tareasEntregadas = txtTareasEntregadas.Text.Trim();
            // Escribir los datos de la asignatura en el objeto
            asignatura.Nombre = nombre;
            asignatura.NumeroAporte = numeroAporte;
            asignatura.Docente = docente;
            asignatura.Notas = notas;
            asignatura.TareasEntregadas = tareasEntregadas;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtNombre.Clear();
            txtNumeroAporte.Clear();
            txtDocente.Clear();
            txtNotas.Clear();
            txtTareasEntregadas.Clear();
            // Hacer que el mouse esté en nombres
            txtNombre.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto
            string nombre = asignatura.Nombre;
            string numeroAporte = asignatura.NumeroAporte;
            string docente = asignatura.Docente;
            string notas = asignatura.Notas;
            string tareasEntregadas = asignatura.TareasEntregadas;
            MessageBox.Show("Datos de la Asignatura" + "\n" + "Nombre: " + nombre + "\n" + "Numero Aporte: " + 
                            numeroAporte + "\n" + "Docente: " + docente + "\n" + "Notas: " + notas + "\n" + 
                            "Tareas entregadas: " + tareasEntregadas);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(asignatura.Aprobar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Desaprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Almacenar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Promediar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Eseniar());
        }
    }
}
