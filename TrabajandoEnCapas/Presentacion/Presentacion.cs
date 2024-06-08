using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; //using agregados
using Negocios;

namespace Presentacion
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();

            
        }

        public Profesional objEntProf = new Profesional();

        public NegProfesionales objNegProf = new NegProfesionales();

       
    }
}

//Commit -Arregle la clase NegProfesionales, diseño del programa y Columnas del DataGridView (seguir desde la pagina 8)