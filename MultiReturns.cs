using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                          //Exercise:1
                                          // can method has multiple returns?

                                          // yes,we can achieve by many ways like 
                                          // 1)using out/Ref parameter
                                          // 2)using class or struct to hold return values then use that struct/                 class/struct as return Type of the method

                                          // 3)Tuple class method also we can use.


//In method1 i am using struct class for olding various return values and then pass this struct class to method as args return Type.

//In Method2 i am using Tuple class for return more than one value

namespace Inheritance
{
    struct MultiReturns
    {
        public int add;
        public int multiply;
        public string str;
        public float amt;
    }
    public class program1
    {
        static void Main(string[] args)
        {

            var Result = Method1(10, 20, "Ananthi", 5.5f);


            Console.WriteLine(Result.add);
            Console.WriteLine(Result.multiply);
            Console.WriteLine("Name is:" + Result.str);
            Console.WriteLine("The final amount is :" + Result.amt);


            var result1 = Method2(20, 25, 2.1f);
            Console.WriteLine(result1.Item1);
            Console.WriteLine(result1.Item2);

        }

        private static MultiReturns Method1(int a, int b, string Name, float Amount)
        {
            var Return = new MultiReturns
            {
                add = a * b,
                multiply = a + b,
                str = "T." + Name,
                amt = Amount + 1000
            };
            return Return;
        }
        //return type       methodname   arguments/parameters
        private static Tuple<int, int, float> Method2(int a, int b, float f)
        {
            var Return1 = new Tuple<int, int, float>(a + b, a * b, a - f);
            return Return1;
        }
    }

}