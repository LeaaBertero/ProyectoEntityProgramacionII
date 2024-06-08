using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Presentacion
{
    public partial class FormAdmProfes : Form
    {
        public FormAdmProfes()
        {
            InitializeComponent();

            DgvProfesionales.ColumnCount = 2;

            DgvProfesionales.Columns[0].HeaderText = "Código";
            DgvProfesionales.Columns[1].HeaderText = "Nombre";

            DgvProfesionales.Columns[0].Width = 60;
            DgvProfesionales.Columns[1].Width = 200;

            //Método invocad en el constructor
            LlenarDgv();

        }

        //Método privado, que no devuelve nada(Void)
        private void LlenarDgv()
        {
            DgvProfesionales.Rows.Clear();

            //instancia del dataset
            DataSet ds = new DataSet();

            ds = objNegProf.listadoProfesionales("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    //Lo que quieres mostrar esta en dr[0].ToString(), dr[1].ToString(), etc
                    DgvProfesionales.Rows.Add(dr[0].ToString(), dr[1]);
                }
            }
            else
            {
                lbInforacion.Text = "No hay profesionales cargados en el sistema";
            }
        }

        private void TxtBox_a_Obj() //Prepara el objeto a enviar a la capa de Negocio
        {
            objEntProf.CodProf = int.Parse(txCodigo.Text);
            objEntProf.Nombre = txNombre.Text;
        }



        private void Limpiar()
        {
            txCodigo.Text = string.Empty;
            txNombre.Text = string.Empty;
        }

        private void btGrabar_Click(object sender, EventArgs e)
        {
            int nGrabados = -1;

            //llamo al método que carga los datos del objeto
            TxtBox_a_Obj();

            nGrabados = objNegProf.abmProfesionales("Agregar", objEntProf); //invoco a la capa de negocio

            if (nGrabados == -1)
            {
                lbInforacion.Text = " No pudo grabar profesionales en el sistema";
            }
            else
            {
                lbInforacion.Text = " Se grabó con éxito profesionales.";
                LlenarDgv();
                Limpiar();
            }
        }

        //evento del dataGridView (CellClick)
        private void DgvProfesionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //instancia del objeto de tipo DataSet
            DataSet ds = new DataSet();
            
            objEntProf.CodProf = Convert.ToInt32(DgvProfesionales.CurrentRow.Cells[0].Value);
            
            ds = objNegProf.listadoProfesionales(objEntProf.CodProf.ToString());
            
            
            if (ds.Tables[0].Rows.Count > 0) 
            {
                Ds_a_TxtBox(ds);
                btGrabar.Visible = false;
                lbInforacion.Text = string.Empty;
            }
        }

        private void Ds_a_TxtBox(DataSet ds)
        {
            txCodigo.Text = ds.Tables[0].Rows[0]["CodProf"].ToString();
            txNombre.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txCodigo.Enabled = false;
        }


        private void btnModifi_click(object sender, EventArgs e) 
        {
            int nResultado = -1;

            TxtBox_a_Obj();

            nResultado = objNegProf.abmProfesionales("Modificar", objEntProf); //invocando a la capa de "Negocio"
        
            if (nResultado != -1) 
            {
                //Mensaje??
                lbInforacion.Text = "Aviso, El profesional fue modificado con éxito";
                Limpiar();
                LlenarDgv();

                //activacion del txcodigo
                txCodigo.Enabled = true;
            }
            else 
            {
                lbInforacion.Text = "Error, se producjo un error al intentar modificar el profesional";
            }

        }


    }
}

