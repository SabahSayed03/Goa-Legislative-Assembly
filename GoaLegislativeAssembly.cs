//Author:Sabah Sayed
//Roll No.:37
//Title:Implementation of Goa Legislative Assembly using OOP concept
//Start Date:22 july 2024
//Modified Date:22 july 2024
//Description:Implementation of Goa Legislative Assembly using OOP concept.This program has Main class , Member class, Committe class, Bill class.



using System;
using System.Collections.Generic;

// Main class
public class GoaLegislativeAssembly
{
    public static void Main(string[] args)
    {
        var members = new List<Member>();
        var committees = new List<Committee>();
        var bills = new List<Bill>();
        var scanner = new Scanner();

        while (true)
        {
            Console.WriteLine("\nGoa Legislative Assembly Management System");
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. View Members");
            Console.WriteLine("3. Add Committee");
            Console.WriteLine("4. View Committees");
            Console.WriteLine("5. Add Bill");
            Console.WriteLine("6. View Bills");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");
            var choice = int.Parse(scanner.NextLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Member Name: ");
                    var memberName = scanner.NextLine();
                    Console.Write("Enter Constituency: ");
                    var constituency = scanner.NextLine();
                    members.Add(new Member(memberName, constituency));
                    Console.WriteLine("Member added successfully.");
                    break;
                case 2:
                    Console.WriteLine("Members of the Assembly:");
                    foreach (var member in members)
                    {
                        Console.WriteLine(member);
                    }
                    break;
                case 3:
                    Console.Write("Enter Committee Name: ");
                    var committeeName = scanner.NextLine();
                    Console.Write("Enter Chairman: ");
                    var chairman = scanner.NextLine();
                    committees.Add(new Committee(committeeName, chairman));
                    Console.WriteLine("Committee added successfully.");
                    break;
                case 4:
                    Console.WriteLine("Committees of the Assembly:");
                    foreach (var committee in committees)
                    {
                        Console.WriteLine(committee);
                    }
                    break;
                case 5:
                    Console.Write("Enter Bill Title: ");
                    var billTitle = scanner.NextLine();
                    Console.Write("Enter Introduced By: ");
                    var introducedBy = scanner.NextLine();
                    bills.Add(new Bill(billTitle, introducedBy));
                    Console.WriteLine("Bill added successfully.");
                    break;
                case 6:
                    Console.WriteLine("Bills in the Assembly:");
                    foreach (var bill in bills)
                    {
                        Console.WriteLine(bill);
                    }
                    break;
                case 7:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

// Scanner class to simulate java.util.Scanner
public class Scanner
{
    public string NextLine()
    {
        return Console.ReadLine();
    }
}

// Member class
public class Member
{
    public string Name { get; set; }
    public string Constituency { get; set; }

    public Member(string name, string constituency)
    {
        Name = name;
        Constituency = constituency;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Constituency: {Constituency}";
    }
}

// Committee class
public class Committee
{
    public string Name { get; set; }
    public string Chairman { get; set; }

    public Committee(string name, string chairman)
    {
        Name = name;
        Chairman = chairman;
    }

    public override string ToString()
    {
        return $"Committee: {Name}, Chairman: {Chairman}";
    }
}

// Bill class
public class Bill
{
    public string Title { get; set; }
    public string IntroducedBy { get; set; }

    public Bill(string title, string introducedBy)
    {
        Title = title;
        IntroducedBy = introducedBy;
    }

    public override string ToString()
    {
        return $"Bill Title: {Title}, Introduced By: {IntroducedBy}";
    }
}
