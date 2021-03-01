
namespace TallerMecanico
{
    partial class FrmUsuario
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
            this.GbDatosUsr = new System.Windows.Forms.GroupBox();
            this.CmbTipUsr = new System.Windows.Forms.ComboBox();
            this.TxtContrasUsr = new System.Windows.Forms.TextBox();
            this.TxtCorreoUsr = new System.Windows.Forms.TextBox();
            this.TxtDocUsr = new System.Windows.Forms.TextBox();
            this.TxtNomUsr = new System.Windows.Forms.TextBox();
            this.TxtLoginUsr = new System.Windows.Forms.TextBox();
            this.TxtCelUsr = new System.Windows.Forms.TextBox();
            this.LblContrasUsr = new System.Windows.Forms.Label();
            this.LblCorreoUsr = new System.Windows.Forms.Label();
            this.LblDocUsr = new System.Windows.Forms.Label();
            this.LblNomUsr = new System.Windows.Forms.Label();
            this.LblLoginUsr = new System.Windows.Forms.Label();
            this.LblCelUsr = new System.Windows.Forms.Label();
            this.LblTipUsr = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnSalirUsr = new System.Windows.Forms.Button();
            this.BtnEliUsr = new System.Windows.Forms.Button();
            this.BtnEdiUsr = new System.Windows.Forms.Button();
            this.BtnGuaUsr = new System.Windows.Forms.Button();
            this.BtnNueUsr = new System.Windows.Forms.Button();
            this.dgvDatosUsr = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbDatosUsr.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsr)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDatosUsr
            // 
            this.GbDatosUsr.Controls.Add(this.CmbTipUsr);
            this.GbDatosUsr.Controls.Add(this.TxtContrasUsr);
            this.GbDatosUsr.Controls.Add(this.TxtCorreoUsr);
            this.GbDatosUsr.Controls.Add(this.TxtDocUsr);
            this.GbDatosUsr.Controls.Add(this.TxtNomUsr);
            this.GbDatosUsr.Controls.Add(this.TxtLoginUsr);
            this.GbDatosUsr.Controls.Add(this.TxtCelUsr);
            this.GbDatosUsr.Controls.Add(this.LblContrasUsr);
            this.GbDatosUsr.Controls.Add(this.LblCorreoUsr);
            this.GbDatosUsr.Controls.Add(this.LblDocUsr);
            this.GbDatosUsr.Controls.Add(this.LblNomUsr);
            this.GbDatosUsr.Controls.Add(this.LblLoginUsr);
            this.GbDatosUsr.Controls.Add(this.LblCelUsr);
            this.GbDatosUsr.Controls.Add(this.LblTipUsr);
            this.GbDatosUsr.Location = new System.Drawing.Point(27, 28);
            this.GbDatosUsr.Name = "GbDatosUsr";
            this.GbDatosUsr.Size = new System.Drawing.Size(610, 205);
            this.GbDatosUsr.TabIndex = 0;
            this.GbDatosUsr.TabStop = false;
            this.GbDatosUsr.Text = "groupBox1";
            // 
            // CmbTipUsr
            // 
            this.CmbTipUsr.FormattingEnabled = true;
            this.CmbTipUsr.Location = new System.Drawing.Point(81, 32);
            this.CmbTipUsr.Name = "CmbTipUsr";
            this.CmbTipUsr.Size = new System.Drawing.Size(214, 21);
            this.CmbTipUsr.TabIndex = 16;
            this.CmbTipUsr.Text = "Por favor Seleccione Tipo de Usuario";
            this.CmbTipUsr.SelectedIndexChanged += new System.EventHandler(this.CmbTipUsr_SelectedIndexChanged);
            // 
            // TxtContrasUsr
            // 
            this.TxtContrasUsr.Location = new System.Drawing.Point(383, 120);
            this.TxtContrasUsr.Name = "TxtContrasUsr";
            this.TxtContrasUsr.PasswordChar = '*';
            this.TxtContrasUsr.Size = new System.Drawing.Size(214, 20);
            this.TxtContrasUsr.TabIndex = 15;
            // 
            // TxtCorreoUsr
            // 
            this.TxtCorreoUsr.Location = new System.Drawing.Point(383, 91);
            this.TxtCorreoUsr.Name = "TxtCorreoUsr";
            this.TxtCorreoUsr.Size = new System.Drawing.Size(214, 20);
            this.TxtCorreoUsr.TabIndex = 14;
            // 
            // TxtDocUsr
            // 
            this.TxtDocUsr.Location = new System.Drawing.Point(383, 62);
            this.TxtDocUsr.Name = "TxtDocUsr";
            this.TxtDocUsr.Size = new System.Drawing.Size(214, 20);
            this.TxtDocUsr.TabIndex = 13;
            this.TxtDocUsr.TextChanged += new System.EventHandler(this.TxtDocUsr_TextChanged);
            // 
            // TxtNomUsr
            // 
            this.TxtNomUsr.Location = new System.Drawing.Point(81, 62);
            this.TxtNomUsr.Name = "TxtNomUsr";
            this.TxtNomUsr.Size = new System.Drawing.Size(214, 20);
            this.TxtNomUsr.TabIndex = 12;
            // 
            // TxtLoginUsr
            // 
            this.TxtLoginUsr.Location = new System.Drawing.Point(81, 120);
            this.TxtLoginUsr.Name = "TxtLoginUsr";
            this.TxtLoginUsr.Size = new System.Drawing.Size(214, 20);
            this.TxtLoginUsr.TabIndex = 11;
            // 
            // TxtCelUsr
            // 
            this.TxtCelUsr.Location = new System.Drawing.Point(81, 91);
            this.TxtCelUsr.Name = "TxtCelUsr";
            this.TxtCelUsr.Size = new System.Drawing.Size(214, 20);
            this.TxtCelUsr.TabIndex = 10;
            // 
            // LblContrasUsr
            // 
            this.LblContrasUsr.AutoSize = true;
            this.LblContrasUsr.Location = new System.Drawing.Point(315, 123);
            this.LblContrasUsr.Name = "LblContrasUsr";
            this.LblContrasUsr.Size = new System.Drawing.Size(61, 13);
            this.LblContrasUsr.TabIndex = 7;
            this.LblContrasUsr.Text = "Contraseña";
            // 
            // LblCorreoUsr
            // 
            this.LblCorreoUsr.AutoSize = true;
            this.LblCorreoUsr.Location = new System.Drawing.Point(315, 94);
            this.LblCorreoUsr.Name = "LblCorreoUsr";
            this.LblCorreoUsr.Size = new System.Drawing.Size(38, 13);
            this.LblCorreoUsr.TabIndex = 6;
            this.LblCorreoUsr.Text = "Correo";
            // 
            // LblDocUsr
            // 
            this.LblDocUsr.AutoSize = true;
            this.LblDocUsr.Location = new System.Drawing.Point(315, 65);
            this.LblDocUsr.Name = "LblDocUsr";
            this.LblDocUsr.Size = new System.Drawing.Size(62, 13);
            this.LblDocUsr.TabIndex = 5;
            this.LblDocUsr.Text = "Documento";
            // 
            // LblNomUsr
            // 
            this.LblNomUsr.AutoSize = true;
            this.LblNomUsr.Location = new System.Drawing.Point(13, 65);
            this.LblNomUsr.Name = "LblNomUsr";
            this.LblNomUsr.Size = new System.Drawing.Size(44, 13);
            this.LblNomUsr.TabIndex = 4;
            this.LblNomUsr.Text = "Nombre";
            // 
            // LblLoginUsr
            // 
            this.LblLoginUsr.AutoSize = true;
            this.LblLoginUsr.Location = new System.Drawing.Point(13, 123);
            this.LblLoginUsr.Name = "LblLoginUsr";
            this.LblLoginUsr.Size = new System.Drawing.Size(33, 13);
            this.LblLoginUsr.TabIndex = 3;
            this.LblLoginUsr.Text = "Login";
            // 
            // LblCelUsr
            // 
            this.LblCelUsr.AutoSize = true;
            this.LblCelUsr.Location = new System.Drawing.Point(13, 94);
            this.LblCelUsr.Name = "LblCelUsr";
            this.LblCelUsr.Size = new System.Drawing.Size(39, 13);
            this.LblCelUsr.TabIndex = 2;
            this.LblCelUsr.Text = "Celular";
            // 
            // LblTipUsr
            // 
            this.LblTipUsr.AutoSize = true;
            this.LblTipUsr.Location = new System.Drawing.Point(13, 35);
            this.LblTipUsr.Name = "LblTipUsr";
            this.LblTipUsr.Size = new System.Drawing.Size(67, 13);
            this.LblTipUsr.TabIndex = 0;
            this.LblTipUsr.Text = "Tipo Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSalirUsr);
            this.groupBox2.Controls.Add(this.BtnEliUsr);
            this.groupBox2.Controls.Add(this.BtnEdiUsr);
            this.groupBox2.Controls.Add(this.BtnGuaUsr);
            this.groupBox2.Controls.Add(this.BtnNueUsr);
            this.groupBox2.Location = new System.Drawing.Point(643, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BtnSalirUsr
            // 
            this.BtnSalirUsr.Location = new System.Drawing.Point(29, 156);
            this.BtnSalirUsr.Name = "BtnSalirUsr";
            this.BtnSalirUsr.Size = new System.Drawing.Size(75, 23);
            this.BtnSalirUsr.TabIndex = 4;
            this.BtnSalirUsr.Text = "Salir";
            this.BtnSalirUsr.UseVisualStyleBackColor = true;
            this.BtnSalirUsr.Click += new System.EventHandler(this.BtnSalirUsr_Click);
            // 
            // BtnEliUsr
            // 
            this.BtnEliUsr.Location = new System.Drawing.Point(29, 127);
            this.BtnEliUsr.Name = "BtnEliUsr";
            this.BtnEliUsr.Size = new System.Drawing.Size(75, 23);
            this.BtnEliUsr.TabIndex = 3;
            this.BtnEliUsr.Text = "Eliminar";
            this.BtnEliUsr.UseVisualStyleBackColor = true;
            this.BtnEliUsr.Click += new System.EventHandler(this.BtnEliUsr_Click);
            // 
            // BtnEdiUsr
            // 
            this.BtnEdiUsr.Location = new System.Drawing.Point(29, 98);
            this.BtnEdiUsr.Name = "BtnEdiUsr";
            this.BtnEdiUsr.Size = new System.Drawing.Size(75, 23);
            this.BtnEdiUsr.TabIndex = 2;
            this.BtnEdiUsr.Text = "Editar";
            this.BtnEdiUsr.UseVisualStyleBackColor = true;
            this.BtnEdiUsr.Click += new System.EventHandler(this.BtnEdiUsr_Click);
            // 
            // BtnGuaUsr
            // 
            this.BtnGuaUsr.Location = new System.Drawing.Point(29, 69);
            this.BtnGuaUsr.Name = "BtnGuaUsr";
            this.BtnGuaUsr.Size = new System.Drawing.Size(75, 23);
            this.BtnGuaUsr.TabIndex = 1;
            this.BtnGuaUsr.Text = "Guardar";
            this.BtnGuaUsr.UseVisualStyleBackColor = true;
            this.BtnGuaUsr.Click += new System.EventHandler(this.BtnGuaUsr_Click);
            // 
            // BtnNueUsr
            // 
            this.BtnNueUsr.Location = new System.Drawing.Point(29, 40);
            this.BtnNueUsr.Name = "BtnNueUsr";
            this.BtnNueUsr.Size = new System.Drawing.Size(75, 23);
            this.BtnNueUsr.TabIndex = 0;
            this.BtnNueUsr.Text = "Nuevo";
            this.BtnNueUsr.UseVisualStyleBackColor = true;
            this.BtnNueUsr.Click += new System.EventHandler(this.BtnNueUsr_Click);
            // 
            // dgvDatosUsr
            // 
            this.dgvDatosUsr.AllowUserToDeleteRows = false;
            this.dgvDatosUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Documento,
            this.Celular,
            this.Correo,
            this.Usuario,
            this.Activo});
            this.dgvDatosUsr.Location = new System.Drawing.Point(27, 240);
            this.dgvDatosUsr.Name = "dgvDatosUsr";
            this.dgvDatosUsr.Size = new System.Drawing.Size(750, 254);
            this.dgvDatosUsr.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.Visible = false;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.dgvDatosUsr);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GbDatosUsr);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.GbDatosUsr.ResumeLayout(false);
            this.GbDatosUsr.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDatosUsr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDatosUsr;
        private System.Windows.Forms.Button BtnNueUsr;
        private System.Windows.Forms.Button BtnSalirUsr;
        private System.Windows.Forms.Button BtnEliUsr;
        private System.Windows.Forms.Button BtnEdiUsr;
        private System.Windows.Forms.Button BtnGuaUsr;
        private System.Windows.Forms.TextBox TxtContrasUsr;
        private System.Windows.Forms.TextBox TxtCorreoUsr;
        private System.Windows.Forms.TextBox TxtDocUsr;
        private System.Windows.Forms.TextBox TxtNomUsr;
        private System.Windows.Forms.TextBox TxtLoginUsr;
        private System.Windows.Forms.TextBox TxtCelUsr;
        private System.Windows.Forms.Label LblContrasUsr;
        private System.Windows.Forms.Label LblCorreoUsr;
        private System.Windows.Forms.Label LblDocUsr;
        private System.Windows.Forms.Label LblNomUsr;
        private System.Windows.Forms.Label LblLoginUsr;
        private System.Windows.Forms.Label LblCelUsr;
        private System.Windows.Forms.Label LblTipUsr;
        private System.Windows.Forms.ComboBox CmbTipUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
    }
}