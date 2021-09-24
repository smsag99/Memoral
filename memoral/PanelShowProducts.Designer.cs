namespace memoral
{
    partial class PanelShowProducts
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
            this.panel_showProducts = new System.Windows.Forms.Panel();
            this.panel_searchProducts = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_searchProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_showProducts
            // 
            this.panel_showProducts.AutoScroll = true;
            this.panel_showProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_showProducts.ForeColor = System.Drawing.Color.Beige;
            this.panel_showProducts.Location = new System.Drawing.Point(3, 91);
            this.panel_showProducts.Name = "panel_showProducts";
            this.panel_showProducts.Size = new System.Drawing.Size(722, 302);
            this.panel_showProducts.TabIndex = 12;
            // 
            // panel_searchProducts
            // 
            this.panel_searchProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_searchProducts.Controls.Add(this.btnRefresh);
            this.panel_searchProducts.Controls.Add(this.pictureBox1);
            this.panel_searchProducts.Controls.Add(this.groupBox1);
            this.panel_searchProducts.Controls.Add(this.txtSearch);
            this.panel_searchProducts.Controls.Add(this.label1);
            this.panel_searchProducts.Location = new System.Drawing.Point(3, 3);
            this.panel_searchProducts.Name = "panel_searchProducts";
            this.panel_searchProducts.Size = new System.Drawing.Size(722, 82);
            this.panel_searchProducts.TabIndex = 12;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::memoral.Properties.Resources.refresh_icon_png_transparent_11;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.btnRefresh.Location = new System.Drawing.Point(288, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 38);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::memoral.Properties.Resources.memoral_On;
            this.pictureBox1.Location = new System.Drawing.Point(27, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(355, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 1);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Beige;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(355, 31);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(200, 21);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(561, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو برای محصول";
            // 
            // PanelShowProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.panel_showProducts);
            this.Controls.Add(this.panel_searchProducts);
            this.Name = "PanelShowProducts";
            this.Size = new System.Drawing.Size(731, 401);
            this.Load += new System.EventHandler(this.PanelShowProducts_Load);
            this.panel_searchProducts.ResumeLayout(false);
            this.panel_searchProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel_showProducts;
        public System.Windows.Forms.Panel panel_searchProducts;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRefresh;
    }
}
