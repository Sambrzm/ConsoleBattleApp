using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp
{
    class Rat
    {
        public static int Health { get; set; } = 100;
        public static int Damage { get; set; } = 10;
        public static int CritDMG { get; set; } = 15;
        public static int CritChance { get; set; } = 15;
        public static int Accuracy { get; set; } = 80;

        public static void EnemyAttack()
        {
            Random R = new Random();
            int attack = R.Next(1, 5);

            if (attack == 1)
            {
                Program.PrintColorMessage(ConsoleColor.Red, "It attacks");
                MyCharacter.Health = MyCharacter.Health - EnemyPunch(MyCharacter.Health);
                Console.WriteLine("Your HP is now {0}", MyCharacter.Health);
            }
            else if (attack == 2)
            {
                Program.PrintColorMessage(ConsoleColor.Red, "It shreiks! Your attack goes down");
                MyCharacter.Damage = MyCharacter.Damage - 1;
                MyCharacter.CritDMG = MyCharacter.CritDMG - 2;
            }
            else if (attack == 3)
            {
                Program.PrintColorMessage(ConsoleColor.Red, "It enrages, it's attack goes up!");
                Damage = Damage + 2;
                CritDMG = CritDMG + 5;
            }
            else
            {
                Program.PrintColorMessage(ConsoleColor.Red, "It sprays you in the eyes - Your accuracy goes down");
                if (MyCharacter.Accuracy >= 30)
                {
                    MyCharacter.Accuracy = MyCharacter.Accuracy - 5;
                } else
                {
                    Program.PrintColorMessage(ConsoleColor.Red, "Your accuracy cant go down any more");
                }
            }
        }

        static int EnemyPunch(int myHP)
        {
            int punchDMG = Damage;

            Random R = new Random();
            int Crit = R.Next(1, 101);
            int Miss = R.Next(1, 101);

            if (Miss >= Accuracy)
            {
                punchDMG = 0;
                Console.WriteLine("Missed!");
            }
            else
            {
                if (Crit <= CritChance)
                {
                    Console.WriteLine("Critial Hit!");
                    punchDMG = CritDMG;
                }
                else
                {
                    punchDMG = Damage;
                }
            }
            return punchDMG;
        }
    }
}
