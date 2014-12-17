using System.IO;
using System.Windows.Forms;
using MovieInformation.Interfaces;

namespace MovieInformation
{
    /// <summary>
    /// Gives access to data source
    /// </summary>
    class Config : IConfig
    {
        public string DatabaseFile = Path.Combine(Application.StartupPath, "MovieDatabase");
        public string DataSource
        {
            get
            {
                return string.Format("data source={0}", DatabaseFile);
            }
        }
    }
}
