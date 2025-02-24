// See https://aka.ms/new-console-template for more information
using System.Text;
using SuperHeroesApp.Models;

var canFly = new SuperPower();
canFly.Name = "Fly";
canFly.Description = "Ability to glide and fly through the air";
canFly.Level = PowerLevel.LevelOne;

var superStreng = new SuperPower();
superStreng.Name = "Super Streng";
superStreng.Description = "";
superStreng.Level = PowerLevel.LevelThree;


var superman = new SuperHero();

superman.Id = Guid.NewGuid();
superman.Name = "Superman       ";
superman.SecretIdentity = "Clark Kent";
superman.City = "Metropolis";
superman.CanFly = true;

List<SuperPower> superpowerSuperman = new List<SuperPower>();
superpowerSuperman.Add(superStreng);
superpowerSuperman.Add(canFly);

superman.SuperPowers =  superpowerSuperman;

System.Console.WriteLine(superman.UseSuperPowers());

enum PowerLevel
{
    LevelOne,
    LevelTwo,
    LevelThree
}