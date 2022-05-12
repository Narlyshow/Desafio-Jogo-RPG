namespace Projetos.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HitPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoints = HitPoints;
        }


        public override string Attack()
        {
            return this.Name + " Atacou com uma arma secreta";
        }

        public string Defense()
        {
            return this.Name + " Defesa ativada: Mortal carpado!";
        }



    }
}