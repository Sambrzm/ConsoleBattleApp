namespace ConsoleBattleApp
{
    interface IEnemy
    {
        int Agility { get; }
        int CharacterLevel { get;}
        int Defence { get; }
        int Intellect { get; }  
        int MagicResist { get; }
        int Stamina { get; }
        int Strength { get; }

        bool IsNeutralized { get; }
        bool IsActive { get; }

        void Attack();
        void GetStats();
    }
}