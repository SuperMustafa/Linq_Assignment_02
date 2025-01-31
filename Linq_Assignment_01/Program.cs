using System.Security.Cryptography;
using Linq_Session_02_demo.MyData;
using static Linq_Session_02_demo.MyData.ListGenerator;


namespace Linq_Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Get first Product out of Stock
            //var res = ProductList.First((P) =>P.UnitsInStock==0);
            //Console.WriteLine(res);

            #endregion
            #region Q2  Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var res = ProductList.FirstOrDefault((P) => P.UnitPrice > 1000);
            //Console.WriteLine(res?.ToString()??"Not found");

            #endregion
            #region Q3 Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int secondNumber = Arr.Where((n) => n > 5).OrderBy((n) => n).ElementAt(1);

            //Console.WriteLine(secondNumber);

            #endregion
            #region Q4 Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddNumbers = Arr.Count((P) => P % 2 == 1);
            //Console.WriteLine(oddNumbers);
            #endregion
            #region Q5 Return a list of customers and how many orders each has
            //var res = CustomerList.Select((C) =>
            //new { CustmorName = C.CustomerName, OrderCount = C.Orders.Aggregate(0, (count, _) => count + 1) });
            //foreach (var item in res) { Console.WriteLine(item); }


            #endregion
            #region Q6  Return a list of categories and how many products each has
            //var categoryCounts = ProductList
            // .GroupBy(p => p.Category)
            // .Select(g => new { Category = g.Key, Count = g.Count() });


            //foreach (var item in categoryCounts)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Count: {item.Count}");
            //}
            #endregion
            #region Q7 Get the total of the numbers in an array.
            // int [] numbers =new int [] {1,2,3,4,5};
            //int res = numbers.Sum();
            //Console.WriteLine(res);
            #endregion
            #region Q8 Get the total number of characters of all words in dictionary_english.txt

            //    string FilePath = "C:\\Users\\ascom\\Downloads\\dictionary_english.txt";
            //    string[] words = File.ReadAllLines(FilePath);


            //    int totalCharacters = words.Sum((word) => word.Length);

            //    Console.WriteLine($"Total number of characters in all words: {totalCharacters}");
            //}


            #endregion
            #region Q9  Get the length of the shortest word in dictionary_english.txt

            //string FilePath = "C:\\Users\\ascom\\Downloads\\dictionary_english.txt";
            //string[] words = File.ReadAllLines(FilePath);
            //var minLength = words.Min((n) => n.Length);
            //Console.WriteLine(minLength);
            #endregion
            #region Q10  Get the length of the longest word in dictionary_english.txt
            //string FilePath = "C:\\Users\\ascom\\Downloads\\dictionary_english.txt";
            //string[] words = File.ReadAllLines(FilePath);
            //var minLength = words.Max((n) => n.Length);
            //Console.WriteLine(minLength);

            #endregion
            #region Q11 Get the average length of the words in dictionary_english.txt
            //string FilePath = "C:\\Users\\ascom\\Downloads\\dictionary_english.txt";
            //string[] words = File.ReadAllLines(FilePath);
            //double AvgLength = words.Average((n) => n.Length);
            //Console.WriteLine(AvgLength);

            #endregion
            #region Q12  Get the total units in stock for each product category.

            //var totalUnitsByCategory = ProductList
            //.GroupBy(p => p.Category)
            //.Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });
            //foreach (var item in totalUnitsByCategory) { Console.WriteLine(item); }
            #endregion
            #region Q13 Get the cheapest price among each category's products

            //var res = ProductList.GroupBy((P) => P.Category).Select((g => new // g here is every and each element
            //{ CategoryName = g.Key, CheapestPrice = g.Min((P) => P.UnitPrice) }));
            //foreach (var item in res) { Console.WriteLine(item); }

            #endregion
            #region Q14 Get the most expensive price among each category's products.

            //var res = ProductList.GroupBy((P) => P.Category).Select((g => new // g here is every and each element
            //{ CategoryName = g.Key, MostExpensivePrice = g.Max((P) => P.UnitPrice) }));
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region Q15  Get the average price of each category's products.

            //var res = ProductList.GroupBy((P) => P.Category).Select((g => new // g here is every and each element
            //{ CategoryName = g.Key, AveragePrice = g.Average((P) => P.UnitPrice) }));
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region Q16  Find the unique Category names from Product List
            //var res = ProductList.Select((P) => P.Category).Distinct();
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region Q17  Produce a Sequence containing the unique first letter from both product and customer names.


            //var uniqueFirstLetters = ProductList
           //.Select(p => p.ProductName[0]) // Get first letter of product names
           //.Union(CustomerList.Select(c => c.CustomerName[0])) // Get first letter of customer names, merge them
           //.Distinct();
           // foreach (var uniqueFirstLetter in uniqueFirstLetters) { Console.WriteLine(uniqueFirstLetter); }
           
           
            #endregion

        }

    }
}