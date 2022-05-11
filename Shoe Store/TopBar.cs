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
    public partial class TopBar : UserControl
    {
        
        public TopBar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Click(object sender, EventArgs e)
        {

            Form form = new Products();

            this.FindForm().Hide();
            form.Show();
           
        }

        private void AccountButton_Click(object sender, EventArgs e)
        {
            Form form = new Profile();

            this.FindForm().Hide();
            form.Show();
        }
    }
}
