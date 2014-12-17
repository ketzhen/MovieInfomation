using System;
using System.Windows.Forms;
using MovieInformation.DAL;
using MovieInformation.Interfaces;
using MovieSample;

namespace MovieInformation
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        #region Save the updated records into database

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string message;

                //DatabaseClass dataBaseObj = new DatabaseClass();
                bool success = _dataAccessor.InsertDataInDatabase(MainForm.movieID, comUType.SelectedItem.ToString(), txtUTitle.Text.ToString(), txtUPublisher.Text.ToString(), txtUYear.Text.ToString(), "UPD",out message);
                this.Close();
                MessageBox.Show(message, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception)
            {


            }
        }
        #endregion
        private IConfig _config;
        private IDatabaseQuery _databaseQuery;
        private IDataAccessor _dataAccessor;

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            _config = new Config();
            _dataAccessor = DatabaseFactory.GetDataAccessor(_config);
            _databaseQuery = DatabaseFactory.GetDatabaseQuery();
        }
        #region Close the Update form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Check year validation here
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
        #endregion
    }
}
