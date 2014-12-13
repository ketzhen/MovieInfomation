namespace MovieSample
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gropAddMovieInformation = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblType = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTitleSearchByTitle = new System.Windows.Forms.Button();
            this.lblTitleSearchByTitle = new System.Windows.Forms.Label();
            this.txtTitleSearchByTitle = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTypeSearchByType = new System.Windows.Forms.Button();
            this.cmbTypeSearchByType = new System.Windows.Forms.ComboBox();
            this.lblTypeSearchByType = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gropAddMovieInformation.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 482);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tabPage1.Controls.Add(this.gropAddMovieInformation);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add movie Information";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // gropAddMovieInformation
            // 
            this.gropAddMovieInformation.Controls.Add(this.btnInsert);
            this.gropAddMovieInformation.Controls.Add(this.lblType);
            this.gropAddMovieInformation.Controls.Add(this.lblYear);
            this.gropAddMovieInformation.Controls.Add(this.lblPublisher);
            this.gropAddMovieInformation.Controls.Add(this.lblTitle);
            this.gropAddMovieInformation.Controls.Add(this.cmbType);
            this.gropAddMovieInformation.Controls.Add(this.txtYear);
            this.gropAddMovieInformation.Controls.Add(this.txtPublisher);
            this.gropAddMovieInformation.Controls.Add(this.txtTitle);
            this.gropAddMovieInformation.Location = new System.Drawing.Point(6, 6);
            this.gropAddMovieInformation.Name = "gropAddMovieInformation";
            this.gropAddMovieInformation.Size = new System.Drawing.Size(507, 205);
            this.gropAddMovieInformation.TabIndex = 12;
            this.gropAddMovieInformation.TabStop = false;
            this.gropAddMovieInformation.Text = "Add Movie Information";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(117)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.ImageList = this.imageList1;
            this.btnInsert.Location = new System.Drawing.Point(350, 119);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 30);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Save";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1418329368_64776.ico");
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(28, 126);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 18);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type: ";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(28, 100);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 18);
            this.lblYear.TabIndex = 18;
            this.lblYear.Text = "Year:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(28, 74);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(77, 18);
            this.lblPublisher.TabIndex = 17;
            this.lblPublisher.Text = "Publisher: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(28, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 18);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Title: ";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Adventure",
            "Comedy",
            "Action",
            "Cartoon",
            "Romantic",
            "Fantasy",
            "Thriller",
            "Historic",
            "Drama",
            "Horor",
            "Crime",
            "Biografy"});
            this.cmbType.Location = new System.Drawing.Point(121, 123);
            this.cmbType.MaxDropDownItems = 9;
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 26);
            this.cmbType.TabIndex = 15;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(121, 97);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 24);
            this.txtYear.TabIndex = 14;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(121, 71);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(332, 24);
            this.txtPublisher.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(121, 45);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(332, 24);
            this.txtTitle.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Database";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(767, 355);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(6, 6);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(761, 84);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tabPage3.Controls.Add(this.btnTitleSearchByTitle);
            this.tabPage3.Controls.Add(this.lblTitleSearchByTitle);
            this.tabPage3.Controls.Add(this.txtTitleSearchByTitle);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(753, 47);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Search by title";
            // 
            // btnTitleSearchByTitle
            // 
            this.btnTitleSearchByTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(117)))));
            this.btnTitleSearchByTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleSearchByTitle.ForeColor = System.Drawing.Color.White;
            this.btnTitleSearchByTitle.Location = new System.Drawing.Point(390, 3);
            this.btnTitleSearchByTitle.Name = "btnTitleSearchByTitle";
            this.btnTitleSearchByTitle.Size = new System.Drawing.Size(75, 30);
            this.btnTitleSearchByTitle.TabIndex = 3;
            this.btnTitleSearchByTitle.Text = "Search";
            this.btnTitleSearchByTitle.UseVisualStyleBackColor = false;
            this.btnTitleSearchByTitle.Click += new System.EventHandler(this.btnTitleSearchByTitle_Click_1);
            // 
            // lblTitleSearchByTitle
            // 
            this.lblTitleSearchByTitle.AutoSize = true;
            this.lblTitleSearchByTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitleSearchByTitle.Name = "lblTitleSearchByTitle";
            this.lblTitleSearchByTitle.Size = new System.Drawing.Size(43, 18);
            this.lblTitleSearchByTitle.TabIndex = 2;
            this.lblTitleSearchByTitle.Text = "Title: ";
            // 
            // txtTitleSearchByTitle
            // 
            this.txtTitleSearchByTitle.Location = new System.Drawing.Point(50, 6);
            this.txtTitleSearchByTitle.Name = "txtTitleSearchByTitle";
            this.txtTitleSearchByTitle.Size = new System.Drawing.Size(332, 24);
            this.txtTitleSearchByTitle.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tabPage4.Controls.Add(this.btnTypeSearchByType);
            this.tabPage4.Controls.Add(this.cmbTypeSearchByType);
            this.tabPage4.Controls.Add(this.lblTypeSearchByType);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(753, 47);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Search by type";
            // 
            // btnTypeSearchByType
            // 
            this.btnTypeSearchByType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(117)))));
            this.btnTypeSearchByType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeSearchByType.ForeColor = System.Drawing.Color.White;
            this.btnTypeSearchByType.Location = new System.Drawing.Point(243, 5);
            this.btnTypeSearchByType.Name = "btnTypeSearchByType";
            this.btnTypeSearchByType.Size = new System.Drawing.Size(75, 30);
            this.btnTypeSearchByType.TabIndex = 2;
            this.btnTypeSearchByType.Text = "Search";
            this.btnTypeSearchByType.UseVisualStyleBackColor = false;
            this.btnTypeSearchByType.Click += new System.EventHandler(this.btnTypeSearchByType_Click_1);
            // 
            // cmbTypeSearchByType
            // 
            this.cmbTypeSearchByType.FormattingEnabled = true;
            this.cmbTypeSearchByType.Items.AddRange(new object[] {
            "Adventure",
            "Comedy",
            "Action",
            "Cartoon",
            "Romantic",
            "Fantasy",
            "Thriller",
            "Historic",
            "Drama",
            "Horor",
            "Crime",
            "Biografy"});
            this.cmbTypeSearchByType.Location = new System.Drawing.Point(51, 8);
            this.cmbTypeSearchByType.Name = "cmbTypeSearchByType";
            this.cmbTypeSearchByType.Size = new System.Drawing.Size(179, 26);
            this.cmbTypeSearchByType.TabIndex = 1;
            // 
            // lblTypeSearchByType
            // 
            this.lblTypeSearchByType.AutoSize = true;
            this.lblTypeSearchByType.Location = new System.Drawing.Point(4, 11);
            this.lblTypeSearchByType.Name = "lblTypeSearchByType";
            this.lblTypeSearchByType.Size = new System.Drawing.Size(48, 18);
            this.lblTypeSearchByType.TabIndex = 0;
            this.lblTypeSearchByType.Text = "Type: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 488);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gropAddMovieInformation.ResumeLayout(false);
            this.gropAddMovieInformation.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gropAddMovieInformation;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnTitleSearchByTitle;
        private System.Windows.Forms.Label lblTitleSearchByTitle;
        private System.Windows.Forms.TextBox txtTitleSearchByTitle;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnTypeSearchByType;
        private System.Windows.Forms.ComboBox cmbTypeSearchByType;
        private System.Windows.Forms.Label lblTypeSearchByType;
        private System.Windows.Forms.ImageList imageList1;


    }
}

