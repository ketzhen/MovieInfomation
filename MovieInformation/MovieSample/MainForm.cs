using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MovieInformation;
using System.Text.RegularExpressions;
using MovieInformation.DAL;
using MovieInformation.Interfaces;

namespace MovieSample
{
    public partial class MainForm : Form
    {
        private IConfig _config;
        private IDatabaseQuery _databaseQuery;
        private IDataAccessor _dataAccessor;


        public MainForm()
        {
            InitializeComponent();
        }

      
        #region Tab colour setting here
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {


            switch (e.Index)
            {
                case 0:
                    e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
                    break;
                case 1:
                    e.Graphics.FillRectangle(new SolidBrush(Color.Blue), e.Bounds);
                    break;
                default:
                    break;
            }

            // Then draw the current tab button text
            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-2, -2);
            e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text, this.Font, SystemBrushes.HighlightText, paddedBounds);
        }

        #endregion
        bool checkLoadData = false;
        #region Page load and show the all data from database

        private void Form1_Load(object sender, EventArgs e)
        {
            _config = new Config();
            _dataAccessor = DatabaseFactory.GetDataAccessor(_config);
            _databaseQuery = DatabaseFactory.GetDatabaseQuery();
            try
            {


                cmbTypeSearchByType.SelectedIndex = 0;
                cmbType.SelectedIndex = 0;
               // QueryClass queryClassObj = new QueryClass();
                string loadAllDataQuery = _databaseQuery.LoadQuery();


                SelectQueryByTitle(loadAllDataQuery);
                checkLoadData = true;
            }
            catch (Exception)
            {


            }
        }

        #endregion

        #region Save data into data base
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {



                if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtYear.Text) && !string.IsNullOrEmpty(txtPublisher.Text) && cmbType.SelectedIndex > 0)
                {


                   // DatabaseClass dataBaseObj = new DatabaseClass();
                    string message;
                    if (_dataAccessor.InsertDataInDatabase(movieID, cmbType.SelectedItem.ToString(), txtTitle.Text,
                                                           txtPublisher.Text, txtYear.Text, "INS",
                                                           out message))
                    {
                        txtTitle.Clear();
                        txtPublisher.Clear();
                        txtYear.Clear();
                        cmbType.SelectedIndex = 0;
                        //QueryClass queryClassObj = new QueryClass();
                        string loadAllDataQuery = _databaseQuery.InsertQuery();

                        SelectQueryByTitle(loadAllDataQuery);
                    }
                    else
                    {
                        string loadAllDataQuery = _databaseQuery.LoadQuery();

                        MessageBox.Show("Data Save Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTitle.Clear();
                        txtPublisher.Clear();
                        txtYear.Clear();
                        cmbType.SelectedIndex = 0;
                        SelectQueryByTitle(loadAllDataQuery);
                        
                    }
                  
                }
                else
                {
                    MessageBox.Show("Please Enter All Required Fields", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;


                }
            }
            catch (Exception)
            {


            }


        }
        #endregion

        DataGridViewButtonColumn editButton;
        DataGridViewButtonColumn deleteButton;
        #region Show database data in UI
        private void SelectQueryByTitle(string searchQueryLocal)
        {
            try
            {
                grdMovieDataGrid.DataSource = null;

                grdMovieDataGrid.Columns.Clear();
              //  DatabaseClass dbclase = new DatabaseClass();
                DataTable dt = _dataAccessor.GetMovieDetail(searchQueryLocal);

                if (dt.Rows.Count == 0 && checkLoadData == true)
                {
                    MessageBox.Show("No Data Found !!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                grdMovieDataGrid.DataSource = dt;
                grdMovieDataGrid.AllowUserToAddRows = false; // remove the null line
                grdMovieDataGrid.ReadOnly = true;
                grdMovieDataGrid.Columns[0].Visible = false;


                editButton = new DataGridViewButtonColumn();
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                editButton.Width = 80;
                grdMovieDataGrid.Columns.Add(editButton);

                // insert delete button to datagridview
                deleteButton = new DataGridViewButtonColumn();
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.Width = 80;
                grdMovieDataGrid.Columns.Add(deleteButton);
                grdMovieDataGrid.Refresh();


            }
            catch (Exception)
            {


            }

        }
        #endregion


        public static int movieID;
        #region Delete/Edit button handling
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                using (SQLiteConnection conn = new SQLiteConnection(_config.DataSource))
                {
                    //QueryClass queryClassObj = new QueryClass();
                    string queryString = _databaseQuery.SelectQuery();



                    int currentRow = int.Parse(e.RowIndex.ToString());
                    DataGridViewRow rowColl = null;
                    try
                    {
                        rowColl = grdMovieDataGrid.Rows[currentRow];
                        string movieIDString = rowColl.Cells["movieID"].Value.ToString();

                        movieID = int.Parse(movieIDString);
                    }
                    catch (Exception ex) { }
                    // edit button
                    if (grdMovieDataGrid.Columns[e.ColumnIndex] == editButton && currentRow >= 0)
                    {
                        string title = rowColl.Cells["Title"].Value.ToString();
                        string publisher = rowColl.Cells["Publisher"].Value.ToString();

                        string year = rowColl.Cells["Year"].Value.ToString();
                        string type = rowColl.Cells["Type"].Value.ToString();

                        UpdateForm updateObj = new UpdateForm();
                        updateObj.txtUTitle.Text = title;
                        updateObj.txtUPublisher.Text = publisher;
                        updateObj.txtUYear.Text = year;
                        updateObj.comUType.Text = type;

                        updateObj.ShowDialog();
                        SelectQueryByTitle(queryString);
                        grdMovieDataGrid.Update();
                        grdMovieDataGrid.Refresh();

                    }

                    else if (grdMovieDataGrid.Columns[e.ColumnIndex] == deleteButton && currentRow >= 0)
                    {
                        // delete sql query
                       // QueryClass queryClassObjDelete = new QueryClass();
                        string queryDeleteString = _databaseQuery.DeleteQuery(movieID);

                        conn.Open();
                        SQLiteCommand sqlDelete = new SQLiteCommand();
                        sqlDelete.CommandText = queryDeleteString;
                        sqlDelete.Connection = conn;
                        sqlDelete.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Data Delete Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SelectQueryByTitle(queryString);
                    }
                }
            }
            catch (Exception)
            {


            }

        }
        #endregion
        #region Save movie details in data base
        private void btnTitleSearchByTitle_Click(object sender, EventArgs e)
        {
            try
            {


                if (!string.IsNullOrEmpty(txtTitleSearchByTitle.Text))
                {
                    //QueryClass queryClassObj = new QueryClass();
                    string searchQuery = _databaseQuery.SearchByTitle(txtTitleSearchByTitle.Text);

                    SelectQueryByTitle(searchQuery);
                    txtTitleSearchByTitle.Clear();
                }
                else if (!string.IsNullOrEmpty(cmbTypeSearchByType.Text))
                {
                    int type = 0;
                    string typeString = cmbTypeSearchByType.SelectedItem.ToString();
                    MovieTypeEnum movieTypeObj;
                    //Need to get the underlying value for enum using Enum.TryParse
                    Enum.TryParse(typeString, out movieTypeObj);
                    string searchQuery = _databaseQuery.SearchByType((int)movieTypeObj);

                    SelectQueryByTitle(searchQuery);
                    cmbTypeSearchByType.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {


            }

        }
        #endregion
        #region Search by title changed event
        private void txtTitleSearchByTitle_TextChanged(object sender, EventArgs e)
        {
            try
            {



                if (cmbTypeSearchByType.SelectedIndex == 0)
                {

                }
                else if (!string.IsNullOrEmpty(txtTitleSearchByTitle.Text))
                {
                    txtTitleSearchByTitle.Clear();

                    MessageBox.Show("You Can Search One Type At A Time !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }
            }
            catch (Exception)
            {


            }
        }
        #endregion
        #region Search by type changed event
        private void cmbTypeSearchByType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(txtTitleSearchByTitle.Text))
                {


                }
                else if (cmbTypeSearchByType.SelectedIndex > 0)
                {

                    cmbTypeSearchByType.SelectedIndex = 0;


                    MessageBox.Show("You Can Search One Type At A Time !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;

                }
            }
            catch (Exception)
            {


            }

        }

        #endregion
        #region check Year formate Validation
        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {


                if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b') //The  character represents a backspace
                {
                    e.Handled = false; //Do not reject the input
                }

                else
                {
                    if (e.KeyChar == ')' && !txtYear.Text.Contains(")"))
                    {
                        e.Handled = false; //Do not reject the input
                    }
                    else if (e.KeyChar == '(' && !txtYear.Text.Contains("("))
                    {
                        e.Handled = false; //Do not reject the input
                    }
                    else if (e.KeyChar == '-' && !txtYear.Text.Contains("-"))
                    {
                        e.Handled = false; //Do not reject the input
                    }
                    else if (e.KeyChar == ' ' && !txtYear.Text.Contains(" "))
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
