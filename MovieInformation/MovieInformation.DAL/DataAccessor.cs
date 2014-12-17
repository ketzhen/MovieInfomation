using System;
using System.Data.SQLite;
using MovieInformation.Interfaces;
using System.Data;

namespace MovieInformation.DAL
{
    /// <summary>
    /// Concrete classes should be internal and exposed via factory
    /// </summary>
    internal class DataAccessor : IDataAccessor
    {
        private readonly IConfig _config;

        public DataAccessor(IConfig config)
        {
            _config = config;
        }

        #region Insert data into database 
        public bool InsertDataInDatabase(int movieId, string cmbType, string title, string publisherM, string yearM, string checkQueryType, out string message)
        {
            
            try
            {
                message = null;
                string typeMoveiString;
                try
                {
                    typeMoveiString = cmbType;
                }
                catch (Exception ex)
                {
                    message = "You must enter movie type\nError: " + ex.Message + "";
                    return false;
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
                    MovieTypeEnum movieTypeEnum ;//= new MovieType();
                    Enum.TryParse(typeMoveiString, out movieTypeEnum);  //movieTypeObj.MovieTypeMethod(typeMoveiString);
                   
                    if (checkQueryType.Equals("INS"))
                    {
                        return InsertData(nameTitle, publisher, year, (int)movieTypeEnum, out message);
                    }
                    else
                    {
                        return UpdateQury(movieId, nameTitle, publisher, year, (int)movieTypeEnum, out message);

                    }


                }
                
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }
            message = null;
            return false;
        }
        #endregion
        #region Call insert Method here
        public bool InsertData(string titletxt, string publishertxt, string yeartxt, int typeIdcmb ,out string message)
        {
            try
            {


                using (SQLiteConnection conn = new SQLiteConnection(_config.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        int responseReslut = -1;

                        cmd.CommandText = "insert into MovieDetails(`Title`,`Publisher`,`Year`,`typeID`)  values('" + titletxt + "','" + publishertxt + "','" + yeartxt + "','" + typeIdcmb + "');";
                        responseReslut = cmd.ExecuteNonQuery();
                        if (responseReslut >= 1) 
                            message = "Data Save Successfully";

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;

            }
            message = null;
            return false;
        }
        #endregion
        #region Check year validation
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
        #endregion
        #region Edit movie records
        public bool UpdateQury(int movieID, string titletxt, string publishertxt, string yeartxt, int typeIdcmb,out string message)
        {
            try
            {
                message = null;

                using (SQLiteConnection conn = new SQLiteConnection(_config.DataSource))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();

                        
                        cmd.CommandText = "UPDATE MovieDetails SET `Title` ='" + titletxt.Replace("'", "''") + "', `Year`='" + yeartxt + "', `Publisher`='" + publishertxt + "', `typeID`=" + typeIdcmb + " WHERE MovieDetails.movieID=" + movieID + "";
                        int i = cmd.ExecuteNonQuery();
                        conn.Close();
                        message = "Data Update Successfully";
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;

            }
        }
        #endregion
        #region  Get Movie Details 
        public DataTable GetMovieDetail(string searchQueryLocal)
        {
            DataTable data = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(_config.DataSource))
            {

                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = conn;
                    conn.Open();


                    cmd.CommandText = searchQueryLocal;
                 
                    SQLiteDataAdapter dataAdapter = null;
                  
                  

                    dataAdapter = new SQLiteDataAdapter(cmd);

                    dataAdapter.Fill(data);
                    conn.Close();
                }
            }
            return data;
        }
        #endregion


    }
}




