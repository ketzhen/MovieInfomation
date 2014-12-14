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
using SQLiteHelper;
using System.Text.RegularExpressions;

namespace MovieSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }
        string dbFile = "data source=" + Path.Combine(Application.StartupPath, "MovieDatabase");
        SQLiteDataReader sqlite_datareader;
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

        private void InsertData(string titletxt, string publishertxt, string yeartxt, int typeIdcmb)
        {
            try
            {

            
            using (SQLiteConnection conn = new SQLiteConnection(dbFile))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    cmd.CommandText = "insert into MovieDetails(`Title`,`Publisher`,`Year`,`typeID`)  values('" + titletxt + "','" + publishertxt + "','" + yeartxt + "','" + typeIdcmb + "');";
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            }
            catch (Exception)
            {

                
            }
        }
        bool checkLoadData = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

            
            cmbTypeSearchByType.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            string loadAllDataQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,(Select movietypes.`Type` from movietypes Where movietypes.typeID = MovieDetails.typeID ) As  `Type` FROM MovieDetails Order By `movieID`";

            SelectQueryByTitle(loadAllDataQuery);
            checkLoadData = true;
            }
            catch (Exception)
            {

                
            }
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {

          

            if (!string.IsNullOrEmpty(txtTitle.Text) && !string.IsNullOrEmpty(txtYear.Text) && !string.IsNullOrEmpty(txtPublisher.Text) && cmbType.SelectedIndex > 0)
            {
                //bool isValidPrice = Regex.IsMatch(txtYear.Text, "^[0-9]");
                //if (isValidPrice == true)
                //{

                //}
                //else
                //{
                //    MessageBox.Show("Please Enter Year", "Fomate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;

                //}

                DatabaseClass dataBaseObj = new DatabaseClass();
                dataBaseObj.InsertDataInDatabase(cmbType.SelectedItem.ToString(), txtTitle.Text.ToString(), txtPublisher.Text.ToString(), txtYear.Text.ToString(), "INS");
                txtTitle.Clear();
                txtPublisher.Clear();
                txtYear.Clear();
                cmbType.SelectedIndex = 0;
                string loadAllDataQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,(Select movietypes.`Type` from movietypes Where movietypes.typeID = MovieDetails.typeID ) As  `Type` FROM MovieDetails Order By `movieID`";
                SelectQueryByTitle(loadAllDataQuery);
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


        DataGridViewButtonColumn editButton;
        DataGridViewButtonColumn deleteButton;
        DataTable data = null;
        private void SelectQueryByTitle(string searchQueryLocal)
        {
            try
            {

           
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {

                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();

                    //cmd.CommandText = "insert into MovieDetails(`Title`,`Publisher`,`Year`,`typeID`)  values();";
                    // cmd.CommandText = "SELECT `Title` FROM MovieDetails";
                    //cmd.CommandText = "SELECT `movieID``Title``Publisher``MovieYear``Type` FROM movie,movietype WHERE movietype.typeID = movie.typeID AND movie.title LIKE '" + txtTitleSearchByTitle.Text + "%'";
                    cmd.CommandText = searchQueryLocal;

                    //cmd.CommandText = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID AND `MovieDetails`.`title` LIKE '" + txtTitleSearchByTitle.Text + "%'";



                    grdMovieDataGrid.DataSource = null;
                    //SQLQuery.Connection = null;

                    SQLiteDataAdapter dataAdapter = null;
                    grdMovieDataGrid.Columns.Clear(); // <-- clear columns
                    //---------------------------------
                    //SQLQuery.CommandText = sqlQueryString;
                    //SQLQuery.Connection = database;
                    data = new DataTable();

                    dataAdapter = new SQLiteDataAdapter(cmd);

                    dataAdapter.Fill(data);
                    if (data.Rows.Count == 0 && checkLoadData == true)
                    {
                        MessageBox.Show("No Data Found !!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    grdMovieDataGrid.DataSource = data;
                    grdMovieDataGrid.AllowUserToAddRows = false; // remove the null line
                    grdMovieDataGrid.ReadOnly = true;
                    grdMovieDataGrid.Columns[0].Visible = false;

                    //grdMovieDataGrid.Columns[1].Width = 250;

                    //grdMovieDataGrid.Columns[2].Width = 160;

                    //grdMovieDataGrid.Columns[3].Width = 60;

                    //grdMovieDataGrid.Columns[4].Width = 100;

                    // insert edit button into datagridview
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

                    conn.Close();
                }
            }
            }
            catch (Exception)
            {

                
            }

        }
        private void SelectQueryByType()
        {
        }




        private void btnTitleSearchByTitle_Click_1(object sender, EventArgs e)
        {
            try
            {

           
            string searchQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID AND `MovieDetails`.`title` LIKE '" + txtTitleSearchByTitle.Text + "%'";
            SelectQueryByTitle(searchQuery);
            }
            catch (Exception)
            {

                
            }
        }

        private void btnTypeSearchByType_Click_1(object sender, EventArgs e)
        {
            try
            {

          
            int type = 0;
            string typeString = cmbTypeSearchByType.SelectedItem.ToString();
            MovieType movieTypeObj = new MovieType();
            type = movieTypeObj.MovieTypeMethod(typeString);


            string searchQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID AND MovieDetails.typeID ='" + type + "'";
            SelectQueryByTitle(searchQuery);
            }
            catch (Exception)
            {

                
            }

        }
        public static int movieID;
        #region Delete/Edit button handling
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

           
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                string queryString = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID";


                int currentRow = int.Parse(e.RowIndex.ToString());
                DataGridViewRow rowColl = null;
                try
                {
                    rowColl = grdMovieDataGrid.Rows[currentRow];
                    string movieIDString = rowColl.Cells["movieID"].Value.ToString();
                    // string movieIDString =Convert.ToString( grdMovieDataGrid.Columns[0]);
                    movieID = int.Parse(movieIDString);
                }
                catch (Exception ex) { }
                // edit button
                if (grdMovieDataGrid.Columns[e.ColumnIndex] == editButton && currentRow >= 0)
                {
                    string title = rowColl.Cells["Title"].Value.ToString();
                    string publisher = rowColl.Cells["Publisher"].Value.ToString();
                    //string previewed = dataGridView1[3, currentRow].Value.ToString();
                    string year = rowColl.Cells["Year"].Value.ToString();
                    string type = rowColl.Cells["Type"].Value.ToString();
                    //runs form 2 for editing    
                    UpdateForm updateObj = new UpdateForm();
                    updateObj.txtUTitle.Text = title;
                    updateObj.txtUPublisher.Text = publisher;
                    updateObj.txtUYear.Text = year;
                    updateObj.comUType.Text = type;
                    //updateObj.movieID = movieIDInt;
                    updateObj.ShowDialog();
                    SelectQueryByTitle(queryString);
                    grdMovieDataGrid.Update();
                    grdMovieDataGrid.Refresh();

                }

                else if (grdMovieDataGrid.Columns[e.ColumnIndex] == deleteButton && currentRow >= 0)
                {
                    // delete sql query
                    string queryDeleteString = "DELETE FROM MovieDetails where `movieID` = " + movieID + "";
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

        private void btnTitleSearchByTitle_Click(object sender, EventArgs e)
        {
            try
            {

           
            if (!string.IsNullOrEmpty(txtTitleSearchByTitle.Text))
            {
                string searchQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID AND `MovieDetails`.`title` LIKE '" + txtTitleSearchByTitle.Text + "%'";
                SelectQueryByTitle(searchQuery);
                txtTitleSearchByTitle.Clear();
            }
            else if (!string.IsNullOrEmpty(cmbTypeSearchByType.Text))
            {
                int type = 0;
                string typeString = cmbTypeSearchByType.SelectedItem.ToString();
                MovieType movieTypeObj = new MovieType();
                type = movieTypeObj.MovieTypeMethod(typeString);

                string searchQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID AND MovieDetails.typeID ='" + type + "'";
                SelectQueryByTitle(searchQuery);
                cmbTypeSearchByType.SelectedIndex = 0;
            }
            }
            catch (Exception)
            {

               
            }

        }

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

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            //string yearValue = txtYear.Text;

            //bool isValidPrice = Regex.IsMatch(yearValue, "^[0-9]");
            //if (isValidPrice == true)
            //{

            //}
            //else if (!string.IsNullOrEmpty(txtYear.Text))
            //{
            //    MessageBox.Show("Please Enter Year", "Fomate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;

            //}
        }

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





    }
}
