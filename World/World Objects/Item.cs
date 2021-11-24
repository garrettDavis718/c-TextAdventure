﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    //Item Class used for creating item objects and storing them in our item list, will be used in future iterations
    public class Item
    {
        //constructors
        public int ID { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int LocationID { get; set; }


        //Item Custom constructor
        public Item()
        {
            
        }
        public Item(int id, string name, string desc)
        {
            ID = id;
            Name = name;
            Desc = desc;
        }
        public Item(int id, string name, double weight, string desc)
        {
            ID = id;
            Weight = weight;
            Name = name;
            Desc = desc;
        }
        //Overload for Items that need a location
        public Item(int id, string name, double weight, string desc, int locationID)
        {
            ID = id;
            Weight = weight;
            Name = name;
            Desc = desc;
            LocationID = locationID;
        }
        public void DropItem(Item droppedItem, PlayerCharacter user)
        {
            Room room = Map.GetLocation(user);
            for (int i = 0; i < user.Inventory.Count; i++)
            {
                if (user.Inventory[i].ID.Equals(droppedItem.ID))
                {
                    room.Inventory.Add(user.Inventory[i]);
                    user.Inventory.RemoveAt(i);
                }
            }
        }
        public static void TakeItem(Item item, PlayerCharacter user)
        {
            if (user.Weight < 50)
            {
                user.Inventory.Add(item);
            }
            else
            {
                //Console writeline, needs fix
                Console.WriteLine("You are too heavy to pick this item up.");
            }
        }
        
        





    }
}
