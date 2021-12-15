using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace AccountingTEST
{
    public static class TestSeeting
    {
        public static string TxtPath {
            get
            {
                string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                return Path.Combine(assemblyFolder, "Save.txt");
            }
        }
    }
}
