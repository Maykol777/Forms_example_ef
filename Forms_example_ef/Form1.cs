using Forms_example_ef.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_example_ef
{
    public partial class Form1 : Form
    {
        ContextBD contextBD = new ContextBD();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboCurso.DataSource = contextBD.Cursos.ToList();
            comboCurso.DisplayMember = "nombre";
        }

        private void comboCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Curso curso = (Curso)comboCurso.SelectedItem;
            textprofesor.Text = curso.Profesore.nombre;
            List<Alumno> alumnos = curso.Alumnos.ToList();
            dataGridView1.DataSource = alumnos;
            dataGridView1.Columns[4].Visible = false;
        }
    }
}
