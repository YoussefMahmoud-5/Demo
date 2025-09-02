using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Demo03.Contexts;
using Demo03.Models;

namespace Demo03.Data_Seeding
{
    internal static class CompanyDbContextSeed
    {
        public static bool DataSeeding(CompanyDbContext context)
        {
            try
            {
                if (!context.Employees.Any())
                {

                    // Step 01: Read Data From File
                    var EmployeeData = File.ReadAllText("files\\employees.json");
                    // Step 02: Deserialize Data 
                    var Employees = JsonSerializer.Deserialize<List<Employee>>(EmployeeData);
                    // Step 03: Insert Data Into Database .. seed the database
                    if (Employees?.Count > 0)
                    {
                        context.Employees.AddRange(Employees);
                        context.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Seeding Error!");
                Console.WriteLine($"Message: {ex.Message}");
                if (ex.InnerException != null)
                    Console.WriteLine($"Inner: {ex.InnerException.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                return false;
            }

        }
    }
}
