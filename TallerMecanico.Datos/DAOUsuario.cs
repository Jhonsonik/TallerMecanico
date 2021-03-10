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
    public class DAOUsuario
    {
        string _cadenaConexion;

        public string CadenaConexion
        {
            get
            {
                if (_cadenaConexion == null)
                {
                    _cadenaConexion = ConfigurationManager.
                        ConnectionStrings["Conex"].ConnectionString;
                }
                return _cadenaConexion;
            }
            set { _cadenaConexion = value; }
        }
        //metodo para traer la lista de usuarios
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                 con.Open();
                SqlCommand cmd = new SqlCommand("ListarUsuarios", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Usuario u = new Usuario((int)dr["Id"],
                            (string)dr["TipoUsuarioNombre"],
                            (string)dr["Nombre"],
                            (string)dr["Documento"],
                            (string)dr["Celular"],
                            (string)dr["Correo"],
                            (string)dr["UsuarioL"]);
                        lista.Add(u);
                    }
                }
            }
            return lista;
        }
        //metodo para traer la lista de Tipos de usuarios
        //public List<TipoUsuario> ListarTpu()
        //{
        //    List<TipoUsuario> listatpu = new List<TipoUsuario>();

        //    using (SqlConnection con = new SqlConnection(CadenaConexion))
        //    {
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("ListarUsuarios", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr != null && dr.HasRows)
        //        {
        //            while (dr.Read())
        //            {
        //                TipoUsuario tu = new TipoUsuario((string)dr["TipoUsuarioNombre"]);

        //                listatpu.Add(tu);
        //            }
        //        }
        //    }
        //    return listatpu;
        //}
        //metodo para traer un usuario segun su identificación 
        public Usuario TraerPorId(int Id)
        {
            Usuario Usuario = new Usuario();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerUsuarioPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    Usuario = new Usuario(
                            (int)dr["Id"],
                            (string)dr["TipoUsuarioNombre"],
                            (string)dr["Nombre"],
                            (string)dr["Documento"],
                            (string)dr["Celular"],
                            (string)dr["Correo"],
                            (string)dr["Usuario"]/*,*/
                            /*(byte)dr["Contrasena"]*//*,*/
                            /*(int)dr["Tpu_Id"]*/);/*,*/ 
                            //(bool)dr["Activo"]);
                }
            }
            return Usuario;
        }
        //metodo para insertar usuari
        public int Insertar(Usuario Usuario)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@USR_TPU_ID", Usuario.Tpu_Id);
                cmd.Parameters.AddWithValue("@USR_NOMBRE", Usuario.Nombre);
                cmd.Parameters.AddWithValue("@USR_DOCUMENTO", Usuario.Documento);
                cmd.Parameters.AddWithValue("@USR_CELULAR", Usuario.Celular);
                cmd.Parameters.AddWithValue("@USR_CORREO", Usuario.Correo);
                cmd.Parameters.AddWithValue("@USR_USUARIO", Usuario.UsuarioL);
                //cmd.Parameters.AddWithValue("@USR_CONTRASENA", Usuario.Contrasena);
                //cmd.Parameters.AddWithValue("@USR_ACTIVO", Usuario.Activo);

                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
        //metodo para actualizar una Usuari puntual
        public int Actualizar(Usuario Usuario)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@USR_TPU_ID", Usuario.Tpu_Id);
                cmd.Parameters.AddWithValue("@USR_NOMBRE", Usuario.Nombre);
                cmd.Parameters.AddWithValue("@USR_DOCUMENTO", Usuario.Documento);
                cmd.Parameters.AddWithValue("@USR_CELULAR", Usuario.Celular);
                cmd.Parameters.AddWithValue("@USR_CORREO", Usuario.Correo);
                cmd.Parameters.AddWithValue("@USR_USUARIO", Usuario.UsuarioL);
                //cmd.Parameters.AddWithValue("@USR_CONTRASENA", Usuario.Contrasena);
                //cmd.Parameters.AddWithValue("@USR_ACTIVO", Usuario.Activo);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
        //metodo para eliminar una usuari puntual
        public int Eliminar(int Id)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("EliminarUsuario", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}

