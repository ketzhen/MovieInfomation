using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieSample
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
    
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

           
            //InsertDataInDatabase();
       
          
            DatabaseClass dataBaseObj = new DatabaseClass();
            dataBaseObj.InsertDataInDatabase(comUType.SelectedItem.ToString(), txtUTitle.Text.ToString(), txtUPublisher.Text.ToString(), txtUYear.Text.ToString(),"UPD");
            this.Close();
            MessageBox.Show("Data Update Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //SelectQueryByTitle(queryString);
            }
            catch (Exception)
            {

               
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

           
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') //The  character represents a backspace
            {
                e.Handled = false; //Do not reject the input
            }

            else
            {
                if (e.KeyChar == ')' && !txtUYear.Text.Contains(")"))
                {
                    e.Handled = false; //Do not reject the input
                }
                else if (e.KeyChar == '(' && !txtUYear.Text.Contains("("))
                {
                    e.Handled = false; //Do not reject the input
                }
                else if (e.KeyChar == '-' && !txtUYear.Text.Contains("-"))
                {
                    e.Handled = false; //Do not reject the input
                }
                else if (e.KeyChar == ' ' && !txtUYear.Text.Contains(" "))
                {
                    e.Handled = false; //Do not reject the input
                }
                else
                {
                    e.Handled = true;
                }
            }
            }
            catch (Exception)
            {

              
            }
        }
    }
}
