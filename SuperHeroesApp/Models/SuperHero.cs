namespace SuperHeroesApp.Models
{
    class SuperHero
    {
        public Guid Id;
        public string? Name;
        public string? SecretIdentity;
        public string? City;
        public List<SuperPower>? SuperPowers;
        public bool CanFly;

        public SuperHero()
        {
            Id = Guid.NewGuid();
            SuperPowers = new List<SuperPower>();
            CanFly = false;
        }

        public string UseSuperPowers()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var power in SuperPowers)
            {
                sb.AppendLine($"{Name} está usando el super poder {power.Name}!!!");
            }
            return sb.ToString();
        }
    }
}