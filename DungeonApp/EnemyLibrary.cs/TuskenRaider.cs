using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace EnemyLibrary
{
    public class TuskenRaider : Enemy
    {
        public TuskenRaider (string name, int health, int maxHealth, int hitChance, int blockDodge, int minDamage, int maxDamage, string description)
               : base(name, health, maxHealth, hitChance, blockDodge, minDamage, maxDamage, description)
        {
        }
        public TuskenRaider ()
        {
            MaxHealth = 75;
            MaxDamage = 80;
            Name = "Tusken Raider";
            Health = 110;
            HitChance = 100;
            BlockDodge = 20;
            MinDamage = 1;
            Description = "A Tusken Raider, indigenous to the planet Tatooine; wearing abundant clothing to protect themselves from the harsh weather and holding a slugthrower enters. They look insane.";
        }
    }
}
