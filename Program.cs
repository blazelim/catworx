// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;


namespace CatWorx.BadgeMaker
{
  class Program
  {



    static void Main(string[] args) // entry point
    {   
      // this is our employee getting code now
      // List<Employee> employees = GetEmployees();
      // Util.PrintEmployees(employees);
      // Util.MakeCSV(employees);

        List<Employee> employees = new List<Employee>();
        // employees = GetEmployees();
        employees = PeopleFetcher.GetFromApi();
        Util.MakeCSV(employees);
        Util.MakeBadges(employees);
    }
  }
}