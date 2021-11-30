using System;
using System.Collections.Generic;
using System.IO;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        // Method declared as 'static'
        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++) 
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
            }  
        }

        public static void MakeCSV(List<Employee> employees) {
            // check to see if folder exists
            if (!Directory.Exists("data"))
            {
                // if not, create it
                Directory.CreateDirectory("data");
            }

            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                // Any code that needs the Sreamwriter would go here.
                file.WriteLine("ID, Name,PhotoUrl");

                // Loop over employees
                for (int i=0; i < employees.Count; i++) 
                {
                    // write each employee to the file
                    string template = "{0},{1},{2}";
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
                }
            }

        }
    }
}