using System;
using System.Threading;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LinqAss1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment
            #region LINQ - Restriction Operators
            // var Result= ListGenerator.ProductsList.Where(P=>P.UnitsInStock==0);
            // Result = ListGenerator.ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.0M);
            // var result = ListGenerator.ProductsList
            //.Select((P, I) => new { ProductName = P.ProductName, Index = I }) 
            //.Where(P => P.ProductName.Length < P.Index) 
            //.Select(P => P.Index);
            // foreach (var Unit in result) 
            // {
            //     Console.Write($"{Unit},");
            // }
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Select((A, I) => new {Name=A,Index=I}).Where((A,I)=>A.Name.Length<A.Index).Select(X=>X.Index).ToList();
            //foreach (var i in result) { 
            //    Console.WriteLine(i);
            //}
            #endregion
            #region LINQ - Element Operators
            //var Result = ListGenerator.ProductsList.First(X => X.UnitsInStock == 0);
            //Result = ListGenerator.ProductsList.FirstOrDefault(X => X?.UnitPrice > 1000M);
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(X=>X>5).Skip(1).FirstOrDefault();
            //result = Arr.FirstOrDefault(X => X > 5);
            //Console.WriteLine(result);
            //Console.WriteLine(Result?.ProductName ?? "Not Found");
            #endregion
            #region LINQ - Aggregate Operators
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(X => X % 2 != 0);
            //Console.WriteLine(result);
            //var CustomerOrder = ListGenerator.CustomersList.Select(C => new
            //{
            //    CustomeID = C.CustomerID,
            //    CustomerName = C.CustomerName,
            //    Order = C.Orders.Length

            //});
            //foreach (var c in CustomerOrder) { 
            //    Console.WriteLine(c);
            //}

            //var CategoryProduct = ListGenerator.ProductsList.GroupBy(C => C.Category).Select(C => new { 

            //    Category=C.Key,
            //    ProductCount=C.Count()
            //});
            //foreach (var c in CategoryProduct)
            //{
            //    Console.WriteLine(c);
            //}

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Sum();
            //Console.WriteLine(result);

            //string[] words = File.ReadAllLines("dictionary_english.txt");
            //var result=words.Sum(X=>X.Length);
            //Console.WriteLine(result);
            //var shortest=words.Min(X=>X.Length);
            //Console.WriteLine(shortest);
            //var longest = words.Max(X => X.Length);
            //Console.WriteLine(longest);
            //var avg=words.Average(X=>X.Length);
            //Console.WriteLine(avg);
            #endregion
            #region LINQ - Ordering Operators
            //var result=ListGenerator.ProductsList.OrderBy(P=>P.ProductName);
            //foreach (var item in result) { 
            //Console.WriteLine(item);
            //}
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result=Arr.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);
            //foreach (string str in result) { 
            //    Console.WriteLine(str);
            //}
            //var orderByUnit=ListGenerator.ProductsList.OrderByDescending(P=>P.UnitsInStock);
            //foreach (var unit in orderByUnit) { 
            //    Console.WriteLine(unit);
            //}
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result=Arr.OrderByDescending(x => x.Length).ThenBy(X=>X);
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            //string [] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).ThenBy(X=>X,StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //var result=ListGenerator.ProductsList.OrderBy(P=>P.Category).ThenByDescending(P=>P.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).ThenByDescending(X => X, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result=Arr.Where(X => X[1]=='i').Reverse();
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion
            #region LINQ – Transformation Operators
            //var list=ListGenerator.ProductsList.Select(x => x.ProductName);
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"ProductName: {item}");
            //}
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(X => new {
            //    UpperCase=X.ToUpper(),
            //    LowerCase=X.ToLower(),   
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"ProductName: {item}");
            //}
            //var result=ListGenerator.ProductsList.Select(x => new
            //{
            //    x.ProductName,
            //    x.ProductID,
            //    Price= x.UnitPrice,
            //    x.Category
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"ProductDetails: {item}");
            //}
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((E, index) => new { Element = E ,InPlace=E == index });
            //Console.WriteLine("Number: In-Place?");
            //foreach (var i in result)
            //{
            //    Console.WriteLine($"{i.Element}: {i.InPlace}");
            //}
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A=a,B=b};
            //Console.WriteLine("Pairs Where A<B");
            //foreach (var ele in result) { Console.WriteLine($"{ele.A} < {ele.B}"); }

            //var result = ListGenerator.CustomersList.SelectMany(c => c.Orders).Where(o=>o.Total<500);
            //foreach (var o in result)
            //{
            //    Console.WriteLine(o);
            //}
            //var result = ListGenerator.CustomersList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >=1998);
            //foreach (var o in result)
            //{
            //    Console.WriteLine(o);
            //}
            #endregion
            #endregion
            #region Demo of Linq
            #region Filtration [Restrication] Operators - Where
            //var result=ListGenerator.ProductsList.Where(p=>p.UnitsInStock==0);
            //result = ListGenerator.ProductsList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry");
            //result = from p in ListGenerator.ProductsList
            //         where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //         select p;
            //foreach (var unit in result) { 

            //    Console.WriteLine(unit);
            //}
            #endregion
            #region Transformation[Projection] Operators[Select, Select Many]
            //var result=from p in ListGenerator.ProductsList
            //           select p.ProductName;
            //result = ListGenerator.CustomersList.Select(c => c.CustomerName);
            //foreach (var unit in result)
            //{

            //    Console.WriteLine(unit);
            //}
            //var Result = ListGenerator.CustomersList.SelectMany(c => c.Orders);
            //foreach (var unit in Result)
            //{

            //    Console.WriteLine(unit);
            //}
            //var Result = ListGenerator.ProductsList.Select(p => new {p.ProductID,p.ProductName});
            //var Result = ListGenerator.ProductsList.Where(p=>p.UnitsInStock>0).Select(p => 
            //new { p.ProductID,
            //    p.ProductName ,
            //    OldPrice=p.UnitPrice,
            //    NewPrice=p.UnitPrice*.1M,
            //});

            //foreach (var unit in Result)
            //{

            //    Console.WriteLine(unit);
            //}
            #endregion
            #region Ording Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]
            //var result=ListGenerator.ProductsList.OrderBy(p=>p.UnitPrice);
            //var result=ListGenerator.ProductsList.OrderByDescending(p=>p.UnitPrice);
            //var result=ListGenerator.ProductsList.OrderBy(p=>p.UnitPrice).ThenBy(p=>p.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Elements Operator -Immediate Execution[Valid Only With Fluent Syntax]
            //var result=ListGenerator.ProductsList.First();
            //List<string>Test = new List<string>();
            //var Result=Test.FirstOrDefault();
            //// Unhandeled exciption error so use FirstOrDefault
            //Result=ListGenerator.ProductsList.Last().ToString();
            //var output=ListGenerator.ProductsList.FirstOrDefault(X=>X.ProductID==1);
            //Console.WriteLine(Result);
            //int[] list = [1, 2, 3, 4, 5, 6, 7, 8];
            //var test=list.ElementAt(0);// 1 to find element in this index
            //test = list.ElementAtOrDefault(2);
            //Console.WriteLine(test);// 3 but it is used for empty not to make error
            ////Console.WriteLine(result);
            //var result=ListGenerator.ProductsList.Single(p=>p.UnitPrice==0);
            //// throw exciption in no element or more that one element
            //var result = ListGenerator.ProductsList.SingleOrDefault(p => p.UnitPrice == 0);
            //Console.WriteLine(result);
            #endregion
            #region Aggregate Operators  - Immediate Execution
            //int[] Arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //var result=Arr.Max(x => x);
            //result =Arr.Min(x => x);
            //var test = ListGenerator.ProductsList.Count();
            //test=ListGenerator.ProductsList.Count(X=>X.UnitsInStock==0);
            //Console.WriteLine(test);
            //Console.WriteLine(result);
            //var sum=Arr.Sum(x => x);
            //var avg=Arr.Average(x => x);
            //Console.WriteLine(avg);
            //Console.WriteLine(sum);
            #endregion
            #endregion

        }
    }
}
