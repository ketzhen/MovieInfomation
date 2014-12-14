namespace MovieSample
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnTitleSearchByTitle = new System.Windows.Forms.Button();
            this.lblOr = new System.Windows.Forms.Label();
            this.cmbTypeSearchByType = new System.Windows.Forms.ComboBox();
            this.lblTypeSearchByType = new System.Windows.Forms.Label();
            this.lblTitleSearchByTitle = new System.Windows.Forms.Label();
            this.txtTitleSearchByTitle = new System.Windows.Forms.TextBox();
            this.grdMovieDataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gropAddMovieInformation.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovieDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 573);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.gropAddMovieInformation);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 53);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 516);
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
            this.gropAddMovieInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gropAddMovieInformation.Location = new System.Drawing.Point(7, 6);
            this.gropAddMovieInformation.Name = "gropAddMovieInformation";
            this.gropAddMovieInformation.Size = new System.Drawing.Size(591, 205);
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
            this.btnInsert.Location = new System.Drawing.Point(408, 119);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 30);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "Save";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1418558577_95876.ico");
            this.imageList1.Images.SetKeyName(1, "1418559143_118797.ico");
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(33, 126);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 17);
            this.lblType.TabIndex = 19;
            this.lblType.Text = "Type: ";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(33, 100);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 17);
            this.lblYear.TabIndex = 18;
            this.lblYear.Text = "Year:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(33, 74);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(75, 17);
            this.lblPublisher.TabIndex = 17;
            this.lblPublisher.Text = "Publisher: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(33, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(43, 17);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Title: ";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "-Select Type-",
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
            this.cmbType.Location = new System.Drawing.Point(142, 123);
            this.cmbType.MaxDropDownItems = 9;
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(140, 24);
            this.cmbType.TabIndex = 15;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(142, 97);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(140, 23);
            this.txtYear.TabIndex = 14;
            this.txtYear.TextChanged += new System.EventHandler(this.txtYear_TextChanged);
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(142, 71);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(387, 23);
            this.txtPublisher.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(142, 45);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(387, 23);
            this.txtTitle.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.grpSearch);
            this.tabPage2.Controls.Add(this.grdMovieDataGrid);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 53);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 516);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search Database";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnTitleSearchByTitle);
            this.grpSearch.Controls.Add(this.lblOr);
            this.grpSearch.Controls.Add(this.cmbTypeSearchByType);
            this.grpSearch.Controls.Add(this.lblTypeSearchByType);
            this.grpSearch.Controls.Add(this.lblTitleSearchByTitle);
            this.grpSearch.Controls.Add(this.txtTitleSearchByTitle);
            this.grpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grpSearch.Location = new System.Drawing.Point(9, 6);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(880, 113);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search By Title/Type";
            // 
            // btnTitleSearchByTitle
            // 
            this.btnTitleSearchByTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(117)))));
            this.btnTitleSearchByTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleSearchByTitle.ForeColor = System.Drawing.Color.White;
            this.btnTitleSearchByTitle.Location = new System.Drawing.Point(436, 80);
            this.btnTitleSearchByTitle.Name = "btnTitleSearchByTitle";
            this.btnTitleSearchByTitle.Size = new System.Drawing.Size(87, 30);
            this.btnTitleSearchByTitle.TabIndex = 6;
            this.btnTitleSearchByTitle.Text = "Search";
            this.btnTitleSearchByTitle.UseVisualStyleBackColor = false;
            this.btnTitleSearchByTitle.Click += new System.EventHandler(this.btnTitleSearchByTitle_Click);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.Location = new System.Drawing.Point(190, 59);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(23, 13);
            this.lblOr.TabIndex = 10;
            this.lblOr.Text = "OR";
            // 
            // cmbTypeSearchByType
            // 
            this.cmbTypeSearchByType.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbTypeSearchByType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeSearchByType.FormattingEnabled = true;
            this.cmbTypeSearchByType.Items.AddRange(new object[] {
            "            <--Select Type-->",
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
            this.cmbTypeSearchByType.Location = new System.Drawing.Point(79, 80);
            this.cmbTypeSearchByType.Name = "cmbTypeSearchByType";
            this.cmbTypeSearchByType.Size = new System.Drawing.Size(328, 24);
            this.cmbTypeSearchByType.TabIndex = 8;
            this.cmbTypeSearchByType.SelectedIndexChanged += new System.EventHandler(this.cmbTypeSearchByType_SelectedIndexChanged);
            // 
            // lblTypeSearchByType
            // 
            this.lblTypeSearchByType.AutoSize = true;
            this.lblTypeSearchByType.Location = new System.Drawing.Point(26, 83);
            this.lblTypeSearchByType.Name = "lblTypeSearchByType";
            this.lblTypeSearchByType.Size = new System.Drawing.Size(48, 17);
            this.lblTypeSearchByType.TabIndex = 7;
            this.lblTypeSearchByType.Text = "Type: ";
            // 
            // lblTitleSearchByTitle
            // 
            this.lblTitleSearchByTitle.AutoSize = true;
            this.lblTitleSearchByTitle.Location = new System.Drawing.Point(26, 29);
            this.lblTitleSearchByTitle.Name = "lblTitleSearchByTitle";
            this.lblTitleSearchByTitle.Size = new System.Drawing.Size(43, 17);
            this.lblTitleSearchByTitle.TabIndex = 5;
            this.lblTitleSearchByTitle.Text = "Title: ";
            // 
            // txtTitleSearchByTitle
            // 
            this.txtTitleSearchByTitle.Location = new System.Drawing.Point(79, 26);
            this.txtTitleSearchByTitle.Name = "txtTitleSearchByTitle";
            this.txtTitleSearchByTitle.Size = new System.Drawing.Size(328, 23);
            this.txtTitleSearchByTitle.TabIndex = 4;
            this.txtTitleSearchByTitle.TextChanged += new System.EventHandler(this.txtTitleSearchByTitle_TextChanged);
            // 
            // grdMovieDataGrid
            // 
            this.grdMovieDataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.grdMovieDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMovieDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMovieDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grdMovieDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdMovieDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMovieDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMovieDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMovieDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdMovieDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdMovieDataGrid.GridColor = System.Drawing.Color.Gray;
            this.grdMovieDataGrid.Location = new System.Drawing.Point(3, 122);
            this.grdMovieDataGrid.Name = "grdMovieDataGrid";
            this.grdMovieDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdMovieDataGrid.RowHeadersVisible = false;
            this.grdMovieDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMovieDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMovieDataGrid.Size = new System.Drawing.Size(892, 391);
            this.grdMovieDataGrid.TabIndex = 1;
            this.grdMovieDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 579);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gropAddMovieInformation.ResumeLayout(false);
            this.gropAddMovieInformation.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMovieDataGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView grdMovieDataGrid;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnTitleSearchByTitle;
        private System.Windows.Forms.Label lblTitleSearchByTitle;
        private System.Windows.Forms.TextBox txtTitleSearchByTitle;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.ComboBox cmbTypeSearchByType;
        private System.Windows.Forms.Label lblTypeSearchByType;


    }
}

