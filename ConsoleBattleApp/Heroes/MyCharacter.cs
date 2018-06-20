using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp
{
    //class MyCharacter
    //{
    //    public static int Health { get; set; } = 100;
    //    public static int Damage { get; set; } = 10;
    //    public static int CritChance { get; set; } = 15;
    //    public static int CritDMG { get; set; } = 15;
    //    public static int Accuracy { get; set; } = 80;

    //    public static void BattleMenu()
    //    {
    //        Console.WriteLine("1 - Attack");
    //        Console.WriteLine("2 - Demoralizing shout");
    //        Console.WriteLine("3 - Battle cry");
    //        Console.WriteLine("4 - Shield bash");

    //        int answer = Int32.Parse(Console.ReadLine());

    //        if (answer == 1)
    //        {
    //            Program.PrintColorMessage(ConsoleColor.Green, "You attack!");
    //            Enemies.Enemy.Health = Enemies.Enemy.Health - MyPunch(Enemies.Enemy.Health);
    //            Console.WriteLine("Enemy HP is now {0}", Enemies.Enemy.Health);
    //        }
    //        else if (answer == 2)
    //        {
    //            Program.PrintColorMessage(ConsoleColor.Green, "Enemy attack goes down");
    //            Enemies.Enemy.AttackDamage = Enemies.Enemy.AttackDamage - 1;
    //            Enemies.Enemy.CritDMG = Enemies.Enemy.CritDMG - 2;
    //        }
    //        else if (answer == 3)
    //        {
    //            Program.PrintColorMessage(ConsoleColor.Green, "Your attack goes up!");
    //            Damage = Damage + 2;
    //            CritDMG = CritDMG + 5;
    //        }
    //        else if (answer == 4)
    //        {
    //            Program.PrintColorMessage(ConsoleColor.Green, "Enemy accuracy goes down!");
    //            if (Enemies.Enemy.Accuracy >= 30)
    //            {
    //                Enemies.Enemy.Accuracy = Enemies.Enemy.Accuracy - 5;
    //            }
    //            else
    //            {
    //                Program.PrintColorMessage(ConsoleColor.Red, "It's accuracy cant go down any more");
    //            }
    //        }
    //        else
    //        {
    //            Program.PrintColorMessage(ConsoleColor.Red, "Please enter a valid number");
    //            BattleMenu();
    //        }

    //        int MyPunch(int enemyHP)
    //        {
    //            int punchDMG = Damage;

    //            Random R = new Random();
    //            int Crit = R.Next(1, 101);
    //            int Miss = R.Next(1, 101);

    //            if (Miss >= Accuracy)
    //            {
    //                punchDMG = 0;
    //                Console.WriteLine("Missed!");
    //            }
    //            else
    //            {
    //                if (Crit <= CritChance)
    //                {
    //                    Console.WriteLine("Critial Hit!");
    //                    punchDMG = CritDMG;
    //                }
    //                else
    //                {
    //                    punchDMG = Damage;
    //                }
    //            }
    //            return punchDMG;
    //        }
    //    }
    //}
}
