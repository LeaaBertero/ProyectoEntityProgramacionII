using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

//creo que esta bien, si no lo vuelvo a como estaba --Datos
namespace TrabajandoEnCapas.Datos
{
    public class DatosConexionBD
    {
        //objeto Conexión
        public OleDbConnection Conexion;

        //string con los datos de la conexion a la base de datos
        public string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data
        Source=F:\EjemploBD.accdb;Persist Security Info=True";

        public DatosConexionBD()
        {
            Conexion = new OleDbConnection(cadenaConexion);
        }

        public void AbrirConexion() 
        {
            try
            {
                if (Conexion.State == ConnectionState.Broken || Conexion.State == ConnectionState.Closed) Conexion.Open();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de abrir la conexion", e);
            }
        }
        public void CerrarConexion() 
        {
            try
            {
                if (Conexion.State == ConnectionState.Open) Conexion.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cerrar la conexion", e);
                
            }
        }
    }
}
