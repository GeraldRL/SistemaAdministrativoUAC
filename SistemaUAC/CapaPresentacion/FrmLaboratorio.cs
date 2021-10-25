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
    public partial class FrmLaboratorio : Form
    {
        public FrmLaboratorio()
        {
            InitializeComponent();
        }

        // Declarar un objeto a partir de la clase
        Laboratorio laboratorio = new Laboratorio();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer Datos
            string ubicacion = txtUbicacion.Text.Trim();
            string aniosFundacion = txtAniosFundacion.Text.Trim();
            string cantidadDocentes = txtCantidadDocentes.Text.Trim();
            string instrumentos = txtInstrumentos.Text.Trim();
            string practicantesCiclo = txtPracticantesCiclo.Text.Trim();
            // Escribir los datos del laboratorio en el objeto
            laboratorio.Ubicacion = ubicacion;
            laboratorio.AniosFundacion = aniosFundacion;
            laboratorio.CantidadDocentes = cantidadDocentes;
            laboratorio.Instrumentos = instrumentos;
            laboratorio.PracticantesCiclo = practicantesCiclo;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtUbicacion.Clear();
            txtAniosFundacion.Clear();
            txtCantidadDocentes.Clear();
            txtInstrumentos.Clear();
            txtPracticantesCiclo.Clear();
            // Hacer que el mouse esté en ubicación
            txtUbicacion.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propiedades del objeto
            string ubicacion = laboratorio.Ubicacion;
            string aniosFundacion = laboratorio.AniosFundacion;
            string cantidadDocentes = laboratorio.CantidadDocentes;
            string instrumentos = laboratorio.Instrumentos;
            string practicantesCiclo = laboratorio.PracticantesCiclo;
            MessageBox.Show("Datos del laboratorio" + "\n" + "Ubicación: " + ubicacion + "\n" +
                            "Años de Fundación: " + aniosFundacion + "\n" + "Cantidad de Docentes: "
                            + cantidadDocentes + "\n" + "Instrumentos: " + instrumentos + "\n" + 
                            "Practicantes Ciclo: " + practicantesCiclo);
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(laboratorio.Investigar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(laboratorio.Practicar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(laboratorio.Experimentar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(laboratorio.Examinar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            // Llamar al método
            MessageBox.Show(laboratorio.Analizar());
        }
    }
}
