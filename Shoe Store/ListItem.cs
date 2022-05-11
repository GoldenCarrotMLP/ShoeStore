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
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }
        private string __id;
        private string _brand;
        private string _naem;
        private string _rating;
        private string _price;
        private Image _icon;


        public string ID
        {
            get { return __id; }
            set { __id = value; }
        }

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
        public string Price
        {
            get { return _price; }
            set { _price = value; PriceLabel.Text = value; }
        }
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; ShoePic.Image =value; }

        }
        

       

        private void ListItem_Click(object sender, EventArgs e)
        {
            Form form = new Shoe(__id);
            MessageBox.Show("the ID is /"+"+__id+/");
            this.FindForm().Hide();
            form.Show();
        }



        private void ShoePic_Click(object sender, EventArgs e)
        {
            Form form = new Shoe(__id);
           
            this.FindForm().Hide();
            form.Show();
        }
    }
}
