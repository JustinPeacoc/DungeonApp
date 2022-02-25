using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;


namespace EnemyLibrary 
{
    public class Rancor : Enemy
    {
        public Rancor (string name, int health, int maxHealth, int minHealth, int blockDodge, int minDamage, int maxDamage, string description)
            : base (name, health, maxHealth, minHealth, blockDodge, minDamage, maxDamage, description)
        {
        }
        public Rancor()
        {
            MaxHealth = 150;
            MaxDamage = 80;
            Name = "Rancor";
            Health = 150;
            HitChance = 100;
            BlockDodge = 20;
            MinDamage = 1;
            Description = "A Rancor; a towering hulk of muscle born to kill from the planet Dathomir blocks your path.";
        }
    }
}
