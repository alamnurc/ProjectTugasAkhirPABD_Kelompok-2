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
    public partial class Form_Tambah_Data_Rekam_Medis : Form
    {
        public Form_Tambah_Data_Rekam_Medis()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = MACBOOKPRO114; Initial Catalog = CatBody; Persist Security Info=True;User ID = sa; Password=04204332300");

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Data_Rekam_Medis DRM = new Form_Data_Rekam_Medis();
            DRM.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.RM_insert'" + tb_IDRM.Text + "','" + cb_IDK.Text + "','" + cb_IDV.Text + "','" + dtp_V1.Text + "','" + dtp_V2.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
            Form_Data_Rekam_Medis DRM = new Form_Data_Rekam_Medis();
            DRM.Show();
            this.Hide();
        }

        private void Form_Tambah_Data_Rekam_Medis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'catBodyDataSet.Rekam_Medis' table. You can move, or remove it, as needed.
            this.rekam_MedisTableAdapter.Fill(this.catBodyDataSet.Rekam_Medis);
            // TODO: This line of code loads data into the 'catBodyDataSet.Vaksin' table. You can move, or remove it, as needed.
            this.vaksinTableAdapter.Fill(this.catBodyDataSet.Vaksin);
            // TODO: This line of code loads data into the 'catBodyDataSet.Kucing' table. You can move, or remove it, as needed.
            this.kucingTableAdapter.Fill(this.catBodyDataSet.Kucing);

        }
    }
}
