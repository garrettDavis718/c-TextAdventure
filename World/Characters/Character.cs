﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    
    public class Character
    {
        public string Name { get; set; }
        public int HealthPoints { get; set; }
        public int ArmorClass { get; set; }
        public int XLocation { get; set; }
        public int YLocation { get; set; }
        public Character()
        {
            
        }
        public Character(string name, int healthPoints, int armorClass, int xLocation, int yLocation)
        {
            Name = name;
            HealthPoints = healthPoints;
            ArmorClass = armorClass;
            XLocation = xLocation;
            YLocation = yLocation;
        }
        public Character(string name, int healthPoints, int armorClass)
        {
            Name = name;
            HealthPoints = healthPoints;
            ArmorClass = armorClass;
        }

    }
}
