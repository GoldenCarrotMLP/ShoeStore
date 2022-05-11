namespace Shoe_Store
{
    partial class Orders
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.YourOrdersLabel = new System.Windows.Forms.Label();
            this.OrdersLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.topBar1 = new Shoe_Store.TopBar();
            this.SuspendLayout();
            // 
            // YourOrdersLabel
            // 
            this.YourOrdersLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.YourOrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.YourOrdersLabel.Location = new System.Drawing.Point(0, 39);
            this.YourOrdersLabel.Name = "YourOrdersLabel";
            this.YourOrdersLabel.Size = new System.Drawing.Size(642, 36);
            this.YourOrdersLabel.TabIndex = 1;
            this.YourOrdersLabel.Text = "Your orders";
            this.YourOrdersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrdersLayout
            // 
            this.OrdersLayout.AutoScroll = true;
            this.OrdersLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersLayout.Location = new System.Drawing.Point(0, 75);
            this.OrdersLayout.Name = "OrdersLayout";
            this.OrdersLayout.Size = new System.Drawing.Size(642, 375);
            this.OrdersLayout.TabIndex = 2;
            this.OrdersLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // topBar1
            // 
            this.topBar1.BackColor = System.Drawing.Color.Gainsboro;
            this.topBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar1.Location = new System.Drawing.Point(0, 0);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(642, 39);
            this.topBar1.TabIndex = 0;
            this.topBar1.Load += new System.EventHandler(this.topBar1_Load);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.OrdersLayout);
            this.Controls.Add(this.YourOrdersLabel);
            this.Controls.Add(this.topBar1);
            this.Name = "Orders";
            this.Text = "Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label YourOrdersLabel;
        private System.Windows.Forms.FlowLayoutPanel OrdersLayout;
        private TopBar topBar1;
    }
}