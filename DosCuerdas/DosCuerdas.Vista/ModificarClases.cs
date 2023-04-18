using DosCuerdas.Controlador;
using DosCuerdas.Modelo.Entidades;
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
    public partial class ModificarClases : Form
    {
        #region Variables
        public int Usuario { get; set; }
        int valorcelda = -1;
        #endregion
        public ModificarClases()
        {
            InitializeComponent();
        }

        private void ModificarClases_Load(object sender, EventArgs e)
        {
            try
            {
                valorcelda = -1;
                CitaController Negocios = new CitaController();
                dat_principal.DataSource = Negocios.Mostrar(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_profesor_Click(object sender, EventArgs e)
        {
            if (this.txtProfesor.Text != "")
            {
                CitaController Negocios = new CitaController();
                dat_principal.DataSource = Negocios.Mostrar(null).Where(x => x.Profesor.Contains(this.txtProfesor.Text)).ToList();
            }
        }

        private void btn_buscar_estudiante_Click(object sender, EventArgs e)
        {
            if (this.txtEstudiante.Text != "")
            {
                CitaController Negocios = new CitaController();
                dat_principal.DataSource = Negocios.Mostrar(null).Where(x => x.Estudiante.Contains(this.txtEstudiante.Text)).ToList();
            }
        }

        private void btn_buscar_id_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text != "")
            {
                int ID = int.Parse(this.txtId.Text);
                CitaController Negocios = new CitaController();
                dat_principal.DataSource = Negocios.Mostrar(null).Where(x => x.IDCITA == ID).ToList();
            }
        }

        private void dat_principal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dat_principal.Rows[e.RowIndex].Cells[0].Value.ToString() == "")
                {
                    ModificarClases_Load(null, null);
                }
                else
                {
                    valorcelda = int.Parse(this.dat_principal.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_atendida_Click(object sender, EventArgs e)
        {
            try
            {
                if (valorcelda != -1)
                {
                    CitaController Controlador = new CitaController();
                    ECita Entidad = new ECita();
                    Entidad.IDCITA = valorcelda;
                    Entidad.ESTADO = "Atendida";
                    var FilasAfectadas = Controlador.Modificar(Entidad, Usuario);
                    if (FilasAfectadas > 0)
                    {
                        MessageBox.Show("Se atendio la clase", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (FilasAfectadas == -1)
                        {
                            MessageBox.Show("La clase se atendio exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo atender la clase!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    valorcelda = -1;
                    CitaController Negocios = new CitaController();
                    dat_principal.DataSource = Negocios.Mostrar(null);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una clase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (valorcelda != -1)
                {
                    CitaController Controlador = new CitaController();
                    ECita Entidad = new ECita();
                    Entidad.IDCITA = valorcelda;
                    Entidad.ESTADO = "Cancelada";
                    var FilasAfectadas = Controlador.Modificar(Entidad, Usuario);
                    if (FilasAfectadas > 0)
                    {
                        MessageBox.Show("Se cancelo la clase", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (FilasAfectadas == -1)
                        {
                            MessageBox.Show("La clase se cancelo exitosamente pero no se a podido registrar la transaccion!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo cancelar la clase!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    valorcelda = -1;
                    CitaController Negocios = new CitaController();
                    dat_principal.DataSource = Negocios.Mostrar(null);
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una clase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
