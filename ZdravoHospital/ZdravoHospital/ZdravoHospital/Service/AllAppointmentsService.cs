
// File:    AllAllAppointmentssService.cs
// Author:  EliteBook
// Created: Thursday, May 5, 2022 11:22:11 AM
// Purpose: Definition of Class AllAllAppointmentssService

using System;
using System.Collections.Generic;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace ZdravoHospital.Service
{
    public class AllAppointmentsService
    {
        private AllAppointmentsRepository allAppointmentsRepository = new AllAppointmentsRepository();
        public List<AllAppointments> GetAll()
        {
            return allAppointmentsRepository.GetAll();
        }

        public AllAppointments GetById(int objectIndex)
        {
            return allAppointmentsRepository.GetById(objectIndex);
        }

        public void Save(AllAppointments allAppointments)
        {
            allAppointmentsRepository.Save(allAppointments);
        }

        public void Delete(int objectIndex)
        {
            allAppointmentsRepository.Delete(objectIndex);
        }

        public void Edit(AllAppointments allAppointments, int objectIndex)
        {
            allAppointmentsRepository.Edit(allAppointments, objectIndex);
        }
    }
}

