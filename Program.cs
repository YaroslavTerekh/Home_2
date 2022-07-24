using ExoftCamp_2_Game_;
using ExoftCamp_2_Game_.Logic;
using ExoftCamp_2_Game_.Soldiers;
using System;

namespace ExoftCamp
{
    class Program
    {
        // Logic classes ----------------------------------------------
        static AddArmor AddArmor = new AddArmor();
        static AddHP AddHP = new AddHP();
        static AddImpactForce AddImpactForce = new AddImpactForce();
        // ------------------------------------------------------------

        static void ChooseCharacter(ConsoleKey key, ref AbstractCharacter player)
        {
            while (true)
            {
                if (key == ConsoleKey.D1)
                {
                    Console.WriteLine(", your choose is bowman");
                    player = new Bowman();     
                    break;
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.WriteLine(", your choose is boxer");
                    player = new Boxer();
                    break;
                }
                else if (key == ConsoleKey.D3)
                {
                    Console.WriteLine(", your choose is swordsman");
                    player = new Swordsman();
                    break;
                }
                else if (key == ConsoleKey.D4)
                {
                    Console.WriteLine(", your choose is wizard");
                    player = new Wizard();
                    break;
                }
                else
                {
                    Console.WriteLine("Choose your character! (press 1, 2, 3 or 4)");
                    key = Console.ReadKey().Key;
                }
            }
        }
        static void GenerateSP(ConsoleKey key, ref AbstractCharacter player, int power)
        {
            while (true)
            {
                if (key == ConsoleKey.D1)
                {
                    Console.WriteLine(", your choose is HP");
                    player.AddSuperPower(AddHP, power);
                    break;
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.WriteLine(", your choose is armor");
                    player.AddSuperPower(AddArmor, power);
                    break;
                }
                else if (key == ConsoleKey.D3)
                {
                    Console.WriteLine(", your choose is impact force");
                    player.AddSuperPower(AddImpactForce, power);
                    break;
                }
                else
                {
                    Console.WriteLine("Choose you want to develop! (press 1, 2 or 3)");
                    key = Console.ReadKey().Key;
                }
            }
        }

        public static AbstractCharacter player1 = null;
        public static AbstractCharacter player2 = null;
        static void Main(string[] args)
        {
            SuperPowerGenerator generator = new SuperPowerGenerator();

            Console.WriteLine("PLAYER 1");
            Console.WriteLine("Choose your character: 1) Bowman(press 1) 2)Boxer(press 2) 3)Swordsman(press 3) 4)Wizard(press 4)");
            var key1 = Console.ReadKey().Key;
            ChooseCharacter(key1, ref player1);

            Console.WriteLine("\n PLAYER 2");
            Console.WriteLine("Choose your character: 1) Bowman(press 1) 2)Boxer(press 2) 3)Swordsman(press 3) 4)Wizard(press 4)");
            var key2 = Console.ReadKey().Key;
            ChooseCharacter(key2, ref player2);

            Console.WriteLine("\n PLAYER 1. SUPER POWER GENERATION");
            Console.WriteLine("Press any key to generate your super power");
            Console.ReadLine();
            var superPower1 = generator.GetSuperPower();
            Console.WriteLine("your super power is " + superPower1);
            Console.WriteLine("What skill you want to improve?");
            Console.WriteLine("1) HP(press 1) 2) Armor(press 2) 3) Impact Force(press 3)");
            var spKey1 = Console.ReadKey().Key;
            GenerateSP(spKey1, ref player1, superPower1);

            Console.WriteLine("\n PLAYER 2. SUPER POWER GENERATION");
            Console.WriteLine("Press any key to generate your super power");
            Console.ReadLine();
            var superPower2 = generator.GetSuperPower();
            Console.WriteLine("your super power is " + superPower2);
            Console.WriteLine("What skill you want to improve?");
            Console.WriteLine("1) HP(press 1) 2) Armor(press 2) 3) Impact Force(press 3)");
            var spKey2 = Console.ReadKey().Key;
            GenerateSP(spKey2, ref player2, superPower2);

            Console.WriteLine("------------------------PRESS ENTER TO GENERATE BATTLE------------------------");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("------------------------BATTLE------------------------");
            Console.WriteLine($"------------PLAYER1-VS-PLAYER2------------");

            Arena.Battle(player1, player2);
        }
    }
}
