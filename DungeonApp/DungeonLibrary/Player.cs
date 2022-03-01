using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dungeon;

namespace DungeonLibrary
{
    //TODO set up character creation
    //TODO set up functionality for race to influence character and player stats
    //TODO set up functionality for weapon types to influence base weapon damage 
    //1. User inputs character race and receives attributes based on race
    //2. User inputs character weapon and receives base damage
    public class Player : Character
    {
        //PROPERTIERS
        //public Race PlayerRace { get; set; }
        public ConsoleKey PlayerRace { get; set; }

        public Weapon PlayerWeapon { get; set; }

        //CONSTRUCTORS
        public Player(string name, int hitChance, int blockDodge, int health, int maxHealth, ConsoleKey playerRace, Weapon playerWeapon)
        {
            MaxHealth = maxHealth;
            Name = name;
            HitChance = hitChance;
            BlockDodge = blockDodge;
            Health = health;
            PlayerRace = playerRace;
            PlayerWeapon = playerWeapon;
        }

        //METHODS 
        public override string ToString()
        {
            //return base.ToString();
            string description = "";
            switch (PlayerRace)
            {
                case ConsoleKey.T:
                    description= "Trandoshan";
                    break;
                case ConsoleKey.H:
                description = "Human";
                    break;
                case ConsoleKey.M:
                description = "Mandalorian";
                    break;
                case ConsoleKey.G:
                    description = "Geonosian";
                    break;
                case ConsoleKey.C:
                    description = "Mon Calamari";
                    break;
                case ConsoleKey.N:
                    description = "Gungan";
                    break;
                case ConsoleKey.W:
                    description = "Wookie";
                    break;
                case ConsoleKey.L:
                    description = "Talz";
                    break;
                case ConsoleKey.Q:
                    description = "Quarren";
                    break;
                case ConsoleKey.U:
                    description = "Muun";
                    break;
                case ConsoleKey.B:
                    description = "Bith";
                    break;
                case ConsoleKey.A:
                    description = "Lasat";
                    break;
                case ConsoleKey.R:
                    description = "Togruta";
                    break;
                case ConsoleKey.Z:
                    description = "Zabrak";
                    break;
               
                default:
                    break;
            }

            //Apply option to choose weapon and calculate damaged based on weapon 
            //string weaponDes = "";
            //switch (PlayerWeapon)
            //{
            //    case Weapon.Sword:
            //        weaponDes = "Sword";
            //        break;
            //    case Weapon.Axe:
            //        weaponDes = "Axe";
            //        break;
            //    case Weapon.Hammer:
            //        weaponDes = "Hammer";
            //        break;
            //    case Weapon.Mace:
            //        description = "Orc";
            //        break;
            //    case Race.HighElf:
            //        description = "High-Elf";
            //        break;
            //    case Race.WoodElf:
            //        description = "Wood Elf";
            //        break;
            //    case Race.Argonian:
            //        description = "Argonian";
            //        break;
            //    case Race.Dragonborn:
            //        description = "Dragonborn";
            //        break;
            //    case Race.Dwarf:
            //        description = "Dwarf";
            //        break;
            //    case Race.Gnome:
            //        description = "Gnome";
            //        break;
            //    case Race.Giant:
            //        description = "Giant";
            //        break;
            //    case Race.Tiefling:
            //        description = "Tiefling";
            //        break;
            //    case Race.Leonin:
            //        description = "Leonin";
            //        break;
            //    case Race.Satyr:
            //        description = "Satyr";
            //        break;
            //    case Race.Fairy:
            //        description = "Fairy";
            //        break;
            //    case Race.Harengon:
            //        description = "Harengon";
            //        break;
            //    case Race.Owlin:
            //        description = "Owlin";
            //        break;
            //    case Race.Khajiit:
            //        description = "Khajiit";
            //        break;
            //    case Race.Merfolk:
            //        description = "Merfolk";
            //        break;
            //    default:
            //        break;
            return string.Format($"\n<==========|--{Name}---|==========>\n" +
                $"\nHealth Points: {Health}\nMax Health: {MaxHealth}\nHit Chance: {HitChance}\nWeapon: {PlayerWeapon}\n" +
                $"\nBlock: {BlockDodge}\nRace:{description}");

        }

        public override int CalcDamage()
        {
            Random playerAttack = new Random();
            int damage = playerAttack.Next(PlayerWeapon.MinDamage, PlayerWeapon.MaxDamage + 1);

            return damage;
        }//Calculate Damage

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + PlayerWeapon.HitChance;
        }//Calculate chance of hitting
    } 
}

