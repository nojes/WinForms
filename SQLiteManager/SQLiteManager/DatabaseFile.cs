using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace SQLiteManager
{
    public class DatabaseFile
    {
        public string fileName { get; set; }
        public string name { get; set; }
        public string extension { get; set; }
        public string path { get; set; }

//        List<DataTable> tables;

        public DatabaseFile()
        {
            
        }

        public DatabaseFile(string fileName)
        {
            this.fileName = Path.GetFileName(fileName);
            path = Path.GetFullPath(fileName);
            name = Path.GetFileNameWithoutExtension(fileName);
            extension = Path.GetExtension(fileName);
        }
    }
}