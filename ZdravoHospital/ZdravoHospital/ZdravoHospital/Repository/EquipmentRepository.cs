// File:    EquipmentRepository.cs
// Author:  User
// Created: Wednesday, April 20, 2022 2:22:32 AM
// Purpose: Definition of Class EquipmentRepository

using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
   public class EquipmentRepository
   {
      public List<Equipment> GetEquipment()
      {
         throw new NotImplementedException();
      }
      
      public Model.Equipment GetById(string id)
      {
         throw new NotImplementedException();
      }
      
      public Model.Equipment GetByName(string name)
      {
         throw new NotImplementedException();
      }
      
      public FileHandler.EquipmentFileHandler equipmentFileHandler;
      public System.Collections.Generic.List<Equipment> equipment;
      
      /// <summary>
      /// Property for collection of Model.Equipment
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Equipment> Equipment
      {
         get
         {
            if (equipment == null)
               equipment = new System.Collections.Generic.List<Equipment>();
            return equipment;
         }
         set
         {
            RemoveAllEquipment();
            if (value != null)
            {
               foreach (Model.Equipment oEquipment in value)
                  AddEquipment(oEquipment);
            }
         }
      }
      
      /// <summary>
      /// Add a new Model.Equipment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddEquipment(Model.Equipment newEquipment)
      {
         if (newEquipment == null)
            return;
         if (this.equipment == null)
            this.equipment = new System.Collections.Generic.List<Equipment>();
         if (!this.equipment.Contains(newEquipment))
            this.equipment.Add(newEquipment);
      }
      
      /// <summary>
      /// Remove an existing Model.Equipment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveEquipment(Model.Equipment oldEquipment)
      {
         if (oldEquipment == null)
            return;
         if (this.equipment != null)
            if (this.equipment.Contains(oldEquipment))
               this.equipment.Remove(oldEquipment);
      }
      
      /// <summary>
      /// Remove all instances of Model.Equipment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllEquipment()
      {
         if (equipment != null)
            equipment.Clear();
      }
   
   }
}