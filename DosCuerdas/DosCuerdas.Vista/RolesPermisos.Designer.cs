namespace DosCuerdas.Vista
{
    partial class RolesPermisos
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
            this.lblRolPermiso = new System.Windows.Forms.Label();
            this.lbdIdRol = new System.Windows.Forms.Label();
            this.lbdNombreRol = new System.Windows.Forms.Label();
            this.lbdDescripcion = new System.Windows.Forms.Label();
            this.txtIdRol = new System.Windows.Forms.TextBox();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbxRC = new System.Windows.Forms.CheckBox();
            this.gpbPermisos = new System.Windows.Forms.GroupBox();
            this.cbxRE = new System.Windows.Forms.CheckBox();
            this.cbxRP = new System.Windows.Forms.CheckBox();
            this.cbxRU = new System.Windows.Forms.CheckBox();
            this.cbxMC = new System.Windows.Forms.CheckBox();
            this.cbxME = new System.Windows.Forms.CheckBox();
            this.cbxMP = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRolPermiso
            // 
            this.lblRolPermiso.AutoSize = true;
            this.lblRolPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolPermiso.Location = new System.Drawing.Point(308, 29);
            this.lblRolPermiso.Name = "lblRolPermiso";
            this.lblRolPermiso.Size = new System.Drawing.Size(177, 24);
            this.lblRolPermiso.TabIndex = 0;
            this.lblRolPermiso.Text = "Roles y Permisos ";
            // 
            // lbdIdRol
            // 
            this.lbdIdRol.AutoSize = true;
            this.lbdIdRol.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdIdRol.Location = new System.Drawing.Point(48, 96);
            this.lbdIdRol.Name = "lbdIdRol";
            this.lbdIdRol.Size = new System.Drawing.Size(58, 22);
            this.lbdIdRol.TabIndex = 1;
            this.lbdIdRol.Text = "Id de Rol";
            // 
            // lbdNombreRol
            // 
            this.lbdNombreRol.AutoSize = true;
            this.lbdNombreRol.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdNombreRol.Location = new System.Drawing.Point(48, 134);
            this.lbdNombreRol.Name = "lbdNombreRol";
            this.lbdNombreRol.Size = new System.Drawing.Size(91, 22);
            this.lbdNombreRol.TabIndex = 2;
            this.lbdNombreRol.Text = "Nombre de Rol";
            // 
            // lbdDescripcion
            // 
            this.lbdDescripcion.AutoSize = true;
            this.lbdDescripcion.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdDescripcion.Location = new System.Drawing.Point(337, 96);
            this.lbdDescripcion.Name = "lbdDescripcion";
            this.lbdDescripcion.Size = new System.Drawing.Size(75, 22);
            this.lbdDescripcion.TabIndex = 3;
            this.lbdDescripcion.Text = "Descripción";
            // 
            // txtIdRol
            // 
            this.txtIdRol.Location = new System.Drawing.Point(152, 98);
            this.txtIdRol.Name = "txtIdRol";
            this.txtIdRol.Size = new System.Drawing.Size(100, 20);
            this.txtIdRol.TabIndex = 5;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(152, 136);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(100, 20);
            this.txtNombreRol.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(418, 96);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(329, 60);
            this.txtDescripcion.TabIndex = 7;
            // 
            // cbxRC
            // 
            this.cbxRC.AutoSize = true;
            this.cbxRC.Location = new System.Drawing.Point(7, 38);
            this.cbxRC.Name = "cbxRC";
            this.cbxRC.Size = new System.Drawing.Size(129, 19);
            this.cbxRC.TabIndex = 8;
            this.cbxRC.Text = "Registro Cliente";
            this.cbxRC.UseVisualStyleBackColor = true;
            // 
            // gpbPermisos
            // 
            this.gpbPermisos.Controls.Add(this.checkBox4);
            this.gpbPermisos.Controls.Add(this.cbxMP);
            this.gpbPermisos.Controls.Add(this.cbxME);
            this.gpbPermisos.Controls.Add(this.cbxMC);
            this.gpbPermisos.Controls.Add(this.cbxRU);
            this.gpbPermisos.Controls.Add(this.cbxRP);
            this.gpbPermisos.Controls.Add(this.cbxRE);
            this.gpbPermisos.Controls.Add(this.cbxRC);
            this.gpbPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPermisos.Location = new System.Drawing.Point(52, 184);
            this.gpbPermisos.Name = "gpbPermisos";
            this.gpbPermisos.Size = new System.Drawing.Size(695, 148);
            this.gpbPermisos.TabIndex = 9;
            this.gpbPermisos.TabStop = false;
            this.gpbPermisos.Text = "Permisos";
            // 
            // cbxRE
            // 
            this.cbxRE.AutoSize = true;
            this.cbxRE.Location = new System.Drawing.Point(7, 63);
            this.cbxRE.Name = "cbxRE";
            this.cbxRE.Size = new System.Drawing.Size(152, 19);
            this.cbxRE.TabIndex = 9;
            this.cbxRE.Text = "Registro Estudiante";
            this.cbxRE.UseVisualStyleBackColor = true;
            // 
            // cbxRP
            // 
            this.cbxRP.AutoSize = true;
            this.cbxRP.Location = new System.Drawing.Point(6, 88);
            this.cbxRP.Name = "cbxRP";
            this.cbxRP.Size = new System.Drawing.Size(138, 19);
            this.cbxRP.TabIndex = 10;
            this.cbxRP.Text = "Registro Profesor";
            this.cbxRP.UseVisualStyleBackColor = true;
            // 
            // cbxRU
            // 
            this.cbxRU.AutoSize = true;
            this.cbxRU.Location = new System.Drawing.Point(6, 113);
            this.cbxRU.Name = "cbxRU";
            this.cbxRU.Size = new System.Drawing.Size(134, 19);
            this.cbxRU.TabIndex = 11;
            this.cbxRU.Text = "Registro Usuario";
            this.cbxRU.UseVisualStyleBackColor = true;
            // 
            // cbxMC
            // 
            this.cbxMC.AutoSize = true;
            this.cbxMC.Location = new System.Drawing.Point(201, 38);
            this.cbxMC.Name = "cbxMC";
            this.cbxMC.Size = new System.Drawing.Size(171, 19);
            this.cbxMC.TabIndex = 12;
            this.cbxMC.Text = "Mantenimiento Cliente";
            this.cbxMC.UseVisualStyleBackColor = true;
            // 
            // cbxME
            // 
            this.cbxME.AutoSize = true;
            this.cbxME.Location = new System.Drawing.Point(201, 63);
            this.cbxME.Name = "cbxME";
            this.cbxME.Size = new System.Drawing.Size(194, 19);
            this.cbxME.TabIndex = 13;
            this.cbxME.Text = "Mantenimiento Estudiente";
            this.cbxME.UseVisualStyleBackColor = true;
            // 
            // cbxMP
            // 
            this.cbxMP.AutoSize = true;
            this.cbxMP.Location = new System.Drawing.Point(201, 88);
            this.cbxMP.Name = "cbxMP";
            this.cbxMP.Size = new System.Drawing.Size(180, 19);
            this.cbxMP.TabIndex = 14;
            this.cbxMP.Text = "Mantenimiento Profesor";
            this.cbxMP.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(201, 113);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(95, 19);
            this.checkBox4.TabIndex = 15;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 119);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(548, 505);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(656, 505);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // RolesPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gpbPermisos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombreRol);
            this.Controls.Add(this.txtIdRol);
            this.Controls.Add(this.lbdDescripcion);
            this.Controls.Add(this.lbdNombreRol);
            this.Controls.Add(this.lbdIdRol);
            this.Controls.Add(this.lblRolPermiso);
            this.Name = "RolesPermisos";
            this.Text = "Dos Cuerdas | Roles y Permisos";
            this.gpbPermisos.ResumeLayout(false);
            this.gpbPermisos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRolPermiso;
        private System.Windows.Forms.Label lbdIdRol;
        private System.Windows.Forms.Label lbdNombreRol;
        private System.Windows.Forms.Label lbdDescripcion;
        private System.Windows.Forms.TextBox txtIdRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.CheckBox cbxRC;
        private System.Windows.Forms.GroupBox gpbPermisos;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox cbxMP;
        private System.Windows.Forms.CheckBox cbxME;
        private System.Windows.Forms.CheckBox cbxMC;
        private System.Windows.Forms.CheckBox cbxRU;
        private System.Windows.Forms.CheckBox cbxRP;
        private System.Windows.Forms.CheckBox cbxRE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}