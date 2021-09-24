namespace memoral
{
    partial class product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            this.labelProductName = new System.Windows.Forms.Label();
            this.picProductOnce = new System.Windows.Forms.Button();
            this.btn_details = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductName.Font = new System.Drawing.Font("B Nazanin", 8.75F, System.Drawing.FontStyle.Bold);
            this.labelProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelProductName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelProductName.Location = new System.Drawing.Point(52, 13);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(93, 42);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "نام محصول";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picProductOnce
            // 
            this.picProductOnce.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picProductOnce.BackColor = System.Drawing.Color.Transparent;
            this.picProductOnce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProductOnce.Enabled = false;
            this.picProductOnce.Location = new System.Drawing.Point(151, 2);
            this.picProductOnce.Name = "picProductOnce";
            this.picProductOnce.Size = new System.Drawing.Size(65, 65);
            this.picProductOnce.TabIndex = 2;
            this.picProductOnce.UseVisualStyleBackColor = false;
            // 
            // btn_details
            // 
            this.btn_details.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_details.BackColor = System.Drawing.Color.Transparent;
            this.btn_details.BackgroundImage = global::memoral.Properties.Resources.details_icon_png_5_Transparent_Images;
            this.btn_details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_details.FlatAppearance.BorderSize = 0;
            this.btn_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_details.Location = new System.Drawing.Point(3, 6);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(50, 41);
            this.btn_details.TabIndex = 3;
            this.btn_details.UseVisualStyleBackColor = false;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            this.btn_details.MouseHover += new System.EventHandler(this.btn_details_MouseHover);
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(14, 51);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(19, 17);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            this.btn_edit.MouseHover += new System.EventHandler(this.btn_details_MouseHover);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::memoral.Properties.Resources.product;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.picProductOnce);
            this.DoubleBuffered = true;
            this.Name = "product";
            this.Size = new System.Drawing.Size(228, 70);
            this.ResumeLayout(false);

        }

        #endregion
        public int productId;
        public int productFrequry;
        public int price;
        public string details;
        public System.Windows.Forms.Label labelProductName;
        public System.Windows.Forms.Button picProductOnce;
        public System.Windows.Forms.Button btn_details;
        public System.Windows.Forms.Button btn_edit;
    }
}
