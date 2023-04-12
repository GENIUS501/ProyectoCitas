using DosCuerdas.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosCuerdas.Vista
{
    public partial class AgendarClases : Form
    {
        #region Variables
        public string Usuario { get; set; }
        int Profesor = -1;
        int Estudiante = -1;
        #endregion
        public AgendarClases()
        {
            InitializeComponent();
        }

        private void AgendarClases_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCedulaProfesor.Text != "")
                {
                    ProfesoresController Controlador = new ProfesoresController();
                    dat_profesores.DataSource = Controlador.Mostrar().Select(Item => new {
                        Id_de_profesor=Item.Id_Profesor,
                        Cedula = Item.Cedula,
                        Nombre = Item.Nombre,
                        PrimerApellido = Item.PrimerApellido,
                        SegundoApellido = Item.SegundoApellido,
                        Instrumento = Item.instrumento
                    }).Where(x => x.Cedula.Contains(this.txtCedulaProfesor.Text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_estudiante_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtCedulaEstudiante.Text != "")
                {
                    EstudiantesController Controlador = new EstudiantesController();
                    datEstudiantes.DataSource = Controlador.Mostrar().Select(Item=> new {
                        Id_de_estudiante=Item.Id_Estudiante,
                        Cedula = Item.Cedula,
                        Nombre = Item.Nombre,
                        PrimerApellido = Item.PrimerApellido,
                        SegundoApellido = Item.SegundoApellido,
                    }).Where(x => x.Cedula.Contains(this.txtEstudiante.Text)).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dat_profesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_profesores.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {

                }
                else
                {
                    Profesor = int.Parse(this.dat_profesores.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var mostrar = this.datEstudiantes.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + this.datEstudiantes.Rows[e.RowIndex].Cells[3].Value.ToString() + " " + this.datEstudiantes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.txtEstudiante.Text = mostrar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void datEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.datEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {

                }
                else
                {
                    Estudiante = int.Parse(this.datEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString());
                    var mostrar = this.datEstudiantes.Rows[e.RowIndex].Cells[2].Value.ToString()+" "+this.datEstudiantes.Rows[e.RowIndex].Cells[3].Value.ToString()+" "+ this.datEstudiantes.Rows[e.RowIndex].Cells[4].Value.ToString();
                    this.txtEstudiante.Text = mostrar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
