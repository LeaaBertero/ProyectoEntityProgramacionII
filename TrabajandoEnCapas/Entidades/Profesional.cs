using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesional
    {
        //instancia de la clase "Profesional"
   

        #region atributos
        private int codProf;
        private string nombre;
        #endregion

        #region Constructor
        public Profesional()
        {
            codProf = 0;
            //string nombre = ""; 
            nombre = string.Empty;
        }
        #endregion

        #region propiedades/ encapsulamiento
        public int CodProf 
        {
            get { return codProf; }
            set { codProf = value; }
        }

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion


    }
}
