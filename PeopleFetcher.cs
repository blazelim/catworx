using System;
using System.Collections.Generic;
using System.Net;
using System.Drawing;
using Newtonsoft.Json.Linq;

namespace CatWorx.BadgeMaker {
    class PeopleFetcher 
    {
        // code from GetEmployees() in Program.cs
        public static List<Employee> GetEmployees()
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

        public static List<Employee> GetFromApi() {
            List<Employee> employees = new List<Employee>();

            using (WebClient client = new WebClient())
            {
                // Image example
                string response = client.DownloadString("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                JObject json = JObject.Parse(response);
                foreach (JToken token in json.SelectToken("results")) {
                // Parse JSON data
                Employee emp = new Employee
                    (
                        token.SelectToken("name.first").ToString(),
                        token.SelectToken("name.last").ToString(),
                        Int32.Parse(token.SelectToken("id.value").ToString().Replace("-", "")),
                        token.SelectToken("picture.large").ToString()
                    );
                    employees.Add(emp);
    }
                }

            return employees;
        }
    }
}