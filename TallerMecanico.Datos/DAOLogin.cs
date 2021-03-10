using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using TallerMecanico.Entidades;

namespace TallerMecanico.Datos
{
    public class DAOLogin
    {
        //string _cadenaConexion;

        //public string CadenaConexion
        //{
        //    get
        //    {
        //        if (_cadenaConexion == null)
        //        {
        //            _cadenaConexion = ConfigurationManager.
        //                ConnectionStrings["Conex"].ConnectionString;
        //        }
        //        return _cadenaConexion;
        //    }
        //    set { _cadenaConexion = value; }
        //}
        ////metodo para traer un usuari segun su identificación 
        //public Usuario TraerPorId(int Id)
        //{
        //    Usuario Usuario = new Usuario();
        //    using (SqlConnection con = new SqlConnection(CadenaConexion))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("TraerUsuarioPorId", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@ID", Id);
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr != null && dr.HasRows)
        //        {
        //            dr.Read();
        //            Usuario = new Usuario(
        //                    (int)dr["Id"], (string)dr["Codigo"],
        //                     (string)dr["Nombre"], (string)dr["Documento"],
        //                    (string)dr["Celular"], (string)dr["Correo"],
        //                    (string)dr["UsuarioL"], (byte)dr["Contrasena"],
        //                    (int)dr["Tpu_Id"], (bool)dr["Activo"]);
        //        }
        //    }
        //    return Usuario;
        //}
    }
}

