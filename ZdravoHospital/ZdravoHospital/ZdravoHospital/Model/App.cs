// File:    App.cs
// Author:  Ilija
// Created: Wednesday, April 13, 2022 10:04:20 PM
// Purpose: Definition of Class App

using System;

namespace Model
{
   public class App
   {
      private int id;
      private string patientID;
      private System.DateTime dt;
      private int duration;

      private int iter = 0;
      
      public App(string patID, System.DateTime dt, int dur)
      {
            this.id = ++iter;
            this.dt = dt;
            this.patientID = patID;
            this.duration = dur;
      }

      public int Id { get; set; }
      public string PatientID { get; set; }
      public System.DateTime Dt { get; set;}
      public int Duration { get; set; }

      
   }
}