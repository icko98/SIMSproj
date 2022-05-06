using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// File:    MakingAppointment.cs
// Author:  EliteBook
// Created: Thursday, May 5, 2022 1:55:56 AM
// Purpose: Definition of Class MakingAppointment

using System;

namespace Model
{
    public class MakeAppointment
    {
        private string jmbg;
        private string doctor;
        private string startTime;
        private string endTime;
        private Priority priority;

        public string Jmbg { get; set; }
        public string Doctor { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public Priority Priority { get; set; }



        public MakeAppointment()
        { }

    }
}
