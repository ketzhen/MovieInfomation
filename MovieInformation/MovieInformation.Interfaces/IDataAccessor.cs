namespace MovieInformation.Interfaces
{
    /// <summary>
    /// Code for abstrations. We Should create interfaces for dependency inversion and unit testing support
    /// </summary>
    public interface IDataAccessor
    {
        int CheckYear(string year);
        System.Data.DataTable GetMovieDetail(string searchQueryLocal);
        bool InsertData(string titletxt, string publishertxt, string yeartxt, int typeIdcmb, out string message);

        bool InsertDataInDatabase(int movieID, string cmbType, string title, string publisherM, string yearM, string checkQueryType,
                                  out string message);
        bool UpdateQury(int movieID, string titletxt, string publishertxt, string yeartxt, int typeIdcmb, out string message);
    }
}
