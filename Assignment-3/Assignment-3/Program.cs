using System;
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
    }
}
class BankAccount
{
    public string AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; private set; }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}, Remaining Balance: {Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    public void DisplayAccount()
    {
        Console.WriteLine($"Account: {AccountNumber}, Holder: {AccountHolderName}, Balance: {Balance}");
    }
}
static class MathHelper
{
    public static double CalculateAverage(int[] numbers)
    {
        double sum = 0;
        foreach (var num in numbers) sum += num;
        return numbers.Length > 0 ? sum / numbers.Length : 0;
    }
}
static class Logger
{
    public static void LogMessage(string message)
    {
        Console.WriteLine($"[LOG] {message}");
    }
}

partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
partial class Person
{
    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}
partial class Employee2
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }
    public double Bonus { get; set; }
}
partial class Employee2
{
    public double CalculateSalary()
    {
        return BaseSalary + Bonus;
    }
}

abstract class Shape
{
    public abstract double CalculateArea();
}
class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea() => Math.PI * Radius * Radius;
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double CalculateArea() => Width * Height;
}

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void MakeSound();
}
class Dog : Animal
{
    public override void MakeSound() => Console.WriteLine("Woof! Woof!");
}
class Cat : Animal
{
    public override void MakeSound() => Console.WriteLine("Meow!");
}

class Vehicle
{
    public void StartEngine() => Console.WriteLine("Engine started.");
    public void StopEngine() => Console.WriteLine("Engine stopped.");
}
sealed class Car : Vehicle { }
class BankAccount2
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }
}
sealed class SavingsAccount : BankAccount2
{
    public double InterestRate { get; set; }
    public double CalculateInterest() => Balance * InterestRate / 100;
}
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee { Name = "om_kul", Age = 24, Salary = 100000 };
        emp.DisplayDetails();

        BankAccount acc = new BankAccount { AccountNumber = "12345", AccountHolderName = "Om Kulshrestha" };
        acc.Deposit(10000);
        acc.Withdraw(5000);
        acc.DisplayAccount();

        int[] nums = { 10, 20, 30, 40 };
        Console.WriteLine("Average: " + MathHelper.CalculateAverage(nums));

        Logger.LogMessage("This is a log entry.");

        Person p = new Person { FirstName = "Om", LastName = "Kulshrestha" };
        p.PrintFullName();

        Employee2 e2 = new Employee2 { Name = "Rahul", BaseSalary = 40000, Bonus = 5000 };
        Console.WriteLine($"Total Salary: {e2.CalculateSalary()}");

        Shape circle = new Circle { Radius = 5 };
        Shape rect = new Rectangle { Width = 4, Height = 6 };
        Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
        Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}");

        Animal dog = new Dog { Name = "Max", Age = 3 };
        Animal cat = new Cat { Name = "Cutie", Age = 2 };
        dog.MakeSound();
        cat.MakeSound();

        Car myCar = new Car();
        myCar.StartEngine();
        myCar.StopEngine();

        SavingsAccount sa = new SavingsAccount { AccountNumber = "67890", Balance = 10000, InterestRate = 5 };
        Console.WriteLine($"Interest: {sa.CalculateInterest()}");
    }
}
