using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;

namespace Datos
{
    public class DatosProfesionales : DatosConexionBD
    {
        public int abmProfesionales(string accion, Profesional objProfesional)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta") orden = "insert into Profesionales values (" + objProfesional.CodProf + ",'" + objProfesional.Nombre + "');";

            if (accion == "Modificar") orden = "update Profesionales set Nombre='" + objProfesional.Nombre + "' where CodProf = " + objProfesional.CodProf + "; ";

            OleDbCommand cmd = new OleDbCommand(orden, Connection);

            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception("Error al tratar de guardar, borrar o modificar de Profesionales", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoProfesionales(string cual)
        {
            string orden = string.Empty;

            if (cual != "Todos") orden = "select * from Profesionales where CodProf = " + int.Parse(cual) + ";";

            else orden = "Select * from Profesionales;";

            OleDbCommand cmd = new OleDbCommand(orden, Connection);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();

                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {

                throw new Exception("Error al listar Profesionales", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose ();
            }

            return ds;
        }

    }
}
