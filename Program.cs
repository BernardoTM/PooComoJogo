using PooComJogo.src.Entitiens;


namespace PooComJogo
{
    class Program
    {
        static void Main(string[] orgs)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 24, "Devil");

            System.Console.WriteLine(arus.Attack());
            System.Console.WriteLine(wizard.Attack());
            System.Console.WriteLine(wizard.Attack(5));
            System.Console.WriteLine(wizard.Attack(7));

            System.Console.WriteLine("\n------------------");

            arus.Print();
            wizard.Print();
            
        }
    }
}