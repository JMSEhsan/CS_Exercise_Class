/* ref. https://www.w3schools.com/cs/trycs.php?filename=demo_class
*/

// See https://aka.ms/new-console-template for more information

using System;

//namespace MyApplication
//{
  class Car
  {
    string color = "red";
    string style = "sedan";
    string year_made = "2020";

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.WriteLine(myObj.color);
      Console.WriteLine(myObj.style);
      Console.WriteLine(myObj.year_made);
    }
  }
//}