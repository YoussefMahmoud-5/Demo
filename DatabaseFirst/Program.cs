using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using NorthwindDbContext context = new NorthwindDbContext();
            //var Result = context.Products.ToList();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            #region DQL [Select statment]
            // var Result = context.Products.FromSqlRaw("Select * from Products where CategoryId = 1");
            // int catId = 1;
            //// Result=context.Products.FromSqlRaw("Select * from Products where CategoryId = {0}",catId);

            // Result=context.Products.FromSqlInterpolated($"Select * from Products where CategoryId ={catId}");

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item.ProductName);
            // } 
            #endregion

            #region DML [Update statment]
            // //var Result = context.Database.ExecuteSqlRaw("Update Products set ProductName = 'Test' where ProductId = 89 ");
            // int productId = 89;

            //// var Result = context.Database.ExecuteSqlRaw("Update Products set ProductName = 'Test' where ProductId = {0} ",productId);

            // var Result = context.Database.ExecuteSqlInterpolated($"Update Products set ProductName = 'Test' where ProductId = {productId} ");

            // Console.WriteLine(Result); 
            #endregion
        }
    }
}
