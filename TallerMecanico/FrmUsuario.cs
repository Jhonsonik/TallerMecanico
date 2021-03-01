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
        BLUsuario blUsuario = new BLUsuario();
        Usuario u;
        bool _nuevo = false;
        public FrmUsuario()
        {
            InitializeComponent();
            ActivarControlDatos(GbDatosUsr, false);
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
            BtnNueUsr.Enabled = Estado;
            BtnGuaUsr.Enabled = !Estado;
            BtnEliUsr.Enabled = Estado;
            BtnSalirUsr.Enabled = Estado;
        }
        private void CargarDatos()
        {
            if (lista == null)
            {
                lista = blUsuario.Listar();
            }
            if (lista.Count > 0)
            {
                dgvDatosUsr.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    dgvDatosUsr.Rows.Add(
                        lista[i].Id,
                        lista[i].Tpu_Id,
                        lista[i].Nombre,
                        lista[i].Documento, 
                        lista[i].Celular,
                        lista[i].Correo,
                        lista[i].UsuarioL//,
                        //lista[i].Contrasena
                        );
                }
            }
        }


        private void BtnSalirUsr_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuaUsr_Click(object sender, EventArgs e)
        {
            int n = -1;
            if (_nuevo)
            {
                u = new Usuario(
                    0, 
                    TxtNomUsr.Text,
                    TxtDocUsr.Text, 
                    TxtCelUsr.Text, 
                    TxtCorreoUsr.Text, 
                    TxtLoginUsr.Text,
                    //Encoding.ASCII.GetBytes(TxtContrasUsr.Text.ToString()),
                    Int32.Parse(CmbTipUsr.Text),
                    true
                    );
                n = blUsuario.Insertar(u);
            }
            else
            {
                u.Nombre = TxtNomUsr.Text;
                u.Documento = TxtDocUsr.Text;
                u.Celular = TxtCelUsr.Text;
                u.Correo = TxtCorreoUsr.Text;
                u.UsuarioL = TxtLoginUsr.Text;
                //u.Contrasena = Encoding.ASCII.GetBytes(TxtContrasUsr.Text.ToString());
                u.Tpu_Id = Int32.Parse(CmbTipUsr.Text);                
                n = blUsuario.Actualizar(u);
            }
            if (n > 0)
            {
                MessageBox.Show("Datos grabados correctamente", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivarControlDatos(GbDatosUsr, false);
                ActivarButton(true);
                dgvDatosUsr.Enabled = true;
                LimpiarControl(GbDatosUsr);
                BtnEdiUsr.Text = "Editar";
                lista = blUsuario.Listar();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Error al grabar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliUsr_Click(object sender, EventArgs e)
        {
            if (dgvDatosUsr.RowCount > 0)
            {
                u = blUsuario.TraerPorId((int)dgvDatosUsr[0, dgvDatosUsr.
                    CurrentRow.Index].Value);
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
        private void BtnNueUsr_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(GbDatosUsr, true);
            BtnNueUsr.Text = "Cancelar";
            ActivarButton(false);
            LimpiarControl(GbDatosUsr);
            TxtNomUsr.Focus();
        }

        private void BtnEdiUsr_Click(object sender, EventArgs e)
        {
            _nuevo = false;
            if (BtnEdiUsr.Text == "Cancelar")
            {
                LimpiarControl(GbDatosUsr);
                ActivarControlDatos(GbDatosUsr, false);
                ActivarButton(true);
                dgvDatosUsr.Enabled = true;
                BtnEdiUsr.Text = "Editar";
            }
            else
            {
                if (dgvDatosUsr.RowCount > 0)
                {
                    u = blUsuario.TraerPorId((int)dgvDatosUsr[0, dgvDatosUsr.
                        CurrentRow.Index].Value);
                    TxtNomUsr.Text = u.Nombre;
                    TxtDocUsr.Text = u.Documento;
                    TxtCelUsr.Text = u.Celular;
                    TxtCorreoUsr.Text = u.Correo;
                    TxtLoginUsr.Text = u.UsuarioL;
                    //TxtContrasUsr.Text = TxtContrasUsr.Text.ToString(); 
                    ActivarControlDatos(GbDatosUsr, true);
                    ActivarButton(false);
                    dgvDatosUsr.Enabled = false;
                    BtnEdiUsr.Text = "Cancelar";
                }
            }
        }

        private void CmbTipUsr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtDocUsr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
