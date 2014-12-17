using MovieInformation.Interfaces;

namespace MovieInformation.DAL
{
    /// <summary>
    /// Factory provides access to all internal objects via their abstract implementations
    /// </summary>
    public class DatabaseFactory
    {
        /// <summary>
        /// Returns Data Accessor instance
        /// </summary>
        /// <param name="config">Config Source</param>
        /// <returns></returns>
        public static IDataAccessor GetDataAccessor(IConfig config)
        {
            return new DataAccessor(config);
        }

        /// <summary>
        /// Returns Database Query Instance
        /// </summary>
        /// <returns></returns>
        public static IDatabaseQuery GetDatabaseQuery()
        {
            return new DatabaseQuery();
        }
    }
}