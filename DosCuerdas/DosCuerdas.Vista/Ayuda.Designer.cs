namespace DosCuerdas.Vista
{
    partial class Ayuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ayuda));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnManualUsuario = new System.Windows.Forms.Button();
            this.lblTituloAyuda2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnManualUsuario
            // 
            this.btnManualUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManualUsuario.BackgroundImage")));
            this.btnManualUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManualUsuario.FlatAppearance.BorderSize = 0;
            this.btnManualUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManualUsuario.Location = new System.Drawing.Point(171, 91);
            this.btnManualUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnManualUsuario.Name = "btnManualUsuario";
            this.btnManualUsuario.Size = new System.Drawing.Size(190, 123);
            this.btnManualUsuario.TabIndex = 3;
            this.btnManualUsuario.UseVisualStyleBackColor = true;
            this.btnManualUsuario.Click += new System.EventHandler(this.btnManualUsuario_Click);
            // 
            // lblTituloAyuda2
            // 
            this.lblTituloAyuda2.AutoSize = true;
            this.lblTituloAyuda2.Location = new System.Drawing.Point(139, 273);
            this.lblTituloAyuda2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloAyuda2.Name = "lblTituloAyuda2";
            this.lblTituloAyuda2.Size = new System.Drawing.Size(249, 13);
            this.lblTituloAyuda2.TabIndex = 5;
            this.lblTituloAyuda2.Text = "Para un mejor soporte contacte al Servicio Técnico";
            // 
            // Ayuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(540, 320);
            this.Controls.Add(this.lblTituloAyuda2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnManualUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ayuda";
            this.Text = "Dos Cuerdas | Ayuda";
            this.Load += new System.EventHandler(this.Ayuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManualUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTituloAyuda2;
    }
}