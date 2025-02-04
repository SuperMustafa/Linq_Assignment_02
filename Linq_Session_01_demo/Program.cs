using System.Collections;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using Linq_Session_02_demo.MyData;
using static Linq_Session_02_demo.MyData.ListGenerator;

namespace Linq_Session_02_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operator [immediate execution and only work with fluent syntax]
            #region [First--if the returned value was null it throw an exeption]
            //get first element
            //var res = ProductList.First();
            //Console.WriteLine(res);

            ////get first element with condition 
            //var res = ProductList.First((P)=>P.UnitsInStock==0);
            //Console.WriteLine(res);


            #endregion
            #region [Last -- if the returned value was null it throw an exeption] 
            //var res = ProductList.Last();
            //Console.WriteLine(res);

            //get last element with condition 
            //var res = ProductList.Last((P) => P.UnitsInStock == 88888);
            //Console.WriteLine(res);

            #endregion
            #region [FirstOrDefault -- we can handle the exeption]
            //List<Product> Products = new List<Product>();
            //var res = Products.FirstOrDefault();
            //Console.WriteLine(res?.ProductName??"not found");
            #endregion
            #region [LastOrDefault -- we can handle the exeption]
            //List<Product> Products = new List<Product>();
            //var res = Products.LastOrDefault();
            //Console.WriteLine(res?.ProductName ?? "not found");
            #endregion
            #region [ElementAt --can not handle the exeption]
            //var res = ProductList.ElementAt(90);
            //Console.WriteLine(res);
            #endregion
            #region [ElementAtOrDefault --can handle the exeption]
            //var res = ProductList.ElementAtOrDefault(40);
            //Console.WriteLine(res?.ToString()??"Not found");
            #endregion
            #region [Single]
            //return one element that match the condition and if morthan element matchs the condition
            //it throw an exception and the sequence were empty it throw also exception
            // the main use of it that return only one element
            //var res = ProductList.Single((P) => P.UnitPrice == 200);

            //Console.WriteLine(res);


            #endregion
            #region [SingleOrDefault -- handle the exception]

            //var res = ProductList.SingleOrDefault((P) => P.UnitPrice == 200);

            //Console.WriteLine(res?.ToString()??"Not found");
            #endregion

            #endregion
            #region [Aggregate Opretaor]
            #region [Count]
            // returns the number of sequence elements and take overload parameter which is a condition that returns 
            // depends on it
            //var res = ProductList.Count((P)=>P.UnitPrice>10);
            //Console.WriteLine(res);
            #endregion
            #region [Max-Min]
            //return the max element at the sequence
            //var res = ProductList.Max((P)=>P.ProductName.Length);
            //Console.WriteLine(res);


            //return the Min element at the sequence

            //var res = ProductList.Min((P)=>P.ProductName.Length);
            //Console.WriteLine(res);

            #region [Hypird Syntax {Merge fluent syntax with query syntax}]
            //select first element that are the length of his name are equal to min length value


            //var minLengthOfName = ProductList.Min((P) => P.ProductName.Length); // must select the compare property 
            //var res = (from P in ProductList
            //          where P.ProductName.Length == minLengthOfName
            //          select P).FirstOrDefault();
            //Console.WriteLine(res);
            #endregion
            #endregion
            #region[Sum & Avg]
            //sum all elemnts based on Property
            //var res = ProductList.Sum((P) => P.UnitPrice);

            //calculate all elemnts average based on Property

            //var res = ProductList.Average((P) => P.UnitPrice);

            //Console.WriteLine(res);
            #endregion
            #region [Aggregate]

            //sum all the elements
            //======================Ex01=========================

            //string[] names = { "Mustafa", "Hamad", "Mohamed", "Hamad" };
            //var res = names.Aggregate((str01, str02) => $"{str01}{str02}");
            //Console.WriteLine(res);

            //======================Ex02=========================

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //var res = numbers.Aggregate((num1, num2) => {  return num1 + num2; });
            //Console.WriteLine(res);
            #endregion
            #endregion
            #region [Casting Operators -- immediate execution ]
            #region [ToList]
            //List<Product> res = ProductList.Where((P) => P.UnitPrice > 10).ToList();
            //foreach(var number in res){ Console.WriteLine(number); }
            #endregion
            #region[ToArray]

            //Product[] res = ProductList.Where((P) => P.UnitPrice > 10).ToArray();
            // foreach (var number in res) { Console.WriteLine(number); }
            #endregion
            #region [ToDectiniory]
            //Dictionary<long, Product> res = ProductList.Where((P) => P.UnitPrice > 10).ToDictionary((P) => P.ProductID);
            //foreach(var product in res) { Console.WriteLine($"{product.Key} ,{product.Value.ProductName}");} 




            #endregion
            #region [ToHashSet]

            #endregion
            #region [OfType]
            //ArrayList Elements =new ArrayList() { "Mustafa","Rewan","333",1,2,3 ,3.3,2.2};
            //var res = Elements.OfType<int>();
            //foreach (var element in res) { Console.WriteLine(element); }   
            #endregion

            #endregion
            #region [Generation Operators -- deferred execution -- they are static methods{call throw class }]

            #region [Range]
            //var res = Enumerable.Range(0, 100);
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region [Reapet]
            //var res = Enumerable.Repeat(1, 10);
            //foreach (var item in res) { Console.WriteLine(item); }
            #endregion
            #region [Empty]
            // craets a empty sequence
            //var res = Enumerable.Empty<Product>();
            //foreach (var item in res) { Console.WriteLine(item); }

            #endregion
            #endregion
            #region [Set Operators(union family)-- deferred execution]
            #region [Union]
            // merge to sequencies with out duplicats
            //int[]numbers01 = Enumerable.Range(0, 100).ToArray();
            //int[] numbers02 = Enumerable.Range(0,110).ToArray();
            //var res=numbers01.Union(numbers02);
            //foreach(int i in res) { Console.WriteLine(i); }  
            #endregion
            #region [Concat]
            //int[] numbers01 = Enumerable.Range(0, 100).ToArray();
            //int[] numbers02 = Enumerable.Range(0, 110).ToArray();
            //var res = numbers01.Concat(numbers02);
            //foreach (int i in res) { Console.WriteLine(i); }
            #endregion
            #region [intersect]
            //int[] numbers01 = Enumerable.Range(0, 100).ToArray();
            //int[] numbers02 = Enumerable.Range(0, 110).ToArray();
            //var res = numbers01.Intersect(numbers02);
            //foreach (int i in res) { Console.WriteLine(i); }
            #endregion
            #region [Except]
            //int[] numbers01 = Enumerable.Range(0, 111).ToArray();
            //int[] numbers02 = Enumerable.Range(0, 110).ToArray();
            //var res = numbers01.Except(numbers02);
            //foreach (int i in res) { Console.WriteLine(i); }
            #endregion


            #endregion
            #region [Quintifier Operators]
            #region [Any-- return true if sequence has any elements and false if not]
            //var res = ProductList.Any();
            //Console.WriteLine(res);
            //var res = ProductList.Any((P) => P.ProductName.Length <0);
            //Console.WriteLine(res);

            #endregion
            #region [All -- returns true if all elemnts equal to a condition and false if not]
            //var res = ProductList.All((P) => P.UnitPrice > 0);
            //Console.WriteLine(res);
            #endregion
            #region [Contains -- return true if the sequance has a specific element  and false of not]
            //var res = ProductList.Contains(new Product { ProductID = 2000, ProductName = "Mustafa" });
            //Console.WriteLine(res);
            #endregion
            #region [SequanceEqual-- check if two sequance are equal or not]
            //List<Product> Seq01= new List<Product>();
            //{ new Product() { ProductID = 1, ProductName = "Samsung", UnitPrice = 2000, UnitsInStock = 3, Category = "electronics" };
            //  new Product() { ProductID = 2, ProductName = "dell", UnitPrice = 3000, UnitsInStock = 3, Category = "electronics" };
            //  new Product() { ProductID = 3, ProductName = "Hb", UnitPrice = 4000, UnitsInStock = 3, Category = "electronics" };

            //}

            //List<Product> Seq02 = new List<Product>();
            //{
            //    new Product() { ProductID = 2, ProductName = "Samsung", UnitPrice = 2000, UnitsInStock = 3, Category = "electronics" };
            //    new Product() { ProductID = 2, ProductName = "dell", UnitPrice = 3000, UnitsInStock = 3, Category = "electronics" };
            //    new Product() { ProductID = 3, ProductName = "Hb", UnitPrice = 4000, UnitsInStock = 3, Category = "electronics" };

            //}

            //var res= Seq01.SequenceEqual( Seq02);
            //Console.WriteLine(res);

            #endregion

            #endregion
            #region [Transformation Operators]
            #region [Zip]
            // =======the first overLoad of zip======================

            //string[] names = { "one", "two", "three", "four", "five" };
            //int[] numbers = { 1, 2, 3, 4 ,5,6};
            //var res = names.Zip(numbers);
            ////foreach(var i in res) { Console.WriteLine(i); }

            //// =======the second overLoad of zip======================
            //var res02 = numbers.Zip(names, new string[] { "*", "*", "*", "*" });
            //foreach(var i in res02) { Console.WriteLine(i); }
            //#endregion
            //// zip operator takes smallest sequence and stop at the end of it


            //// =======the Third overLoad of zip======================
            //var res03 = names.Zip(numbers, (x, y) => $"{x}==>{y}");
            //foreach(var i in res03) { Console.WriteLine(i); }


            #endregion
            #endregion
            #region [Grouping Operators]
            #region [Group by]
            // ==================fluent syntax=====================
            //var res = ProductList.GroupBy((P) => P.Category);
            //foreach (var item in res) { Console.WriteLine("====================="+item.Key);

            //    foreach (var product in item) { Console.WriteLine(product); }

            //}

            //===============================EX02==========================
            //select categories that ar in stock and each category has more than ten products and
            // return product category with the count of products of it
            ////======================== query syntax=========================
            //var res = from P in ProductList
            //          where P.UnitsInStock > 0
            //          group P by P.Category
            //         into ProductGroup
            //          where ProductGroup.Count() > 10
            //          select new { ProductCategory = ProductGroup.Key, numberOFProducts = ProductGroup.Count() };
            //foreach (var item in res) { Console.WriteLine(item); }

            //=========================fluent syntax==========================

            //var res = ProductList.Where((P) => P.UnitsInStock > 0).GroupBy((P) => P.Category).Where((P) => P.Count() > 10)
            //    .Select(ProductGroup => new { ProductCategory = ProductGroup.Key, Productnumber = ProductGroup.Count() });
            //foreach (var item in res) { Console.WriteLine(item); }


            // =======================second over load of GroupBy================================

            //var res = ProductList.GroupBy((P) => P.Category,(P)=>P.ProductName);// select the property want to print
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item.Key+"====================================");
            //    foreach (var item2 in item) { Console.WriteLine(item2); }

            //}

            #endregion
            #region [Chunck]
            // int[] numbers = { 1, 2, 3 ,4,5,6,7,8,8};
            //var Chuncks = numbers.Chunk(3);
            //foreach (var ch in Chuncks)
            //{ foreach (var item in ch) { Console.Write(item);
            //    }

            //        Console.WriteLine();

            //}
            #endregion

            #endregion
            #region [Particioned Operators ]
            #region [take-- get first 5 elements out of stock]
            //var res01 = ProductList.Where((P) => P.UnitsInStock == 0).Take(1);
            //foreach (var item in res01) { Console.WriteLine(item); }

            #endregion
            #region [takeLast-- get last 5 elements out of stock]
            //var res = ProductList.Where((P) => P.UnitsInStock == 0).TakeLast(1);
            //foreach (var item01 in res) { Console.WriteLine(item01); }



            #endregion
            #region [skip ]
            //var res = ProductList.Where((P) => P.UnitsInStock == 0).Skip(1);
            //foreach (var item in res) { Console.WriteLine(item); }

            #endregion
            #region [skipLast ]
            //var res = ProductList.Where((P) => P.UnitsInStock == 0).SkipLast(2);
            //foreach (var item in res) { Console.WriteLine(item); }

            #endregion
            #region [Take while]
            // take number of the array while its number smaller than its zero index

            //int[] numbers = { -1, -2, -3, 1, 3, 30 };
            //var res = numbers.TakeWhile((num, Index) => num < Index);
            //foreach (int num in res) { Console.WriteLine(num); }

            #endregion
            #region [Skip while]
            //take number of the array while number moduls 2 ==0


            //int[] numbers = { 1, 1, 1, 2, 2, 2 };
            //var res = numbers.SkipWhile(Number=>Number%2!=0);
            //foreach (int num in res) { Console.WriteLine(num); }

            #endregion
            #endregion
            #region [let - into]
            //string[] names = { "Mustafa", "Rewan", "Hesham" };
            //var res = from n in names
            //          select Regex.Replace(n, "[aeiouAEIOU]", "")
            //          into nonVowelNames
            //          where nonVowelNames.Length > 3
            //          select nonVowelNames;
            //foreach (var name in res) { Console.WriteLine(name); }


            //===========================let===========================

            //string[] names = { "Mustafa", "Rewan", "Hesham" };
            //var res = from n in names
            //          let nonVowelNames = Regex.Replace(n, "[aeiouAEIOU]", "")
            //          where nonVowelNames.Length > 3
            //          select nonVowelNames;
            //foreach (var name in res) { Console.WriteLine(name); }
            #endregion
        }
    }
}
