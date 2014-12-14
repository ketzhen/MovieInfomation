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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUType = new System.Windows.Forms.Label();
            this.lblUYear = new System.Windows.Forms.Label();
            this.lblUPublisher = new System.Windows.Forms.Label();
            this.lblUTitle = new System.Windows.Forms.Label();
            this.comUType = new System.Windows.Forms.ComboBox();
            this.txtUYear = new System.Windows.Forms.TextBox();
            this.txtUPublisher = new System.Windows.Forms.TextBox();
            this.txtUTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(117)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(19, 165);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "OK";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUType
            // 
            this.lblUType.AutoSize = true;
            this.lblUType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUType.Location = new System.Drawing.Point(244, 123);
            this.lblUType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUType.Name = "lblUType";
            this.lblUType.Size = new System.Drawing.Size(48, 17);
            this.lblUType.TabIndex = 21;
            this.lblUType.Text = "Type: ";
            // 
            // lblUYear
            // 
            this.lblUYear.AutoSize = true;
            this.lblUYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUYear.Location = new System.Drawing.Point(16, 122);
            this.lblUYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUYear.Name = "lblUYear";
            this.lblUYear.Size = new System.Drawing.Size(46, 17);
            this.lblUYear.TabIndex = 20;
            this.lblUYear.Text = "Year: ";
            // 
            // lblUPublisher
            // 
            this.lblUPublisher.AutoSize = true;
            this.lblUPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUPublisher.Location = new System.Drawing.Point(16, 70);
            this.lblUPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUPublisher.Name = "lblUPublisher";
            this.lblUPublisher.Size = new System.Drawing.Size(75, 17);
            this.lblUPublisher.TabIndex = 19;
            this.lblUPublisher.Text = "Publisher: ";
            // 
            // lblUTitle
            // 
            this.lblUTitle.AutoSize = true;
            this.lblUTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUTitle.Location = new System.Drawing.Point(16, 18);
            this.lblUTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUTitle.Name = "lblUTitle";
            this.lblUTitle.Size = new System.Drawing.Size(39, 17);
            this.lblUTitle.TabIndex = 18;
            this.lblUTitle.Text = "Title:";
            // 
            // comUType
            // 
            this.comUType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comUType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            this.comUType.Location = new System.Drawing.Point(300, 124);
            this.comUType.Margin = new System.Windows.Forms.Padding(4);
            this.comUType.Name = "comUType";
            this.comUType.Size = new System.Drawing.Size(160, 24);
            this.comUType.TabIndex = 15;
            // 
            // txtUYear
            // 
            this.txtUYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUYear.Location = new System.Drawing.Point(66, 122);
            this.txtUYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtUYear.MaxLength = 4;
            this.txtUYear.Name = "txtUYear";
            this.txtUYear.Size = new System.Drawing.Size(160, 23);
            this.txtUYear.TabIndex = 14;
            this.txtUYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUYear_KeyPress);
            // 
            // txtUPublisher
            // 
            this.txtUPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUPublisher.Location = new System.Drawing.Point(16, 93);
            this.txtUPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.txtUPublisher.Name = "txtUPublisher";
            this.txtUPublisher.Size = new System.Drawing.Size(441, 23);
            this.txtUPublisher.TabIndex = 13;
            // 
            // txtUTitle
            // 
            this.txtUTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUTitle.Location = new System.Drawing.Point(16, 41);
            this.txtUTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtUTitle.Name = "txtUTitle";
            this.txtUTitle.Size = new System.Drawing.Size(441, 23);
            this.txtUTitle.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(61)))), ((int)(((byte)(117)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(373, 165);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 30);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox
            // 
            this.picBox.Image = global::MovieSample.Properties.Resources._1418559535_1730021;
            this.picBox.Location = new System.Drawing.Point(425, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(32, 32);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 25;
            this.picBox.TabStop = false;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(473, 203);
            this.ControlBox = false;
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUType);
            this.Controls.Add(this.lblUTitle);
            this.Controls.Add(this.lblUYear);
            this.Controls.Add(this.txtUTitle);
            this.Controls.Add(this.lblUPublisher);
            this.Controls.Add(this.txtUPublisher);
            this.Controls.Add(this.txtUYear);
            this.Controls.Add(this.comUType);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Movie Record";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUType;
        private System.Windows.Forms.Label lblUYear;
        private System.Windows.Forms.Label lblUPublisher;
        private System.Windows.Forms.Label lblUTitle;
        public System.Windows.Forms.ComboBox comUType;
        public System.Windows.Forms.TextBox txtUYear;
        public System.Windows.Forms.TextBox txtUPublisher;
        internal System.Windows.Forms.TextBox txtUTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picBox;
    }
}