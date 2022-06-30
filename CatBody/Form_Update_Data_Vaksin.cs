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
    public partial class Form_Update_Data_Vaksin : Form
    {
        public Form_Update_Data_Vaksin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source = MACBOOKPRO114; Initial Catalog = CatBody; Persist Security Info=True;User ID = sa; Password=04204332300");

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Data_Vaksin DV = new Form_Data_Vaksin();
            DV.Show();
            this.Hide();
        }

        private void Form_Update_Data_Vaksin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'catBodyDataSet.Vaksin' table. You can move, or remove it, as needed.
            this.vaksinTableAdapter.Fill(this.catBodyDataSet.Vaksin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.Vaksin_update'" + tb_IDV.Text + "','" + tb_NV.Text + "','" + tb_D.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            Form_Data_Vaksin DV = new Form_Data_Vaksin();
            DV.Show();
            this.Hide();
        }
    }
}
