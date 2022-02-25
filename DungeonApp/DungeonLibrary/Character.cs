using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Character
    {
        //FIELDS

        private int _health;

        //PROPERTIES

        public string Name { get; set; }

        public int HitChance { get; set; }

        public int BlockDodge { get; set; }

        public int MaxHealth { get; set; }

        public int Health
        {
            get { return _health; }
            set
            {
                if (value < +MaxHealth)
                {
                    _health = value;
                }

                else
                {
                    _health = MaxHealth;
                }
            }
        }

        //METHODS
        public virtual int CalcBlockDodge()
        {
            return BlockDodge;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }
    }
}
