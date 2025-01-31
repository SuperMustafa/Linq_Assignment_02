using System.Collections;
using System.Reflection.Metadata;
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
        }
    }
}
