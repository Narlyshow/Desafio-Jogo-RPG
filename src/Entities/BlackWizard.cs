namespace Projetos.src.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int HitPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoints = HitPoints;

        }

        public override string Attack()
        {
            return this.Name + " Atacou com um sabre de Luz";
        }

        public string Defense()
        {
            return this.Name + " Defesa ativada: Portal Black!";
        }


    }
}