using System.Globalization;
using System.Linq;
using static Assignment02LINQ.ListGenerators;
namespace Assignment02LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Element Operators

            #region Q01 :Get first Product out of Stock

            //var Result = ProductList.FirstOrDefault(P => P.UnitsInStock == 0);
            //Console.WriteLine(Result);


            #endregion


            #region Q02 : Return the fi rst product whose Price > 1000, unless there is no match, in which case null is returned.

            //var Result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(Result);


            #endregion


            #region Q03 : Retrieve the second number greater than 5
            //int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            //var Result = Arr.Where(A => A > 5).OrderBy(A=> A).Skip(1).FirstOrDefault();

            //Console.WriteLine(Result);
            #endregion

            #endregion


            #region LINQ - Aggregate Operators

            #region Q01 : Uses Count to get the number of odd numbers in the array 
            //int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            //var Result = Arr.Count(A => A % 2 != 0);
            //Console.WriteLine(Result);

            #endregion

            #region Q02 : Return a list of customers and how many orders each has.


            // var Result = CustomerList.Select(C => new { CustomerDatales = C, OrderCount = C.Orders.Count() });

            //foreach (var item in Result) 
            //     Console.WriteLine(item);
            #endregion

            #region Q03 : Return a list of categories and how many products each has
            //var Result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, ProductCount = g.Count() });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q04 : Get the total of the numbers in an array.
            //int [] Arr = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            //var Result = Arr.Sum();

            //Console.WriteLine(Result);

            #endregion

            #region Q05 : Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string file = "dictionary_english.txt";

            //string[] dictionary_english = File.ReadAllLines(file);


            //var Result = dictionary_english.Sum(D => D.Length);

            //Console.WriteLine(Result);

            #endregion

            #region Q06 : Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string file = "dictionary_english.txt";

            //string[] dictionary_english = File.ReadAllLines(file);


            //var Result = dictionary_english.Min(D => D.Length);

            //Console.WriteLine(Result);

            #endregion


            #region Q07 : Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string file = "dictionary_english.txt";

            //string[] dictionary_english = File.ReadAllLines(file);


            //var Result = dictionary_english.Max(D => D.Length);

            //Console.WriteLine(Result);


            #endregion


            #region Q08 : Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //string file = "dictionary_english.txt";

            //string[] dictionary_english = File.ReadAllLines(file);


            //var Result = dictionary_english.Average(D => D.Length);

            //Console.WriteLine(Result);

            #endregion


            #region Q09 : Get the total units in stock for each product category
            //var Result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key,SumUnitsInStock = g.Sum(P=> P.UnitsInStock) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q10 :Get the cheapest price among each category's products
            //var Result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, MinUnitPrice = g.Min(P => P.UnitPrice) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q11 : Get the products with the cheapest price in each category (Use Let)
            //var Result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key,  product = g.MinBy(P => P.UnitPrice) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q12 : Get the most expensive price among each category's products.
            //var Result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, MaxUnitPrice = g.Max(P => P.UnitPrice) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q13  :  Get the products with the most expensive price in each category
            //var Result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, product = g.MaxBy(P => P.UnitPrice) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Q14 : Get the average price of each category's products
            //var Result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, AVGUnitPrice = g.Average(P => P.UnitPrice) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #endregion

            #region LINQ - Set Operators

            #region Q01 : Find the unique Category names from Product List
            //var Result = ProductList.Select(P=> P.Category).Distinct();

            //foreach (var result in Result)
            //    Console.WriteLine( result);
            #endregion

            #region Q02 : Produce a Sequence containing the unique first letter from both product and customer names.
            //var ProductFirstLetter = ProductList.Select(p => p.ProductName[0]);


            //var CustomerFirstLetter = CustomerList.Select(c => c.CustomerName[0]);

            //var Result = ProductFirstLetter.Concat(CustomerFirstLetter).Distinct();

            //foreach (var result in Result)
            //    Console.WriteLine(result);

            #endregion

            #region Q03 : Create one sequence that contains the common first letter from both product and customer names.
            //var productFirstLetters = ProductList.Select(p => p.ProductName[0]);  

            //var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);

            //var common = productFirstLetters.Intersect(customerFirstLetters).Distinct();

            //foreach (var item in common) 
            //    Console.WriteLine(item);


            #endregion

            #region Q04 : Create one sequence that contains the first letters of product names that are not also fi rst letters of customer names.
            //var productFirstLetters = ProductList.Select(p => p.ProductName[0]);

            //var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);

            //var common = productFirstLetters.Except(customerFirstLetters).Distinct();

            //foreach (var item in common)
            //    Console.WriteLine(item);

            #endregion


            #region Q05 : Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var productLast3Letters = ProductList.Select(p => p.ProductName.Length>=3 ? p.ProductName.Substring(p.ProductName.Length-3): p.ProductName);

            //var customerLast3Letters = CustomerList.Select(c => c.CustomerName.Length >= 3 ? c.CustomerName.Substring(c.CustomerName.Length - 3) : c.CustomerName);

            //var common = productLast3Letters.Concat(customerLast3Letters).Distinct();

            //foreach (var item in common)
            //    Console.WriteLine(item);




            #endregion


            #endregion

            #region LINQ - Quantifiers

            #region Q01 : Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string file = "dictionary_english.txt";

            //string[] dictionary_english = File.ReadAllLines(file);


            //var Result = dictionary_english.Any(D=> D.Contains("ei"));

            //Console.WriteLine(Result);
            #endregion

            #region Q02 :Return a grouped a list of products only for categories that have at least one product that is out of stock.

            // var Result = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0)).ToList();

            //foreach (var item in Result)
            //     Console.WriteLine(item.Key);


            #endregion


            #region Q03  : Return a grouped a list of products only for categories that have all of their products in stock.

            //var Result = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock > 0)).ToList();

            //foreach (var item in Result)
            //    Console.WriteLine(item.Key);
            #endregion

            #endregion




        }
    }
}
