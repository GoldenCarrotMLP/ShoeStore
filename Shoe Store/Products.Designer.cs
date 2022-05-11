namespace Shoe_Store
{
    partial class Products
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
            this.components = new System.ComponentModel.Container();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.WindowLabel = new System.Windows.Forms.Label();
            this.ShoeLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.InvisibleMenuPanel = new System.Windows.Forms.Panel();
            this.MyFavoritesDropDownPanel = new System.Windows.Forms.Panel();
            this.MyFavoritesDropDownPanelLabel = new System.Windows.Forms.Label();
            this.MyOrdersDropDownPanel = new System.Windows.Forms.Panel();
            this.MyOrdersDropDownPanelLabel = new System.Windows.Forms.Label();
            this.AccountDropDownPanel = new System.Windows.Forms.Panel();
            this.SignInDropDownPanelLabel = new System.Windows.Forms.Label();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.BrandShoesChecklist = new System.Windows.Forms.CheckedListBox();
            this.DropdownEnabler = new System.Windows.Forms.Label();
            this.BrandsCheckboxLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TopBarPanel = new System.Windows.Forms.Panel();
            this.topBar1 = new Shoe_Store.TopBar();
            this.ItemsPanel.SuspendLayout();
            this.InvisibleMenuPanel.SuspendLayout();
            this.MyFavoritesDropDownPanel.SuspendLayout();
            this.MyOrdersDropDownPanel.SuspendLayout();
            this.AccountDropDownPanel.SuspendLayout();
            this.FilterPanel.SuspendLayout();
            this.TopBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.Controls.Add(this.WindowLabel);
            this.ItemsPanel.Controls.Add(this.ShoeLayout);
            this.ItemsPanel.Controls.Add(this.InvisibleMenuPanel);
            this.ItemsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsPanel.Location = new System.Drawing.Point(159, 41);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(481, 489);
            this.ItemsPanel.TabIndex = 2;
            this.ItemsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ItemsPanel_Paint);
            // 
            // WindowLabel
            // 
            this.WindowLabel.AutoSize = true;
            this.WindowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WindowLabel.Location = new System.Drawing.Point(26, 7);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(154, 25);
            this.WindowLabel.TabIndex = 11;
            this.WindowLabel.Text = "Men\'s Sneakers";
            // 
            // ShoeLayout
            // 
            this.ShoeLayout.AutoScroll = true;
            this.ShoeLayout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ShoeLayout.Location = new System.Drawing.Point(0, 35);
            this.ShoeLayout.Name = "ShoeLayout";
            this.ShoeLayout.Size = new System.Drawing.Size(481, 454);
            this.ShoeLayout.TabIndex = 10;
            this.ShoeLayout.TabStop = true;
            this.ShoeLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.ShoeLayout_Paint);
            // 
            // InvisibleMenuPanel
            // 
            this.InvisibleMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InvisibleMenuPanel.Controls.Add(this.MyFavoritesDropDownPanel);
            this.InvisibleMenuPanel.Controls.Add(this.MyOrdersDropDownPanel);
            this.InvisibleMenuPanel.Controls.Add(this.AccountDropDownPanel);
            this.InvisibleMenuPanel.Location = new System.Drawing.Point(241, 0);
            this.InvisibleMenuPanel.Name = "InvisibleMenuPanel";
            this.InvisibleMenuPanel.Size = new System.Drawing.Size(200, 107);
            this.InvisibleMenuPanel.TabIndex = 0;
            this.InvisibleMenuPanel.TabStop = true;
            this.InvisibleMenuPanel.Visible = false;
            this.InvisibleMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.InvisibleMenuPanel_Paint);
            // 
            // MyFavoritesDropDownPanel
            // 
            this.MyFavoritesDropDownPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyFavoritesDropDownPanel.Controls.Add(this.MyFavoritesDropDownPanelLabel);
            this.MyFavoritesDropDownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyFavoritesDropDownPanel.Location = new System.Drawing.Point(0, 70);
            this.MyFavoritesDropDownPanel.Name = "MyFavoritesDropDownPanel";
            this.MyFavoritesDropDownPanel.Size = new System.Drawing.Size(200, 35);
            this.MyFavoritesDropDownPanel.TabIndex = 0;
            // 
            // MyFavoritesDropDownPanelLabel
            // 
            this.MyFavoritesDropDownPanelLabel.AutoSize = true;
            this.MyFavoritesDropDownPanelLabel.Location = new System.Drawing.Point(4, 4);
            this.MyFavoritesDropDownPanelLabel.Name = "MyFavoritesDropDownPanelLabel";
            this.MyFavoritesDropDownPanelLabel.Size = new System.Drawing.Size(67, 13);
            this.MyFavoritesDropDownPanelLabel.TabIndex = 0;
            this.MyFavoritesDropDownPanelLabel.Text = "My Favorites";
            // 
            // MyOrdersDropDownPanel
            // 
            this.MyOrdersDropDownPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MyOrdersDropDownPanel.Controls.Add(this.MyOrdersDropDownPanelLabel);
            this.MyOrdersDropDownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyOrdersDropDownPanel.Location = new System.Drawing.Point(0, 35);
            this.MyOrdersDropDownPanel.Name = "MyOrdersDropDownPanel";
            this.MyOrdersDropDownPanel.Size = new System.Drawing.Size(200, 35);
            this.MyOrdersDropDownPanel.TabIndex = 0;
            this.MyOrdersDropDownPanel.Click += new System.EventHandler(this.MyOrdersDropDownPanel_Click);
            // 
            // MyOrdersDropDownPanelLabel
            // 
            this.MyOrdersDropDownPanelLabel.AutoSize = true;
            this.MyOrdersDropDownPanelLabel.Location = new System.Drawing.Point(4, 7);
            this.MyOrdersDropDownPanelLabel.Name = "MyOrdersDropDownPanelLabel";
            this.MyOrdersDropDownPanelLabel.Size = new System.Drawing.Size(55, 13);
            this.MyOrdersDropDownPanelLabel.TabIndex = 0;
            this.MyOrdersDropDownPanelLabel.Text = "My Orders";
            // 
            // AccountDropDownPanel
            // 
            this.AccountDropDownPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountDropDownPanel.Controls.Add(this.SignInDropDownPanelLabel);
            this.AccountDropDownPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountDropDownPanel.Location = new System.Drawing.Point(0, 0);
            this.AccountDropDownPanel.Name = "AccountDropDownPanel";
            this.AccountDropDownPanel.Size = new System.Drawing.Size(200, 35);
            this.AccountDropDownPanel.TabIndex = 1;
            // 
            // SignInDropDownPanelLabel
            // 
            this.SignInDropDownPanelLabel.AutoSize = true;
            this.SignInDropDownPanelLabel.Location = new System.Drawing.Point(4, 7);
            this.SignInDropDownPanelLabel.Name = "SignInDropDownPanelLabel";
            this.SignInDropDownPanelLabel.Size = new System.Drawing.Size(40, 13);
            this.SignInDropDownPanelLabel.TabIndex = 0;
            this.SignInDropDownPanelLabel.Text = "Sign In";
            // 
            // FilterPanel
            // 
            this.FilterPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.FilterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilterPanel.Controls.Add(this.SizeTextBox);
            this.FilterPanel.Controls.Add(this.SizeLabel);
            this.FilterPanel.Controls.Add(this.BrandShoesChecklist);
            this.FilterPanel.Controls.Add(this.DropdownEnabler);
            this.FilterPanel.Controls.Add(this.BrandsCheckboxLabel);
            this.FilterPanel.Controls.Add(this.comboBox1);
            this.FilterPanel.Controls.Add(this.SortByLabel);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterPanel.Location = new System.Drawing.Point(0, 41);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(159, 489);
            this.FilterPanel.TabIndex = 1;
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(31, 249);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(90, 20);
            this.SizeTextBox.TabIndex = 7;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(4, 233);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 13);
            this.SizeLabel.TabIndex = 6;
            this.SizeLabel.Text = "Size";
            // 
            // BrandShoesChecklist
            // 
            this.BrandShoesChecklist.FormattingEnabled = true;
            this.BrandShoesChecklist.Items.AddRange(new object[] {
            "Brand1",
            "Brand2",
            "Brand3",
            "Brand4",
            "Brand5",
            "Brand6",
            "Brand7",
            "Brand8",
            "Brand9",
            "Brand10"});
            this.BrandShoesChecklist.Location = new System.Drawing.Point(32, 126);
            this.BrandShoesChecklist.Name = "BrandShoesChecklist";
            this.BrandShoesChecklist.Size = new System.Drawing.Size(120, 94);
            this.BrandShoesChecklist.TabIndex = 5;
            this.BrandShoesChecklist.Visible = false;
            this.BrandShoesChecklist.SelectedIndexChanged += new System.EventHandler(this.BrandShoesChecklist_SelectedIndexChanged);
            // 
            // DropdownEnabler
            // 
            this.DropdownEnabler.AutoSize = true;
            this.DropdownEnabler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DropdownEnabler.Location = new System.Drawing.Point(35, 107);
            this.DropdownEnabler.Name = "DropdownEnabler";
            this.DropdownEnabler.Size = new System.Drawing.Size(18, 20);
            this.DropdownEnabler.TabIndex = 4;
            this.DropdownEnabler.Text = "+";
            this.DropdownEnabler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DropdownEnabler_MouseClick);
            // 
            // BrandsCheckboxLabel
            // 
            this.BrandsCheckboxLabel.AutoSize = true;
            this.BrandsCheckboxLabel.Location = new System.Drawing.Point(4, 110);
            this.BrandsCheckboxLabel.Name = "BrandsCheckboxLabel";
            this.BrandsCheckboxLabel.Size = new System.Drawing.Size(35, 13);
            this.BrandsCheckboxLabel.TabIndex = 2;
            this.BrandsCheckboxLabel.Text = "Brand";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Featured",
            "Top rated",
            "Price: High to low",
            "Price: Low to high"});
            this.comboBox1.Location = new System.Drawing.Point(0, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Featured";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SortByLabel
            // 
            this.SortByLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SortByLabel.Location = new System.Drawing.Point(0, 0);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(157, 48);
            this.SortByLabel.TabIndex = 0;
            this.SortByLabel.Text = "Sort by";
            this.SortByLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TopBarPanel
            // 
            this.TopBarPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.TopBarPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopBarPanel.Controls.Add(this.topBar1);
            this.TopBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopBarPanel.Name = "TopBarPanel";
            this.TopBarPanel.Size = new System.Drawing.Size(640, 41);
            this.TopBarPanel.TabIndex = 0;
            // 
            // topBar1
            // 
            this.topBar1.BackColor = System.Drawing.Color.Gainsboro;
            this.topBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topBar1.Location = new System.Drawing.Point(0, 0);
            this.topBar1.Name = "topBar1";
            this.topBar1.Size = new System.Drawing.Size(638, 39);
            this.topBar1.TabIndex = 0;
            this.topBar1.Load += new System.EventHandler(this.topBar1_Load_1);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 530);
            this.Controls.Add(this.ItemsPanel);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.TopBarPanel);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Products";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Products_Load);
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.InvisibleMenuPanel.ResumeLayout(false);
            this.MyFavoritesDropDownPanel.ResumeLayout(false);
            this.MyFavoritesDropDownPanel.PerformLayout();
            this.MyOrdersDropDownPanel.ResumeLayout(false);
            this.MyOrdersDropDownPanel.PerformLayout();
            this.AccountDropDownPanel.ResumeLayout(false);
            this.AccountDropDownPanel.PerformLayout();
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            this.TopBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Panel InvisibleMenuPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel MyFavoritesDropDownPanel;
        private System.Windows.Forms.Label MyFavoritesDropDownPanelLabel;
        private System.Windows.Forms.Panel MyOrdersDropDownPanel;
        private System.Windows.Forms.Label MyOrdersDropDownPanelLabel;
        private System.Windows.Forms.Panel AccountDropDownPanel;
        private System.Windows.Forms.Label SignInDropDownPanelLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.FlowLayoutPanel ShoeLayout;
        private System.Windows.Forms.Label WindowLabel;
        private System.Windows.Forms.Label BrandsCheckboxLabel;
        private System.Windows.Forms.Label DropdownEnabler;
        private System.Windows.Forms.CheckedListBox BrandShoesChecklist;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Panel TopBarPanel;
        private TopBar topBar1;
    }
}

