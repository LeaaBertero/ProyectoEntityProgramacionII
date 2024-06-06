using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Datos
{
    public class DatosConexionBD
    {

        public OleDbConnection Connection; 

        public string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data
        Source=F:\EjemploBD.accdb;Persist Security Info=True";
    }
}
