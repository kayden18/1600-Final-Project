using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            myFunction();
            myInt = intFunction(22);
            string myString = stringFunction(Console.ReadLine());
            Console.WriteLine(myString);
        }
        public static int myInt = 10;
        public static void myFunction (){
            Console.WriteLine("Run Function");
        }
        public static int intFunction (int _peram){
            return _peram + myInt;
        }
        public static string stringFunction (string _name){
            return "You did well " + _name;
        }
    }
}