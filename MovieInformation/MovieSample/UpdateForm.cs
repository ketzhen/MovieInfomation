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
            //InsertDataInDatabase();
       
          
            DatabaseClass dataBaseObj = new DatabaseClass();
            dataBaseObj.InsertDataInDatabase(comUType.SelectedItem.ToString(), txtUTitle.Text.ToString(), txtUPublisher.Text.ToString(), txtUYear.Text.ToString(),"UPD");
            this.Close();
            //SelectQueryByTitle(queryString);
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
