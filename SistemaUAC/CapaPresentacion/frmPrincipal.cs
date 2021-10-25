using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario alumno
            FrmAlumno form1 = new FrmAlumno();
            form1.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario docente
            FrmDocente frmDocente = new FrmDocente();
            frmDocente.Show();
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario laboratorio
            FrmLaboratorio frmLaboratorio = new FrmLaboratorio();
            frmLaboratorio.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario asignatura
            FrmAsignatura frmAsignatura = new FrmAsignatura();
            frmAsignatura.Show();
        }

        private void jefeDePrácticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario jefePractica
            FrmJefePractica frmjefePractica = new FrmJefePractica();
            frmjefePractica.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario rector
            FrmRector frmRector = new FrmRector();
            frmRector.Show();
        }

        private void prácticasPreProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Llamar al formulario PPP
            FrmPracticasPreProfesionales frmPracticasPreProfesionales = new FrmPracticasPreProfesionales();
            frmPracticasPreProfesionales.Show();
        }

    }
}
