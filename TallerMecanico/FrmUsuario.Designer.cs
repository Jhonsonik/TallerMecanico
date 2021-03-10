
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
            this.gbDatosUsr = new System.Windows.Forms.GroupBox();
            this.cbbTipUsr = new System.Windows.Forms.ComboBox();
            this.txtPassUsr = new System.Windows.Forms.TextBox();
            this.txtCorreoUsr = new System.Windows.Forms.TextBox();
            this.txtDocUsr = new System.Windows.Forms.TextBox();
            this.txtLoginUsr = new System.Windows.Forms.TextBox();
            this.txtNomUsr = new System.Windows.Forms.TextBox();
            this.lblPassUsr = new System.Windows.Forms.Label();
            this.lblCorreoUsr = new System.Windows.Forms.Label();
            this.lblDocUsr = new System.Windows.Forms.Label();
            this.lblLoginUsr = new System.Windows.Forms.Label();
            this.lblCelUsr = new System.Windows.Forms.Label();
            this.lblNomUsr = new System.Windows.Forms.Label();
            this.lblTipUsr = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalirUsr = new System.Windows.Forms.Button();
            this.btnEliminarUsr = new System.Windows.Forms.Button();
            this.btnEditarUsr = new System.Windows.Forms.Button();
            this.btnGuardarUsr = new System.Windows.Forms.Button();
            this.btnNewUsr = new System.Windows.Forms.Button();
            this.gbvDatosUsr = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tpu_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCelUsr = new System.Windows.Forms.TextBox();
            this.gbDatosUsr.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbvDatosUsr)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosUsr
            // 
            this.gbDatosUsr.Controls.Add(this.cbbTipUsr);
            this.gbDatosUsr.Controls.Add(this.txtPassUsr);
            this.gbDatosUsr.Controls.Add(this.txtCorreoUsr);
            this.gbDatosUsr.Controls.Add(this.txtDocUsr);
            this.gbDatosUsr.Controls.Add(this.txtLoginUsr);
            this.gbDatosUsr.Controls.Add(this.txtCelUsr);
            this.gbDatosUsr.Controls.Add(this.txtNomUsr);
            this.gbDatosUsr.Controls.Add(this.lblPassUsr);
            this.gbDatosUsr.Controls.Add(this.lblCorreoUsr);
            this.gbDatosUsr.Controls.Add(this.lblDocUsr);
            this.gbDatosUsr.Controls.Add(this.lblLoginUsr);
            this.gbDatosUsr.Controls.Add(this.lblCelUsr);
            this.gbDatosUsr.Controls.Add(this.lblNomUsr);
            this.gbDatosUsr.Controls.Add(this.lblTipUsr);
            this.gbDatosUsr.Location = new System.Drawing.Point(27, 28);
            this.gbDatosUsr.Name = "gbDatosUsr";
            this.gbDatosUsr.Size = new System.Drawing.Size(610, 205);
            this.gbDatosUsr.TabIndex = 0;
            this.gbDatosUsr.TabStop = false;
            this.gbDatosUsr.Text = "groupBox1";
            // 
            // cbbTipUsr
            // 
            this.cbbTipUsr.FormattingEnabled = true;
            this.cbbTipUsr.Location = new System.Drawing.Point(81, 32);
            this.cbbTipUsr.Name = "cbbTipUsr";
            this.cbbTipUsr.Size = new System.Drawing.Size(214, 21);
            this.cbbTipUsr.TabIndex = 16;
            this.cbbTipUsr.SelectedIndexChanged += new System.EventHandler(this.cbbTipUsr_SelectedIndexChanged);
            // 
            // txtPassUsr
            // 
            this.txtPassUsr.Location = new System.Drawing.Point(383, 120);
            this.txtPassUsr.Name = "txtPassUsr";
            this.txtPassUsr.Size = new System.Drawing.Size(214, 20);
            this.txtPassUsr.TabIndex = 15;
            // 
            // txtCorreoUsr
            // 
            this.txtCorreoUsr.Location = new System.Drawing.Point(383, 91);
            this.txtCorreoUsr.Name = "txtCorreoUsr";
            this.txtCorreoUsr.Size = new System.Drawing.Size(214, 20);
            this.txtCorreoUsr.TabIndex = 14;
            // 
            // txtDocUsr
            // 
            this.txtDocUsr.Location = new System.Drawing.Point(383, 62);
            this.txtDocUsr.Name = "txtDocUsr";
            this.txtDocUsr.Size = new System.Drawing.Size(214, 20);
            this.txtDocUsr.TabIndex = 13;
            // 
            // txtLoginUsr
            // 
            this.txtLoginUsr.Location = new System.Drawing.Point(81, 120);
            this.txtLoginUsr.Name = "txtLoginUsr";
            this.txtLoginUsr.Size = new System.Drawing.Size(214, 20);
            this.txtLoginUsr.TabIndex = 11;
            // 
            // txtNomUsr
            // 
            this.txtNomUsr.Location = new System.Drawing.Point(81, 62);
            this.txtNomUsr.Name = "txtNomUsr";
            this.txtNomUsr.Size = new System.Drawing.Size(214, 20);
            this.txtNomUsr.TabIndex = 9;
            // 
            // lblPassUsr
            // 
            this.lblPassUsr.AutoSize = true;
            this.lblPassUsr.Location = new System.Drawing.Point(315, 123);
            this.lblPassUsr.Name = "lblPassUsr";
            this.lblPassUsr.Size = new System.Drawing.Size(61, 13);
            this.lblPassUsr.TabIndex = 7;
            this.lblPassUsr.Text = "Contraseña";
            // 
            // lblCorreoUsr
            // 
            this.lblCorreoUsr.AutoSize = true;
            this.lblCorreoUsr.Location = new System.Drawing.Point(315, 94);
            this.lblCorreoUsr.Name = "lblCorreoUsr";
            this.lblCorreoUsr.Size = new System.Drawing.Size(38, 13);
            this.lblCorreoUsr.TabIndex = 6;
            this.lblCorreoUsr.Text = "Correo";
            // 
            // lblDocUsr
            // 
            this.lblDocUsr.AutoSize = true;
            this.lblDocUsr.Location = new System.Drawing.Point(315, 65);
            this.lblDocUsr.Name = "lblDocUsr";
            this.lblDocUsr.Size = new System.Drawing.Size(62, 13);
            this.lblDocUsr.TabIndex = 5;
            this.lblDocUsr.Text = "Documento";
            // 
            // lblLoginUsr
            // 
            this.lblLoginUsr.AutoSize = true;
            this.lblLoginUsr.Location = new System.Drawing.Point(13, 123);
            this.lblLoginUsr.Name = "lblLoginUsr";
            this.lblLoginUsr.Size = new System.Drawing.Size(43, 13);
            this.lblLoginUsr.TabIndex = 3;
            this.lblLoginUsr.Text = "Usuario";
            // 
            // lblCelUsr
            // 
            this.lblCelUsr.AutoSize = true;
            this.lblCelUsr.Location = new System.Drawing.Point(13, 94);
            this.lblCelUsr.Name = "lblCelUsr";
            this.lblCelUsr.Size = new System.Drawing.Size(39, 13);
            this.lblCelUsr.TabIndex = 2;
            this.lblCelUsr.Text = "Celular";
            // 
            // lblNomUsr
            // 
            this.lblNomUsr.AutoSize = true;
            this.lblNomUsr.Location = new System.Drawing.Point(13, 65);
            this.lblNomUsr.Name = "lblNomUsr";
            this.lblNomUsr.Size = new System.Drawing.Size(44, 13);
            this.lblNomUsr.TabIndex = 1;
            this.lblNomUsr.Text = "Nombre";
            // 
            // lblTipUsr
            // 
            this.lblTipUsr.AutoSize = true;
            this.lblTipUsr.Location = new System.Drawing.Point(13, 35);
            this.lblTipUsr.Name = "lblTipUsr";
            this.lblTipUsr.Size = new System.Drawing.Size(67, 13);
            this.lblTipUsr.TabIndex = 0;
            this.lblTipUsr.Text = "Tipo Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalirUsr);
            this.groupBox2.Controls.Add(this.btnEliminarUsr);
            this.groupBox2.Controls.Add(this.btnEditarUsr);
            this.groupBox2.Controls.Add(this.btnGuardarUsr);
            this.groupBox2.Controls.Add(this.btnNewUsr);
            this.groupBox2.Location = new System.Drawing.Point(643, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnSalirUsr
            // 
            this.btnSalirUsr.Location = new System.Drawing.Point(29, 156);
            this.btnSalirUsr.Name = "btnSalirUsr";
            this.btnSalirUsr.Size = new System.Drawing.Size(75, 23);
            this.btnSalirUsr.TabIndex = 4;
            this.btnSalirUsr.Text = "Salir";
            this.btnSalirUsr.UseVisualStyleBackColor = true;
            this.btnSalirUsr.Click += new System.EventHandler(this.btnSalirUsr_Click);
            // 
            // btnEliminarUsr
            // 
            this.btnEliminarUsr.Location = new System.Drawing.Point(29, 127);
            this.btnEliminarUsr.Name = "btnEliminarUsr";
            this.btnEliminarUsr.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsr.TabIndex = 3;
            this.btnEliminarUsr.Text = "Eliminar";
            this.btnEliminarUsr.UseVisualStyleBackColor = true;
            this.btnEliminarUsr.Click += new System.EventHandler(this.btnEliminarUsr_Click);
            // 
            // btnEditarUsr
            // 
            this.btnEditarUsr.Location = new System.Drawing.Point(29, 98);
            this.btnEditarUsr.Name = "btnEditarUsr";
            this.btnEditarUsr.Size = new System.Drawing.Size(75, 23);
            this.btnEditarUsr.TabIndex = 2;
            this.btnEditarUsr.Text = "Editar";
            this.btnEditarUsr.UseVisualStyleBackColor = true;
            this.btnEditarUsr.Click += new System.EventHandler(this.btnEditarUsr_Click);
            // 
            // btnGuardarUsr
            // 
            this.btnGuardarUsr.Location = new System.Drawing.Point(29, 69);
            this.btnGuardarUsr.Name = "btnGuardarUsr";
            this.btnGuardarUsr.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarUsr.TabIndex = 1;
            this.btnGuardarUsr.Text = "Guardar";
            this.btnGuardarUsr.UseVisualStyleBackColor = true;
            this.btnGuardarUsr.Click += new System.EventHandler(this.btnGuardarUsr_Click);
            // 
            // btnNewUsr
            // 
            this.btnNewUsr.Location = new System.Drawing.Point(29, 40);
            this.btnNewUsr.Name = "btnNewUsr";
            this.btnNewUsr.Size = new System.Drawing.Size(75, 23);
            this.btnNewUsr.TabIndex = 0;
            this.btnNewUsr.Text = "Nuevo";
            this.btnNewUsr.UseVisualStyleBackColor = true;
            this.btnNewUsr.Click += new System.EventHandler(this.btnNewUsr_Click);
            // 
            // gbvDatosUsr
            // 
            this.gbvDatosUsr.AllowUserToDeleteRows = false;
            this.gbvDatosUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gbvDatosUsr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Documento,
            this.Celular,
            this.Correo,
            this.UsuarioL,
            this.Contrasena,
            this.Tpu_Id,
            this.Activo});
            this.gbvDatosUsr.Location = new System.Drawing.Point(27, 239);
            this.gbvDatosUsr.Name = "gbvDatosUsr";
            this.gbvDatosUsr.Size = new System.Drawing.Size(750, 254);
            this.gbvDatosUsr.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "IdUsuario";
            this.Id.Name = "Id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Usuario";
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
            // UsuarioL
            // 
            this.UsuarioL.HeaderText = "Usuario";
            this.UsuarioL.Name = "UsuarioL";
            // 
            // Contrasena
            // 
            this.Contrasena.HeaderText = "Contraseña";
            this.Contrasena.Name = "Contrasena";
            // 
            // Tpu_Id
            // 
            this.Tpu_Id.HeaderText = "Tipo Usuario";
            this.Tpu_Id.Name = "Tpu_Id";
            // 
            // Activo
            // 
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            // 
            // txtCelUsr
            // 
            this.txtCelUsr.Location = new System.Drawing.Point(81, 91);
            this.txtCelUsr.Name = "txtCelUsr";
            this.txtCelUsr.Size = new System.Drawing.Size(214, 20);
            this.txtCelUsr.TabIndex = 10;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.gbvDatosUsr);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDatosUsr);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.gbDatosUsr.ResumeLayout(false);
            this.gbDatosUsr.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbvDatosUsr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosUsr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gbvDatosUsr;
        private System.Windows.Forms.Button btnNewUsr;
        private System.Windows.Forms.Button btnSalirUsr;
        private System.Windows.Forms.Button btnEliminarUsr;
        private System.Windows.Forms.Button btnEditarUsr;
        private System.Windows.Forms.Button btnGuardarUsr;
        private System.Windows.Forms.TextBox txtPassUsr;
        private System.Windows.Forms.TextBox txtCorreoUsr;
        private System.Windows.Forms.TextBox txtDocUsr;
        private System.Windows.Forms.TextBox txtLoginUsr;
        private System.Windows.Forms.TextBox txtNomUsr;
        private System.Windows.Forms.Label lblPassUsr;
        private System.Windows.Forms.Label lblCorreoUsr;
        private System.Windows.Forms.Label lblDocUsr;
        private System.Windows.Forms.Label lblLoginUsr;
        private System.Windows.Forms.Label lblCelUsr;
        private System.Windows.Forms.Label lblNomUsr;
        private System.Windows.Forms.Label lblTipUsr;
        private System.Windows.Forms.ComboBox cbbTipUsr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tpu_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.TextBox txtCelUsr;
    }
}