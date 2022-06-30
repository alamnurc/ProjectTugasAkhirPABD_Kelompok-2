using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatBody
{
    public partial class Form_Report : Form
    {
        public Form_Report()
        {
            InitializeComponent();
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'catBodyDataSet.Rekam_Medis' table. You can move, or remove it, as needed.
            this.rekam_MedisTableAdapter.Fill(this.catBodyDataSet.Rekam_Medis);

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Data_Rekam_Medis DRM = new Form_Data_Rekam_Medis();
            DRM.Show();
            this.Hide();
        }
    }
}
