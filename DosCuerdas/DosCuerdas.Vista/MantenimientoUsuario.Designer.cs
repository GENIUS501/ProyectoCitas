namespace DosCuerdas.Vista
{
    partial class MantenimientoUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoUsuario));
            this.txtCClave = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmbrol = new System.Windows.Forms.ComboBox();
            this.lblInstrumento = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.lblTelefono1 = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrpDatosPersonales.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCClave
            // 
            this.txtCClave.Location = new System.Drawing.Point(141, 140);
            this.txtCClave.Name = "txtCClave";
            this.txtCClave.PasswordChar = '*';
            this.txtCClave.Size = new System.Drawing.Size(125, 20);
            this.txtCClave.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 99;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(10, 18);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(67, 13);
            this.lblid.TabIndex = 97;
            this.lblid.Text = "ID Usuario";
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Enabled = false;
            this.txtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNac.Location = new System.Drawing.Point(9, 115);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(100, 20);
            this.txtFechaNac.TabIndex = 96;
            // 
            // cmbrol
            // 
            this.cmbrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrol.FormattingEnabled = true;
            this.cmbrol.Items.AddRange(new object[] {
            "Administrador",
            "Servivio al Cliente",
            "Profesor"});
            this.cmbrol.Location = new System.Drawing.Point(141, 89);
            this.cmbrol.Name = "cmbrol";
            this.cmbrol.Size = new System.Drawing.Size(125, 21);
            this.cmbrol.TabIndex = 95;
            // 
            // lblInstrumento
            // 
            this.lblInstrumento.AutoSize = true;
            this.lblInstrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstrumento.Location = new System.Drawing.Point(10, 124);
            this.lblInstrumento.Name = "lblInstrumento";
            this.lblInstrumento.Size = new System.Drawing.Size(71, 13);
            this.lblInstrumento.TabIndex = 93;
            this.lblInstrumento.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(13, 89);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 91;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(13, 140);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 90;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Enabled = false;
            this.txtApellido2.Location = new System.Drawing.Point(139, 76);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(100, 20);
            this.txtApellido2.TabIndex = 88;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Enabled = false;
            this.txtApellido1.Location = new System.Drawing.Point(9, 76);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(100, 20);
            this.txtApellido1.TabIndex = 87;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(9, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 86;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(13, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 85;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(314, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 84;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(188, 337);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 83;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(10, 73);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(115, 13);
            this.lblDireccion.TabIndex = 81;
            this.lblDireccion.Text = "Nombre de Usuario";
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono2.Location = new System.Drawing.Point(138, 73);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(26, 13);
            this.lblTelefono2.TabIndex = 79;
            this.lblTelefono2.Text = "Rol";
            // 
            // lblTelefono1
            // 
            this.lblTelefono1.AutoSize = true;
            this.lblTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono1.Location = new System.Drawing.Point(6, 99);
            this.lblTelefono1.Name = "lblTelefono1";
            this.lblTelefono1.Size = new System.Drawing.Size(127, 13);
            this.lblTelefono1.TabIndex = 78;
            this.lblTelefono1.Text = "Fecha de Nacimiento";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido2.Location = new System.Drawing.Point(136, 60);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(106, 13);
            this.lblApellido2.TabIndex = 77;
            this.lblApellido2.Text = "Segundo Apellido";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(6, 60);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(91, 13);
            this.lblApellido1.TabIndex = 76;
            this.lblApellido1.Text = "Primer Apellido";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(136, 16);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(46, 13);
            this.lblCedula.TabIndex = 75;
            this.lblCedula.Text = "Cédula";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 74;
            this.lblNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 73;
            this.label1.Text = "Mantenimiento de Usuarios";
            // 
            // GrpDatosPersonales
            // 
            this.GrpDatosPersonales.Controls.Add(this.txtCedula);
            this.GrpDatosPersonales.Controls.Add(this.btn_buscar);
            this.GrpDatosPersonales.Controls.Add(this.label7);
            this.GrpDatosPersonales.Controls.Add(this.txtTelefono2);
            this.GrpDatosPersonales.Controls.Add(this.label6);
            this.GrpDatosPersonales.Controls.Add(this.txtTelefono1);
            this.GrpDatosPersonales.Controls.Add(this.cmbGenero);
            this.GrpDatosPersonales.Controls.Add(this.label5);
            this.GrpDatosPersonales.Controls.Add(this.label4);
            this.GrpDatosPersonales.Controls.Add(this.txtCorreo);
            this.GrpDatosPersonales.Controls.Add(this.lblCedula);
            this.GrpDatosPersonales.Controls.Add(this.lblNombre);
            this.GrpDatosPersonales.Controls.Add(this.lblApellido1);
            this.GrpDatosPersonales.Controls.Add(this.lblApellido2);
            this.GrpDatosPersonales.Controls.Add(this.txtFechaNac);
            this.GrpDatosPersonales.Controls.Add(this.txtNombre);
            this.GrpDatosPersonales.Controls.Add(this.txtApellido1);
            this.GrpDatosPersonales.Controls.Add(this.txtApellido2);
            this.GrpDatosPersonales.Controls.Add(this.lblTelefono1);
            this.GrpDatosPersonales.Location = new System.Drawing.Point(12, 58);
            this.GrpDatosPersonales.Name = "GrpDatosPersonales";
            this.GrpDatosPersonales.Size = new System.Drawing.Size(283, 243);
            this.GrpDatosPersonales.TabIndex = 102;
            this.GrpDatosPersonales.TabStop = false;
            this.GrpDatosPersonales.Text = "Datos Personales";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(139, 32);
            this.txtCedula.Mask = "000000000000";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 109;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Location = new System.Drawing.Point(245, 31);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar.TabIndex = 104;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Telefono adicional";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Enabled = false;
            this.txtTelefono2.Location = new System.Drawing.Point(11, 205);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono2.TabIndex = 106;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Telefono";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.Enabled = false;
            this.txtTelefono1.Location = new System.Drawing.Point(137, 154);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(102, 20);
            this.txtTelefono1.TabIndex = 104;
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.Enabled = false;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(11, 154);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(100, 21);
            this.cmbGenero.TabIndex = 102;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(137, 115);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(102, 20);
            this.txtCorreo.TabIndex = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDireccion);
            this.groupBox2.Controls.Add(this.lblTelefono2);
            this.groupBox2.Controls.Add(this.txtCClave);
            this.groupBox2.Controls.Add(this.lblid);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.txtClave);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.lblInstrumento);
            this.groupBox2.Controls.Add(this.cmbrol);
            this.groupBox2.Location = new System.Drawing.Point(301, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 178);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de acceso";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MantenimientoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 372);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GrpDatosPersonales);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoUsuario";
            this.Text = "Dos Cuerdas | MantenimientoUsuario";
            this.Load += new System.EventHandler(this.MantenimientoUsuario_Load);
            this.GrpDatosPersonales.ResumeLayout(false);
            this.GrpDatosPersonales.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DateTimePicker txtFechaNac;
        private System.Windows.Forms.ComboBox cmbrol;
        private System.Windows.Forms.Label lblInstrumento;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.Label lblTelefono1;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GrpDatosPersonales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}