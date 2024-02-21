var p = new Person();
System.Console.Write("Enter your Firstname: ");
p.FirstName = Console.ReadLine();
System.Console.Write("Enter your LastName : ");
p.LastName = Console.ReadLine();
System.Console.Write("Enter your Age : ");
p.Age = Convert.ToInt32(Console.ReadLine());

p.GetInfo();



// naqsha
public class Person
{
    public string FirstName; 
    public string LastName;
    public int Age;

    public void GetInfo()
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"FirstName: {FirstName}");
        System.Console.WriteLine($"LastName: {LastName}");
        System.Console.WriteLine($"Age: {Age}");
    }
}