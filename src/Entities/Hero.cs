namespace Projetos.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string HeroType, int HitPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoints = HitPoints;
        }

        public Hero()
        {

        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HitPoints;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " Atacou com a sua espada ";
        }



    }
}