using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_Solution
{
    /// <summary>
    /// The Natural class is the implementation of a specific value from the set of natural numbers.
    /// </summary>
    /// <remarks> 
    /// @author: August Bryan N. Florese
    /// @since: 2019-02-24
    /// </remarks> 

 public class Integer
    {
        public int Value { get; set; }


        public Integer() { }
        public Integer(int value) { Value = value; }


        // Custom cast from "int":
        public static implicit operator Integer(Int32 x) { return new Integer(x); }

        // Custom cast to "int":
        public static implicit operator Int32(Integer x) { return x.Value; }


        public override string ToString()
        {
            return string.Format("Integer({0})", Value);
        }
    }
    
    class Program
    {
        Operations perform = new Operations();
        static void Main(string[] args)
        {
            Console.WriteLine("On Discrete Mathematics: A compilation of lessons in Number Theory");

            int choice;
            do
            {
                Console.WriteLine("[1] Basic Mathematical Operations");
                Console.WriteLine("[2] Observations in Number Theory");
                Console.WriteLine("[3] Display");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("Choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Basic(); break;
                    case 2:
                        Console.Clear();
                        break;
                }
            } while (choice != 0);
            Console.ReadKey();
        }

        static void Basic() {
            Operations perform = new Operations();
            int choice = -1;
            do
            {
                Console.WriteLine("We are now testing... [Basic Mathematical Operations]!");
                Console.WriteLine("[1] Addition");
                Console.WriteLine("[2] Subtraction");
                Console.WriteLine("[3] Division");
                Console.WriteLine("[4] Multiplication");
                Console.WriteLine("[5] Maximum");
                Console.WriteLine("[6] Minimum");
                Console.WriteLine("[7] Power");
                Console.WriteLine("[8] Modulo");
                Console.WriteLine("[9]CompareTo");
                Console.WriteLine("[10] Modulo-Power");
                Console.WriteLine("[11]Divide&Remainder");
                Console.WriteLine("[12]ToString(Base)");
                Console.WriteLine("[0] Back");
                Console.WriteLine("Choice: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                var Set = Tuple.Create<BigInteger, BigInteger>(0,0);
                string operation = String.Empty;
                BigInteger result = 0;
                switch (choice)
                {
                    case 1:
                        Set = perform.Entry();
                        operation = "Addition";   
                        result = perform.ADDITION(Set.Item1, Set.Item2); break;
                    case 2:
                        Set = perform.Entry();
                        operation = "Subtraction";
                        result = perform.SUBTRACTION(Set.Item1, Set.Item2); break;
                    case 3:
                        Set = perform.Entry();
                        operation = "Division";
                        result = perform.DIVISION(Set.Item1, Set.Item2); break;
                    case 4:
                        Set = perform.Entry();
                        operation = "Multiplication";
                        result = perform.MULTIPLICATION(Set.Item1, Set.Item2); break;
                    case 5:
                        Set = perform.Entry();
                        operation = "Maximum";
                        result = perform.MAX(Set.Item1, Set.Item2); break;
                    case 6:
                        Set = perform.Entry();
                        operation = "Minimum";
                        result = perform.MIN(Set.Item1, Set.Item2); break;
                    case 7:
                        Set = perform.Entry();
                        operation = "Power";
                        result = perform.POWER(Set.Item1, Set.Item2); break;
                    case 8:
                        Set = perform.Entry();
                        operation = "Modulo";
                        result = perform.MODULO(Set.Item1, Set.Item2); break;
                    case 9:
                        Set = perform.Entry();
                        operation = "CompareTo";
                        result = perform.COMPARE(Set.Item1, Set.Item2); break;
                    case 10:
                        var Set2 = Tuple.Create<BigInteger, BigInteger, BigInteger>(0, 0, 0);
                        Set2 = perform.Entry(1);
                        operation = "Modulo-Power";
                        result = perform.MODPOWER(Set2.Item1, Set2.Item2, Set2.Item3);
                        Console.WriteLine(Set2.Item1.ToString() + " base, raised to " + Set2.Item2.ToString() + " modulo " + Set2.Item3 + " is " + result);
                        break;
                    case 11:
                        Set = perform.Entry();
                        operation = "Divide&Remainder";
                        Natural[] nat = perform.DIVIDEREMAIN(Set.Item1, Set.Item2);
                        Console.WriteLine("At index [0]: " + nat[0].ToString() + ", At index [1]: " + nat[1].ToString());
                        break;
                    case 12:
                        Set = perform.Entry();
                        operation = "ToString(Base)";
                        string line = perform.STRINGBASE(Set.Item1, Set.Item2);
                        Console.WriteLine(Set.Item1.ToString() + " in base " + Set.Item2.ToString() + " is " + line);
                        break;
                }
                if(choice != 0 && choice < 10)
                    Console.WriteLine(string.Format("Performing: {0} on, {1} and {2}. Result is {3}", operation, Set.Item1, Set.Item2, result.ToString()));
                Console.ReadKey();
                Console.Clear();
            } while (choice != 0);
        }
    }
}
