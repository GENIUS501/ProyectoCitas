
namespace DosCuerdas.Vista
{
    partial class AgendarClases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendarClases));
            this.cbo_hora = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buscar_nombre = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.datEstudiantes = new System.Windows.Forms.DataGridView();
            this.dat_profesores = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar_estudiante = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtCedulaProfesor = new System.Windows.Forms.MaskedTextBox();
            this.txtCedulaEstudiante = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_profesores)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_hora
            // 
            this.cbo_hora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_hora.FormattingEnabled = true;
            this.cbo_hora.Items.AddRange(new object[] {
            "07:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00"});
            this.cbo_hora.Location = new System.Drawing.Point(24, 51);
            this.cbo_hora.Name = "cbo_hora";
            this.cbo_hora.Size = new System.Drawing.Size(121, 21);
            this.cbo_hora.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hora de la cita";
            // 
            // btn_buscar_nombre
            // 
            this.btn_buscar_nombre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_nombre.BackgroundImage")));
            this.btn_buscar_nombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_nombre.Location = new System.Drawing.Point(115, 32);
            this.btn_buscar_nombre.Name = "btn_buscar_nombre";
            this.btn_buscar_nombre.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_nombre.TabIndex = 47;
            this.btn_buscar_nombre.UseVisualStyleBackColor = true;
            this.btn_buscar_nombre.Click += new System.EventHandler(this.btn_buscar_nombre_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Cedula del profesor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCedulaEstudiante);
            this.groupBox1.Controls.Add(this.txtCedulaProfesor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtProfesor);
            this.groupBox1.Controls.Add(this.txtEstudiante);
            this.groupBox1.Controls.Add(this.datEstudiantes);
            this.groupBox1.Controls.Add(this.dat_profesores);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_buscar_estudiante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_buscar_nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 340);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los participantes.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 113;
            this.label5.Text = "Estudiante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 112;
            this.label4.Text = "Profesor";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Enabled = false;
            this.txtProfesor.Location = new System.Drawing.Point(169, 311);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtProfesor.TabIndex = 111;
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Enabled = false;
            this.txtEstudiante.Location = new System.Drawing.Point(296, 311);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(100, 20);
            this.txtEstudiante.TabIndex = 110;
            // 
            // datEstudiantes
            // 
            this.datEstudiantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datEstudiantes.Location = new System.Drawing.Point(9, 196);
            this.datEstudiantes.Name = "datEstudiantes";
            this.datEstudiantes.Size = new System.Drawing.Size(388, 81);
            this.datEstudiantes.TabIndex = 109;
            this.datEstudiantes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datEstudiantes_CellClick);
            // 
            // dat_profesores
            // 
            this.dat_profesores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_profesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_profesores.Location = new System.Drawing.Point(9, 58);
            this.dat_profesores.Name = "dat_profesores";
            this.dat_profesores.Size = new System.Drawing.Size(388, 81);
            this.dat_profesores.TabIndex = 108;
            this.dat_profesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_profesores_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Cedula del estudiante";
            // 
            // btn_buscar_estudiante
            // 
            this.btn_buscar_estudiante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_estudiante.BackgroundImage")));
            this.btn_buscar_estudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_estudiante.Location = new System.Drawing.Point(115, 170);
            this.btn_buscar_estudiante.Name = "btn_buscar_estudiante";
            this.btn_buscar_estudiante.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_estudiante.TabIndex = 51;
            this.btn_buscar_estudiante.UseVisualStyleBackColor = true;
            this.btn_buscar_estudiante.Click += new System.EventHandler(this.btn_buscar_estudiante_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtObservaciones);
            this.groupBox2.Controls.Add(this.txtFecha);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbo_hora);
            this.groupBox2.Location = new System.Drawing.Point(448, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 340);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la clase";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Observaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(23, 170);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(311, 161);
            this.txtObservaciones.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(22, 107);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(200, 20);
            this.txtFecha.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(379, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 88;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(266, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 87;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtCedulaProfesor
            // 
            this.txtCedulaProfesor.Location = new System.Drawing.Point(8, 33);
            this.txtCedulaProfesor.Mask = "000000000000";
            this.txtCedulaProfesor.Name = "txtCedulaProfesor";
            this.txtCedulaProfesor.Size = new System.Drawing.Size(101, 20);
            this.txtCedulaProfesor.TabIndex = 114;
            // 
            // txtCedulaEstudiante
            // 
            this.txtCedulaEstudiante.Location = new System.Drawing.Point(8, 170);
            this.txtCedulaEstudiante.Mask = "000000000000";
            this.txtCedulaEstudiante.Name = "txtCedulaEstudiante";
            this.txtCedulaEstudiante.Size = new System.Drawing.Size(101, 20);
            this.txtCedulaEstudiante.TabIndex = 115;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AgendarClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "AgendarClases";
            this.Text = "AgendarClases";
            this.Load += new System.EventHandler(this.AgendarClases_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dat_profesores)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_hora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar_estudiante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.DataGridView datEstudiantes;
        private System.Windows.Forms.DataGridView dat_profesores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.MaskedTextBox txtCedulaEstudiante;
        private System.Windows.Forms.MaskedTextBox txtCedulaProfesor;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}