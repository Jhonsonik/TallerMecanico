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
        //int _id_tipousuario;
        string _tipousuarionombre;
        string _nombre;
        string _documento;
        string _celular;
        string _correo;
        string _usuario;
        //byte _contrasena;
        //bool _activo;

        // Se definen los metodos get y set
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //public int Id_TipoUsuario
        //{
        //    get { return _id_tipousuario; }
        //    set { _id_tipousuario = value; }
        //}

        public string TipoUsuarioNombre
        {
            get { return _tipousuarionombre; }
            set { _tipousuarionombre = value; }
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

        //public byte Contrasena
        //{
        //    get { return _contrasena; }
        //    set { _contrasena = value; }
        //}

        //public bool Activo
        //{
        //    get { return _activo; }
        //    set { _activo = value; }
        //}


        // Se crean los constructores de la clase
        public Usuario(int Id, /*int Id_TipoUsuario,*/ string TipoUsuarioNombre, string Nombre, string Documento, string Celular, string Correo,string UsuarioL/*, byte Contrasena*//*,bool Activo*/)
        {
            this._id = Id;
            //this._id_tipousuario = Id_TipoUsuario;
            this._tipousuarionombre = TipoUsuarioNombre;
            this._nombre = Nombre;
            this._documento = Documento;
            this._celular = Celular;
            this._correo = Correo;
            this._usuario = UsuarioL;
            //this._contrasena = Contrasena;
            //this._activo = Activo;
        }

        public Usuario() : this(0, "", "", "","","","")
        {
        }
    }
    //public class TipoUsuario
    //{
    //    // Atributos  de la clase TipoUsuario
    //    //Recuerde que la clase debe tener los mismos tipos de datos relacionados con el objeto en la base de datos.         
    //    string _tipousuarionombre;

    //    public TipoUsuario(string TipoUsuarioNombre)
    //    {
    //        this._tipousuarionombre = TipoUsuarioNombre;           
    //    }

    //}
}
