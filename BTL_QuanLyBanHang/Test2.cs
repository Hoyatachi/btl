using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace BTL_QuanLyBanHang
{
    public partial class FormBaoCaoNV : Form
    {
        public FormBaoCaoNV()
        {
            InitializeComponent();
        }
        public void ShowReport2(string recordSelectionFormula = "")
        {
            ReportDocument reportDocument = new ReportDocument();
            string path = "../../Crystal Report/CrystalReport1.rpt";

            reportDocument.Load(path);

            reportDocument.RecordSelectionFormula = recordSelectionFormula;

            crystalReportViewer1.ReportSource = reportDocument;
            Show();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
