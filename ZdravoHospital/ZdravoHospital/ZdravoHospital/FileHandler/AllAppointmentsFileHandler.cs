using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FileHandler
{
    public class AllAppointmentsFileHandler
    {
        public void Save(List<AllAppointments> allAppointments)
        {
            System.IO.File.WriteAllText(path, Newtonsoft.Json.JsonConvert.SerializeObject(allAppointments));
        }

        public List<AllAppointments> Load()
        {
        
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<AllAppointments>>(System.IO.File.ReadAllText(path));
             
            
        }


        private string path = @"..\..\Data\AllAppointments.txt";
    }
}
