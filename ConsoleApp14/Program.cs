using System;
using System.Globalization;
using ASSLINQ;
using static ASSLINQ.ListGenerators;
class program
{
    static void Main(string[] args)
    {
        #region part1

        var ge = ProductList.First(x => x.UnitsInStock == 0);
        Console.WriteLine(ge);
        var gee = ProductList.FirstOrDefault(x => x.UnitPrice > 500);
        Console.WriteLine(gee);
        int[] numberss = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
        var isgreater5 = numberss.Where(x => x > 5).Skip(1).FirstOrDefault();
        Console.WriteLine(isgreater5);
        #endregion
        #region part2
        // 1
        int[] numbo = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
        var num = numbo.Where(x => x % 2 != 0);
        foreach (var x in num)
        {
            Console.WriteLine(x);
        }
        //2
        var customerss = CustomerList.Select(x => new { x.CustomerName, x.Orders.Length }).ToList();
        foreach (var customer in customerss)
        {
            Console.WriteLine(customer);
        }
        //3
        var cat = ProductList.Select(x => new { x.Category, x.ProductID }).ToList();
        foreach (var x in cat)
        {
            Console.WriteLine(x);
        }
        //4
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int total = numbers.Sum();
        Console.WriteLine(total);
        //5
        string[] wordd = File.ReadAllLines("dictionary_english.txt");
        var countword = wordd.Sum(s => s.Count());
        Console.WriteLine(countword);
        //6
        var shortest = wordd.Min(s => s.Count());
        Console.WriteLine(shortest);
        //7
        var longestw = wordd.Max(s => s.Count());
        Console.WriteLine(longestw);
        //8
        var avgw = wordd.Average(s => s.Count());
        Console.WriteLine(avgw);
        //9
        var totlunitstockbycat = ProductList.Select(x => new { x.UnitsInStock, x.Category });
        foreach (var x in totlunitstockbycat)
        {
            Console.WriteLine(x);
        }
        //10
        var cheap = ProductList.Min(x => x.UnitPrice);
        Console.WriteLine(cheap);
        #endregion
        #region part3

        //    //1
        //    var uniq = ProductList.Select(x => x.Category).Distinct();
        //    foreach (var x in uniq)
        //    {
        //        Console.WriteLine(x);
        //    }
        //    //2
        //    var productNames = ProductList
        //.Select(p => p.ProductName.Substring(0, 1));
        //    var customerNames = CustomerList.Select(c => c.CustomerName.Substring(0, 1));
        //    var uniqueFirstLetters = productNames.Union(customerNames).Distinct();
        //    foreach (var letter in uniqueFirstLetters)
        //    {
        //        Console.WriteLine(letter);
        //    }
        //    //3
        //    var commonFirstLetters = productNames.Intersect(customerNames).Distinct();
        //    foreach (var letter in commonFirstLetters)
        //    {
        //        Console.WriteLine(letter);
        //    }
        //    //4
        //    var uniqueProductFirstLetters = productNames.Except(customerNames).Distinct();
        //    foreach (var letter in uniqueProductFirstLetters)
        //    {
        //        Console.WriteLine(letter);
        //    }
        #endregion
        #region part4
        //1
        var w = wordd.Any(x => x.Contains("ei"));
        Console.WriteLine(w);
        //2
        var catstock = ProductList.Where(x => x.UnitsInStock == 0).Select(x => new { x.Category, x.ProductName });
        foreach (var x in catstock)
        {
            Console.WriteLine(x);
        }
        #endregion
    }
}

