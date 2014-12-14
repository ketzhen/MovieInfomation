using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using SQLiteHelper;

namespace MovieSample
{
    class DatabaseClass
    {
        
        internal void InsertDataInDatabase(string cmbType,string title,string publisherM,string yearM,string checkQueryType)
        {
            try
            {

          
            string typeMoveiString;
            try
            {
                typeMoveiString = cmbType;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("You must enter movie type\nError: " + ex.Message + "");
                return;
            }
            int type = 0;
            string nameTitle = title;
            string publisher = publisherM;
            string year = yearM;
            int yr = 0;
            if (year != "")
            {
                yr = CheckYear(year);
            }
            if (!string.IsNullOrEmpty(typeMoveiString))
            {
                MovieType movieTypeObj = new MovieType();
               type=movieTypeObj.MovieTypeMethod(typeMoveiString);
                //if (typeMoveiString == "Adventure") type = 1;
                //if (typeMoveiString == "Comedy") type = 2;
                //if (typeMoveiString == "Action") type = 3;
                //if (typeMoveiString == "Cartoon") type = 4;
                //if (typeMoveiString == "Romantic") type = 5;
                //if (typeMoveiString == "Fantasy") type = 6;
                //if (typeMoveiString == "Thriller") type = 7;
                //if (typeMoveiString == "Historic") type = 8;
                //if (typeMoveiString == "Drama") type = 9;
                //if (typeMoveiString == "Horor") type = 10;
                //if (typeMoveiString == "Crime") type = 11;
                //if (typeMoveiString == "Biografy") type = 12;
                if (checkQueryType.Equals("INS"))
                {
                    InsertData(nameTitle, publisher, year, type);  
                }
                else
                {
                    UpdateQury(nameTitle, publisher, year, type);
                    
                }


            }
            }
            catch (Exception)
            {

                
            }
        }
        private void InsertData(string titletxt, string publishertxt, string yeartxt, int typeIdcmb)
        {
            try
            {

            
            using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
                    int responseReslut = -1;
              
                    cmd.CommandText = "insert into MovieDetails(`Title`,`Publisher`,`Year`,`typeID`)  values('" + titletxt + "','" + publishertxt + "','" + yeartxt + "','" + typeIdcmb + "');";
                    responseReslut = cmd.ExecuteNonQuery();
                    if (responseReslut >= 1) MessageBox.Show("Data Save Successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conn.Close();
                }
            }
            }
            catch (Exception)
            {

                
            }
        }
        public int CheckYear(string year)
        {

            int yr = int.Parse(year);
            if (yr >= 2100 || yr <= 1900)
            {
                return 1;
            }
            else
            {
                return yr;
            }
        }
        internal void UpdateQury(string titletxt, string publishertxt, string yeartxt, int typeIdcmb)
        {
            try
            {

           
               using (SQLiteConnection conn = new SQLiteConnection(config.DataSource))
            {
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();
              
                    //cmd.CommandText = "insert into MovieDetails(`Title`,`Publisher`,`Year`,`typeID`)  values('" + titletxt + "','" + publishertxt + "','" + yeartxt + "','" + typeIdcmb + "');";

                    cmd.CommandText = "UPDATE MovieDetails SET `Title` ='" + titletxt.Replace("'", "''") + "', `Year`='" + yeartxt + "', `Publisher`='" + publishertxt + "', `typeID`=" + typeIdcmb + " WHERE MovieDetails.movieID=" + MainForm.movieID + "";
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            }
            catch (Exception)
            {

                
            }
        }
        }
    }
    
    
  

