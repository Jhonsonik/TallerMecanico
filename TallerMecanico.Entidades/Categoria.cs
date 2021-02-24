using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Categoria
    {
        // Atributos  de la clase Categoria
        //Recuerde que la clase debe tener los mismos tipos de datos relacionados con el objeto en la base de datos. 
        int _id;
        string _codigo;
        string _nombre;
        string _observacion;
        bool _activo;

        // Se definen los metodos get y set
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }


        // Se crean los constructores de la clase
        public Categoria(int Id, string Codigo, string Nombre, string Observacion, bool Activo)
        {
            this._id = Id;
            this._codigo = Codigo;
            this._nombre = Nombre;
            this._observacion = Observacion;
            this._activo = Activo;
        }

        public Categoria(int Id, string Codigo, string Nombre, string Observacion) : this(Id, Codigo, Nombre, Observacion,true)
        {
        }

        public Categoria(int Id, string Nombre) : this(Id, "", Nombre, "")
        {
        }

        public Categoria() : this(0, "", "", "")
        {
        }

    }

}

