// File:    App.cs
// Author:  Ilija
// Created: Wednesday, April 13, 2022 10:04:20 PM
// Purpose: Definition of Class App

using System;

namespace Model
{
   public class App
   {
      private Guid id;
      private string patientID;
      private System.DateTime dt;
      private int duration;

      
      public App(string patID, System.DateTime dt, int dur)
      {
            this.Id = Guid.NewGuid();
            this.Dt = dt;
            this.PatientID = patID;
            this.Duration = dur;
      }

      public Guid Id { get; set; }
      public string PatientID { get; set; }
      public System.DateTime Dt { get; set;}
      public int Duration { get; set; }

      
   }
}