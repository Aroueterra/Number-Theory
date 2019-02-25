using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

    //[END-TO-END System test]
namespace Discrete_Solution
{
    public class Operations //: Natural
    {
        public Operations() { }
        public Tuple<BigInteger, BigInteger> Entry()
        {
            Console.WriteLine();
            Console.WriteLine("(0) Enter a number: ");
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("(1) Enter a number: ");
            BigInteger input2 = BigInteger.Parse(Console.ReadLine());
            return new Tuple<BigInteger, BigInteger>(input, input2);
        }
        public Tuple<BigInteger, BigInteger, BigInteger> Entry(int num)
        {
            Console.WriteLine();
            Console.WriteLine("(0) Enter a number: ");
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("(1) Enter a number: ");
            BigInteger input2 = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("(2) Enter a number: ");
            BigInteger input3 = BigInteger.Parse(Console.ReadLine());
            return new Tuple<BigInteger, BigInteger, BigInteger>(input, input2, input3);
        }
        public BigInteger ADDITION(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            Natural operand2 = new Natural(input2);
            int result = operand1.Add(operand2).GetIntValue();
            return result;
        }
        public BigInteger SUBTRACTION(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            Natural operand2 = new Natural(input2);
            int result = operand1.Subtract(operand2).GetIntValue();
            return result;
        }
        public BigInteger DIVISION(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            Natural operand2 = new Natural(input2);
            int result = operand1.Divide(operand2).GetIntValue();
            return result;
        }
        public BigInteger MULTIPLICATION(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            Natural operand2 = new Natural(input2);
            int result = operand1.Multiply(operand2).GetIntValue();
            return result;
        }
        public BigInteger MAX(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            Natural operand2 = new Natural(input2);
            int result = operand1.Max(operand2).GetIntValue();
            return result;
        }
        public BigInteger MIN(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            Natural operand2 = new Natural(input2);
            int result = operand1.Min(operand2).GetIntValue();
            return result;
        }
        public BigInteger MODULO(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            Natural operand2 = new Natural(input2);
            int result = operand1.Modulo(operand2).GetIntValue();
            return result;
        }
        public BigInteger POWER(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            BigInteger power = input2;
            int result = operand1.Pow(power).GetIntValue();
            return result;
        }
        public BigInteger MODPOWER(BigInteger input, BigInteger input2, BigInteger input3)
        {
            Natural operand1 = new Natural(input);
            Natural exponent = new Natural(input2);
            Natural mod = new Natural(input3);
            int result = operand1.ModPow(exponent, mod).GetIntValue();
            return result;
        }
        public Natural[] DIVIDEREMAIN(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            Natural operand2 = new Natural(input2);
            Natural[] result = operand1.DivideAndRemainder(operand2);
            return result;
        }
        public string STRINGBASE(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            Natural ibase = new Natural(input2);
            string result = operand1.ToString(ibase.GetIntValue());
            return result;
        }
        public BigInteger COMPARE(BigInteger input, BigInteger input2)
        {
            Natural operand1 = new Natural(input);
            Natural operand2 = new Natural(input2);
            int result = operand1.CompareTo(operand2);
            return result;
        }
    }

}
