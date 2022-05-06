using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class RecordFileHandler
    {
        public void Save(List<Record> record)
        {
            System.IO.File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(record));
        }

        public List<Record> Load()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Record>>(System.IO.File.ReadAllText(path));
        }

        private string path = @"..\..\Data\Record.txt";
    }
}

