
namespace DosCuerdas.Vista
{
    partial class ModificarClases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarClases));
            this.dat_principal = new System.Windows.Forms.DataGridView();
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.btn_buscar_id = new System.Windows.Forms.Button();
            this.btn_buscar_estudiante = new System.Windows.Forms.Button();
            this.btn_buscar_profesor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstudiante = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_atendida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dat_principal)).BeginInit();
            this.grpBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dat_principal
            // 
            this.dat_principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dat_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dat_principal.Location = new System.Drawing.Point(1, 263);
            this.dat_principal.Name = "dat_principal";
            this.dat_principal.Size = new System.Drawing.Size(611, 185);
            this.dat_principal.TabIndex = 94;
            this.dat_principal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dat_principal_CellClick);
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.Controls.Add(this.btn_buscar_id);
            this.grpBusqueda.Controls.Add(this.btn_buscar_estudiante);
            this.grpBusqueda.Controls.Add(this.btn_buscar_profesor);
            this.grpBusqueda.Controls.Add(this.label3);
            this.grpBusqueda.Controls.Add(this.txtId);
            this.grpBusqueda.Controls.Add(this.label2);
            this.grpBusqueda.Controls.Add(this.txtEstudiante);
            this.grpBusqueda.Controls.Add(this.label1);
            this.grpBusqueda.Controls.Add(this.txtProfesor);
            this.grpBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(265, 201);
            this.grpBusqueda.TabIndex = 95;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Datos de busqueda";
            // 
            // btn_buscar_id
            // 
            this.btn_buscar_id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_id.BackgroundImage")));
            this.btn_buscar_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_id.Location = new System.Drawing.Point(172, 140);
            this.btn_buscar_id.Name = "btn_buscar_id";
            this.btn_buscar_id.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_id.TabIndex = 10;
            this.btn_buscar_id.UseVisualStyleBackColor = true;
            this.btn_buscar_id.Click += new System.EventHandler(this.btn_buscar_id_Click);
            // 
            // btn_buscar_estudiante
            // 
            this.btn_buscar_estudiante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_estudiante.BackgroundImage")));
            this.btn_buscar_estudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_estudiante.Location = new System.Drawing.Point(172, 90);
            this.btn_buscar_estudiante.Name = "btn_buscar_estudiante";
            this.btn_buscar_estudiante.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_estudiante.TabIndex = 9;
            this.btn_buscar_estudiante.UseVisualStyleBackColor = true;
            this.btn_buscar_estudiante.Click += new System.EventHandler(this.btn_buscar_estudiante_Click);
            // 
            // btn_buscar_profesor
            // 
            this.btn_buscar_profesor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar_profesor.BackgroundImage")));
            this.btn_buscar_profesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar_profesor.Location = new System.Drawing.Point(172, 35);
            this.btn_buscar_profesor.Name = "btn_buscar_profesor";
            this.btn_buscar_profesor.Size = new System.Drawing.Size(25, 20);
            this.btn_buscar_profesor.TabIndex = 8;
            this.btn_buscar_profesor.UseVisualStyleBackColor = true;
            this.btn_buscar_profesor.Click += new System.EventHandler(this.btn_buscar_profesor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Id de la cita";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(9, 139);
            this.txtId.Mask = "000000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "00000000000000000000000000000000000000000000000000000000000000000000000000000000" +
    "0000000000";
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(157, 20);
            this.txtId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estudiante";
            // 
            // txtEstudiante
            // 
            this.txtEstudiante.Location = new System.Drawing.Point(6, 89);
            this.txtEstudiante.Name = "txtEstudiante";
            this.txtEstudiante.Size = new System.Drawing.Size(160, 20);
            this.txtEstudiante.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Profesor";
            // 
            // txtProfesor
            // 
            this.txtProfesor.Location = new System.Drawing.Point(6, 35);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(160, 20);
            this.txtProfesor.TabIndex = 2;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::DosCuerdas.Vista.Properties.Resources.Delete;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(514, 222);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(98, 35);
            this.btn_cancelar.TabIndex = 97;
            this.btn_cancelar.Text = "Cancelada";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_atendida
            // 
            this.btn_atendida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atendida.Image = global::DosCuerdas.Vista.Properties.Resources.Apply;
            this.btn_atendida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_atendida.Location = new System.Drawing.Point(397, 222);
            this.btn_atendida.Name = "btn_atendida";
            this.btn_atendida.Size = new System.Drawing.Size(91, 35);
            this.btn_atendida.TabIndex = 96;
            this.btn_atendida.Text = "Atendida";
            this.btn_atendida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atendida.UseVisualStyleBackColor = true;
            this.btn_atendida.Click += new System.EventHandler(this.btn_atendida_Click);
            // 
            // ModificarClases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 450);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_atendida);
            this.Controls.Add(this.grpBusqueda);
            this.Controls.Add(this.dat_principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ModificarClases";
            this.Text = "Dos Cuerdas | ModificarClases";
            this.Load += new System.EventHandler(this.ModificarClases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dat_principal)).EndInit();
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dat_principal;
        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Button btn_atendida;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProfesor;
        private System.Windows.Forms.Button btn_buscar_id;
        private System.Windows.Forms.Button btn_buscar_estudiante;
        private System.Windows.Forms.Button btn_buscar_profesor;
    }
}