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
        public OleDbConnection Connection;

        //conexion con la base de datos
        public string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data
        Source=F:\EjemploBD.accdb;Persist Security Info=True";

        public DatosConexionBD()
        {
            Connection = new OleDbConnection(cadenaConexion);
        }

        public void AbrirConexion() 
        {
            try
            {
                if (Connection.State == ConnectionState.Broken || Connection.State == ConnectionState.Closed) Connection.Open();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cerrar la conexion", e);
            }
        }
        public void CerrarConexion() 
        {
            try
            {
                if (Connection.State == ConnectionState.Open) Connection.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de cerrar la conexion", e);
                
            }
        }
    }
}
