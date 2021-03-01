using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Usuario
    {
        // Atributos  de la clase Categoria
        //Recuerde que la clase debe tener los mismos tipos de datos relacionados con el objeto en la base de datos. 
        int _id;
        int _tpu_id;
        string _nombre;
        string _documento;
        string _celular;
        string _correo;
        string _usuario;
        //byte[] _contrasena;
        bool _activo;

        // Se definen los metodos get y set
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Tpu_Id
        {
            get { return _tpu_id; }
            set { _tpu_id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Documento 
        {
            get { return _documento; }
            set { _documento = value; }
        }

        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        public string UsuarioL
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        //public byte[] Contrasena
        //{
        //    get { return _contrasena; }
        //    set { _contrasena = value; }
        //}

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }


        // Se crean los constructores de la clase
        public Usuario(int Id, string Nombre, 
            string Documento, string Celular, string Correo,
            string UsuarioL, /*byte[] Contrasena,*/int Tpu_Id,
            bool Activo)
        {
            this._id = Id;
            this._tpu_id = Tpu_Id;
            this._nombre = Nombre;
            this._documento = Documento;
            this._celular = Celular;
            this._correo = Correo;
            this._usuario = UsuarioL;
            //this._contrasena = Contrasena;
            this._activo = Activo;
        }

        public Usuario(
            int Id, int Tpu_Id, string Nombre,
            string Documento, string Celular, string Correo,
            string UsuarioL//, byte[] Contrasena
            ) 
      : this(Id, Nombre, Documento, Celular, Correo, UsuarioL, /*Contrasena,*/ Tpu_Id, true)
        {
        }

        public Usuario()
        {
        }

        //public Usuario(int Id, string Nombre) : this(Id, "", Nombre, "")
        //{
        //}

        //public Usuario() : this(0, "", "", "")
        //{
        //}
    }
}
