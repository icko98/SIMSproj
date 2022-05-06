using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandler
{
    public class MakeAppointmentFileHandler
    {
        public void Save(List<MakeAppointment> makeAppointment)
        {
            System.IO.File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(makeAppointment));
        }

        public List<MakeAppointment> Load()
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<MakeAppointment>>(System.IO.File.ReadAllText(path));
        }

        private string path = @"..\..\Data\makeAppointment.txt";
    }
}
