using ExoftCamp_2_Game_.Soldiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoftCamp
{
    public static class Arena
    {
        public static void Battle (AbstractCharacter player1, AbstractCharacter player2)
        {
            int i = 0;
            while(player1.HP > 0 && player2.HP > 0)
            {
                i++;
                Console.WriteLine("ROUND "+ i +". FIGHT!");
                player1.Attack(player2);
                player2.Attack(player1);

                Console.WriteLine("Player 1 HP: " + player1.HP);
                Console.WriteLine("Player 2 HP: " + player2.HP);
                Console.ReadLine();

                if(!player1.isAlive)
                {
                    Console.WriteLine("Player 2 won");
                    break;
                }
                if(!player2.isAlive)
                {
                    Console.WriteLine("Player 1 won");
                    break;
                }
            }

            Console.WriteLine("Round quantity: " + i);
        }
    }
}
