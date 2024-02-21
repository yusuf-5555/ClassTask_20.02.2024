var p = new Person();
System.Console.Write("Enter employee's FirstName: ");
p.FirstName = Console.ReadLine();
System.Console.Write("Enter employee's LastName: ");
p.LastName = Console.ReadLine();
System.Console.Write("Enter employee's Age: ");
p.Age = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Enter employee's Position: ");
p.Position = Console.ReadLine();
System.Console.Write("Enter employee's Salary: ");
p.Salary = Convert.ToDecimal(Console.ReadLine());
p.GetInfo();
System.Console.WriteLine("-----------------");
System.Console.Write("Set a new Salary: ");
p.SetSalary(Convert.ToDecimal(Console.ReadLine()));
p.GetInfo();



// naqsha
public class Person
{
    public string FirstName; 
    public string LastName;
    public int Age;
    public string Position;
    public decimal Salary;

    public void GetInfo()
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"FirstName: {FirstName}");
        System.Console.WriteLine($"LastName: {LastName}");
        System.Console.WriteLine($"Age: {Age}");
        System.Console.WriteLine($"Position: {Position}");
        System.Console.WriteLine($"Salary: {Salary}");
    }
    public void SetSalary(decimal salary)
    {
Salary = salary;
    }
}
