namespace SuperHeroesApp.Models
{
    class SuperPower
    {
        public string? Name;
        public string? Description;
        public PowerLevel Level;

        public SuperPower()
        {
            Level = PowerLevel.LevelOne;
        }

    }
}