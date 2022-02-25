using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace EnemyLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {
            //Get a random number from 1-100
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(30);

            if (diceRoll <= (attacker.CalcHitChance()) - defender.CalcBlockDodge())
            {
                //if the attacker hit, calculate the damage
                int damageDealt = attacker.CalcDamage();

                //Assign the damage
                defender.Health -= damageDealt;

                //Write the result to the screen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} took {1} HP from {2}",
                    attacker.Name,
                    damageDealt,
                    defender.Name);
                Console.ResetColor();
            }
            else
            {
                //The attacker missed
                Console.WriteLine("{0} didn't hit the target, try again.. if you don't get killed.", attacker.Name);
            }
        }//End DoAttack();

        public static void DoBattle(Player player, Enemy enemy)
        {
            DoAttack(player, enemy);

            if (enemy.Health > 0)
            {
                DoAttack(enemy, player);
            }
        }//End DoBattle();


    }
}
