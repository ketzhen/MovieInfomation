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

namespace MovieSample
{
    public partial class Form1 : Form
    {
        public Form1()
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
            // Graphics g = e.Graphics;
            // Pen p = new Pen(Color.Blue);
            // Font font = new Font("Arial", 10.0f);
            // SolidBrush brush = new SolidBrush(Color.Red);
            //Rectangle tabArea = tabControl1.GetTabRect(0);
            //RectangleF tabTextArea = (RectangleF)tabControl1.GetTabRect(0);

            // g.DrawRectangle(p, tabArea);
            // g.DrawString("tabPage1", font, brush, tabTextArea);

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
        private void Form1_Load(object sender, EventArgs e)
        {

            string loadAllDataQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,(Select movietypes.`Type` from movietypes Where movietypes.typeID = MovieDetails.typeID ) As  `Type` FROM MovieDetails Order By `movieID`";
            SelectQueryByTitle(loadAllDataQuery);
        }
        

      
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //InsertDataInDatabase();
           
             
                DatabaseClass dataBaseObj = new DatabaseClass();
                dataBaseObj.InsertDataInDatabase(cmbType.SelectedItem.ToString(), txtTitle.Text.ToString(), txtPublisher.Text.ToString(), txtYear.Text.ToString(),"INS");
                txtTitle.Clear();
                txtPublisher.Clear();
                txtYear.Clear();
                cmbType.ResetText();
           
            
        }
        
       
        DataGridViewButtonColumn editButton;
        DataGridViewButtonColumn deleteButton;
        private void SelectQueryByTitle(string searchQueryLocal)
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


                    DataTable data = null;
                    dataGridView1.DataSource = null;
                    //SQLQuery.Connection = null;

                    SQLiteDataAdapter dataAdapter = null;
                    dataGridView1.Columns.Clear(); // <-- clear columns
                    //---------------------------------
                    //SQLQuery.CommandText = sqlQueryString;
                    //SQLQuery.Connection = database;
                    data = new DataTable();

                    dataAdapter = new SQLiteDataAdapter(cmd);
                    //if (data.Rows.Count==0)
                    //{
                    //    MessageBox.Show("No Data Found !!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    return;
                    //}
                    dataAdapter.Fill(data);
                    dataGridView1.DataSource = data;
                    dataGridView1.AllowUserToAddRows = false; // remove the null line
                    dataGridView1.ReadOnly = true;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Width = 150;
                    dataGridView1.Columns[3].Width = 150;
                    dataGridView1.Columns[4].Width = 150;
                    //grdMovidGrid.Columns[5].Width = 80;
                    // insert edit button into datagridview
                    editButton = new DataGridViewButtonColumn();
                    editButton.HeaderText = "Edit";
                    editButton.Text = "Edit";
                    editButton.UseColumnTextForButtonValue = true;
                    editButton.Width = 80;
                    dataGridView1.Columns.Add(editButton);
                    // insert delete button to datagridview
                    deleteButton = new DataGridViewButtonColumn();
                    deleteButton.HeaderText = "Delete";
                    deleteButton.Text = "Delete";
                    deleteButton.UseColumnTextForButtonValue = true;
                    deleteButton.Width = 80;
                    dataGridView1.Columns.Add(deleteButton);

                    //sqlite_datareader = cmd.ExecuteReader();



                    // The SQLiteDataReader allows us to run through the result lines:
                    //while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                    //{




                    //    string myreader = sqlite_datareader.GetString(1);

                    //    MessageBox.Show(myreader);

                    //}
                    conn.Close();
                }
            }

        }
        private void SelectQueryByType()
        {
        }


       

        private void btnTitleSearchByTitle_Click_1(object sender, EventArgs e)
        {
            string searchQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID AND `MovieDetails`.`title` LIKE '" + txtTitleSearchByTitle.Text + "%'";
            SelectQueryByTitle(searchQuery);
        }

        private void btnTypeSearchByType_Click_1(object sender, EventArgs e)
        {
            int type = 0;
            string typeString = cmbTypeSearchByType.SelectedItem.ToString();
            if (typeString == "Adventure") type = 1;
            if (typeString == "Comedy") type = 2;
            if (typeString == "Action") type = 3;
            if (typeString == "Cartoon") type = 4;
            if (typeString == "Romantic") type = 5;
            if (typeString == "Fantasy") type = 6;
            if (typeString == "Thriller") type = 7;
            if (typeString == "Historic") type = 8;
            if (typeString == "Drama") type = 9;
            if (typeString == "Horor") type = 10;
            if (typeString == "Crime") type = 11;
            if (typeString == "Biografy") type = 12;

            string searchQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID AND MovieDetails.typeID ='" + type +"'";
            SelectQueryByTitle(searchQuery);

        }
       public static int movieID;
        #region Delete/Edit button handling
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                string queryString = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID";


                int currentRow = int.Parse(e.RowIndex.ToString());
                try
                {
                    string movieIDString = dataGridView1[0, currentRow].Value.ToString();
                    movieID = int.Parse(movieIDString);
                }
                catch (Exception ex) { }
                // edit button
                if (dataGridView1.Columns[e.ColumnIndex] == editButton && currentRow >= 0)
                {
                    string title = dataGridView1[1, currentRow].Value.ToString();
                    string publisher = dataGridView1[2, currentRow].Value.ToString();
                    //string previewed = dataGridView1[3, currentRow].Value.ToString();
                    string year = dataGridView1[3, currentRow].Value.ToString();
                    string type = dataGridView1[4, currentRow].Value.ToString();
                    //runs form 2 for editing    
                    UpdateForm updateObj = new UpdateForm();
                    updateObj.txtUTitle.Text = title;
                    updateObj.txtUPublisher.Text = publisher;
                    updateObj.txtUYear.Text = year;
                    updateObj.comUType.Text = type;
                    //updateObj.movieID = movieIDInt;
                    updateObj.ShowDialog();
                    SelectQueryByTitle(queryString);
                    dataGridView1.Update();

                }

                else if (dataGridView1.Columns[e.ColumnIndex] == deleteButton && currentRow >= 0)
                {
                    // delete sql query
                    string queryDeleteString = "DELETE FROM MovieDetails where `movieID` = " + movieID + "";
                    conn.Open();
                    SQLiteCommand sqlDelete = new SQLiteCommand();
                    sqlDelete.CommandText = queryDeleteString;
                    sqlDelete.Connection = conn;
                    sqlDelete.ExecuteNonQuery();
                    SelectQueryByTitle(queryString);
                }
            }

        }
         #endregion

       


    }
}
