// File:    AllAppointmentsRepository.cs
// Author:  EliteBook
// Created: Thursday, May 5, 2022 11:27:12 AM
// Purpose: Definition of Class AllAppointmentsRepository

using System;
using System.Collections.Generic;
using Model;
using System.Windows;
using FileHandler;
using Newtonsoft.Json;

namespace Repository
{
    public class AllAppointmentsRepository
    {
        private List<AllAppointments> appointments = new List<AllAppointments>();
        public AllAppointmentsFileHandler fileHandler = new AllAppointmentsFileHandler();

        public AllAppointmentsRepository()
        {
            fileHandler.Load();
        }

        public void Read()
        {

            appointments=fileHandler.Load();
           
        }
        public void Write()
        {
            fileHandler.Save(appointments);
        }

        public List<AllAppointments> GetAll()
        {
            Read();
            return appointments;
        }

        public AllAppointments GetById(int objectIndex)
        {
            Read();

            foreach (AllAppointments appointment in appointments)
            {
                if (appointment.Jmbg.Equals(objectIndex))
                    return appointment;
            }
            return null;
        }
        public void Save(AllAppointments appointment)
        {
            appointments.Add(appointment);
            Write();
        }

        public void Delete(int objectIndex)
        {
            Read();
            appointments.RemoveAt(objectIndex);
            Write();
        }

        public void Edit(AllAppointments appointment, int objectIndex)
        {
            Read();
            AllAppointments temp = GetById(objectIndex);
            temp.Jmbg = appointment.Jmbg;
            temp.DateAndTime = appointment.DateAndTime;
            temp.Duration = appointment.Duration;
            temp.Doctor = appointment.Doctor;
            Write();
        }
    }
}
