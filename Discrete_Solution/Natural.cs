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
    /// @since: 2019-02-25
    /// </remarks> 
    public class Natural
    {
        private BigInteger value;

        ///<summary>
        ///The default constructor for the class Natural.
        /// </summary> 
        /// <remarks> Sets BigInteger value to default as 0.</remarks>
        public Natural()
        {
            this.value = 0;
        }

        ///<summary>
        /// The constructor for the class Natural, sets the BigInteger value default to a specified value.
        /// <para> 
        /// @value the default initial value of the natural number.
        /// @exception RuntimeException if the value is negative.
        /// </para>
        /// <para > 
        /// Pre-condition: The number is not null and is within the domain of natural numbers.
        /// Post-condition: The methods may return negative numbers or 0, only after a local operation has been performed.
        /// </para>
        /// </summary>
        public Natural(BigInteger value)
        {
            try
            {
                if (value < 0)
                {
                    throw new ArgumentException("Natural numbers cannot be negative");
                }
                this.value = value;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }

        ///<summary>
        ///Adds the value of this instance by the value of another instance of Natural.
        /// </summary> 
        /// <remarks> 
        /// Due to the nature of BigInteger, System.OverflowException is not to be thrown.
        /// </remarks>
        public Natural Add(Natural value)
        {
            this.value += value.value;
            return this;
        }

        ///<summary>
        ///Subtract the value of this instance by the value of another instance of Natural.
        ///<para>
        /// <see cref="Natural()"/> Post-condition: The methods may return negative numbers or 0. 
        /// </para>
        /// </summary> 
        public Natural Subtract(Natural value)
        {
            this.value -= value.value;
            return this;
        }

        ///<summary>
        ///Multiply the value of this instance by the value of another instance of Natural.
        /// </summary> 
        public Natural Multiply(Natural value)
        {
            this.value *= value.value;
            return this;
        }

        ///<summary>
        ///Divide the value of this instance by the value of another instance of Natural.
        /// </summary> 
        public Natural Divide(Natural value)
        {
            try
            {
                if (this.value == 0 || value.value == 0)
                    throw new ArgumentException("You cannot divide by zero!");
                else
                    this.value /= value.value;
                return this;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                this.value = 0;
                return this;
            }

        }

        ///<summary>
        ///Divide the value of this instance by the value of another instance of Natural then return the remainder.
        /// </summary> 
        public Natural Modulo(Natural value)
        {
            try
            {
                if (value.value <= 0 || this.value <= 0)
                    throw new ArgumentException("You cannot divide by zero!");
                this.value %= value.value;
                return this;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                this.value = 0;
                return this;
            }
        }

        ///<summary>
        ///Divide the value of this instance by the value of another instance of Natural then return the quotient and remainder as an array.
        /// </summary> 
        /// <remarks>
        /// Due to the nature of BigInteger, the decimal or floating point precision is omitted.
        /// </remarks>
        public Natural[] DivideAndRemainder(Natural value)
        {
            Natural[] divided = new Natural[2];
            try
            {
                if (value.value <= 0 || this.value <= 0)
                    throw new ArgumentException("You cannot divide by zero!");
                divided[0] = new Natural(this.value / value.value);
                divided[1] = new Natural(this.value % value.value);
                return divided;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                return divided;
            }

        }

        ///<summary>
        ///Returns the maximum value between this instance and another instance.
        /// </summary> 
        public Natural Max(Natural value)
        {
            return this.value > value.value ? this : value;
        }

        ///<summary>
        ///Returns the minimum value between this instance and another instance.
        /// </summary> 
        public Natural Min(Natural value)
        {
            return this.value < value.value ? this : value;
        }

        ///<summary>
        ///Returns different values depending on the compared instance.
        /// </summary> 
        /// <returns>
        /// 1 if this instance value is greater than another instance
        /// 0 if this instance value is equal to another instance value
        ///-1 if this instance value is less than another instance value
        /// </returns>
        public int CompareTo(Natural value)
        {
            return this.value == value.value ? 0 : this.value < value.value ? -1 : 1;
        }

        ///<summary>
        ///Returns the value of the expression this raised to a BigInteger instance, power.
        /// </summary> 
        public Natural Pow(BigInteger power)
        {
            BigInteger var = 1;
            if (power > 0)
            {
                for (int i = 1; i <= power; ++i)
                {
                    var *= this.value;
                }
            }
            else if (power < 0)
            {
                for (int i = -1; i >= power; --i)
                {
                    var /= this.value;
                }
            }
            this.value = var;
            return this;
        }

        ///<summary>
        ///Return the value of the expression this raised to value % mod
        /// </summary> 
        public Natural ModPow(Natural exponent, Natural mod)
        {
            BigInteger exp = exponent.value, m = mod.value;
            this.value = Pow(exp).value %= m;
            return this;
        }

        ///<summary>
        ///returns the next prime number greater than the value of this instance
        /// </summary> 
        public Natural NextProbablePrime()
        {
            Natural n = new Natural(++this.value);
            if (n.value < 0)
                throw new ArgumentException("Number should be within the domain of natural numbers.");
            bool PrimeCheck = n.IsPrime();
            try
            {
                while (!PrimeCheck)
                {
                    n.value++;
                    PrimeCheck = n.IsPrime();
                    if (PrimeCheck)
                    {
                        PrimeCheck = true;
                        return n;
                    }
                }
                return n;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                return this;
            }
        }

        ///<summary>
        ///Returns the greatest common denominator between the value of this instance and the value of another instance
        /// </summary> 
        public Natural Gcd(Natural value)
        {
            BigInteger x = this.value, y = value.value, temp = 0;
            while (y != 0)
            {
                temp = x % y;
                x = y;
                y = temp;
            }
            this.value = x;
            return this;
        }

        ///<summary>
        ///Returns the least common multiple between the value of this instance and the value of another instance.
        /// </summary> 
        public Natural Lcm(Natural value)
        {
            BigInteger z = this.Gcd(value).value;
            this.value = (this.value / z) * value.value;
            return this;
        }

        ///<summary>
        ///Checks if the value of this instance is a prime number, return true if yes, otherwise false.
        /// </summary>
        public Boolean IsPrime()
        {

            BigInteger num = this.value;
            try
            {
                if (this.value < 0)
                    throw new ArgumentException("Number should be within the domain of natural numbers.");
                if (this.value == 1)
                    return false;
                if (this.value == 2 || this.value == 3)
                    return true;
                if (this.value % 2 == 0 || this.value % 3 == 0)
                    return false;
                int i;
                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        ///<summary>
        ///Returns a String representation of the value of this instance
        /// </summary>
        public override String ToString()
        {
            return Convert.ToString(this.value);
        }

        ///<summary>
        ///Returns a String representation of the value of this instance given a certain base value for conversion.
        /// </summary>
        /// <remarks>
        /// Your base must be greater than 1 or less than 63.
        /// The table of conversion are the numbers 0-9, A-Z and a-z (62 variables in total).
        /// Could be replaced with a dictionary key value lookup or some linq/regular expression implementation.
        /// </remarks>
        public String ToString(Integer num)
        {
            try
            {
                if (num.Value <= 1 || num.Value >= 63)
                    throw new ArgumentException("Number should be greater than or equal to 2, and less than or equal to 62");
                char[] map = new char[] { '0','1','2','3','4','5','6','7','8','9',
                                         'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                                         'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x'};
                string builder = string.Empty;
                do
                {
                    builder = map[(long)this.value % num.Value] + builder;
                    value = value / num.Value;
                }
                while (value > 0);
                return builder;

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        ///<summary>
        ///Returns the number of relatively prime numbers with respect to the value of this instance.
        /// </summary>
        //public  Integer countRelativelyPrimes()
        //{
        //    int result = 1;
        //    BigInteger n = this.value;
        //    result = n * 1 - (1 /2);
        //    for (int i = 2; i < n; i++)
        //        if (this.Gcd(n) == 1)
        //            result++;
        //    return result;
        //}

        ///<summary>
        ///Returns the number of relatively prime numbers with respect to the value of this instance.
        /// </summary>
        public Boolean IsRelativelyPrimeTo(Natural value)
        {
            return (this.Gcd(value).value == 1) ? true : false;
        }

        ///<summary>
        ///Returns the number of relatively prime numbers with respect to the value of this instance.
        /// </summary>
        public String DivisionAlgorithm(Natural value)
        {
            BigInteger x = this.value, y = value.value, q = x / y, r = x % y;
            return string.Format("{0} = {1} * {2} + {3}", x, y, q, r);
        }

        ///<summary>
        ///Returns the number of relatively prime numbers with respect to the value of this instance.
        /// </summary>
        public List<Natural> PrimeFactorize()
        {
            BigInteger val = this.value;
            BigInteger maxFactor = 0;
            var factors = new List<Natural>();
            BigInteger squared = (BigInteger)Math.Sqrt((double)val);
            while (val > 1)
            {
                BigInteger nextFactor = 2;

                if (val % nextFactor > 0)
                {
                    nextFactor = 3;
                    do
                    {
                        if (val % nextFactor == 0)
                        {
                            break;
                        }

                        nextFactor += 2;
                    } while (!(nextFactor > squared));
                }

                val /= nextFactor;
                var n = new Natural(nextFactor);
                factors.Add(n);
                if (nextFactor > maxFactor)
                {
                    maxFactor = nextFactor;
                }
            }
            return factors;
        }

        ///<summary>
        ///Returns a set of distinct prime factors of the value for this instance
        /// </summary>
        public List<Natural> DistinctPrimeFactors()
        {

            var list = this.PrimeFactorize();
            List<Natural> unique = new List<Natural>();
            unique = list.GroupBy(elem => elem.value).Select(group => group.First()).ToList();

            return unique;
        }

        ///<summary>
        ///Returns the int32 representation of the value of this instance
        /// </summary>
        public Integer GetIntValue()
        {
            return (Int32)(this.value);
        }

        ///<summary>
        ///Returns the int64 representation of the value of this instance.
        /// </summary>
        public long GetLongValue()
        {
            return (Int64)(this.value);
        }
    }
}
