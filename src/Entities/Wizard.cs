namespace DesafioJogoRPG.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard (string Name, int Level, string HeroType) 
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " lançou magia";
        }

        public string Attack (int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " lançou magia super efetiva com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " lançou magia com força fraca com bônus de " + Bonus;
            }
            
        }


    }
}