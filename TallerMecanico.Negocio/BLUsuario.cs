using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TallerMecanico.Datos;
using TallerMecanico.Entidades;

namespace TallerMecanico.Negocio
{
    public class BLUsuario
    {
        public List<Usuario> Listar()
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.Listar();
        }

        public Usuario TraerPorId(int Id)
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.TraerPorId(Id);
        }

        public int Insertar(Usuario Usuario)
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.Insertar(Usuario);
        }

        public int Actualizar(Usuario Usuario)
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.Actualizar(Usuario);
        }

        public int Eliminar(int Id)
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.Eliminar(Id);
        }
    }
}
