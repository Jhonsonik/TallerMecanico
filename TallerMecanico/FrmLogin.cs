using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TallerMecanico.Entidades;
using TallerMecanico_05;
using TallerMecanico.Negocio;

namespace TallerMecanico
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private Login getUserFromDB(string username)
        {
            Login user = new Login();

            var connectionString = ConfigurationManager.ConnectionStrings["Conex"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string saltSaved = "select usr_usuario,usr_salt,usr_tpu_id,usr_contrasena,usr_activo FROM Usuarios where usr_usuario = @username";

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = saltSaved;
                    command.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;

                    try
                    {
                        connection.Open();
                        using (SqlDataReader oReader = command.ExecuteReader())
                        {
                            if (oReader.Read())
                            {
                                try
                                {
                                    user.user = oReader["usr_usuario"].ToString();
                                    user.salt = (byte[])oReader["usr_salt"];
                                    user.rol = (Int32)oReader["usr_tpu_id"];
                                    user.pass = (byte[])oReader["usr_contrasena"];
                                    user.activo = (bool)oReader["usr_activo"];
                                }
                                catch (SqlException ex)
                                {
                                    lblResultado.Text = ex.Message;
                                }

                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        lblResultado.Text = ex.Message;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            return user;
        }
        private void BtnAcLogin_Click(object sender, EventArgs e)
        {            
            string username = txtLogin.Text.Trim();
            Login user = getUserFromDB(username);
            string pass = txtContrasena.Text.Trim();
            int rol = user.rol;
            bool activo = user.activo;

            if (isValidPassword(username, pass))
            {
                if (rol == 1 && activo == true)
                {
                    this.Hide();
                    FrmMenuAdm frm = new FrmMenuAdm();
                    frm.Show();
                }
                else if (rol == 2 && activo == true)
                {
                    lblResultado.Text = $"Menu Auxiliar en construcción";
                }
                else if(rol == 3 && activo == true)
                {
                    lblResultado.Text = $"Menu Mecanico en construcción";
                }
                else
                {
                    lblResultado.Text = $"Este usuario no tiene Rol Asignado consulte al administrador";
                }

            }
            else if (activo == false)
            {
                lblResultado.Text = $"Este usuario se encuentra inactivo";
            }
            else
            {
                lblResultado.Text = $"Usuario y/o password son incorrectos";
            }            
        }

        private bool isValidPassword(string username, string password)
        {
            Login user = getUserFromDB(username);
            bool isValid = false;

            if (!string.IsNullOrEmpty(user.user))
            {
                byte[] hashedPassword = Encripta.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), user.salt);

                if (hashedPassword.SequenceEqual(user.pass))
                    isValid = true;
            }

            return isValid;

        }
        private void rdLogin_CheckedChanged(object sender, EventArgs e)
        {
            txtContrasena.PasswordChar = '*';
            txtLogin.Text = "Ingresar";
        }

        private void BtnSalLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkVerCont_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVerCont.Checked == false)
            {
                txtContrasena.PasswordChar = '*';
            }
            else
            {
                
                txtContrasena.PasswordChar = '\0';
            }

        }


    }
}
