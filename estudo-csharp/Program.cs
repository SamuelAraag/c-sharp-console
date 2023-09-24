// See https://aka.ms/new-console-template for more information
using System.Globalization;
using estudo_csharp.Entities;
using estudo_csharp.Entities.Enums;
using estudo_csharp.Extension;

Console.WriteLine("Enter departament's name: ");
string? deptName = Console.ReadLine();


Console.WriteLine("Enter worker data: ");
Console.WriteLine("Name: ");
string? name = Console.ReadLine();

Console.WriteLine("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.WriteLine("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


Departament dept = new Departament(deptName);
Worker worker = new Worker(name, level, baseSalary, dept);


Console.WriteLine("How many contracts to this worker?");
int n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data: ");
    Console.Write($"Date: ");
    DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", new CultureInfo("pt-BR"), DateTimeStyles.None, out DateTime date);
    Console.Write($"Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write($"Duration (hours): ");

    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract(date, valuePerHour, hours);

    worker.AddContract(contract);
}

Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.GetMonth());
int year = int.Parse(monthAndYear.GetYear());


Console.WriteLine("Name: "+worker.Name);
Console.WriteLine("Department: "+worker.Departament.Name);
Console.WriteLine($"Income for: {monthAndYear}: {worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");


Console.ReadLine();
