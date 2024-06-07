using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 200;
        }

        public Profesional objEntProf = new Profesional();

        public NegProfesionales objNegProf = new NegProfesionales();

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

//Commit -Arregle la clase NegProfesionales, diseño del programa y Columnas del DataGridView (seguir desde la pagina 8)