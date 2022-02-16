namespace PooComJogo.src.Entitiens
{
    public class Wizard : Hero
    {

        public Wizard(string name, int level, string heroType) : base (name, level, heroType)
        {

        }

        public override string Attack()
        {
           return this.Name + " Lançou Magia";
        }

        public string Attack(int bonus)
        {
            if(bonus > 6)
            {
                return $"{this.Name} Lançou Magia super efetiva com {bonus} de bonus de gelo";
            }
            return $"{this.Name} Lançou Magia com {bonus} de bonus de fogo";
        }


    }
}