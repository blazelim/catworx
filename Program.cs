// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {

    static List<string> GetEmployees()
    {
      // I will return a lost of strings
      List<string> employees = new List<string>();
      while (true)
      {        
        Console.WriteLine("Please enter a name: ");
        string input = Console.ReadLine();
        // Break if the user hits ENTER without typing a name
        if (input == "")
        {
          break;
        }
        employees.Add(input);
      }
      return employees;
    }

    static void PrintEmployees(List<string> employees)
    {
      for (int i = 0; i<employees.Count; i++)
      {
        Console.WriteLine(employees[i]);
      }
    }

        static void Main(string[] args) // entry point
    {   
      // this is our employee getting code now
      List<string> employees = GetEmployees();
      PrintEmployees(employees);
    }
  }
}