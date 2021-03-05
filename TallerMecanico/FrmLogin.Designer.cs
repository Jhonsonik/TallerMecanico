
namespace TallerMecanico
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.PctLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAcLogin = new System.Windows.Forms.Button();
            this.BtnSalLogin = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.ChkVerCont = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // PctLogin
            // 
            this.PctLogin.Image = ((System.Drawing.Image)(resources.GetObject("PctLogin.Image")));
            this.PctLogin.Location = new System.Drawing.Point(152, 87);
            this.PctLogin.Name = "PctLogin";
            this.PctLogin.Size = new System.Drawing.Size(306, 197);
            this.PctLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctLogin.TabIndex = 0;
            this.PctLogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(187, 326);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(235, 38);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(187, 415);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(235, 38);
            this.txtContrasena.TabIndex = 3;
            this.txtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // BtnAcLogin
            // 
            this.BtnAcLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcLogin.Location = new System.Drawing.Point(187, 470);
            this.BtnAcLogin.Name = "BtnAcLogin";
            this.BtnAcLogin.Size = new System.Drawing.Size(98, 30);
            this.BtnAcLogin.TabIndex = 5;
            this.BtnAcLogin.Text = "Aceptar";
            this.BtnAcLogin.UseVisualStyleBackColor = true;
            this.BtnAcLogin.Click += new System.EventHandler(this.BtnAcLogin_Click);
            // 
            // BtnSalLogin
            // 
            this.BtnSalLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalLogin.Location = new System.Drawing.Point(324, 470);
            this.BtnSalLogin.Name = "BtnSalLogin";
            this.BtnSalLogin.Size = new System.Drawing.Size(98, 30);
            this.BtnSalLogin.TabIndex = 6;
            this.BtnSalLogin.Text = "Salir";
            this.BtnSalLogin.UseVisualStyleBackColor = true;
            this.BtnSalLogin.Click += new System.EventHandler(this.BtnSalLogin_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(35, 533);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 7;
            // 
            // ChkVerCont
            // 
            this.ChkVerCont.AutoSize = true;
            this.ChkVerCont.Location = new System.Drawing.Point(305, 395);
            this.ChkVerCont.Name = "ChkVerCont";
            this.ChkVerCont.Size = new System.Drawing.Size(113, 17);
            this.ChkVerCont.TabIndex = 8;
            this.ChkVerCont.Text = "Ver Contraseña";
            this.ChkVerCont.UseVisualStyleBackColor = true;
            this.ChkVerCont.CheckedChanged += new System.EventHandler(this.ChkVerCont_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 583);
            this.Controls.Add(this.ChkVerCont);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.BtnSalLogin);
            this.Controls.Add(this.BtnAcLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PctLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmLogin";
            this.Text = "Taller Mecanico 5 - Ingreso";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PctLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PctLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAcLogin;
        private System.Windows.Forms.Button BtnSalLogin;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.CheckBox ChkVerCont;
    }
}