namespace Projetos.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int HitPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoints = HitPoints;
        }
    
        
        public override string Attack()
        {
            return this.Name + " Ataque silencioso!";
        }

        public string Defense()
        {
            return this.Name + " Defesa ativada: Camuflagem!";
        }

    }
}