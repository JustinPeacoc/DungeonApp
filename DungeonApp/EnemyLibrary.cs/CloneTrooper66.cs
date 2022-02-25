using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace EnemyLibrary
{
    public class CloneTrooper66 : Enemy
    {
         public CloneTrooper66 (string name, int health, int maxHealth, int minHealth, int blockDodge, int minDamage, int maxDamage, string description)
          : base(name, health, maxHealth, minHealth, blockDodge, minDamage, maxDamage, description)
        {
        }
        public CloneTrooper66 ()
        {
            MaxHealth = 75;
            MaxDamage = 66;
            Name = "Clone Trooper";
            Health = 75;
            HitChance = 100;
            BlockDodge = 20;

            MinDamage = 1;
            Description = "A Clone Trooper enters the room. Cloned and bred for war, Order 66 is enacted. He's not here to be friendly.";
        }
    }
}
