using DosCuerdas.Controlador;
using DosCuerdas.Modelo.Entidades;
using Microsoft.Reporting.WinForms;
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
    public partial class ReporteEstudiantes : Form
    {
        public string Usuario { get; set; }
        public ReporteEstudiantes()
        {
            InitializeComponent();
        }

        private void ReporteEstudiantes_Load(object sender, EventArgs e)
        {
            try
            {
                EstudiantesController Controlador = new EstudiantesController();
                var datasource = Controlador.Mostrar();
                ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(Rds);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuario);
                parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_buscar_id_estudiante.Text != "")
                {
                    EstudiantesController Controlador = new EstudiantesController();
                    var datasource = Controlador.Mostrar().Where(x=>x.Cedula.Contains(this.txt_buscar_id_estudiante.Text));
                    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Rds);
                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("Usuario", Usuario);
                    parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                    reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_buscar_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_nombre.Text != "")
                {
                    EstudiantesController Controlador = new EstudiantesController();
                    var datasource = Controlador.Mostrar().Where(x => x.Nombre.Contains(this.txt_nombre.Text));
                    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Rds);
                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("Usuario", Usuario);
                    parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                    reportViewer1.LocalReport.SetParameters(parameters);
                    this.reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
