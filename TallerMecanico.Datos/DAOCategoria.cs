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
    public class DAOCategoria
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
        //metodo para traer la lista de todas las categorías de la tabla
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ListarCategorias", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Categoria c = new Categoria((int)dr["Id"],
                            (string)dr["Codigo"], (string)dr["Nombre"],
                            (string)dr["Observacion"], (bool)dr["Activo"]);
                        lista.Add(c);
                    }
                }
            }
            return lista;
        }
        //metodo para traer una categoría segun su identificación 
        public Categoria TraerPorId(int Id)
        {
            Categoria Categoria = new Categoria();
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("TraerCategoriaPorId", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Id);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.HasRows)
                {
                    dr.Read();
                    Categoria = new Categoria((int)dr["Id"],
                        (string)dr["Codigo"], (string)dr["Nombre"],
                        (string)dr["Observacion"], (bool)dr["Activo"]);
                }
            }
            return Categoria;
        }
        //metodo para insertar una nueva categoría
        public int Insertar(Categoria Categoria)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Categoria.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", Categoria.Nombre);
                cmd.Parameters.AddWithValue("@Observacion", Categoria.Observacion);
                cmd.Parameters.AddWithValue("@Activo", Categoria.Activo);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
        //metodo para actualizar una categoria puentual
        public int Actualizar(Categoria Categoria)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ActualizarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Categoria.Id);
                cmd.Parameters.AddWithValue("@Codigo", Categoria.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", Categoria.Nombre);
                cmd.Parameters.AddWithValue("@Observacion", Categoria.Observacion);
                cmd.Parameters.AddWithValue("@Activo", Categoria.Activo);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
        //metodo para eliminar una categoría puntual
        public int Eliminar(int Id)
        {
            int n = -1;
            using (SqlConnection con = new SqlConnection(CadenaConexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("EliminarCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                n = cmd.ExecuteNonQuery();
            }
            return n;
        }
    }
}
