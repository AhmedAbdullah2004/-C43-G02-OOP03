using System;
using System.Globalization;
using static Assignment.Employee;
namespace Assignment
{
    // 1
    //class Employee
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    private string gender;

    //    public string Gender
    //    {
    //        get => gender;
    //        set
    //        {
    //            if (value != "M" && value != "F")
    //            {
    //                Console.WriteLine("Error: Gender must be 'M' or 'F'.");
    //                Environment.Exit(1);
    //            }
    //            gender = value;
    //        }
    //    }
    //    public Employee(int id, string name, string gender, SecurityLevel securityPrivilege, decimal salary, DateTime hireDate)
    //    {
    //        ID = id;
    //        Name = name;
    //        Gender = gender;
    //        SecurityPrivilege = securityPrivilege;
    //        Salary = salary;
    //        HireDate = hireDate;
    //    }
    //    public enum SecurityLevel
    //    {
    //        Guest,
    //        Developer,
    //        Secretary,
    //        DBA
    //    }
    //    public SecurityLevel SecurityPrivilege { get; set; }
    //    public decimal Salary { get; set; }
    //    public DateTime HireDate { get; set; }

    //    public override string ToString()
    //    {
    //        return string.Format(CultureInfo.CurrentCulture,
    //            "ID: {0}, Name: {1}, Gender: {2}, Role: {3}, Salary: {4:C}, Hire Date: {5:dd/MM/yyyy}",
    //            ID, Name, Gender, SecurityPrivilege, Salary, HireDate);
    //    }
    //}
    // 2
    //class HiringDate
    //{
    //    public int Day;
    //    public int Month;
    //    public int Year;

    //    public HiringDate(int day, int month, int year)
    //    {
    //        Day = day;
    //        Month = month;
    //        Year = year;
    //    }

    //    public string GetFormattedDate()
    //    {
    //        return $"{Day:D2}/{Month:D2}/{Year}";
    //    }
    //}

    // 3
    //class Employees
    //{
    //    #region Properties
    //    public string Name { get; set; }
    //    public string Role { get; set; }
    //    public string Permissions { get; set; }
    //    #endregion
    //    #region Constructor
    //    public Employees(string name, string role, string permissions)
    //    {
    //        Name = !string.IsNullOrWhiteSpace(name) ? name : "Unknown";
    //        Role = role;
    //        Permissions = permissions;
    //    }
    //    #endregion
    //    #region Method
    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Name: {Name}, Role: {Role}, Permissions: {Permissions}");
    //    }
    //    #endregion
    //}

    // 4
    //class employees
    //{
    //    public string Name { get; set; }
    //    public DateTime HireDate { get; set; }

    //    public employees(string name, DateTime hireDate)
    //    {
    //        Name = name;
    //        HireDate = hireDate;
    //    }

    //    public override string ToString()
    //    {
    //        return $"{Name} ({HireDate.ToShortDateString()})";
    //    }
    //}
    // 5
    //Book
    //class Book
    //{
    //    public string Title { get; set; }
    //    public string Author { get; set; }
    //    public string ISBN { get; set; }

    //    public Book(string title, string author, string isbn)
    //    {
    //        Title = title;
    //        Author = author;
    //        ISBN = isbn;
    //    }

    //    public virtual void DisplayDetails()
    //    {
    //        Console.WriteLine($"Title: {Title}");
    //        Console.WriteLine($"Author: {Author}");
    //        Console.WriteLine($"ISBN: {ISBN}");
    //    }
    //}
    ////EBook
    //class EBook : Book
    //{
    //    public double FileSize { get; set; } 

    //    public EBook(string title, string author, string isbn, double fileSize)
    //        : base(title, author, isbn)
    //    {
    //        FileSize = fileSize;
    //    }

    //    public override void DisplayDetails()
    //    {
    //        base.DisplayDetails();
    //        Console.WriteLine($"File Size: {FileSize} MB");
    //    }
    //}
    ////PrintedBook
    //class PrintedBook : Book
    //{
    //    public int PageCount { get; set; }

    //    public PrintedBook(string title, string author, string isbn, int pageCount)
    //        : base(title, author, isbn)
    //    {
    //        PageCount = pageCount;
    //    }

    //    public override void DisplayDetails()
    //    {
    //        base.DisplayDetails();
    //        Console.WriteLine($"Page Count: {PageCount}");
    //    }
    //}


    class Program
        {
            static void Main(string[] args)
            {
            #region 1-Design and implement a Class for the employees in a company:
            //Employee emp1 = new Employee(1, "Ahmed", "M", SecurityLevel.DBA, 75000, new DateTime(2004, 8, 5));
            //Console.WriteLine(emp1);
            #endregion

            #region 2-Develop a Class to represent the Hiring Date Data:
            //HiringDate HD = new HiringDate(12, 1, 2025);
            //Console.WriteLine("Hiring Date: " + HD.GetFormattedDate());
            #endregion

            #region 3-Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //Employees[] EmpArr = new Employees[3];

            //EmpArr[0] = new Employees("Ahmed", "DBA", "Database Access");
            //EmpArr[1] = new Employees("Khaled", "Guest", "Read-Only Access");
            //EmpArr[2] = new Employees("Malak", "Security Officer", "Full Access");

            //foreach (var emp in EmpArr)
            //{
            //    emp.DisplayInfo();
            //}
            #endregion

            #region 4-Sort the employees based on their hire date then Print the sorted array.
        //    var employees = new List<employees>
        //{
        //    new employees("Ahmed", new DateTime(2004, 8, 5)),
        //    new employees("Khaled", new DateTime(2002, 3, 15)),
        //    new employees("Malak", new DateTime(2006, 2, 10))
        //};

        //    int boxingCount = 0;
        //    int unboxingCount = 0;

        //    employees.Sort((e1, e2) =>
        //    {
        //        long ticks1 = e1.HireDate.Ticks; 
        //        long ticks2 = e2.HireDate.Ticks; 
        //        unboxingCount += 2;

        //        int result = ticks1.CompareTo(ticks2); 
        //        boxingCount++;

        //        return result;
        //    });

        //    Console.WriteLine("Sorted Employees:");
        //    foreach (var employee in employees)
        //    {
        //        Console.WriteLine(employee);
        //    }

        //    Console.WriteLine($"\nBoxing Count: {boxingCount}");
        //    Console.WriteLine($"Unboxing Count: {unboxingCount}");
            #endregion

            #region 5- Design a program for a library management system where:
            //EBook ebook = new EBook("Land of Zykola", "Ahmed", "123-456-789", 15.5);
            //Console.WriteLine("EBook Details:");
            //ebook.DisplayDetails();

            //PrintedBook printedBook = new PrintedBook("C#", "Khaled", "987-654-321", 350);
            //Console.WriteLine("PrintedBook Details:");
            //printedBook.DisplayDetails();

            #endregion
        }
        }
    }

