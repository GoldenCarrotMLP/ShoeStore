namespace Shoe_Store
{
    partial class ListItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListItem));
            this.ShoePic = new System.Windows.Forms.PictureBox();
            this.BrandLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShoePic)).BeginInit();
            this.SuspendLayout();
            // 
            // ShoePic
            // 
            this.ShoePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ShoePic.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShoePic.Image = ((System.Drawing.Image)(resources.GetObject("ShoePic.Image")));
            this.ShoePic.Location = new System.Drawing.Point(0, 0);
            this.ShoePic.Name = "ShoePic";
            this.ShoePic.Size = new System.Drawing.Size(135, 85);
            this.ShoePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShoePic.TabIndex = 0;
            this.ShoePic.TabStop = false;
            this.ShoePic.Click += new System.EventHandler(this.ShoePic_Click);
            // 
            // BrandLabel
            // 
            this.BrandLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BrandLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BrandLabel.Location = new System.Drawing.Point(0, 85);
            this.BrandLabel.Name = "BrandLabel";
            this.BrandLabel.Size = new System.Drawing.Size(135, 17);
            this.BrandLabel.TabIndex = 1;
            this.BrandLabel.Text = "Brand";
            this.BrandLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoEllipsis = true;
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.NameLabel.Location = new System.Drawing.Point(0, 102);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(135, 36);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RatingLabel
            // 
            this.RatingLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.RatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RatingLabel.Location = new System.Drawing.Point(0, 138);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(135, 25);
            this.RatingLabel.TabIndex = 3;
            this.RatingLabel.Text = "Rating";
            this.RatingLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.PriceLabel.Location = new System.Drawing.Point(0, 163);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(135, 15);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.BrandLabel);
            this.Controls.Add(this.ShoePic);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(135, 189);
            this.Click += new System.EventHandler(this.ListItem_Click);
            ((System.ComponentModel.ISupportInitialize)(this.ShoePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ShoePic;
        private System.Windows.Forms.Label BrandLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label PriceLabel;
    }
}
