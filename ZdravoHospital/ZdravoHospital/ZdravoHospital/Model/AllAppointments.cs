

// File:    AllAppointments.cs
// Author:  EliteBook
// Created: Thursday, May 5, 2022 3:53:22 AM
// Purpose: Definition of Class AllAppointments

using System;

namespace Model
{
    public class AllAppointments
    {
        public string Jmbg { get; set; }
        public string DateAndTime { get; set; }
        public int Duration { get; set; }
        public string Doctor { get; set; }

        public AllAppointments(string jmbg, string dateAndTime, int duration, string doctor)
        {
            Jmbg = jmbg;
            DateAndTime = dateAndTime;
            Duration = duration;
            Doctor = doctor;
        }

        public AllAppointments()
        {

        }

        public override string ToString()
        {
            return "" + this.Jmbg + "," + this.DateAndTime + "," + this.Duration + "," + this.Doctor;
        }
    }



}
