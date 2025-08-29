using Demo03.Models;
using Demo03.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DbContext
            //CompanyDbContext context = new CompanyDbContext();
            //try
            //{
            //    // Some Code
            //}
            //finally
            //{
            //    context.Dispose();
            //}

            //using(CompanyDbContext context = new CompanyDbContext())
            //{
            //    // Some Code
            //} 

            //using CompanyDbContext context = new CompanyDbContext();
            #endregion

            #region Migrations
            //using CompanyDbContext context = new CompanyDbContext();

            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //var Result = context.Employees.Where(E => E.Name == "Hamada").FirstOrDefault();
            // select top(1) * from Employees as e where e.EmpName = N"Hamada"

            //Console.WriteLine(Result);

            //context.Database.Migrate(); 
            #endregion

            #region CRUD Operations
            using CompanyDbContext context=new CompanyDbContext();

            #region Add (Create)
            //Employee emp01 = new Employee()
            //{
            //    Name="Omar",
            //    Age=24,
            //    Salary=3_000
            //};
            //Employee emp02 = new Employee()
            //{
            //    Name = "Youssef",
            //    Age = 20,
            //    Salary = 5_000
            //};
            //Console.WriteLine($"Employee 01 {context.Entry(emp01).State}");//Detached
            //Console.WriteLine($"Employee 02 {context.Entry(emp02).State}");

            ////Added ways
            ////first way
            //context.Employees.Add( emp01);
            //context.Employees.Add( emp02);
            //////second way
            ////context.Add(emp01);
            ////context.Add(emp02);
            //////third way
            ////context.Set<Employee>().Add( emp01);
            ////context.Set<Employee>().Add( emp02);
            //Console.WriteLine($"Employee 01 {context.Entry(emp01).State}");//Added
            //Console.WriteLine($"Employee 02 {context.Entry(emp02).State}");

            //context.SaveChanges();

            //Console.WriteLine($"Employee 01 : {context.Entry(emp01).State}");//Unchanged
            //Console.WriteLine($"Employee 02 : {context.Entry(emp02).State}"); 
            #endregion

            #region Select
            //context.ChangeTracker.QueryTrackingBehavior=QueryTrackingBehavior.NoTracking;

            //var result = context.Employees.AsTracking().FirstOrDefault(E=>E.Salary>4_000);

            //Console.WriteLine(result.Name);

            //Console.WriteLine($"Employee 01 : {context.Entry(result).State}"); 
            #endregion

            #region Update
            //var Result=(from E in context.Employees
            //           where E.Id==1
            //           select E).FirstOrDefault();

            //if(Result != null )
            //{
            //    Console.WriteLine($"Employee 01 : {context.Entry(Result).State}");
            //    Console.WriteLine($"Employee Name : {Result.Name}");
            //    Console.WriteLine($"Employee Name : {Result.Salary}");

            //    Result.Salary = 4_000;

            //    Console.WriteLine($"Employee 01 : {context.Entry(Result).State}");
            //    Console.WriteLine($"Employee Name : {Result.Name}");
            //    Console.WriteLine($"Employee Name : {Result.Salary}");

            //    context.SaveChanges();
            //    Console.WriteLine($"Employee 01 : {context.Entry(Result).State}");
            //} 
            #endregion

            #region Delete
            //var Result = (from E in context.Employees
            //              where E.Id == 1
            //              select E).FirstOrDefault();

            //if(Result != null)
            //{
            //    Console.WriteLine($"Employee 01 : {context.Entry(Result).State}");

            //    //Remove ways 
            //    //first way
            //    context.Employees.Remove(Result);
            //    ////second way
            //    //context.Remove(Result);
            //    ////third way 
            //    //context.Set<Employee>().Remove(Result);
            //    Console.WriteLine($"Employee 01 : {context.Entry(Result).State}");

            //    context.SaveChanges();

            //    Console.WriteLine($"Employee 01 : {context.Entry(Result).State}");
            //} 
            //var Result = (from E in context.Employees
            //              where E.Id == 2
            //             select E).FirstOrDefault();
            //if (Result != null)
            //{
            //    Console.WriteLine($"Employee 01 : {context.Entry(Result).State}");

            //    //Remove ways 
            //    //first way
            //    context.Employees.Remove(Result);
            //    context.SaveChanges();
            //}
                #endregion

                #endregion


            }
    }
}
