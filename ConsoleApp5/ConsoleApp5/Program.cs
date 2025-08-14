using System;
using System.Collections.Generic;

class UserProfile
{
    private string username;
    private string password;
    private string email;

    public void SetUsername(string name) { username = name; }
    public string GetUsername() { return username; }

    public void SetPassword(string pass)
    {
        if (pass.Length >= 6) password = pass;
        else Console.WriteLine("Password must be at least 6 characters.");
    }
    public string GetPassword() { return password; }

    public void SetEmail(string mail)
    {
        if (mail.Contains("@")) email = mail;
        else Console.WriteLine("Invalid email.");
    }
    public string GetEmail() { return email; }
}

class Vehicle
{
    public string Make;
    public string Model;
    public int Year;
}

class Truck : Vehicle
{
    public void DisplayDetails()
    {
        Console.WriteLine($"Truck: {Make} {Model}, {Year}");
    }
}

class Bus : Vehicle
{
    public void DisplayDetails()
    {
        Console.WriteLine($"Bus: {Make} {Model}, {Year}");
    }
}

class Calculator
{
    public int Add(int a, int b) => a + b;
    public float Add(float a, float b) => a + b;
    public double Add(double a, double b, double c) => a + b + c;
}

abstract class Employee
{
    public string Name;
    public abstract double CalculateSalary();
}

class FullTimeEmployee : Employee
{
    public double MonthlySalary;
    public override double CalculateSalary() => MonthlySalary;
}

class PartTimeEmployee : Employee
{
    public double HourlyRate;
    public int HoursWorked;
    public override double CalculateSalary() => HourlyRate * HoursWorked;
}

class Student
{
    public string Name;
    public int RollNo;
    public double Marks;

    public Student()
    {
        Name = "Unknown";
        RollNo = 0;
        Marks = 0;
    }

    public Student(string name, int roll)
    {
        Name = name;
        RollNo = roll;
        Marks = 0;
    }

    public Student(string name, int roll, double marks)
    {
        Name = name;
        RollNo = roll;
        Marks = marks;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Roll No: {RollNo}, Marks: {Marks}");
    }
}

class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }

    private double price;
    public double Price
    {
        get => price;
        set
        {
            if (value >= 0) price = value;
            else Console.WriteLine("Price cannot be negative.");
        }
    }

    public int Quantity { get; set; }

    public void PrintDetails()
    {
        Console.WriteLine($"Product ID: {ProductID}, Name: {ProductName}, Price: {Price}, Quantity: {Quantity}");
    }
}

class Book
{
    public string Title;
    public bool IsAvailable = true;
}

class Member
{
    public string Name;
    public List<Book> BorrowedBooks = new List<Book>();
}

class Library
{
    public List<Book> Books = new List<Book>();
    public List<Member> Members = new List<Member>();

    public void RegisterMember(Member m)
    {
        Members.Add(m);
        Console.WriteLine($"Member {m.Name} registered.");
    }

    public void LendBook(Book book, Member member)
    {
        if (book.IsAvailable)
        {
            book.IsAvailable = false;
            member.BorrowedBooks.Add(book);
            Console.WriteLine($"{member.Name} borrowed {book.Title}");
        }
        else
        {
            Console.WriteLine($"{book.Title} is not available.");
        }
    }

    public void DisplayAvailableBooks()
    {
        foreach (var book in Books)
        {
            if (book.IsAvailable)
                Console.WriteLine($"Available: {book.Title}");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Experiment 1:");
        var user1 = new UserProfile();
        user1.SetUsername("om_kulshrestha");
        user1.SetPassword("om@123");
        user1.SetEmail("omkulshrestha24@gmail.com");
        Console.WriteLine($"User: {user1.GetUsername()}, Email: {user1.GetEmail()}");

        var user2 = new UserProfile();
        user2.SetUsername("rahul");
        user2.SetPassword("rahul@123");
        user2.SetEmail("rahulverma29@gmail.com");

        Console.WriteLine("\nExperiment 2:");
        var truck = new Truck { Make = "Tata", Model = "LPT", Year = 2020 };
        var bus = new Bus { Make = "Volvo", Model = "9400", Year = 2022 };
        truck.DisplayDetails();
        bus.DisplayDetails();

        Console.WriteLine("\nExperiment 3:");
        var calc = new Calculator();
        Console.WriteLine(calc.Add(5, 3));
        Console.WriteLine(calc.Add(4.5f, 3.2f));
        Console.WriteLine(calc.Add(1.1, 2.2, 3.3));

        Console.WriteLine("\nExperiment 4:");
        var ft = new FullTimeEmployee { Name = "John", MonthlySalary = 50000 };
        var pt = new PartTimeEmployee { Name = "Jane", HourlyRate = 200, HoursWorked = 30 };
        Console.WriteLine($"{ft.Name} Salary: {ft.CalculateSalary()}");
        Console.WriteLine($"{pt.Name} Salary: {pt.CalculateSalary()}");

        Console.WriteLine("\nExperiment 5:");
        var s1 = new Student();
        var s2 = new Student("Rahul", 101);
        var s3 = new Student("Sneha", 102, 89.5);
        s1.Display();
        s2.Display();
        s3.Display();

        Console.WriteLine("\nExperiment 6:");
        var p1 = new Product { ProductID = 1, ProductName = "Mouse", Price = 599, Quantity = 10 };
        var p2 = new Product { ProductID = 2, ProductName = "Keyboard", Price = -100, Quantity = 5 };
        p1.PrintDetails();
        p2.PrintDetails();

        Console.WriteLine("\nExperiment 7:");
        var library = new Library();
        library.Books.Add(new Book { Title = "C# Basics" });
        library.Books.Add(new Book { Title = "OOP Concepts" });
        var member = new Member { Name = "Karan" };
        library.RegisterMember(member);
        library.LendBook(library.Books[0], member);
        library.DisplayAvailableBooks();
    }
}