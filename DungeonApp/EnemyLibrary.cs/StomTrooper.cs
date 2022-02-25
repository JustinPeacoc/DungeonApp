using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace EnemyLibrary
{
    public class StormTrooper : Enemy
    {
        public StormTrooper (string name, int health, int maxHealth, int minHealth, int blockDodge, int minDamage, int maxDamage, string description)
            : base(name, health, maxHealth, minHealth, blockDodge, minDamage, maxDamage, description)
        {
        }
        public StormTrooper()
        {
            MaxHealth = 40;
            MaxDamage = 20;
            Name = "Stormtrooper";
            Health = 50;
            HitChance = 20;
            BlockDodge = 20;

            MinDamage = 1;
            Description = "Description";
        }
    }
}
