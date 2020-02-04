using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports;
using System.Windows.Forms;

namespace proyecto.Forms
{
    public partial class frmReport : Form
    {
        public DateTime fechaIni;
        public DateTime fechaFin;
        /// <summary>
        /// 4
        /// </summary>
        Reports.ReporteVentas reporte = new Reports.ReporteVentas();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            
            reporte.SetParameterValue("@Date1", fechaIni);
            reporte.SetParameterValue("@Date2", fechaFin);
            crystalReportViewer1.ReportSource = reporte;
        }
    }
}
