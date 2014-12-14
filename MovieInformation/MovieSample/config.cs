using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SQLiteHelper
{
    class config
    {

        public static string DatabaseFile =Path.Combine(Application.StartupPath, "MovieDatabase");
        public static string DataSource
        {
            get
            {
                return string.Format("data source={0}", DatabaseFile);
            }
        }
    }
}
