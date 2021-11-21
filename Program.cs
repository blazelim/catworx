// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args) // entry point
    {   
        List<string> employees = new List<string>() { "adam", "amy" };
        employees.Add("barbara");
        employees.Add("billy");

        for (int i = 0; i < employees.Count; i++) 
        {
        Console.WriteLine(employees[i]);
        }
    }
  }
}