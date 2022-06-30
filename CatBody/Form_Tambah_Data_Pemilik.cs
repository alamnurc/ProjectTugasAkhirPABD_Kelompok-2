using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatBody
{
    public partial class Form_Tambah_Data_Pemilik : Form
    {
        public Form_Tambah_Data_Pemilik()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = MACBOOKPRO114; Initial Catalog = CatBody; Persist Security Info=True;User ID = sa; Password=04204332300");
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Data_Pemilik DPP = new Form_Data_Pemilik();
            DPP.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string jk = "";
            if (rbLakilaki.Checked == true)
            {
                jk = rbLakilaki.Text;
            }
            else
            {
                jk = rbPerempuan.Text;
            }
            SqlCommand com = new SqlCommand("exec dbo.Pemilik_insert'" + txIDPem.Text + "','" + txNamaPem.Text + "','" + jk + "','" + txNo.Text + "','" + txAlamat.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
            Form_Data_Pemilik DP = new Form_Data_Pemilik();
            DP.Show();
            this.Hide();
        }
    }
}
