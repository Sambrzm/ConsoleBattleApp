using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp
{
    abstract class Enemy : IEnemy
    {
        public int CharacterLevel { get; protected set; }

        public abstract int Stamina { get; protected set; }
        public abstract int Strength { get; protected set; }
        public abstract int Intellect { get; protected set; }
        public abstract int Agility { get; protected set; }
        public abstract int Defence { get; protected set; }
        public abstract int MagicResist { get; protected set; }
        public static double Accuracy = .80;

        public static int Health;
        public static int Mana;
        public static int AttackDamage;
        public static double CritChance;
        public static double CritDMG;
        public static int SpellPower;

        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized);

        //int IEnemy.Health => throw new NotImplementedException();
        //int IEnemy.Mana => throw new NotImplementedException();
        //int IEnemy.AttackDamage => throw new NotImplementedException();
        //double IEnemy.CritChance => throw new NotImplementedException();
        //double IEnemy.CritDMG => throw new NotImplementedException();
        //int IEnemy.SpellPower => throw new NotImplementedException();

        private static readonly Random _random = new Random();

        public static void DecreaseHealth(int factor)
        {
            Health -= factor;
        }

        public static bool IsCriticalHit()
        {
            return _random.NextDouble() < CritChance;
        }

        public static bool IsSuccessfulHit()
        {
            return _random.NextDouble() < Accuracy;
        }

        public Enemy()
        {
            GetStats();
        }

        public void GetStats()
        {
            Health = CalculateStats.CalcHealth(Stamina);
            Mana = CalculateStats.CalcMana(Intellect);
            AttackDamage = CalculateStats.CalcAtkDmg(Strength);
            CritChance = CalculateStats.CalcCritChance(Agility);
            CritDMG = CalculateStats.CalcCritDmg(Strength);
            SpellPower = CalculateStats.CalcSpellPower(Intellect);
        }

        public abstract void Attack();

        
    }
}
