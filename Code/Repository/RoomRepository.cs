// File:    RoomRepository.cs
// Author:  smvul
// Created: Tuesday, April 12, 2022 10:59:59 PM
// Purpose: Definition of Class RoomRepository

using System;

namespace Repository
{
   public class RoomRepository
   {
      public void CreateRoom(Room room)
      {
         throw new NotImplementedException();
      }
      
      public List<Room> GetRooms()
      {
         throw new NotImplementedException();
      }
      
      public void EditRoom(Room room)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteRoom(Room room)
      {
         throw new NotImplementedException();
      }
      
      public Model.Room GetById(string id)
      {
         throw new NotImplementedException();
      }
      
      public FileHandler.RoomFileHandler roomFileHandler;
      public System.Collections.Generic.List<Room> room;
      
      /// <summary>
      /// Property for collection of Model.Room
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Room> Room
      {
         get
         {
            if (room == null)
               room = new System.Collections.Generic.List<Room>();
            return room;
         }
         set
         {
            RemoveAllRoom();
            if (value != null)
            {
               foreach (Model.Room oRoom in value)
                  AddRoom(oRoom);
            }
         }
      }
      
      /// <summary>
      /// Add a new Model.Room in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddRoom(Model.Room newRoom)
      {
         if (newRoom == null)
            return;
         if (this.room == null)
            this.room = new System.Collections.Generic.List<Room>();
         if (!this.room.Contains(newRoom))
            this.room.Add(newRoom);
      }
      
      /// <summary>
      /// Remove an existing Model.Room from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveRoom(Model.Room oldRoom)
      {
         if (oldRoom == null)
            return;
         if (this.room != null)
            if (this.room.Contains(oldRoom))
               this.room.Remove(oldRoom);
      }
      
      /// <summary>
      /// Remove all instances of Model.Room from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllRoom()
      {
         if (room != null)
            room.Clear();
      }
   
   }
}