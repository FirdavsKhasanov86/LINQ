using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задачка 1  
            // hello => h2ll4

            //string word = "hello";
            //string ConvertWord = String.Join("", word.ToCharArray().Select(x => x == 'a' ? "1" : x == 'e' ? "2" : x == 'i' ? "3" : x == 'o' ? "4" : x == 'u' ? "5" : x == 'y' ? "6" : x.ToString()));
            //Console.WriteLine(ConvertWord);
            //Console.ReadKey();



            //-------------------------------------------------------------------//

            //Задачка 2
            // h3 th2r2 => hi there

            //string word = "h3 th2r2";
            //string ConvertWord = String.Join("", word.ToCharArray().Select(p => p == '1' ? "a" : p == '2' ? "e" : p == '3' ? "i" : p == '4' ? "o" : p == '5' ? "u" : p == '6' ? "y" : p.ToString()));
            //Console.WriteLine(ConvertWord);
            //Console.ReadKey();

            //-------------------------------------------------------------------//

            //Задачка 3
            //gdfgdf234dg54gf*23oP42 => 54929268

            //string word = "gdfgdf234dg54gf*23oP42";
            //int x = 0;
            //string clear = String.Join("", word.ToCharArray().Select(p => int.TryParse(p.ToString(), out x) == true ? p.ToString() : p == '+' || p == '-' || p == '*' || p == '/' ? p.ToString() : ""));
            //string func = String.Join("", clear.ToCharArray().Select(p => int.TryParse(p.ToString(), out x) == true ? "" : p == '+' || p == '-' || p == '*' || p == '/' ? p.ToString() : ""));
            //var z = clear.Split(func);
            //x = int.Parse(z[0]);
            //int y = int.Parse(z[1]);
            //int result = 0;
            //result = func == "+" ? x + y : func == "-" ? x - y : func == "*" ? x * y : func == "/" ? x / y : 0;
            //Console.WriteLine(clear);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //-------------------------------------------------------------------//

            //Задачка 4
            //camelCasing => camel Casing

            string camelWord = "camelCasing";
            var word = String.Join("", camelWord.ToCharArray().Select(p => char.IsUpper(p) == true ? " " + p.ToString().ToUpper() : p.ToString()));
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
