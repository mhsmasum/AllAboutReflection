// See https://aka.ms/new-console-template for more information
using UseOfReflection;

public class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Hi there");

        Battle aBattle = new Battle(new Thief());
        Battle aBattle2 = new Battle(new Wizard());
        aBattle.RearAttack();
        aBattle2.RearAttack();


        Console.WriteLine("Hi there with reflection");

        BetterBattle aBattle3 = new BetterBattle(new ProjectManager());
        BetterBattle aBattle4 = new BetterBattle(new Fighter());
        aBattle3.RearAttack();
        aBattle4.RearAttack();

    }
}
