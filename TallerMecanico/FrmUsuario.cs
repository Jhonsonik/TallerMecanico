using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TallerMecanico.Entidades;
using TallerMecanico.Negocio;

namespace TallerMecanico
{
    public partial class FrmUsuario : Form
    {
            List<Usuario> lista = null;
            //List<TipoUsuario> listatpu = null;
            BLUsuario blUsuario = new BLUsuario();
            Usuario u;
            //TipoUsuario tu;
            bool _nuevo = false;

            public FrmUsuario()
            {
                InitializeComponent();
                ActivarControlDatos(gbvDatosUsr, false);
                CargarDatos();
            }
        private void ActivarControlDatos(Control Contenedor, bool Estado)
            {
                try
                {
                    foreach (var item in Contenedor.Controls)
                    {
                        if (item.GetType() == typeof(TextBox))
                        {
                            ((TextBox)item).Enabled = Estado;
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
            private void LimpiarControl(Control Contenedor)
            {
                foreach (var item in Contenedor.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).Clear();
                    }
                }
            }
            private void ActivarButton(bool Estado)
            {
                btnNewUsr.Enabled = Estado;
                btnGuardarUsr.Enabled = !Estado;
                btnEliminarUsr.Enabled = Estado;
                btnSalirUsr.Enabled = Estado;
            }
            private void CargarDatos()
            {
                if (lista == null)
                {
                    lista = blUsuario.Listar();
                }
                if (lista.Count > 0)
                {
                gbvDatosUsr.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                    gbvDatosUsr.Rows.Add(lista[i].Id, lista[i].Nombre,
                            lista[i].Documento, lista[i].Celular, 
                            lista[i].Correo, lista[i].UsuarioL/*,*/ 
                            /*lista[i].Contrasena*//*, lista[i].Activo*/);
                    }
                }
            }

        private void btnNewUsr_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(gbvDatosUsr, true);
            btnEditarUsr.Text = "Cancelar";
            ActivarButton(false);
            LimpiarControl(gbvDatosUsr);
            txtNomUsr.Focus();
            if (lista == null)
            {
                lista = blUsuario.Listar();
            }
            if (lista.Count > 0)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    cbbTipUsr.Items.Add(lista[i].TipoUsuarioNombre);
                }
            }
        }

        private void btnGuardarUsr_Click(object sender, EventArgs e)
        {
            int n = -1;
            if (_nuevo)
            {
                u = new Usuario(0, cbbTipUsr.Text, txtNomUsr.Text, txtDocUsr.Text, txtCelUsr.Text, txtCorreoUsr.Text, txtLoginUsr.Text/*, Convert.ToByte(txtPassUsr.Text)*//*, Int32.Parse(cbbTipUsr.Text)*//*,true*/);
                n = blUsuario.Insertar(u);
            }
            else
            {
                u.TipoUsuarioNombre = cbbTipUsr.Text;
                u.Nombre = txtNomUsr.Text;
                u.Documento = txtDocUsr.Text;
                u.Celular = txtCelUsr.Text;
                u.Correo = txtCorreoUsr.Text;
                u.UsuarioL = txtLoginUsr.Text;
                //u.Contrasena = Convert.ToByte(txtPassUsr.Text);
                //u.Activo = true;
                n = blUsuario.Actualizar(u);
            }
            if (n > 0)
            {
                MessageBox.Show("Datos grabados correctamente", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivarControlDatos(gbvDatosUsr, false);
                ActivarButton(true);
                gbvDatosUsr.Enabled = true;
                LimpiarControl(gbvDatosUsr);
                btnEditarUsr.Text = "Editar";
                lista = blUsuario.Listar();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Error al grabar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarUsr_Click(object sender, EventArgs e)
        {
            //gbDatosUsr
            //gbvDatosUsr
            _nuevo = false;
            if (btnEditarUsr.Text == "Cancelar")
            {
                LimpiarControl(gbDatosUsr);
                ActivarControlDatos(gbDatosUsr, false);
                ActivarButton(true);
                gbvDatosUsr.Enabled = true;
                btnEditarUsr.Text = "Editar";
            }
            else
            {
                if (gbvDatosUsr.RowCount > 0)
                {
                    u = blUsuario.TraerPorId((int)gbvDatosUsr[0, gbvDatosUsr.CurrentRow.Index].Value);
                    txtNomUsr.Text = u.Nombre;
                    txtDocUsr.Text = u.Documento;
                    txtCelUsr.Text = u.Celular;
                    txtCorreoUsr.Text = u.Correo;
                    txtLoginUsr.Text = u.UsuarioL;
                    //txtPassUsr.Text = u.Contrasena.ToString();
                    ActivarControlDatos(gbDatosUsr, true);
                    ActivarButton(false);
                    gbvDatosUsr.Enabled = false;
                    btnEditarUsr.Text = "Cancelar";
                }
            }
        }

        private void btnEliminarUsr_Click(object sender, EventArgs e)
        {
            //gbDatosUsr
            //gbvDatosUsr
            if (gbvDatosUsr.RowCount > 0)
            {
                u = blUsuario.TraerPorId((int)gbvDatosUsr[0, gbvDatosUsr.CurrentRow.Index].Value);
                DialogResult rpta =
                    MessageBox.Show("Desea eliminar el registro", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == System.Windows.Forms.DialogResult.Yes)
                {
                    int n = blUsuario.Eliminar(u.Id);
                    if (n > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lista = blUsuario.Listar();
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void btnSalirUsr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbbTipUsr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
