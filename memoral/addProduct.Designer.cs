namespace memoral
{
    partial class addProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProduct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputDetails = new System.Windows.Forms.TextBox();
            this.inputNewProductName = new System.Windows.Forms.TextBox();
            this.inputNewProductPrice = new System.Windows.Forms.TextBox();
            this.inputNewProductFrequery = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.pic_product = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputDetails);
            this.groupBox1.Controls.Add(this.inputNewProductName);
            this.groupBox1.Controls.Add(this.inputNewProductPrice);
            this.groupBox1.Controls.Add(this.inputNewProductFrequery);
            this.groupBox1.Controls.Add(this.lable2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_Name);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(373, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(346, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "افزودن و ویرایش محصولات";
            // 
            // inputDetails
            // 
            this.inputDetails.BackColor = System.Drawing.Color.White;
            this.inputDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputDetails.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.inputDetails.Location = new System.Drawing.Point(26, 221);
            this.inputDetails.MaxLength = 500;
            this.inputDetails.Multiline = true;
            this.inputDetails.Name = "inputDetails";
            this.inputDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputDetails.Size = new System.Drawing.Size(301, 114);
            this.inputDetails.TabIndex = 3;
            this.inputDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_Persian);
            // 
            // inputNewProductName
            // 
            this.inputNewProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.inputNewProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.inputNewProductName.BackColor = System.Drawing.Color.White;
            this.inputNewProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNewProductName.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.inputNewProductName.Location = new System.Drawing.Point(42, 51);
            this.inputNewProductName.MaxLength = 50;
            this.inputNewProductName.Name = "inputNewProductName";
            this.inputNewProductName.Size = new System.Drawing.Size(186, 28);
            this.inputNewProductName.TabIndex = 0;
            this.inputNewProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_Persian);
            // 
            // inputNewProductPrice
            // 
            this.inputNewProductPrice.BackColor = System.Drawing.Color.White;
            this.inputNewProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNewProductPrice.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.inputNewProductPrice.Location = new System.Drawing.Point(121, 148);
            this.inputNewProductPrice.MaxLength = 9;
            this.inputNewProductPrice.Name = "inputNewProductPrice";
            this.inputNewProductPrice.Size = new System.Drawing.Size(106, 28);
            this.inputNewProductPrice.TabIndex = 2;
            this.inputNewProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PersianDesimal);
            // 
            // inputNewProductFrequery
            // 
            this.inputNewProductFrequery.BackColor = System.Drawing.Color.White;
            this.inputNewProductFrequery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputNewProductFrequery.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.inputNewProductFrequery.Location = new System.Drawing.Point(121, 99);
            this.inputNewProductFrequery.MaxLength = 6;
            this.inputNewProductFrequery.Name = "inputNewProductFrequery";
            this.inputNewProductFrequery.Size = new System.Drawing.Size(107, 28);
            this.inputNewProductFrequery.TabIndex = 1;
            this.inputNewProductFrequery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PersianDesimal);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.lable2.Location = new System.Drawing.Point(238, 196);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(97, 20);
            this.lable2.TabIndex = 0;
            this.lable2.Text = "توضیحات محصول :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(259, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "قیمت (تومان) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(291, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "تعداد  :";
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Name.Location = new System.Drawing.Point(234, 51);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(96, 20);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "نام محصول :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files(*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnChooseImage);
            this.groupBox2.Controls.Add(this.pic_product);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(323, 294);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عکس";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.White;
            this.btnRemove.BackgroundImage = global::memoral.Properties.Resources.delete_remove_trash_trash_bin_trash_can_icon_1320073117929397588;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(53, 244);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(47, 38);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.btnChooseImage.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChooseImage.Location = new System.Drawing.Point(106, 244);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(184, 38);
            this.btnChooseImage.TabIndex = 0;
            this.btnChooseImage.Text = "افزودن تصویر";
            this.btnChooseImage.UseVisualStyleBackColor = false;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_click);
            // 
            // pic_product
            // 
            this.pic_product.BackgroundImage = global::memoral.Properties.Resources.succulent_in_flower_pot_icon_isolated_vector_14370395;
            this.pic_product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pic_product.Location = new System.Drawing.Point(53, 19);
            this.pic_product.Name = "pic_product";
            this.pic_product.Size = new System.Drawing.Size(237, 219);
            this.pic_product.TabIndex = 0;
            this.pic_product.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.btnSave.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(12, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(323, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "افزودن محصول           ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.BackColor = System.Drawing.Color.Red;
            this.btnRemoveProduct.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRemoveProduct.Location = new System.Drawing.Point(12, 330);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(176, 41);
            this.btnRemoveProduct.TabIndex = 9;
            this.btnRemoveProduct.Text = "حذف این محصول";
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            this.btnRemoveProduct.Visible = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.inputNewProductName;
            this.requiredFieldValidator1.ErrorMessage = "نام محصول وارد نشده";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.inputNewProductFrequery;
            this.requiredFieldValidator2.ErrorMessage = "تعداد محصول وارد نشده";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.inputNewProductPrice;
            this.requiredFieldValidator3.ErrorMessage = "قیمت محصول وارد نشده";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "addProduct";
            this.Size = new System.Drawing.Size(731, 401);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Name;
        public System.Windows.Forms.TextBox inputNewProductName;
        public System.Windows.Forms.TextBox inputNewProductFrequery;
        public System.Windows.Forms.Button pic_product;
        public System.Windows.Forms.TextBox inputDetails;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.TextBox inputNewProductPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnChooseImage;
        public System.Windows.Forms.Button btnSave;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        public System.Windows.Forms.Button btnRemoveProduct;
    }
}
