using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Enemy : Character
    {
        //FIELDS
        private int _minDamage;

        //PROPERTIES

        public int MaxDamage { get; set; }

        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        //CONSTRUCTORS

        public Enemy(string name, int health, int maxHealth, int hitChance, int blockDodge, int minDamage, int maxDamage, string description)
        {
            MaxHealth = maxHealth;
            MaxDamage = maxDamage;
            Name = name;
            Health = health;
            HitChance = hitChance;
            BlockDodge = blockDodge;
            MinDamage = minDamage;
            Description = description;

        }

        public Enemy() { }

        //METHODS
        public override string ToString()
        {
            //0return base.ToString();

            return string.Format("\n<============|--- Enemy Info---|============>\n" +
                "{0}\nLife: {1} of {2}\nDamage: {3} to {4}\n" +
                "Block: {5}\nDescription:\n{6}\n",
                Name,
                Health,
                MaxHealth,
                MinDamage,
                MaxDamage,
                BlockDodge,
                Description);
        }

        public override int CalcDamage()
        {
            //return base.CalcDamage();

            Random rand = new Random();

            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }
}
