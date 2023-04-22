using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace DosCuerdas.Vista
{
    public partial class Ayuda : Form
    {
        string Ruta = "";
        public Ayuda()
        {
            InitializeComponent();
        }

        private void btnManualUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la ruta completa del archivo PDF
                string rutaPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Ayuda.pdf");

                // Verificar si el archivo existe
                if (File.Exists(rutaPDF))
                {
                    // Abrir el archivo PDF en el lector de PDF predeterminado del sistema
                    Process.Start(rutaPDF);
                }
                else
                {
                    Console.WriteLine("El archivo PDF no existe en la ruta especificada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error al cargar el pdf", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {

        }
    }
}
