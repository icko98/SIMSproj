// File:    BasicRenovationRepository.cs
// Author:  User
// Created: Wednesday, May 4, 2022 1:27:28 AM
// Purpose: Definition of Class BasicRenovationRepository

using System;

namespace Repository
{
   public class BasicRenovationRepository
   {
      public void ScheduleRenovation(Model.BasicRenovation basicRenovation)
      {
         throw new NotImplementedException();
      }
      
      public List<BasicRenovation> GetScheduledRenovations()
      {
         throw new NotImplementedException();
      }
      
      public FileHandler.BasicRenovationFileHandler basicRenovationFileHandler;
      public Model.BasicRenovation[] basicRenovation;
   
   }
}