using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormAdmProfes : Form
    {
        public Profesional objEntProf = new Profesional();
        public NegProfesionales objNegProf = new NegProfesionales();

        public FormAdmProfes()
        {
            InitializeComponent();

            InitializeComponent();
            dgvProfesionales.ColumnCount = 2;
            dgvProfesionales.Columns[0].HeaderText = "Código";
            dgvProfesionales.Columns[1].HeaderText = "Nombre";
            dgvProfesionales.Columns[0].Width = 60;
            dgvProfesionales.Columns[1].Width = 200;
            LlenarDGV();
        }

        private void LlevarDgv() 
        {
            private void LlenarDGV()
            {
                dgvProfesionales.Rows.Clear();

                DataSet ds = new DataSet();
                ds = objNegProf.listadoProfesionales("Todos");

                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        dgvProfesionales.Rows.Add(dr[0].ToString(), dr[1]);
                    }
                }
                else
                    lblMensaje.Text = "No hay profesionales cargados en el sistema";
            }

            private void TxtBox_a_Obj()
            {
                objEntProf.CodProf = int.Parse(txtCodigo.Text);
                objEntProf.Nombre = txtNombre.Text;
            }
        }
    }
}
