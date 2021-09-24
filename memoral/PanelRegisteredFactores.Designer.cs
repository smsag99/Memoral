namespace memoral
{
    partial class PanelRegisteredFactores
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
            this.txtFromDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSsearch = new System.Windows.Forms.Button();
            this.txtFactoreIdSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToDate = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSabad = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frequery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiPrint = new Stimulsoft.Report.StiReport();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(304, 30);
            this.txtFromDate.Mask = "0000/00/00";
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(100, 28);
            this.txtFromDate.TabIndex = 1;
            this.txtFromDate.ValidatingType = typeof(System.DateTime);
            this.txtFromDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustDecimal_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.btnSsearch);
            this.groupBox1.Controls.Add(this.txtFactoreIdSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtToDate);
            this.groupBox1.Controls.Add(this.txtFromDate);
            this.groupBox1.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(696, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   جستجو بر اساس   ";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundImage = global::memoral.Properties.Resources.unnamed;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPrint.Location = new System.Drawing.Point(21, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(45, 43);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSsearch
            // 
            this.btnSsearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSsearch.BackgroundImage = global::memoral.Properties.Resources.search;
            this.btnSsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSsearch.FlatAppearance.BorderSize = 0;
            this.btnSsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSsearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSsearch.Location = new System.Drawing.Point(76, 27);
            this.btnSsearch.Name = "btnSsearch";
            this.btnSsearch.Size = new System.Drawing.Size(29, 24);
            this.btnSsearch.TabIndex = 3;
            this.btnSsearch.UseVisualStyleBackColor = false;
            this.btnSsearch.Click += new System.EventHandler(this.btnSsearch_Click);
            // 
            // txtFactoreIdSearch
            // 
            this.txtFactoreIdSearch.Location = new System.Drawing.Point(495, 29);
            this.txtFactoreIdSearch.MaxLength = 9;
            this.txtFactoreIdSearch.Name = "txtFactoreIdSearch";
            this.txtFactoreIdSearch.Size = new System.Drawing.Size(91, 28);
            this.txtFactoreIdSearch.TabIndex = 0;
            this.txtFactoreIdSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustDecimal_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "تا تاریخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "از تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره فاکتور  :";
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(130, 30);
            this.txtToDate.Mask = "0000/00/00";
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(100, 28);
            this.txtToDate.TabIndex = 2;
            this.txtToDate.ValidatingType = typeof(System.DateTime);
            this.txtToDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustDecimal_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSabad);
            this.groupBox2.Font = new System.Drawing.Font("B Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(18, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(696, 310);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "   لیست فاکتور ها جهت چاپ   ";
            // 
            // dgvSabad
            // 
            this.dgvSabad.AllowUserToAddRows = false;
            this.dgvSabad.AllowUserToDeleteRows = false;
            this.dgvSabad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSabad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.dgvSabad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSabad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.ID,
            this.Column1,
            this.frequery,
            this.Price,
            this.Column3});
            this.dgvSabad.Location = new System.Drawing.Point(6, 19);
            this.dgvSabad.Name = "dgvSabad";
            this.dgvSabad.ReadOnly = true;
            this.dgvSabad.Size = new System.Drawing.Size(684, 285);
            this.dgvSabad.TabIndex = 12;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FactoreId";
            this.Column2.HeaderText = "شماره فاکتور";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ProductId";
            this.ID.HeaderText = "ایدی محصول";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "ProductName";
            this.Column1.FillWeight = 98.47716F;
            this.Column1.HeaderText = "نام محصول";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 230;
            // 
            // frequery
            // 
            this.frequery.DataPropertyName = "Frq_request";
            this.frequery.FillWeight = 101.5228F;
            this.frequery.HeaderText = "تعداد";
            this.frequery.Name = "frequery";
            this.frequery.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت واحد";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Date";
            this.Column3.HeaderText = "تاریخ خرید";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // stiPrint
            // 
            this.stiPrint.CookieContainer = null;
            this.stiPrint.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiPrint.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiPrint.ReportAlias = "Report";
            this.stiPrint.ReportGuid = "6d305fabe6d6466ba9bb803c4413e19a";
            this.stiPrint.ReportName = "Report";
            this.stiPrint.ReportSource = null;
            this.stiPrint.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiPrint.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiPrint.UseProgressInThread = false;
            // 
            // PanelRegisteredFactores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PanelRegisteredFactores";
            this.Size = new System.Drawing.Size(730, 400);
            this.Load += new System.EventHandler(this.PanelRegisteredFactores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSabad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtFromDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFactoreIdSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtToDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSabad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequery;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnSsearch;
        private System.Windows.Forms.Button btnPrint;
        private Stimulsoft.Report.StiReport stiPrint;
    }
}
