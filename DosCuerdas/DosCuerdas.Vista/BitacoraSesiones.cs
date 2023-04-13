using DosCuerdas.Controlador;
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
    public partial class BitacoraSesiones : Form
    {
        public string Usuariologueado { get; set; }
        public BitacoraSesiones()
        {
            InitializeComponent();
        }

        private void BitacoraSesiones_Load(object sender, EventArgs e)
        {
            try
            {
                Bitacora_SesionesController Controlador = new Bitacora_SesionesController();
                var datasource = Controlador.Mostrara();
                ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(Rds);
                ReportParameter[] parameters = new ReportParameter[2];
                parameters[0] = new ReportParameter("Usuario", Usuariologueado);
                parameters[1] = new ReportParameter("Fecha", DateTime.Now.ToString());
                reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_usuario.Text != "")
                {
                    Bitacora_SesionesController Controlador = new Bitacora_SesionesController();
                    var datasource = Controlador.Mostrara().Where(y => y.Usuario.Contains(this.txt_usuario.Text)).ToList(); ;                        
                    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Rds);
                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("Usuario", Usuariologueado);
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

        private void btn_fecha_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_fecha_ini.Text != "" && this.txt_fecha_fin.Text != "")
                {
                    var FechaIni = Convert.ToDateTime(this.txt_fecha_ini.Text);
                    var FechaFin = Convert.ToDateTime(this.txt_fecha_fin.Text).AddHours(23).AddMinutes(59).AddSeconds(59);
                    Bitacora_SesionesController Controlador = new Bitacora_SesionesController();
                    var datasource = Controlador.Mostrara().Where(x => x.fecha_hora_ingreso >= FechaIni && x.fecha_hora_ingreso <= FechaFin).ToList();
                    ReportDataSource Rds = new ReportDataSource("DataSet1", datasource);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(Rds);
                    ReportParameter[] parameters = new ReportParameter[2];
                    parameters[0] = new ReportParameter("Usuario", Usuariologueado);
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
