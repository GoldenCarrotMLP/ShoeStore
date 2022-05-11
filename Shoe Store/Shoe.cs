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

namespace Shoe_Store
{
    public partial class Shoe : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public string Shoe_ID;    
        public Shoe(string Shoe_ID)
        {
            InitializeComponent();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\ander\\source\\repos\\Shoe Store\\Shoe Store\\Database1.mdf\"; Integrated Security = True";

        }

        private void Shoe_Load(object sender, EventArgs e)
        {
            string query = "Select * from  footwear where Shoe_ID = "+"\""+Shoe_ID+"\"";
            MessageBox.Show(query);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            //pictureBox1.Image
            Price_Label.Text = dt.Rows[0]["Shoe_Price"].ToString();
            Name_Label.Text = dt.Rows[0]["Shoe_Name"].ToString();
            con.Close();
        }

        
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
