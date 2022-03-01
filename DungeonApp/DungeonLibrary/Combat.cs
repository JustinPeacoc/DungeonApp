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
            Random rand = new Random();
            int attackNbr = rand.Next(1, 151);
            
            if (attackNbr <= (attacker.CalcHitChance()) - defender.CalcBlockDodge())
            {

                int damageDealt = attacker.CalcDamage();

                defender.Health -= damageDealt;


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("{0} hit {1} for {2} HP.",
                    attacker.Name,
                    defender.Name,
                    damageDealt);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("{0} didn't hit the target.", attacker.Name);
            }//attacker misses
            //end attack
        }

        public static void DoBattle(Player player, Enemy enemy)
        {
            DoAttack(player, enemy);

            if (enemy.Health > 0)
            {
                DoAttack(enemy, player);
            }
        }


    }
}
