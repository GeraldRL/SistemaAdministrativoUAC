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
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        // Declarar un objeto a partir de la clase
        Notas notas = new Notas();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos
            string promedioFinal = txtPromedioFinal.Text.Trim();
            string promedioTrabajos = txtPromedioTrabajos.Text.Trim();
            string promedioExamen = txtPromedioExamen.Text.Trim();
            string sustitutorio = txtSustitutorio.Text.Trim();
            string puntos = txtPuntos.Text.Trim();
            string nombreCurso = txtNombreCurso.Text.Trim();
            // Escribir los datos de las notas en el objeto
            notas.PromedioFinal = promedioFinal;
            notas.PromedioTrabajos = promedioTrabajos;
            notas.PromedioExamen = promedioExamen;
            notas.Sustitutorio = sustitutorio;
            notas.Puntos = puntos;
            notas.NombreCurso = nombreCurso;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtPromedioFinal.Clear();
            txtPromedioTrabajos.Clear();
            txtPromedioExamen.Clear();
            txtSustitutorio.Clear();
            txtPuntos.Clear();
            txtNombreCurso.Clear();
            // Hacer que el mouse esté en promedioFinal
            txtPromedioFinal.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto
            string promedioFinal = notas.PromedioFinal;
            string promedioTrabajos = notas.PromedioTrabajos;
            string promedioExamen = notas.PromedioExamen;
            string sustitutorio = notas.Sustitutorio;
            string puntos = notas.Puntos;
            string nombreCurso = notas.NombreCurso;
            MessageBox.Show("Datos de Notas" + "\n" + "Promedio final: " + promedioFinal + "\n" + "Promedio trabajos: " +
                            promedioTrabajos + "\n" + "Promedio examen: " + promedioExamen + "\n" + "Sustitutorio: " +
                            sustitutorio + "\n" + "Puntos: " + puntos + "\n" + "Nombre del curso: " + nombreCurso);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(notas.Promediar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.Aprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.Desaprobar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.Evaluar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.Determinar());
        }
    }
}
