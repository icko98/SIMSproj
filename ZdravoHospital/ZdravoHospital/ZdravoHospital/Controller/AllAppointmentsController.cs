

using System;
using System.Collections.Generic;
using Model;
using Service;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravoHospital.Service;

namespace ZdravoHospital.Controller
{
    public class AllAppointmentsCotroller
    {
        private AllAppointmentsService allAppointmentsService = new AllAppointmentsService();
        public List<AllAppointments> GetAll()
        {
            return allAppointmentsService.GetAll();
        }

        public AllAppointments GetById(int objectIndex)
        {
            return allAppointmentsService.GetById(objectIndex);
        }

        public void Save(AllAppointments allAppointments)
        {
            allAppointmentsService.Save(allAppointments);
        }

        public void Delete(int objectIndex)
        {
            allAppointmentsService.Delete(objectIndex);
        }

    }
}

