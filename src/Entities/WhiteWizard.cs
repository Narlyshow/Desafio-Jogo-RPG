namespace Projetos.src.Entities

{
    public class WhiteWizard : Hero
    {

        public WhiteWizard(string Name, int Level, string HeroType, int HitPoints)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HitPoints = HitPoints;
        }
        public override string Attack()
        {
            return this.Name + " Atacou com magia ";
        }

        public string Defense()
        {
            return this.Name + " Defendeu com escudo mágico";
        }


        public string Attack(int Bonus)
        {

            if (Bonus > 6)
            {
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou uma magia super efetiva com bonus de  " + Bonus;
            }


        }
    }
}