using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using System.Data.SqlClient;

using System.Data.OleDb;

namespace Shoe_Store
{
    public partial class Products : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public static class Globals
        {
            public static int number;
        }
            public Products()
        {
            InitializeComponent();



            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = \"C:\\Users\\ander\\source\\repos\\Shoe Store\\Shoe Store\\Database1.mdf\"; Integrated Security = True";


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Products_Load(object sender, EventArgs e)
        {
            PopulateItems();
        }
        private void PopulateItems()
        {
            
            string query = "Select * from  footwear";
            con.Open();
            
            //com.Connection = con;
            //com.CommandText = query;

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            string s = "";
            ListItem[] listItems = new ListItem[dt.Rows.Count];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s += dt.Rows[i]["Brand_Name"].ToString();
                listItems[i] = new ListItem();
                listItems[i].ID = dt.Rows[i]["Shoe_ID"].ToString();
                listItems[i].Brand = dt.Rows[i]["Brand_Name"].ToString();
                listItems[i].Name = dt.Rows[i]["Shoe_Name"].ToString();
                listItems[i].Rating = dt.Rows[i]["Shoe_Rating"].ToString();
                listItems[i].Price = dt.Rows[i]["Shoe_Price"].ToString();

                HttpWebRequest request;
                if (dt.Rows[i]["Image_URL"].ToString() == "NULL") {

                    request = (HttpWebRequest)WebRequest.Create("https://www.thewindowsclub.com/wp-content/uploads/2018/06/Broken-image-icon-in-Chrome.gif");
                }
                else
                {
                     request = (HttpWebRequest)WebRequest.Create(dt.Rows[i]["Image_URL"].ToString());
                }

                
                
                WebHeaderCollection myWebHeaderCollection = request.Headers;
                request.Accept =("text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
                myWebHeaderCollection.Add("accept-encoding: gzip, deflate, br");
                myWebHeaderCollection.Add("accept-language: en-US,en;q=0.9,es-US;q=0.8,es;q=0.7");
                myWebHeaderCollection.Add("cache-control: no-cache");
                myWebHeaderCollection.Add("pragma: no-cache");
                myWebHeaderCollection.Add("sec-ch-ua: \" Not A; Brand\";v=\"99\", \"Chromium\";v=\"101\", \"Google Chrome\";v=\"101\"");
                myWebHeaderCollection.Add("sec-ch-ua-mobile: ?0");
                myWebHeaderCollection.Add("sec-ch-ua-platform: \"Windows\"");
                myWebHeaderCollection.Add("sec-fetch-dest: document");
                myWebHeaderCollection.Add("sec-fetch-mode: navigate");
                myWebHeaderCollection.Add("sec-fetch-site: none");
                myWebHeaderCollection.Add("sec-fetch-user: ?1");
                myWebHeaderCollection.Add("upgrade-insecure-requests: 1");
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.54 Safari/537.36 OPR/86.0.4363.23";
                //MessageBox.Show(request.Headers.ToString());
                using (var response = request.GetResponse())
                    
                using (var stream = response.GetResponseStream())
                {
                    listItems[i].Icon = Bitmap.FromStream(stream);
                }

                

                //add to flow layout
                //if (ShoeLayout.Controls.Count > 0)
                //{
                //    ShoeLayout.Controls.Clear(); 
                //}
                //else
                ShoeLayout.Controls.Add(listItems[i]);
            }

            

      
            con.Close();
        }

        
        

        

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

            InvisibleMenuPanel.Visible = !InvisibleMenuPanel.Visible;
            InvisibleMenuPanel.BringToFront();
             

        }

        private void AccountPanel_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void ItemsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InvisibleMenuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BrandShoesChecklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DropdownEnabler_MouseClick(object sender, MouseEventArgs e)
        {

            BrandShoesChecklist.Visible = !BrandShoesChecklist.Visible;

            if (BrandShoesChecklist.Visible) {
                DropdownEnabler.Text = "-";
            }
            else
            {
                DropdownEnabler.Text = "+";
            }
            BrandShoesChecklist.BringToFront();
        }

        private void ShoeLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyOrdersDropDownPanel_Click(object sender, EventArgs e)
        {
            var m = new Orders();
            m.Show();
        }

        private void topBar1_Load(object sender, EventArgs e)
        {

        }

        private void topBar1_Load_1(object sender, EventArgs e)
        {

        }
        //Methods definitions







    }
}
