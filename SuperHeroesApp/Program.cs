// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var canFly = new SuperPower();
canFly.Name = "Fly";
canFly.Description = "Ability to glide and fly through the air";
canFly.Level = PowerLevel.LevelOne;

var superStreng = new SuperPower();
superStreng.Name = "Super Streng";
superStreng.Description = "";
superStreng.Level = PowerLevel.LevelThree;


var superman = new SuperHero();

//superman.Id = Guid.NewGuid();
superman.Name = "Superman";
superman.SecretIdentity = "Clark Kent";
superman.City = "Metropolis";
superman.CanFly = true;

List<SuperPower> superpowerSuperman = new List<SuperPower>();
superpowerSuperman.Add(superStreng);
superpowerSuperman.Add(canFly);

superman.SuperPowers =  superpowerSuperman;

superman.UseSuperPowers();

class SuperHero
{
    public Guid Id;
    public string ? Name;
    public string ? SecretIdentity;
    public string ? City;
    public List<SuperPower> ? SuperPowers;
    public bool CanFly;

    public SuperHero()
    {
        Id = Guid.NewGuid();
        SuperPowers = new List<SuperPower>();
        CanFly = false;
    }

    public void UseSuperPowers()
    {
        foreach (var power in SuperPowers)
        {
            System.Console.WriteLine($"{Name} está usando el super poder {power.Name}!!!");
        }
    }
}

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

enum PowerLevel
{
    LevelOne,
    LevelTwo,
    LevelThree
}