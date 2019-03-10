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
    /// @started: 2019-02-25  
    /// @concluded: 2019-02-27
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
                throw;
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
            try
            {
                if ((this.value - value.value) < 0)
                    throw new ArgumentException("Natural numbers cannot be negative");
                else
                    this.value -= value.value;
                return this;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
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
                if (this.value <= 0 || value.value <= 0)
                    throw new ArgumentException("You cannot divide by zero!");
                else
                {
                    this.value /= value.value;
                    return this;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
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
                BigInteger quo = this.value / value.value;
                BigInteger mod = this.value % value.value;
                divided[0] = new Natural(quo);
                divided[1] = new Natural(mod);
                return divided;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
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
        /// <returns>
        /// A negative power is permitted as not all
        /// </returns>
        public Natural Pow(BigInteger power)
        {
            try
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
                if (var < 0)
                {
                    throw new ArgumentException("Output should be within the domain of natural numbers.");
                }
                this.value = var;
                return this;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        ///<summary>
        ///Return the value of the expression this raised to value % mod
        /// </summary> 
        public Natural ModPow(Natural exponent, Natural mod)
        {
            BigInteger exp = exponent.value, m = mod.value;
            this.value = this.Pow(exp).Modulo(mod).value;
            return this;
        }

        ///<summary>
        ///Returns the next prime number greater than the value of this instance
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
                throw;
            }
        }

        ///<summary>
        ///Returns the greatest common denominator between the value of this instance and the value of another instance
        /// </summary> 
        /// <remarks>
        /// X cannot be negative but can be zero; whereas y cannot be negative or zero
        /// </remarks>
        public Natural Gcd(Natural value)
        {
            BigInteger x = this.value, y = value.value, temp = 0;
            try
            {
                if (x < 0 || y <= 0)
                    throw new ArgumentException("An invalid argument was detected.");
                else if (y < x)
                {
                    temp = x;
                    x = y;
                    y = temp;
                }
                while (y != 0)
                {
                    temp = x % y;
                    x = y;
                    y = temp;
                }
                this.value = x;
                return this;
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        ///<summary>
        ///Returns the least common multiple between the value of this instance and the value of another instance.
        /// </summary> 
        /// <remarks>
        /// Calls the result of GCD
        /// </remarks>
        public Natural Lcm(Natural value)
        {
            Natural temp = new Natural(this.value);
            BigInteger gcd = temp.Gcd(value).value;
            this.value = (this.value / gcd) * value.value;
            return this;
        }

        ///<summary>
        ///Checks if the value of this instance is a prime number
        /// </summary>
        /// <remarks>
        /// An extension method was incorporated to handle numbers outside the limit of Int64, however this implementation is not the fastest.
        /// While the method is optimized for long and int numbers, the solution also accepts even larger numbers at the cost of performance
        /// </remarks>
        /// <returns>
        /// True : the value is prime
        /// False : the value is composite or non-natural
        /// </returns>
        public Boolean IsPrime()
        {

            BigInteger num = this.value;
            try
            {
                if (this.value <= 1)
                    return false;
                if (this.value == 2 || this.value == 3)
                    return true;
                if (this.value % 2 == 0 || this.value % 3 == 0)
                    return false;
                BigInteger limit = (this.Sqrt())+1;
                for (int i = 3; i <= limit; i+=2)
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
                throw;
            }
        }

        public BigInteger Sqrt()
        {
            BigInteger n = this.value;
            if (n == 0) return 0;
            if (n > 0)
            {
                int length = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (length / 2);

                while (!isRooted(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }
            throw new ArithmeticException("NDE");
        }

        private static Boolean isRooted(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return n >= lowerBound && n <= lowerBound + root + root;
        }

        ///<summary>
        ///Returns a String representation of the value of this instance
        /// </summary>
        public override String ToString()
        {
            return Convert.ToString(this.value);
        }

        ///<summary>
        ///Returns a String representation of the value of this instance converted  based on a given base value.
        /// </summary>
        /// <remarks>
        /// Your base must be greater than 1 or less than 63.
        /// The table of conversion are the numbers 0-9, A-Z and a-z (62 variables in total).
        /// Could be replaced with a dictionary key value lookup or some linq/regular expression implementation.
        /// </remarks>
        public String ToString(Int32 num)
        {
            try
            {
                if (num <= 1 || num >= 63)
                    throw new ArgumentException("Number should be greater than or equal to 2, and less than or equal to 62");
                char[] map = new char[] { '0','1','2','3','4','5','6','7','8','9',
                                         'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                                         'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x', 'y', 'z'};
                string builder = string.Empty;
                do
                {
                    builder = map[(Int64)this.value % num] + builder;
                    value = value / num;
                }
                while (value > 0);
                return builder;

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        ///<summary>
        ///Returns the number of relatively prime numbers with respect to the value of this instance.
        /// </summary>
        /// <remarks>
        /// Implements Euler's Totient Algorithm
        /// </remarks>
        public Int32 CountRelativelyPrimes()
        {
            Double n = (Double)this.value;
            Double p = 1;
            var distinct_factors = this.DistinctPrimeFactors();
            foreach(var element in distinct_factors)
            {
                p *= 1-(1/(Double)element.value);
            }
            n *= p;
            return (Int32)n;
        }

        ///<summary>
        ///Returns a boolean check true or false, whether the gcd of two values is equal to 1.
        /// </summary>
        /// <returns>
        /// @True: 1
        /// </returns>
        public Boolean IsRelativelyPrimeTo(Natural value)
        {
            return (this.Gcd(value).value == 1) ? true : false;
        }

        ///<summary>
        ///This returns a string formatted representation of the division algorithm 
        /// </summary>
        public String DivisionAlgorithm(Natural value)
        {
            Natural X = new Natural(this.value); Natural X2 = new Natural(this.value);
            Natural Y = new Natural(value.value);
            if(X.value <= 0 || Y.value <=0)
                throw new ArgumentException("Invalid arguments detected!");
            BigInteger q = X.Divide(value).value, r = X2.Modulo(Y).value;
            return string.Format("{0} = {1} * {2} + {3}", X.value, Y.value, q, r);
        }

        ///<summary>
        ///Returns a list of prime factors with respect to the value of this instance.
        /// </summary>
        /// <remarks>
        /// Implements direct search algorithm
        /// </remarks>
        public List<Natural> PrimeFactorize()
        {
            if (this.value < 0)
                throw new ArgumentException("This.value contains an invalid value");
            var factors = new List<Natural>();
            BigInteger value = this.value;
            Double squared = Math.Sqrt((double)value);
            while (value % 2 == 0)
            {
                factors.Add(new Natural(2));
                value = value / 2;
            }
            for (int i = 3; i <= squared; i = i + 2)
            {
                while (value % i == 0)
                {
                    factors.Add(new Natural(i));
                    value = value / i;
                }
            }
            if (value > 2)
                factors.Add(new Natural(value));
            return factors;
        }

        ///<summary>
        ///Returns a set of distinct prime factors of the value for this instance
        /// </summary>
        public List<Natural> DistinctPrimeFactors()
        {
            if (this.value < 0)
                throw new ArgumentException("This.value contains an invalid value");
            var list = this.PrimeFactorize();
            List<Natural> unique = new List<Natural>();
            unique = list.GroupBy(elem => elem.value).Select(group => group.First()).ToList();
            return unique;
        }

        ///<summary>
        ///Returns the int32 representation of the value of this instance
        /// </summary>
        public Int32 GetIntValue()
        {
            var str = this.value.ToString();
            if (str.Length <= 9 || this.value <= 2147483647)
                return (Int32)this.value;
            else
                throw new ArgumentException("The value is too large to be contained in the Int32 format.");
        }

        ///<summary>
        ///Returns the int32 representation of the value of this instance as an array of integers
        /// </summary>
        public int[] GetArray(BigInteger num)
        {
            String str = num.ToString();
            int[] arr = new int[str.Length];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = str.ElementAt(i) - '0';
            return arr;
        }

        ///<summary>
        ///Returns the int64 representation of the value of this instance.
        /// </summary>
        public Int64 GetLongValue()
        {
            return (Int64)(this.value);
        }

        ///<summary>
        ///Returns the BigInteger representation of the value of this instance.
        /// </summary>
        public BigInteger GetBigValue()
        {
            return (this.value);
        }
    }
}
