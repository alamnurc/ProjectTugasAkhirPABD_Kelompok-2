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
    public partial class Form_Tambah_Data_Kucing : Form
    {
        public Form_Tambah_Data_Kucing()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = MACBOOKPRO114; Initial Catalog = CatBody; Persist Security Info=True;User ID = sa; Password=04204332300");

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string jk = "";
            if(rbJantan.Checked==true)
            {
                jk = rbJantan.Text;
            }
            else
            {
                jk = rbBetina.Text;
            }
            SqlCommand com = new SqlCommand("exec dbo.Kucing_insert'" + tb_IDK.Text + "','" + cb_IDPM.Text + "','" + cb_IDPG.Text + "','" + tb_NK.Text + "','" + tb_UK.Text + "','" + jk + "','" + tb_R.Text + "','" + tb_W.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
            Form_Data_Kucing DK = new Form_Data_Kucing();
            DK.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Data_Kucing DK = new Form_Data_Kucing();
            DK.Show();
            this.Hide();
        }

        private void Form_Tambah_Data_Kucing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'catBodyDataSet.Pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.catBodyDataSet.Pegawai);
            // TODO: This line of code loads data into the 'catBodyDataSet.Rekam_Medis' table. You can move, or remove it, as needed.
            this.rekam_MedisTableAdapter.Fill(this.catBodyDataSet.Rekam_Medis);
            // TODO: This line of code loads data into the 'catBodyDataSet.Pemilik' table. You can move, or remove it, as needed.
            this.pemilikTableAdapter.Fill(this.catBodyDataSet.Pemilik);
            // TODO: This line of code loads data into the 'catBodyDataSet.Kucing' table. You can move, or remove it, as needed.
            this.kucingTableAdapter.Fill(this.catBodyDataSet.Kucing);

        }
    }
}
