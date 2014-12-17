namespace MovieInformation.Interfaces
{
    /// <summary>
    /// Code for abstrations. We Should create interfaces for dependency inversion and unit testing support
    /// </summary>
    public interface IDatabaseQuery
    {
        string DeleteQuery(int movieid);
        string InsertQuery();
        string LoadQuery();
        string SearchByTitle(string searchTitle);
        string SearchByType(int type);
        string SelectQuery();
    }
}
