using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Store
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            PopulateItems();
            
        }

        private void YourOrdersLabel_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Orders_Load(object sender, EventArgs e)
        {
            
        }
        private void PopulateItems()
        {
            ListOrder[] listItems = new ListOrder[10];

            

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListOrder();
                listItems[i].Date = "Get Date";
                listItems[i].Brand = "Get Brand";
                listItems[i].Name = "Get Name";
                listItems[i].Rating = "Get Rating";
                listItems[i].Price = "Get Price";

                

                //add to flow layout
                //if (ShoeLayout.Controls.Count > 0)
                //{
                //    ShoeLayout.Controls.Clear(); 
                //}
                //else
                OrdersLayout.Controls.Add(listItems[i]);
            }

        }

        private void topBar1_Load(object sender, EventArgs e)
        {

        }
    }
}
