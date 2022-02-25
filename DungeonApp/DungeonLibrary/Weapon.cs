using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //FIELDS 
        private int _minDamage;
        private int _maxDamage;
        private string _weaponName;
        private int _hitChance;
        private bool _isTwoHanded;

        //PROPERTIES

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string WeaponName
        {
            get { return _weaponName; }
            set { _weaponName = value; }

        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

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

        public Weapon(int minDamage, int maxDamage, string weaponName, int hitChance, bool isTwoHanded)
        {
            
            MaxDamage = maxDamage;           
            MinDamage = minDamage;
            WeaponName = weaponName;
            IsTwoHanded = isTwoHanded;
        }

        //METHODS
        public override string ToString()
        {
            return string.Format("{0}\t{1} to {2} Damage\n " +
              "Bonus Hit {3}%\t{4}",
              WeaponName,
              MinDamage,
              MaxDamage,
              HitChance,
              IsTwoHanded ? "Two-Handed" : "One-Handed");
        }
    }
}
