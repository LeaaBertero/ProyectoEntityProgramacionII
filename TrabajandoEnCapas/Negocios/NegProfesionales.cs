using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;
using Entidades;

namespace Negocios
{
    public class NegProfesionales
    {

        DatosProfesionales objDatosProfes = new DatosProfesionales();
        
        //ver acá este eror que se prudujo,(continuar con el final de la pagina 6 del documento Pdf)
        public int abmProfesionales(string accion, Profesional objProfesional) 
        {
            return objDatosProfes.abmProfesionales(accion, objProfesional);
        }

        public DataSet listadoProfesionales (string cual)
        {
            return objDatosProfes.listadoProfesionales(cual);
        }


    }
}
