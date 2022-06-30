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
    public partial class Form_Data_Kucing : Form
    {
        public Form_Data_Kucing()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = MACBOOKPRO114; Initial Catalog = CatBody; Persist Security Info=True;User ID = sa; Password=04204332300");

        private void Form_Data_Kucing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'catBodyDataSet.Kucing_view' table. You can move, or remove it, as needed.
            this.kucing_viewTableAdapter.Fill(this.catBodyDataSet.Kucing_view);
            // TODO: This line of code loads data into the 'catBodyDataSet.Kucing_view' table. You can move, or remove it, as needed.
            this.kucing_viewTableAdapter.Fill(this.catBodyDataSet.Kucing_view);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form_Tambah_Data_Kucing TDK = new Form_Tambah_Data_Kucing();
            TDK.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Form_Update_Data_Kucing UDK = new Form_Update_Data_Kucing();
            UDK.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            {
                con.Open();
                SqlCommand com = new SqlCommand("exec dbo.Kucing_delete'" + tb_IDK.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Deleted");
                LoadAllRecords();
            }
            void LoadAllRecords()
            {
                SqlCommand com = new SqlCommand("exec dbo.Kucing_view", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form_Data_Pemilik DP = new Form_Data_Pemilik();
            DP.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form_Data_Pegawai DPG = new Form_Data_Pegawai();
            DPG.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form_Data_Vaksin DV = new Form_Data_Vaksin();
            DV.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form_Data_Rekam_Medis DRM = new Form_Data_Rekam_Medis();
            DRM.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
