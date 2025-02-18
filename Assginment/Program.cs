
using System.Collections.Generic;
using Assginment.Demo;
using Assginment.Demo.Data;
using static Assginment.Demo.ListGenerator;

namespace Assginment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Demo

            #region Implicitly Typed Local Variable [Var , Dynamic]

            #region Var

            //// string Data = "Ahmed";

            //var Data = "Ahmed"; // Implicit Type
            //                    // Compiler WillDetect The Datatype Of Variable at Compilation Time
            //                    // Based On its Intial Value

            //// var X = null; // Invalid
            //// Var Can't be Intialized With null

            //Data = null; // Valid

            //// Data = 5; // Invalid
            //// After Intialization , You can't change the type of Var

            //// var X; // Invalid
            //// Var Must be Intialized

            #endregion

            #region Dynamic

            //dynamic Data = "Adham";
            //// Clr Will Detect Datatype Of Variable At Runtime
            //// Based On it's last Assigned value

            //dynamic X; // Valid
            //// Can Declare Variable With Dynamic Without Intialization;

            //dynamic Y = null; // Valid
            //// Can Be Intialized With NUll

            //Data = 2;

            //// After intialization , You Can Change Datatype of Variable

            //Data = true;
            //Data = 3.3;
            //Data = 'A';

            #endregion

            // Can't Use Var in Parameter Or Return Type Or Attribute at Class
            // We Use It Only To Declare Local Variable

            //for (var i = 0; i < 10; i++) { }
            //foreach (var item in args) { }

            //Var Is Recommended
            //Errors => Compilation Time

            // var X = null; // Compilation Error

            //dynamic Y = null;
            //Console.WriteLine(Y); //RuntimeBinderException

            #endregion

            #region Extension Methods

            //int X = 12345;

            //// int Y = IntExtension.Reverse(X);

            //int Y = X.Reverse();

            //Console.WriteLine(Y);

            #endregion

            #region Anonymous Type

            ////object Emp01 = new { Id = 10, Name = "Adham", Salary = 1000 };

            ////Console.WriteLine(Emp01.Salary); // Invalid

            //var Emp02 = new { Id = 10, Name = "Adham", Salary = 1000 };

            ////Emp02.Salary = 2000; Invalid

            //var Emp03 = new { Id = Emp02.Id, Name = Emp02.Name, Salary = 2000 }; // Till C# 9

            //var Emp04 = Emp03 with { Salary = 2000 }; // C# 10 Feature .Net 6

            //Console.WriteLine($"Emp 02 = {Emp02.GetType().Name}"); // AnonymousType0`3
            //Console.WriteLine($"Emp 03 = {Emp03.GetType().Name}"); // AnonymousType0`3
            //Console.WriteLine($"Emp 04 = {Emp04.GetType().Name}"); // AnonymousType0`3

            //// The Anonymous Type As Long As : 
            //// 1. Same Properties Name [Case Senstive]
            //// 2. Same Properties Order

            //var Emp05 = new { id = 10, Name = "Adham", Salary = 1000 };
            //Console.WriteLine($"Emp 05 = {Emp05.GetType().Name}"); // AnonymousType1`3

            #endregion

            #region What Is LINQ

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> OddNumbers = Numbers.Where(Num => Num % 2 != 0).ToList();

            //foreach (int number in OddNumbers)
            //    Console.WriteLine(number);

            //// You Can Use "LINQ Operator" Against The Data [Stored in Sequence]
            //// Regardless Data Store [Sql server , Oracle , MySql]

            //// Sequence => The Object From Vlass That Impelement Built In Interface "IEnmerable"
            //// 1. Local -> Static [L2Object] , XML File [L2XML]
            //// 2. Remote -> [L2EF]

            #endregion

            #region LINQ Syntax [Fluent Syntax , Query Syntax]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region Fluent Syntax

            //// 1. Fluent Syntax
            ////    1.1 Call "LINQ Operators" as Static Method

            //var OddNumbers = Enumerable.Where(Numbers, X => X % 2 == 1);

            ////    1.2 Call "LINQ Operators" as Extension Method [Recommended]

            //OddNumbers = Numbers.Where(X => X % 2 == 1);

            //foreach (var item in OddNumbers)
            //{
            //    Console.WriteLine(item); // 1 3 5 7 9
            //}

            #endregion

            #region Query Syntax - Like SQL Server Style

            //// 3. Select *
            //// 1. From Numbers N
            //// 2. Where N % 2 == 1

            //var OddNumbers = from N in Numbers
            //                 where N % 2 == 1
            //                 select N;

            //// Must Be Begin With Keyword "From"
            //// Must Be End With Select OR GroupBy


            //foreach (var Number in OddNumbers)
            //{
            //    Console.Write($"{Number} ");
            //}

            #endregion

            #endregion

            #region Execution Ways

            #region Deferred Execution [Latest Version Of Data]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(X => X % 2 == 1); // 1 3 5 7 9

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //// Where Is Executed With Deferred Execution

            //foreach (var Number in OddNumbers)
            //{
            //    Console.Write($"{Number} ");
            //}

            #endregion

            #region Immediate Execution [Elements Operators , Casting Operators , Aggregate Operators]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var OddNumbers = Numbers.Where(X => X % 2 == 1).ToList(); // 1 3 5 7 9

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });
            //// Where Is Executed With Immediate Execution

            //foreach (var Number in OddNumbers)
            //{
            //    Console.Write($"{Number} ");
            //}

            #endregion

            #endregion

            #region Data Setup

            //Console.WriteLine(ProductsList[0]);

            //Console.WriteLine(CustomersList[0]);

            #endregion


            #region LINQ Categories

            #region 1. Filtration [Restriction] Operators - Where

            #region Get Products Out Of Stock

            //// Get Products Out Of Stock
            //// Fluent Syntax
            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);

            //// Query Syntax
            //Result = from P in ProductsList
            //         where P.UnitsInStock == 0
            //         select P;

            #endregion

            #region Get Products In Stock & Category Meat/Poultry

            //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.Category == "Meat/Poultry");

            //Result = from P in ProductsList
            //         where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //         select P;

            #endregion

            // Indexed Where

            //var Result = ProductsList.Where((P, I) => P.UnitsInStock == 0 && I < 10);

            //foreach (var Product in Result)
            //    Console.WriteLine(Product);

            #endregion

            #region 2. Transformation [Projection] Operators [Select , Select Many]

            //var Result = ProductsList.Select(P => P.ProductName);

            //Result = from P in ProductsList
            //         select P.ProductName;

            //var Result02 = ProductsList.Select(P => new { P.ProductID, P.ProductName });

            //var Result03 = ProductsList.Where(P => P.UnitsInStock > 0)
            //    .Select(P => new
            //    {
            //        Id = P.ProductID,
            //        Name = P.ProductName,
            //        OldPrice = P.UnitPrice,
            //        NewPrice = P.UnitPrice * 0.9M,
            //    });

            //Result03 = from P in ProductsList
            //           where P.UnitsInStock > 0
            //           select new
            //           {
            //               Id = P.ProductID,
            //               Name = P.ProductName,
            //               OldPrice = P.UnitPrice,
            //               NewPrice = P.UnitPrice * 0.9M
            //           };

            //var Result = ProductsList.Where(P => P.UnitsInStock > 0)
            //    .Select((P, I) => new
            //    {
            //        Serial = I + 1,
            //        Name = P.ProductName
            //    });

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            ////var Result = CustomersList.SelectMany(C => C.Orders);

            //var Result = CustomersList.SelectMany(C => C.Orders, (C, O) => new { C.CustomerName, O.OrderID });


            //Result = from C in CustomersList
            //         from O in C.Orders
            //         select new
            //         {
            //             C.CustomerName,
            //             O.OrderID
            //         };

            //var Result = CustomersList.SelectMany((C, cIndex) =>
            //C.Orders.Select((O, oIndex) => new
            //{ CustomerIndex = cIndex + 1, C.CustomerName, OrderIndex = oIndex + 1, O.OrderID }));

            //List<int> Numbers = [ 1,2,3,4,5,6,7];
            //List<char> Letters = ['A', 'B', 'C', 'D', 'E', 'F' ];

            ////var Result = Numbers.Zip(Letters);

            //List<string> words = ["First", "Second", "Third", "Fourth", "Fifth"];

            ////var Result = Numbers.Zip(Letters , words);

            //var Result = Numbers.Zip(Letters , (N , L) => $"NUmber {N} Zipped With Letter {L}");

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Ording Operators [Ascending , Descending , Reverse , ThenBy , ThenByDescending]

            // var Result = CustomersList.Order();
            //// At least one one object must implement IComparaple.

            //var Result = CustomersList.OrderBy(C => C.CustomerID);

            //var Result = CustomersList.OrderByDescending(C => C.CustomerID);

            //var Result = ProductsList.OrderByDescending(P => P.UnitsInStock).ThenByDescending(P => P.UnitPrice);

            //Result = from P in ProductsList
            //         orderby P.UnitsInStock, P.UnitPrice descending
            //         select P;

            //var Result = ProductsList.Where(P => P.UnitsInStock > 10)
            //    .Select(P => P.ProductName)
            //    .OrderByDescending(N => N.Length);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Element operators [Valid With Fluent - Method Syntax Only]

            ////var Result = ProductsList.First();

            ////Result = ProductsList.Last();

            ////var Result = ProductsList.FirstOrDefault(P => P.UnitsInStock == 0, new Product());

            ////var Result = ProductsList.ElementAt(1);
            ////Result = ProductsList.ElementAt(new Index(1, true));
            ////// سينتاكس سكر
            ////Result = ProductsList.ElementAt(^1);
            ////// يعني الاول من ورا 
            ////// من الاخر مبيكونش في index[0]

            ////Result = ProductsList.ElementAtOrDefault(100); // Return Deafult

            ////var Result = ProductsList.Single(P => P.ProductID == 1);

            ////Result = ProductsList.SingleOrDefault(P => P.UnitsInStock > 1000); // Return Deafult

            //// Hybrid Syntax
            //var Result = (from P in ProductsList
            //          where P.UnitsInStock == 0
            //          select new 
            //          {
            //            P.ProductID,
            //            P.ProductName,
            //            P.UnitsInStock

            //          }).SingleOrDefault();

            //Console.WriteLine(Result);

            #endregion

            #region 5. Aggregate Operators

            #region Count() , TryGetNonEnumeratedCount()


            //var Result = ProductList.Count(); // LINQ Operator
            //Result = ProductList.Count; // List Property [Recommended]

            //var Numbers = Enumerable.Range(1, 100);
            //Console.WriteLine(Numbers.Count()); // 100

            //var NumbersList = Numbers.ToList();
            //Console.WriteLine(NumbersList.Count()); // 100
            //Console.WriteLine(NumbersList.Count); // 100

            //Result = ProductList.Where(P => P.UnitsInStock > 0).Count();
            //Result = ProductList.Count(P => P.UnitsInStock > 0);
            //Console.WriteLine(Result); // 72

            //bool Flag = ProductList.TryGetNonEnumeratedCount(out Result);
            //Console.WriteLine(Flag); // True 
            //Console.WriteLine(Result); // 77

            //Console.WriteLine("================================");
            //var LazyNumbers = GetLazyNumbers();
            //Result = LazyNumbers.Count(); // 10
            //Flag = LazyNumbers.TryGetNonEnumeratedCount(out Result);
            //// Works best with IQueryable<T> or collections that can determine the count without iteration.
            //Console.WriteLine(Flag); // False 
            //Console.WriteLine(Result); // 0 
            #endregion

            #region Sum() , Average() 

            //var Result = ProductList.Sum(P => P.UnitPrice); // 2222.7100
            //Result = ProductList.Average(P => P.UnitPrice); // 28.83
            //Console.WriteLine(Result);

            #endregion

            #region Max(), MaxBy() , Min() , MinBy() 

            //var Result = ProductList.Max();
            //// Product Must be Implement Interface "IComparable"
            //Console.WriteLine(Result); // ProductID:38,ProductName:Côte de Blaye,CategoryBeverages,UnitPrice:263.5000,UnitsInStock:17
            //Result = ProductList.Min(); // 2.5
            //Console.WriteLine(Result); // ProductID:33,ProductName:Geitost,CategoryDairy Products,UnitPrice:2.5000,UnitsInStock:112

            //Result = ProductList.Max(new ProductUnitInStockComparer());
            //Console.WriteLine(Result); //ProductID:75,ProductName:Rhönbräu Klosterbier,CategoryBeverages,UnitPrice:7.7500,UnitsInStock:125


            //var MinLengthProductName = ProductList.Min(P => P.ProductName); // 4
            //Console.WriteLine(MinLengthProductName);


            //Result = (from P in ProductList
            //          where P.ProductName == MinLengthProductName
            //          select P).FirstOrDefault(); // Chai
            //Console.WriteLine(Result); // ProductID:17,ProductName:Alice Mutton,CategoryMeat/Poultry,UnitPrice:39.0000,UnitsInStock:0

            //Result = ProductList.MinBy(P => P.ProductName); // .NET 6+
            //Console.WriteLine(Result); // ProductID:17,ProductName:Alice Mutton,CategoryMeat/Poultry,UnitPrice:39.0000,UnitsInStock:0


            #endregion

            #region Aggregate() 


            //string[] Words = { "Hello", "From", "Route", "Academy" };
            //var Result = Words.Aggregate((Str01, Str02) => $"{Str01} {Str02}");
            //Console.WriteLine(Result); // Hello From Route Academy
            //                           // Str01 = Hello , Str02 = From
            //                           // Str01 = Hello From , Str02 = Route
            //                           // Str01 = Hello From Route , Str02 = Academy
            //                           // Result = Hello From Route Academy

            //Result = Words.Aggregate("Hi : ", (Str01, Str02) => $"{Str01} {Str02}");
            //Console.WriteLine(Result); // Hi :  Hello From Route Academy
            //Result = Words.Aggregate("Hi : ", (Str01, Str02) => $"{Str01} {Str02}", (TAcc) => TAcc.Replace(' ', '_'));
            //Console.WriteLine(Result); //Hi_:__Hello_From_Route_Academy


            #endregion

            #endregion

            #endregion

            #endregion



            #region Assignment

            #region Restriction Operators

            #region 1. Find all products that are out of stock.

            //var Result = ProductsList.Where(P => P.UnitsInStock == 0);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.

            //var Result = ProductsList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3M);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 3. Returns digits whose name is shorter than their value.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var Result = Arr.Where((A, I) => A.Length < I);

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region Element Operators

            #region  1. Get first Product out of Stock

            //var Result = ProductsList.FirstOrDefault(P => P.UnitsInStock == 0);

            //Console.WriteLine(Result);

            #endregion

            #region  2. Return the first product whose Price > 1000, unless there is no match, in which case null isreturned

            //var Result = ProductsList.FirstOrDefault(P => P.UnitPrice > 1000);

            //Console.WriteLine(Result);

            //// null will be returned if ProductList is not null Or no case match the condition

            #endregion

            #region  3. Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Where(A => A > 5).ElementAt( new Index(1));

            //Console.WriteLine(Result);

            #endregion

            #endregion

            #region Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Reslut = Arr.Count(num => num % 2 == 1);

            //Console.WriteLine(Reslut);

            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var Result = CustomersList.Select(C => new { C.CustomerName, NumberOfOrders = C.Orders.Count() });

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 3. Return a list of categories and how many products each has

            //var Result = ProductsList.Select(C => new { C.Category, NumberOfProducts = C.Category.Count() });

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = Arr.Sum();

            //Console.WriteLine(Result);

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Readdictionary_english.txt into Array of String First).

            //string[] words = "dictionary_english.txt".Split('_' , '.' );

            //var Result = words.Select(word => word.Length).Sum();

            //Console.WriteLine(Result);

            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txtinto Array of String First).

            //string[] words = "dictionary_english.txt".Split('_', '.');

            //var Result = words.MinBy( word => word.Length);

            //Console.WriteLine(Result);

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txtinto Array of String First).

            //string[] words = "dictionary_english.txt".Split('_', '.');

            //var Result = words?.MaxBy(word => word.Length)?.Length;

            //Console.WriteLine(Result);

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txtinto Array of String First).

            //string[] words = "dictionary_english.txt".Split('_', '.');

            //var Result = words.Average(word => word.Length);

            //Console.WriteLine(Result);

            #endregion

            #endregion

            #endregion
        }

        static IEnumerable<int> GetLazyNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                yield return i;
            }
        }
    }
}
