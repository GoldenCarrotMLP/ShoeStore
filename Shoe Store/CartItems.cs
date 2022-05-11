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
    public partial class CartItems : UserControl
    {
        public CartItems()
        {
            InitializeComponent();
        }
        //private string _date;
        private string _brand;
        private string _naem;
        private string _rating;
        //private string _price;
        private Image _icon;

       // public string Date
        //{
            //get { return _date; }
            //set { _date = value; DateLabel.Text = value; }
        //}

        public string Brand { 
        get {return _brand;}
        set {_brand = value; BrandLabel.Text = value; }
        }
        public string Naem
        {
            get { return _naem; }
            set { _naem = value; NameLabel.Text = value; }
        }
        public string Rating
        {
            get { return _rating;}
            set { _rating = value; RatingLabel.Text = value; }
        }
        //public string Price
        //{
            //get { return _price; }
            //set { _price = value; PriceLabel.Text = value; }
        //}
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ShoePic.Image = value; }
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PurchasedInLabel_Click(object sender, EventArgs e)
        {

        }

        private void ListOrder_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}