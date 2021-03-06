﻿using System;
using System.Linq;
using System.Numerics;
using Discrete_Solution;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiscreteTestProject
{
    [TestClass]
    public class Discrete_Test
    {
        [TestMethod, Description("Addition test must meet expected output")]
        public void Addition_Test()
        {
            var natural1 = new Natural(Int32.MaxValue);
            var natural2 = new Natural(Int64.MaxValue);
            bool expected = true;
            var actual = natural1.Add(natural2);
            Assert.AreEqual(expected, (actual.GetBigValue()>Int64.MaxValue));

            Console.WriteLine("The Big Integer sum is: "+ actual.GetBigValue());
        }
        [TestMethod, Description("Test all arithmetic through complex method chaining!")]
        public void Arithmetic_Test()
        {
            var natural1 = new Natural(5);//10);
            //var natural2 = new Natural(-2);//);
            var natural3 = new Natural(7);
            int expected = 0;
            BigInteger expected2 = 0;

            //var actual = natural1.Add(natural2).Subtract(natural2).Multiply(natural1).Divide(natural2);
            var actual2 = natural3.Pow(-2);//.Divide(new Natural(new Natural(5).Pow(50).GetBigValue()));

            //Assert.AreEqual(expected, actual.GetIntValue());
            Assert.AreEqual(expected2, actual2.GetBigValue());

            //Console.WriteLine("((((10+2)-2)*10)/2) == 50 matches our result:  " + actual.GetBigValue());
            Console.WriteLine("7^50 / 5^50 == 20248916 w/o decimal matches our result:  " + actual2.GetBigValue());
        }

        [TestMethod, Description("Test all arithmetic through complex method chaining!")]
        public void Arithmetic_Test2()
        {
            var natural1 = new Natural(10);
            var natural2 = new Natural(6);
            var natural3 = new Natural(3);
            var natural4 = new Natural(10);
            var natural22 = new Natural(6);
            int expected = 2;
            int expected2 = 12;
            var natural_array = natural1.DivideAndRemainder(natural2);
            natural_array[0].Add(natural3);
            natural_array[0].Add(natural2.Divide(natural3));
            var actual = natural_array[1].Gcd(natural_array[0]);
            Console.WriteLine("First Result: " + actual.GetBigValue());
            Assert.AreEqual(expected, actual.GetIntValue());
            Assert.AreEqual(2, natural_array[1].GetIntValue());
            var actual2 = actual.ModPow(natural_array[0], natural3.Add(natural4));
            Assert.AreEqual(expected2, actual2.GetIntValue());
            Console.WriteLine("Second Result: " + actual2.GetBigValue());
        }

        [TestMethod, Description("Expect exception thrown when initializing with negatives")]
        [ExpectedException(typeof(ArgumentException))]
        public void Domain_Exception_Test()
        {
            try
            {
                var negative_natural = new Natural(-5);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [TestMethod, Description("Test for default initialization")]
        public void Constructor_Init_Test()
        {
            var zero_natural = new Natural(0);
            var default_natural = new Natural();
            var valid_natural = new Natural(Int32.MaxValue);
            Assert.AreEqual(zero_natural.GetIntValue(), default_natural.GetIntValue());
            Assert.IsNotNull(default_natural.GetIntValue());
            Assert.AreNotSame(zero_natural.GetIntValue(), valid_natural.GetIntValue());
            Assert.AreEqual(zero_natural.GetIntValue(), valid_natural.GetIntValue() - valid_natural.GetIntValue());

            Console.WriteLine("The value of zero initialization is: " + zero_natural.GetIntValue());
            Console.WriteLine("The value of default initialization is: " + default_natural.GetIntValue());
            Console.WriteLine("The value of a valid initialization is: " + valid_natural.GetIntValue());
        }

        [TestMethod, Description("Test for default initialization")]
        public void Mod_Test()
        {
            var val = new Natural(52);
            var exponent = new Natural(7);
            var modulo = new Natural(3);
            var expected = BigInteger.ModPow(52, 7, 3);

            var actual = val.ModPow(exponent, modulo);
            Assert.AreEqual(expected, actual.GetBigValue());

            Console.WriteLine("The value of expected {0} vs actual: " + actual.GetBigValue(), expected);

        }

        [TestMethod, Description("Test for default initialization")]
        public void Prime_Test()
        {
            var val = new Natural(199);
            var exponent = new Natural(7);
            var modulo = new Natural(3);
            var expected = true;

            var actual = val.IsPrime();
            Assert.AreEqual(expected, actual);

            Console.WriteLine("The value of expected {0} vs actual: " + actual, expected);

        }



        [TestMethod, Description("Various methods of comparison")]
        public void Comparison_Test()
        {
            var natural1 = new Natural(50);
            var natural2 = new Natural(25);
            int larger = 50, smaller = 25;
            int expected = -1;
            Natural actual;
            actual = natural1.Max(natural2);
            Assert.AreEqual(larger, actual.GetIntValue());
            Console.WriteLine(actual.GetIntValue() + " is larger than 25");

            //natural2 = new Natural(75);
            actual = natural1.Min(natural2);
            Assert.AreEqual(smaller, actual.GetIntValue());
            Console.WriteLine(actual.GetIntValue() + " is smaller than 50");

            int output = actual.CompareTo(natural1);
            Assert.AreEqual(expected, output);
            Console.WriteLine("The comparison of natural1 and natural2 produces: " + output);
        }

        [TestMethod, Description("Basic observations on Number Theory")]
        public void NumberTheory_Basic_Test()
        {
            var natural = new Natural(9);
            var relative_natural = new Natural(38);
            var valid_natural = new Natural(36);
            int relativelyprime = 1, gcd = 9, lcm = 342;
            Natural actual;
            
            actual = natural.Gcd(relative_natural);
            //actual = relative_natural.Gcd(natural);
            Assert.AreEqual(relativelyprime, actual.GetIntValue());
            Console.WriteLine("Relatively Prime (38,9): " + actual.GetIntValue());

            natural = new Natural(9);
            var IsRelativelyPrime = natural.IsRelativelyPrimeTo(relative_natural);
            Assert.AreEqual(true, IsRelativelyPrime);
            Console.WriteLine("Relatively Prime (38,9): " + IsRelativelyPrime);

            natural = new Natural(0);
            var IsPrime = natural.IsPrime();
            Console.WriteLine("Is 38 Prime?: " + IsPrime);

            natural = new Natural(9);
            actual = natural.Lcm(relative_natural);
            Assert.AreEqual(lcm, actual.GetIntValue());
            Console.WriteLine("Valid LCM (38,9): " + actual.GetIntValue());

            natural = new Natural(9);
            actual = natural.Gcd(valid_natural);
            Assert.AreEqual(gcd, actual.GetIntValue());
            Console.WriteLine("Valid GCD (36,9): " + actual.GetIntValue());
        }
        [TestMethod, Description("String map, number conversion to specified base")]
        public void String_Test()
        {
            var natural1 = new Natural(Int32.MaxValue);
            var natural2 = new Natural(Int64.MaxValue);
            string intmax = "2jg3E7";
            string longmax = "Ca06U74ZPEa7";
            Console.WriteLine(natural1.ToString());
            Console.WriteLine(natural2.ToString());
            var actual = natural1.ToString(60);
            Assert.AreEqual(intmax, actual);
            
            Console.WriteLine("2,147,483,647 in base 60: " + actual);

            var actual2 = natural2.ToString(42);
            Assert.AreEqual(longmax, actual2);
            
            Console.WriteLine("9,223,372,036,854,775,807 in base 42: " + actual2);
        }

        [TestMethod, Description("Tests various cases of primality")]
        public void Primality_Test()
        {
            var natural1 = new Natural(Int32.MaxValue - 1);
            var natural2 = new Natural(678);
            var hardphi = new Natural(667);
            var actual = natural1.PrimeFactorize();
            Console.WriteLine("\nFactors of {0} are: ", natural1);
            foreach (var element in actual)
            {
                Console.Write(element + " ");
            }
            var actual2 = natural2.PrimeFactorize();
            Console.WriteLine("\nFactors of {0} are: ", natural2);
            foreach (var element in actual2)
            {
                Console.Write(element + " ");
            }

            var distinctlist = natural1.DistinctPrimeFactors();
            Console.WriteLine("\nDistinct Factors of {0} are: ", natural1);
            foreach (var element in distinctlist)
            {
                Console.Write(element + " ");
            }
            var distinctlist2 = hardphi.DistinctPrimeFactors();
            Console.WriteLine("\nDistinct Factors of {0} are: ", hardphi);
            foreach (var element in distinctlist2)
            {
                Console.Write(element + " ");
            }
            int expected = 616;
            var phi = hardphi.CountRelativelyPrimes();
            Console.Write("\nφPhi of {0} is: " + phi, hardphi);
            Assert.AreEqual(expected, phi);
        }

        [TestMethod, Description("Basic primality")]
        public void NumberTheory2_Basic_Test()
        {
            BigInteger n = 9223372036854775807;
            var natural = new Natural(n);
            bool expected = true;
            var actual = natural.NextProbablePrime();
            for (int i = 1; i < 50; i+=6)
            {
                Console.WriteLine(n + i);
                natural = new Natural(n + i);
                actual = natural.NextProbablePrime();
                Assert.AreEqual(expected, actual.IsPrime());
                Console.WriteLine("The next probable prime after {0} is: " + actual.GetBigValue(), n + i);
                n += 7;
            }
        }
        [TestMethod, Description("Division Algorithm")]
        public void Division_Algorithm_Test()
        {
            var natural = new Natural(158);
            var natural2 = new Natural(17);
            var actual = natural.DivisionAlgorithm(natural2);
            Console.WriteLine("The Division Algorithm of {0} / {1} is: " + actual, natural, natural2);
            natural = new Natural(int.MaxValue);
            natural2 = new Natural(86340);
            actual = natural.DivisionAlgorithm(natural2);
            Console.WriteLine("The Division Algorithm of {0} / {1} is: " + actual, natural, natural2);
        }
    }
}
