namespace MovieSample
{
    partial class Form2
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
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnTitleSearchByTitle = new System.Windows.Forms.Button();
            this.lblTitleSearchByTitle = new System.Windows.Forms.Label();
            this.txtTitleSearchByTitle = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnTypeSearchByType = new System.Windows.Forms.Button();
            this.cmbTypeSearchByType = new System.Windows.Forms.ComboBox();
            this.lblTypeSearchByType = new System.Windows.Forms.Label();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(39, 94);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(6, 6);
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(761, 124);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tabPage3.Controls.Add(this.btnTitleSearchByTitle);
            this.tabPage3.Controls.Add(this.lblTitleSearchByTitle);
            this.tabPage3.Controls.Add(this.txtTitleSearchByTitle);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(753, 92);
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
            // 
            // lblTitleSearchByTitle
            // 
            this.lblTitleSearchByTitle.AutoSize = true;
            this.lblTitleSearchByTitle.Location = new System.Drawing.Point(6, 9);
            this.lblTitleSearchByTitle.Name = "lblTitleSearchByTitle";
            this.lblTitleSearchByTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTitleSearchByTitle.TabIndex = 2;
            this.lblTitleSearchByTitle.Text = "Title: ";
            this.lblTitleSearchByTitle.Click += new System.EventHandler(this.lblTitleSearchByTitle_Click);
            // 
            // txtTitleSearchByTitle
            // 
            this.txtTitleSearchByTitle.Location = new System.Drawing.Point(50, 6);
            this.txtTitleSearchByTitle.Name = "txtTitleSearchByTitle";
            this.txtTitleSearchByTitle.Size = new System.Drawing.Size(332, 20);
            this.txtTitleSearchByTitle.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.tabPage4.Controls.Add(this.btnTypeSearchByType);
            this.tabPage4.Controls.Add(this.cmbTypeSearchByType);
            this.tabPage4.Controls.Add(this.lblTypeSearchByType);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(753, 92);
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
            this.cmbTypeSearchByType.Size = new System.Drawing.Size(179, 21);
            this.cmbTypeSearchByType.TabIndex = 1;
            // 
            // lblTypeSearchByType
            // 
            this.lblTypeSearchByType.AutoSize = true;
            this.lblTypeSearchByType.Location = new System.Drawing.Point(4, 11);
            this.lblTypeSearchByType.Name = "lblTypeSearchByType";
            this.lblTypeSearchByType.Size = new System.Drawing.Size(37, 13);
            this.lblTypeSearchByType.TabIndex = 0;
            this.lblTypeSearchByType.Text = "Type: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 313);
            this.Controls.Add(this.tabControl2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnTitleSearchByTitle;
        private System.Windows.Forms.Label lblTitleSearchByTitle;
        private System.Windows.Forms.TextBox txtTitleSearchByTitle;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnTypeSearchByType;
        private System.Windows.Forms.ComboBox cmbTypeSearchByType;
        private System.Windows.Forms.Label lblTypeSearchByType;

    }
}