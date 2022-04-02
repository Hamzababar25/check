using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace check
{
    public partial class Form1 : Form
    {
        ReportDocument cry = new ReportDocument();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OT87DKU\\SQLEXPRESS;Initial Catalog=emp;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string q = "select *from studentt";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet dataReport = new DataSet();
            da.Fill(dataReport, "studentt");
            CrystalReport2 dd = new CrystalReport2();
            dd.SetDataSource(dataReport);
            crystalReportViewer2.ReportSource = dd;
        }
    }
}
