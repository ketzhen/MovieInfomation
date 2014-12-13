namespace MovieSample
{
    partial class UpdateForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUType = new System.Windows.Forms.Label();
            this.lblUYear = new System.Windows.Forms.Label();
            this.lblUPublisher = new System.Windows.Forms.Label();
            this.lblUTitle = new System.Windows.Forms.Label();
            this.comUType = new System.Windows.Forms.ComboBox();
            this.txtUYear = new System.Windows.Forms.TextBox();
            this.txtUPublisher = new System.Windows.Forms.TextBox();
            this.txtUTitle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111)))));
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.lblUType);
            this.groupBox1.Controls.Add(this.lblUYear);
            this.groupBox1.Controls.Add(this.lblUPublisher);
            this.groupBox1.Controls.Add(this.lblUTitle);
            this.groupBox1.Controls.Add(this.comUType);
            this.groupBox1.Controls.Add(this.txtUYear);
            this.groupBox1.Controls.Add(this.txtUPublisher);
            this.groupBox1.Controls.Add(this.txtUTitle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 254);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(117)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(333, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUType
            // 
            this.lblUType.AutoSize = true;
            this.lblUType.Location = new System.Drawing.Point(11, 127);
            this.lblUType.Name = "lblUType";
            this.lblUType.Size = new System.Drawing.Size(48, 18);
            this.lblUType.TabIndex = 21;
            this.lblUType.Text = "Type: ";
            // 
            // lblUYear
            // 
            this.lblUYear.AutoSize = true;
            this.lblUYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUYear.Location = new System.Drawing.Point(11, 101);
            this.lblUYear.Name = "lblUYear";
            this.lblUYear.Size = new System.Drawing.Size(46, 18);
            this.lblUYear.TabIndex = 20;
            this.lblUYear.Text = "Year: ";
            // 
            // lblUPublisher
            // 
            this.lblUPublisher.AutoSize = true;
            this.lblUPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUPublisher.Location = new System.Drawing.Point(11, 75);
            this.lblUPublisher.Name = "lblUPublisher";
            this.lblUPublisher.Size = new System.Drawing.Size(77, 18);
            this.lblUPublisher.TabIndex = 19;
            this.lblUPublisher.Text = "Publisher: ";
            // 
            // lblUTitle
            // 
            this.lblUTitle.AutoSize = true;
            this.lblUTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUTitle.Location = new System.Drawing.Point(11, 49);
            this.lblUTitle.Name = "lblUTitle";
            this.lblUTitle.Size = new System.Drawing.Size(39, 18);
            this.lblUTitle.TabIndex = 18;
            this.lblUTitle.Text = "Title:";
            // 
            // comUType
            // 
            this.comUType.FormattingEnabled = true;
            this.comUType.Items.AddRange(new object[] {
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
            this.comUType.Location = new System.Drawing.Point(105, 124);
            this.comUType.Name = "comUType";
            this.comUType.Size = new System.Drawing.Size(121, 26);
            this.comUType.TabIndex = 15;
            // 
            // txtUYear
            // 
            this.txtUYear.Location = new System.Drawing.Point(104, 98);
            this.txtUYear.Name = "txtUYear";
            this.txtUYear.Size = new System.Drawing.Size(121, 24);
            this.txtUYear.TabIndex = 14;
            // 
            // txtUPublisher
            // 
            this.txtUPublisher.Location = new System.Drawing.Point(104, 72);
            this.txtUPublisher.Name = "txtUPublisher";
            this.txtUPublisher.Size = new System.Drawing.Size(332, 24);
            this.txtUPublisher.TabIndex = 13;
            // 
            // txtUTitle
            // 
            this.txtUTitle.Location = new System.Drawing.Point(104, 46);
            this.txtUTitle.Name = "txtUTitle";
            this.txtUTitle.Size = new System.Drawing.Size(332, 24);
            this.txtUTitle.TabIndex = 12;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 277);
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUType;
        private System.Windows.Forms.Label lblUYear;
        private System.Windows.Forms.Label lblUPublisher;
        private System.Windows.Forms.Label lblUTitle;
        public System.Windows.Forms.ComboBox comUType;
        public System.Windows.Forms.TextBox txtUYear;
        public System.Windows.Forms.TextBox txtUPublisher;
        internal System.Windows.Forms.TextBox txtUTitle;
    }
}