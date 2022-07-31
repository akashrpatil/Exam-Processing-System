using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
            reportViewer1.RefreshReport();
            reportViewer1.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
