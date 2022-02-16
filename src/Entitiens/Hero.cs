namespace PooComJogo.src.Entitiens
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public string HeroType { get; set; }

        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public void Print()
        {
            System.Console.WriteLine(this.Name + " " + this.Level + " " + this.HeroType);
        }

        public virtual string Attack(){
            return this.Name + " Atacou com a sua espada";
        }

    }
}