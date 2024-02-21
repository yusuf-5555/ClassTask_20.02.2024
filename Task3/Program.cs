
var p = new Person();
System.Console.Write("Enter player's name: ");
p.Name = Console.ReadLine();
System.Console.Write("Enter player's number: ");
p.Number = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter player's position: ");
p.Position = Console.ReadLine();
System.Console.Write("Enter player's team: ");
p.Team = Console.ReadLine();

p.GetInfo();
p.ScoreGoal();
p.AssistGoal("Neymar");



// naqsha
public class Person
{
    public string Name; 
    public int Number;
    public string Position;
    public string Team;

    public void GetInfo()
    
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Number: {Number}");
        System.Console.WriteLine($"Position: {Position}");
        System.Console.WriteLine($"Team: {Team}");
    }
      public void ScoreGoal()
    {
        Console.WriteLine($"Player {Name} scores a goal.");
    }
    public void AssistGoal(string playerName)
    {
        Console.WriteLine($"Player {Name} assists a goal for {playerName}.");
    }
}