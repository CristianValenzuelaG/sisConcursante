using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using sisConcurso.Manager;

namespace sisConcurso.Vista.Reportes
{
    public partial class frmCandidataMunicipio : Form
    {
        ReportDocument crpDocument;
        public void llenarcombomunicipios()
        {
            comboBox1.DisplayMember = "mNombre";
            comboBox1.ValueMember = "pkMunicipio";
            comboBox1.DataSource = MunicipioManage.getAll();
        }
        public frmCandidataMunicipio()
        {
            InitializeComponent();
            llenarcombomunicipios();
        }
        private void GenerarReporte()
        {
            crpDocument = new ReportDocument();
            crpDocument.Load(@"Vista\Reportes\frmCandidataXMuni.rpt");
            crpDocument.SetDataSource(ReportsManager.reporteCandidataXMunicipio(Convert.ToInt32(comboBox1.SelectedIndex.ToString())));
            //crpDocument.SetParameterValue("NombreParametros",valor);
            this.crystalReportViewer1.ReportSource = crpDocument;

        }
        private void frmCandidataMunicipio_Load(object sender, EventArgs e)
        {

            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarReporte();
        }
    }
}
