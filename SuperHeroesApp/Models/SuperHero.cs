using System.Text;

namespace SuperHeroesApp.Models
{
    class SuperHero : Hero
    {
        private string _Name;
        public Guid Id;
        public override string? Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value.Trim();
            }
        }

        public string? NameAndSecretIdentity
        {
            get
            { 
                return $"{Name} ({SecretIdentity})";             
            }
        }
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
                sb.AppendLine($"{NameAndSecretIdentity} está usando el super poder {power.Name}!!!");
            }
            return sb.ToString();
        }

        //Implementar un metodo de una clase abstracta
        public override string SaveTheWorld()
        {
            return $@"{Id} {Name}";
        }

    }
}