using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyBanHang
{
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            InitializeComponent();
        }

        public void ShowReport()
        {
            ReportDocument reportDocument = new ReportDocument();
            string path = "../../Crystal Report/CrystalReportHoaDon.rpt";

            reportDocument.Load(path);

            crystalReportViewer1.ReportSource = reportDocument;
            Show();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
