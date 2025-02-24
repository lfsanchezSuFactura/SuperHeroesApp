using System.Text;

namespace SuperHeroesApp.Models
{
    internal class AntiHero : SuperHero
    {
        public string Organization { get; set; }

        public string BadAction (string action){
            return $"El anti-héroe {NameAndSecretIdentity} perteneciente a la organización ({Organization}) realizó la fechoria {action}";
        }
    }
}