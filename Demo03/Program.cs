using Demo03.Models;
using Demo03.Contexts;
using Microsoft.EntityFrameworkCore;
using Demo03.Data_Seeding;
using Demo03.Inheritance_Models;

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
            // using CompanyDbContext context=new CompanyDbContext();

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

            #region Data Seeding
            // using CompanyDbContext context = new CompanyDbContext();
            #region Manul Data Seeding
            //Department Dept01 = new Department()
            //{
            //    Code = 101,
            //    DateOfCreation = new DateOnly(2025, 05, 23),
            //    DepartmentName = "HR"
            //};
            //context.Set<Department>().Add(Dept01);
            //context.SaveChanges();
            //List<Department> departments = new List<Department>()
            //{
            //    new Department() {Code=99,DateOfCreation=new DateOnly(2021,03,19),DepartmentName="Sales" },
            //    new Department() {Code=100,DateOfCreation=new DateOnly(2023,07,1),DepartmentName ="Software Engineering" },
            //    new Department() {Code=105,DateOfCreation=new DateOnly(2024,12,25),DepartmentName="Markting" }
            //};
            //context.Set<Department>().AddRange(departments);
            //context.SaveChanges(); 
            #endregion
            #region using Migration
            //On DbContext
            #endregion
            #region Dynamic Data Seeding
            //CompanyDbContextSeed.DataSeeding(context);
            #endregion
            #endregion

            #region Loading Related Data
            // using CompanyDbContext context = new CompanyDbContext();
            #region Eager Loading
            #region Example 01 02
            //var Emp01 = context.Employees.Include(E => E.EmployeeDepartment)
            //                           .ThenInclude(D => D.Manager)
            //                           .FirstOrDefault(E => E.EmpId == 4);
            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee Name: {Emp01.EmpName}");
            //    Console.WriteLine($"Department Id: {Emp01.DepartmentId}");
            //    Console.WriteLine($"Department Name: {Emp01.EmployeeDepartment.DepartmentName}");
            //    Console.WriteLine($"Manger Id: {Emp01.EmployeeDepartment.MngID}");
            //    Console.WriteLine($"Manger Name: {Emp01.EmployeeDepartment.Manager.EmpName}");
            //} 
            #endregion
            #region Example 03
            //var Emp01 = context.Employees.Include(E => E.ManagedDepartment)
            //                           .FirstOrDefault(E => E.EmpId == 2);
            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee Name: {Emp01.EmpName}");
            //    Console.WriteLine($"Department Id: {Emp01.DepartmentId}");
            //    Console.WriteLine($"Department Name: {Emp01.ManagedDepartment.DepartmentName}");
            //    //Console.WriteLine($"Manger Id: {Emp01.EmployeeDepartment.MngID}");
            //    //Console.WriteLine($"Manger Name: {Emp01.EmployeeDepartment.Manager.EmpName}");
            //} 
            #endregion
            #endregion

            #region Explicit Loading
            #region Example 01
            //var Emp01 = context.Employees.FirstOrDefault(E => E.EmpId == 1);
            //if (Emp01 != null)
            //{
            //    Console.WriteLine($"Employee Name: {Emp01.EmpName}");
            //    Console.WriteLine($"Department Id: {Emp01.DepartmentId}");
            //    context.Entry(Emp01).Reference(E => E.EmployeeDepartment).Load();
            //    Console.WriteLine($"Department Name: {Emp01.EmployeeDepartment.DepartmentName}");

            //} 
            #endregion

            #region Example 02
            //var Dept=context.Set<Department>().FirstOrDefault(D=>D.DeptId==3);
            //if(Dept != null )
            //{
            //    Console.WriteLine($"Department name : {Dept.DepartmentName}");
            //    context.Entry(Dept).Collection(D => D.Employees).Load();
            //    foreach(var emp in  Dept.Employees)
            //    {
            //        Console.WriteLine($"---------{emp.EmpName}");
            //    }
            //} 
            #endregion
            #endregion

            #region Lazy Loading
            #region Example 01
            //var Emp01 = context.Employees.FirstOrDefault(E => E.EmpId == 1);

            //if(Emp01 != null)
            //{
            //    Console.WriteLine($"Employee Name: {Emp01.EmpName}");
            //    Console.WriteLine($"Employee Id: {Emp01.EmpId}");
            //    Console.WriteLine($"Department Name: {Emp01.EmployeeDepartment.DepartmentName}");
            //} 
            #endregion
            #endregion
            #endregion

            #region Joins
            //using CompanyDbContext context = new CompanyDbContext();
            #region Join()

            //Query 

            //var Result = from D in context.Set<Department>()
            //             join E in context.Employees
            //             on D.DeptId equals E.DepartmentId
            //             select new
            //             {
            //                 E.EmpId,
            //                 E.EmpName,
            //                 D.DeptId,
            //                 D.DepartmentName
            //             };

            //Fluent 
            //var Result = context.Set<Department>().Join(context.Employees,
            //                                           D => D.DeptId,
            //                                           E => E.DepartmentId,
            //                                           (D, E) => new
            //                                           {
            //                                               E.EmpId,
            //                                               E.EmpName,
            //                                               D.DeptId,
            //                                               D.DepartmentName
            //                                           });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region GroupJoin()
            //Fluent Syntax
            //var Result = context.Set<Department>().GroupJoin(context.Employees,
            //                                                D => D.DeptId,
            //                                                E => E.DepartmentId,
            //                                                (D, Employees) => new
            //                                                {
            //                                                    Department = D,
            //                                                    Employees
            //                                                });

            //Query Syntax
            //var Result = from D in context.Set<Department>()
            //             join E in context.Employees
            //             on D.DeptId equals E.DepartmentId
            //             into Employees
            //             select new
            //             {
            //                 Department = D,
            //                 Employees
            //             };


            //foreach(var item in  Result)
            //{
            //    Console.WriteLine(item.Department.DepartmentName);
            //    foreach(var employee in item.Employees)
            //    {
            //        Console.WriteLine($"----------: {employee.EmpName}");
            //    }
            //} 
            #endregion


            #region Cross Join
            //var Result = context.Set<Department>().SelectMany(D => context.Employees.Select(E => new
            //                                                    {
            //                                                        Employee = E,
            //                                                        Department = D
            //                                                    }));

            //var Result = from D in context.Set<Department>()
            //             from E in context.Employees
            //             select new
            //             {
            //                 Employee = E,
            //                 Department = D
            //             };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.Employee.EmpName} :: {item.Department.DepartmentName}");
            //} 
            #endregion
            #endregion

            #region Mapping Inheritance Classes
            //using InhertanceDbContext context = new InhertanceDbContext();
            //FullTimeEmployee FTE= new FullTimeEmployee() 
            //{
            //    Name="Omar",
            //    Address="Cairo",
            //    Age=24,
            //    Salary=5_000,
            //    StartDate=new DateOnly(2024,09,15)
            //};
            //PartTimeEmployee PTE = new PartTimeEmployee()
            //{
            //    Name = "Youssef",
            //    Address = "Hehia",
            //    Age = 20,
            //    CountofHours = 100,
            //    HourRate = 150
            //};

            #region TPC
            //context.Add(FTE);
            //context.Add(PTE);
            //Console.WriteLine( context.SaveChanges());

            //var full = context.FullTimeEmployees.FirstOrDefault();
            //var part=context.PartTimeEmployees.FirstOrDefault();
            //Console.WriteLine(full.Name);
            //Console.WriteLine(part.Name); 
            #endregion

            #region TPH
            //context.Employees.Add(PTE);
            //context.Add(FTE);
            //Console.WriteLine(context.SaveChanges());

            //var Result=from E in context.Employees
            //           select E;
            //if(Result != null)
            //{
            //    //foreach(var E in Result)
            //    //{
            //    //    Console.WriteLine($"{E.Name} :: {E.Age}");
            //    //}
            //    foreach(var full in Result.OfType<FullTimeEmployee>())
            //    {
            //        Console.WriteLine($"{full.Name} :: {full.Age} :: {full.Salary}");
            //    }

            //    foreach (var part in Result.OfType<PartTimeEmployee>())
            //    {
            //        Console.WriteLine($"{part.Name} :: {part.Age} :: {part.CountofHours}");
            //    }
            //} 
            #endregion

            #region TPT

            //context.PartTimeEmployees.Add(PTE);
            //context.FullTimeEmployees.Add(FTE);

            //Console.WriteLine(context.SaveChanges());

            //var full = context.FullTimeEmployees.FirstOrDefault();
            //var part =context.PartTimeEmployees.FirstOrDefault();
            //Console.WriteLine($"{full.Name} :: {full.Salary}");
            //Console.WriteLine("----------");
            //Console.WriteLine($"{part.Name} :: {part.HourRate}"); 
            #endregion
            #endregion

            #region Local
            //using InhertanceDbContext context = new InhertanceDbContext();

            #region Example 01
            //var Result = context.Employees.Local.Any(E => E.Age != null);//Search in data in localy in program => don't send request to database
            //Console.WriteLine(Result);
            //Result = context.Employees.Any(E => E.Age != null);
            //Console.WriteLine(Result); 
            #endregion

            #region Example 02
            //var Emp01 = context.Employees.FirstOrDefault();
            //if(Emp01 != null )
            //{
            //    Console.WriteLine(Emp01.Age);
            //}
            //var Result = context.Employees.Local.Any(E => E.Age != null);
            //Console.WriteLine(Result);
            //Result = context.Employees.Any(E => E.Age != null);
            //Console.WriteLine(Result); 
            #endregion
            #endregion

            using CompanyDbContext context = new CompanyDbContext();
            var Result= context.EmployeeDepartmentView.ToList();
            foreach(var result in Result)
            {
                Console.WriteLine($"{result.EmployeeName} : {result.DepartmentName}");
            }



        }
    }
}
