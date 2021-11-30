// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {

    static List<Employee> GetEmployees()
    {
      // I will return a lost of strings
      List<Employee> employees = new List<Employee>();
      while (true)
      {        
        Console.WriteLine("Enter First Name: (leave empty to exit)");
        string firstName = Console.ReadLine();
        // Break if the user hits ENTER without typing a name
        if (firstName == "")
        {
          break;
        }

        // add a Console.ReadLine() for each value
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter ID: ");
        int id = Int32.Parse(Console.ReadLine());
        Console.Write("Enter Photo URL:");
        string photoUrl = Console.ReadLine();
        Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
        
        // add current employee not a string
        employees.Add(currentEmployee);
      }

      return employees;
    }

    static void PrintEmployees(List<Employee> employees)
    {
      for (int i = 0; i < employees.Count; i++) 
      {
        string template = "{0,-10}\t{1,-20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
      }
    }

    static void Main(string[] args) // entry point
    {   
      // this is our employee getting code now
      List<Employee> employees = GetEmployees();
      PrintEmployees(employees);
    }
  }
}