using MovieInformation.Interfaces;

namespace MovieInformation.DAL
{
    /// <summary>
    /// This class provides access to all database queries. Concrete classes should be internal and exposed via factory
    /// </summary>
   internal class DatabaseQuery : IDatabaseQuery
    {
        #region Load data into UI
        public string LoadQuery()
        {
            //Since the query is not going to change . It makes sense to make it const
            const string loadAllDataQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,(Select movietypes.`Type` from movietypes Where movietypes.typeID = MovieDetails.typeID ) As  `Type` FROM MovieDetails Order By `movieID`";
            return loadAllDataQuery;
        }

       #endregion
        #region Insert data into database
        public string InsertQuery()
        {
            //Since the query is not going to change . It makes sense to make it const
            const string loadAllDataQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,(Select movietypes.`Type` from movietypes Where movietypes.typeID = MovieDetails.typeID ) As  `Type` FROM MovieDetails Order By `movieID`";
            return loadAllDataQuery;
        }

        #endregion
        #region Search By Title
        public string SearchByTitle(string searchTitle)
        {
            string searchQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID AND `MovieDetails`.`title` LIKE '" + searchTitle + "%'";
            return searchQuery;
        }
        #endregion
        #region Search by type
        public string SearchByType(int type)
        {
            string searchQuery = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID AND MovieDetails.typeID ='" + type + "'";
            return searchQuery;
        }
        #endregion
        #region Select movie details from database
        public string SelectQuery()
        {
            //Since the query is not going to change . It makes sense to make it const
            const string queryString = "SELECT `MovieDetails`.`movieID`,`MovieDetails`.`Title`,`MovieDetails`.`Publisher`,`MovieDetails`.`Year`,`movietypes`.`Type` FROM MovieDetails,movietypes WHERE movietypes.typeID = MovieDetails.typeID";
            return queryString;
        }

        #endregion
        #region Delete data from database
        public string DeleteQuery(int movieid)
        {
            string queryDeleteString = "DELETE FROM MovieDetails where `movieID` = " + movieid + "";
            return queryDeleteString;
        }
        #endregion

    }
}
