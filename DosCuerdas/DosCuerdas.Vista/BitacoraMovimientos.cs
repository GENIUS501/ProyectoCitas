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
    public partial class BitacoraMovimientos : Form
    {
        public string Usuario { get; set; }
        public BitacoraMovimientos()
        {
            InitializeComponent();
        }

        private void BitacoraMovimientos_Load(object sender, EventArgs e)
        {
            try
            {
                Bitacora_movimientosController Controlador = new Bitacora_movimientosController();
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

        private void btn_nombre_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txt_usuario.Text != "")
                {
                    Bitacora_movimientosController Controlador = new Bitacora_movimientosController();
                    var datasource = Controlador.Mostrar().Where(x=>x.Usuario.Contains(this.txt_usuario.Text)).ToList();
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

        private void btn_buscar_accion_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbo_Accion.SelectedItem.ToString() != "")
                {
                    if (this.cbo_Accion.SelectedItem.ToString() == "Todas")
                    {
                        Bitacora_movimientosController Controlador = new Bitacora_movimientosController();
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
                    else
                    {
                        Bitacora_movimientosController Controlador = new Bitacora_movimientosController();
                        var datasource = Controlador.Mostrar().Where(j => j.tipo_movimiento == this.cbo_Accion.SelectedItem.ToString()).ToList();
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
                    Bitacora_movimientosController Controlador = new Bitacora_movimientosController();
                    var datasource = Controlador.Mostrar().Where(x => x.fecha_hora_movimiento >= FechaIni && x.fecha_hora_movimiento <= FechaFin).ToList();
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
