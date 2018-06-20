namespace ConsoleBattleApp
{
    interface IHero
    {
        int Agility { get; }
        int CharacterLevel { get; }
        int Defence { get; }
        int Intellect { get; }
        bool IsActive { get; }
        bool IsNeutralized { get; }
        int MagicResist { get; }
        int Stamina { get; }
        int Strength { get; }

        void Attack();
        void GetStats();
    }
}