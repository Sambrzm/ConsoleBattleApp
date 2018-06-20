using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBattleApp
{
    abstract class Hero : IHero
    {
        public int CharacterLevel { get; protected set; }

        public abstract int CurrentXP { get; protected set; }
        public int NextLevelUp;

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

        private static readonly Random _random = new Random();

        public static void DecreaseHealth(int factor)
        {
            Health -= factor;
        }

        public static bool IsSuccessfulHit()
        {
            return _random.NextDouble() < Accuracy;
        }

        public static bool IsCriticalHit()
        {
            return _random.NextDouble() < CritChance;
        }

        public Hero()
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

            NextLevelUp = Leveling.NextLevel(CharacterLevel);
        }

        public abstract void Attack();

        public void GainExperience(int amount)
        {
            CurrentXP += amount;
            if (CurrentXP >= NextLevelUp)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            CharacterLevel += 1;
            NextLevelUp = Leveling.NextLevel(CharacterLevel);
        }


    }
}
