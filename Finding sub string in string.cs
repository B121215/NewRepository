using System;
namespace ConsoleApplication4 {

public class Geeks {

   // Main Method
  public static void Main(string[] args)
   {

       string str = "Hello Friends....How are you...";

       int i = str.IndexOf("How");

       // As this string is present in the
       // main string then it will obviously
       //  output the value as 17
       Console.WriteLine("First value Index of 'How' is " + i);

       // now the following string is not present
       // So as per the rules, it will return -1
       int i1 = str.IndexOf("Chair");

       // As this string is present in
       // the main string then it will
       // obviously output the value as -1
       Console.WriteLine("First value Index of 'Chair' is " + i1);
   }
}
}