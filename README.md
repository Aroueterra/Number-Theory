# FINAL PROJECT

## CS012 – Discrete Structures 2



Submitted to:

**Mr. Kim Howel D. delos Reyes**

Course Adviser

Table of Contents

1. Project Specifications        

2. Team Members        

3. Introduction        

4. Objectives        

5. Discussion     

6. Source Code        

7. Conclusion        



# Project Specifications

The class Natural represents the set of natural numbers. As defined, the set of natural numbers are non-negative whole numbers meaning, these are counting numbers starting from 1 up until to positive infinity including 0.

The class contains two constructors and a list of different methods. Below are the specifications on how the implementation for these parts of the class will be done.

**Constructors**

- Natural() : default constructor which sets the value of the Natural number to 0.

- Natural(BigInteger value) : constructor which sets the value of the Natural Number with the given BigInteger value, throwing RuntimeException if the value is less than 0.

**Methods/Functions**

- add(Natural value) : add the value of this instance by another instance

- subtract(Natural value) : subtract the value of this instance by another instance

- multiply(Natural value) : multiply the value of this instance by another instance

- divide(Natural value) : divide the value of this instance by another instance

- modulo(Natural value) : divide the value of this instance by another instance then return the remainder

- divideAndRemainder(Natural value) : divide the value of this instance by another instance then return the quotient and remainder as an array

- max(Natural value) : returns the maximum value between this instance and another instance

- min(Natural value) : returns the minimum value between this instance and another instance

- compareTo(Natural value) : return 1 if this instance value is greater than another instance value, 0 if this instance value is equal to another instance value, or -1 if this instance value is less than another instance value

- pow(BigInteger power) : returns the value of the expression this

# value

- modPow(Natural exponent, Natural mod) : return the value of the expression this

# value
 % mod

- nextProbablePrime() : returns the next prime number greater than the value of this instance

- gcd(Natural value) : returns the greatest common denominator between the value of this instance and the value of another instance

- lcm(Natural value) : returns the least common multiple between the value of this instance and the value of another instance

- isPrime() : checks if the value of this instance is a prime number, return true if yes, otherwise false

- toString() : returns a String representation of the value of this instance

- toString(Integer base) : returns a String representation of the value of this instance given a specific base value, where 2 ≤ base ≤ 62 and symbols are {0,...,9} U {A,...,Z} U {a,...,z}

- countRelativelyPrimes() : returns the number of relatively prime numbers with respect to the value of this instance, implement Euler&#39;s totient function

- isRelativelyPrimeTo(Natural value) : checks whether the value of this instance is relatively prime to the value of another instance

- divisionAlgorithm(Natural value) : returns a String value with the format &quot;this.value = another.value \* quotient + remainder&quot;

- primeFactorize() : returns a list of prime factors of the value for this instance

- distinctPrimeFactors() : returns a set of prime factors of the value for this instance

- getIntValue() : returns the integer representation of the value of this instance

- getLongValue() : returns the long representation of the value of this instance



# Team Members

FLORESE, AUGUST BRYAN, N.

A Computer Science student, favors the C# language above others due to experience, creating useful programs both for work and for fun.

Built an awful Unity-Engine game ridden with bugs, an M.U.D. framework, and more.

I&#39;m interested in re-visiting these ideas, reconstructing them to their full potential once I have mastered the discipline.



# Introduction

Discrete mathematics is essential in studying the core concepts of programming especially for Computer Science students. Why? It will help you with the algorithms, complexity and computability. The understanding of set theory, probability, and combinations will allow you to analyze algorithms. You will be able to successfully identify parameters and limitations of your algorithms and can realize how complex a problem or a solution is.

As far as the programming language, discrete math doesn&#39;t touch on how to actually program; but rather it can be used for software system design specification. In fact, applications like &quot;ZED&quot; can be used to designing a system using set theory.

The last important concept to grab out of discrete math is Boolean algebra. This is very useful not only in creating logical solution but is very useful in programming too. Software can be made or broken simply on the Boolean logic in it.

# Objectives

The objectives of this projects are the following:

- To be able to implement the behavior of set of natural numbers into a class containing different methods;
- To be able to provide the optimized solution for each method/function depending on the specifications provided; and
- To be able to understand the use of some of the concepts learned from Number Theories especially the natural numbers to real world situations.

# Discussion

The following sections will be observable throughout the document:

1. The Natural class
2. The Unit Test project
3. The test output (if any)

Using the Visual Studio Test Suite, Unit Testing each method is made simpler.

The project utilized the following import directives:

using System;

using System.Linq;

using System.Text;

using System.Numerics;

using Discrete\_Solution;

using System.Threading.Tasks;

using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

**Numerics** : Imports the BigInteger class. **TestTools**. **UnitTestng** : References the test suite.

**Linq** : Allows access to basic lambda query operations, a C# advantage.

φ **The Unit Test Class:**

    [TestClass]

    public class Discrete\_Test

    {

        [TestMethod, Description(&quot;Addition test must meet expected output&quot;)]

        public void Arithmetic\_Test()

        {

//method actions

        }

    }

We opted for the unit test method of testing due to the east in handling multiple methods and scenarios simultaneously. A screenshot will be included whether calculations meet expected values through the unit test. There is no console interface, however, we can still retrieve the output of the program. Throughout, you may notice the frequent usage of var to declare types, this is common practice if you come from a scripting language as var can practically mean any type. Java has no concept of this as it is a strongly typed language.

The type of var is dependent on the type of the object assigned to it, visible under intellisense.

For the sake of readability, Natural class methods are bulleted with the symbol **±** , while Discrete\_Test methods will start with **φ (phi).**

 ///\&lt;summary\&gt;

        ///Returns a String representation of the...

        /// \&lt;/summary\&gt;

        /// \&lt;remarks\&gt;

        /// Your base must be greater than 1 or less than 63...

        /// The table of conversion are the numbers 0-9, A-Z and a-z (62 varia...

        /// Could be replaced with a dictionary key value loo…

        /// \&lt;/remarks\&gt;

In-line documentation was omitted for the discussion section. Refer to the source code. We used XML in-line markup to auto-generate a documentation file in the backend. (Found in the debug folder)

Unit Testing was formatted under the AAA guidelines as follows:

- The  **Arrange**  section of a unit test method initializes objects and sets the value of the data that is passed to the method under test.
- The  **Act**  section invokes the method under test with the arranged parameters.
- The  **Assert**  section verifies that the action of the method under test behaves as expected.

In order to save print material and design space, multiple act and assertion sections can be found per test method.

± **The Natural Class:**

(Comments are extracted from this discussion, refer to the source code for in-line documentation)

Method Signatures are outlined in **Bold** to distinguish them.

**public class Natural**

 {

       private BigInteger value;

       **public Natural()**

        {

            this.value = 0;

        }

       **public Natural(BigInteger value)**

        {

            try

            {

                if (value \&lt; 0)

                {

                    throw new ArgumentException(&quot;Natural numbers cannot be negative&quot;);

                }

                this.value = value;

            }

            catch (ArgumentException e)

            {

                Console.WriteLine(e);

                throw;

            }

        }

}

The Natural class has a default constructor and a constructor taking one parameter of type BigInteger. Due to the nature of natural numbers, its private member value must contain numbers falling in the domain ![](data:image/*;base64,R0lGODlhDgAOAIAAAP///wAAACH5BAMAAAAALAAAAAAOAA4AAAIlRH6gmLYKAzTSxYnovbXaZ3XYInpfkm1gA26mqb0TKc8alY5AAQA7) = {x | x \&gt;= 0}; throwing an exception otherwise.

± **public Natural Add(Natural value)**

As you might notice, in this method and mostly throughout the Natural class we return this, rather than a new instance of Natural. This was entirely out of personal preference and is quite common in the C# environment under the paradigm of Fluent Interfaces; This allows method chaining for the unit test later.

      {

            this.value += value.value;

            return this;

      }

± **public Natural Subtract(Natural value)**

Natural numbers cannot be negative, therefore we throw an ArgumentException. (I chose an ArgumentException over RuntimeException because it better describes the cause.)

        {

            try

            {

                if ((this.value - value.value) \&lt; 0)

                    throw new ArgumentException(&quot;Natural numbers cannot be negative&quot;);

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

± **public Natural Multiply(Natural value)**

These methods are for the most part self-explanatory; for a more detailed discussion, see the more complex methods such as those involving number theory.

        {

            this.value \*= value.value;

            return this;

        }



± **public Natural Divide(Natural value)**

We throw an exception if at all any of the arguments passed are zero or less than zero.

        {

            try

            {

                if (this.value \&lt;= 0 || value.value \&lt;= 0)

                    throw new ArgumentException(&quot;You cannot divide by zero!&quot;);

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



**Relevant Tests:**

Regarding these tests, many of these are checked against an initial Assertion that the calculated value is equal to a certain expected value. In the case of strings or list iteration, the compiler pass is sufficient.

 ![](data:image/*;base64,iVBORw0KGgoAAAANSUhEUgAAApEAAAFSCAIAAAAl3RMbAAAAAXNSR0IArs4c6QAAiWVJREFUeF7tfQ1cVUX6/+FFEcE35IqYBhqiKL6klWhiqGlZbaWF2otWW9mm+2d7f9k2c23d2lrbosTNti2zN8Ufau1GaRmJq2Zqvly9iqQYKsJFUJEXEeT/nZlzzj33BbgXLnDvuc8sn+2cmWdmnvnOuX7P88ycefyuuvHRu++4Y/y1cZKS5r/2vnrdtIuFzzzYtIpUixAgBAgBQoAQIATqQ8DPnrMJLEKAECAECAFCgBDwQAT8PVAnUokQIAQIAUKAECAE7BGQ7eyPRzxD6BAChAAhQAgQAoSAJyNAdrYnzw7pRggQAoQAIUAIWBAgzqangRAgBAgBQoAQ8A4E/P28Q0/SkhAgBAgBQoAQ8HUEyM729SeAxk8IEAKEACHgLQj4S2Roe8tckZ6EACFACBACvo2A39VTHr1r2h2PPzTRt3Gg0RMChAAhQAgQAp6OAHzjZGh7+iSRfoQAIUAIEAKEABCg9Wx6DAgBQoAQIAQIAe9AgDjbO+aJtCQECAFCgBAgBLyMs+fy5L3T5u36ey/ypDkhQAgQAjpAwMs4WweI0xAIAUKAECAECIGmIeAUZ1ftPTzskZ1+4u+JnB+b1pVSi7X2e+Nnv6qt1Oz+eO9t/z0nSRfW/OPnl3Y0r3WpatN7u2VVH9k5clVJM5tr7erHj01PUaD+Y86Octb/rhW778ysdE6TstWL9y7cdVGScLHL6Vr1tn386/3dFDW4kNp+0aKn9686bakIJVXYxUXze3duyCRFCBAChICvIOAUZwOMjld0P/buyLp3h/08onLqh6eaAU/Nwb1VYwf5P7mxOY003L//wzMH1kHbVyMn7jieeqgZyrZJ1bBOP70BqEfmj7s4aekxDS26pE2nO58csXpKsH0d0PDojwornGqsbNt+v7t7V7y6qfE3hhGzhjPMXwxPjpT1d9i7dbe2xO+UUiRECBAChICvIuAsZyv4BA4c2jGqqMpiJLsKXFXp13lBs+8JTdp7rpn2euM9dwu7pb9kPMltVS9MveNDJ52/cLQN1T9esiowZOGYkF37i5r66uCFuJPKhAAhQAh4KgKucjas5Moeg8Mul6Rz6w/0Ugxu9ZpfHF/zj3q96FU5Z77t3XlUl4jkPuVfNdcN3hiopSX/OdFu6qAQKPvBor2Kwa1e84tNRydxR65LXvQ3lnzYe9B1Nn/IbEyh5pYzT7W8SMH80uz274ohzpzqWme1lZNcdVajypA1Vdv+dzzkEVvPtr0r+7jxfHBsj+7DuzxYeP67ppA2889b+cl3H+4n9Gf+dhjZ+X86VzXjjzvjYfdbFgWsFBOQtRXgzZ0wqk8IEAKEgFsRcJazK345HcX+td37UrfodTd3bkCHgq3m3Ylw7cZn9Dn/V7ZKrU0XMr87f218T0kKmjg46D1jC7nHL733+UFGDC+fHf9o3JSIBpS9+IcNl96GR/dPYWHbCjMLnYX2iXn3PzHvAa00bpHpbH3n5HZ9X3qgXxf2yqGk3jcOLmUrFCPzp0r/+G9h2I2GpxQ2Bb/mXxV+S3e7pnefeqauezGvBWc1Wtg3tUPCtb3L3x083V7YqnbR8u+km6+Bd73HlKEXV21v3D1u3TcI++iB8UOYw/zdPlduPLLqdNnq7yrvf2Qoy/lr7FUhPV54vc9fOndY+deRxtkRB78vvTRlEBd2oFjrAO7ctJAUIUAIEAJthoCznC3Ws8/e0WHj/pKGHeORoyP/fBXGA1bu8JPZetn0bGF6fshNrFTqPKrl3ONiPbv/v7tXrTnQsGe53Vv3XjEQ2vTpfnf3i4fPuDANYJGHZieLCrhwJ2GXlF39BDf9C7v9MDuiozWPLnqaFfWBrVxUVWlhUyw8106JD7MW5jXD21/1a/F1jS1gYzXadvl599n3I0Incl4fMaQJ7vHKQ6cuvvTuXm5nw56uOXisQ78el156N0e7c00dXA9Du+/W5vDdc45TCwLuwrSTKCFACBACbYmAs5wtdOw8+YqP2pW+31Sf9rkfz39WXpYgvKPPmD8rb1H3eOcHZnc9uvHUwRaDd8Fzvwdb4w8X7uxE2YNW91SUtSUMZ3JB7V3cTn20c1/e5Yjx3fxzik6zhecu80a0c6BG76hVqSO/7lF8mYsbuXftKz96uDhcTNbSc0cPN8E9zmxobjqz3YvzR7Tj+9QMh18VvnErZbkLod+g7/f5WTvttUItBbg7J4/aIgQIAUKgBRFwjbNhPU+ZGLr2U/a5V/ue7QzyPrIL3+13xnEKsQvzH1b/EYfVHvTGxrymb2drFJY+kS9eXnYP+9yr/RU9Li3fw7/7yj/9aQNd5h+d9OIvB9kHY3vnfF8ulZ58ZoGpAZ85WMTNhN3AoI5X7rkQODCKETMjVCHZO2x6TfkH2/jCc/11GSM+2rmBrWR2n5MVZe5tp2HckTvHXlz4Xyd3mws9ggf0vOCoClzisendq746ZG9Ss73u6KgBP3yrAt7oA0YChAAhQAi0LgKucrbUYejlC/qU4XMvccGN5gPfBjn4psh2IBrHuCiCe/w3v57/XwuSdodxN3YJ+w6fe4mLo8xkXFYVix103ph6Rz139UXs2MIo/loWJOxsSeqUMLhu0a52/29cPVOgbvtaWv3qA8xwx3b0Pjts96DZ4qFxjIsiuMcrDp5tZKnBqhUQcO+79qEjddOZuiUtZ4Eh4inmFWAr5WIP2mbl826sCLzr6BM1b5wx0pkQIAQIAfcigFicc++aNs1bYnGKg0vT0tLci0KrtdYS+mMreHJR+He2K9+tNibqiBAgBAgBQqCVEPAyzm4lVLypG7HIPQirxd6kNelKCBAChAAh4DoCLvvGXe+CarQUAvxz7fyfJ8QSYbcUxNQuIUAIEAKehABxtifNhou6iM+1nTgi1MV2SZwQIAQIAULAIxEgzvbIaSGlCAFCgBAgBAgBOwSIs+mhIAQIAUKAECAEvAMB4mzvmCfSkhAgBFofgUFjpqt/rd879UgI2CNAnE1PBSFACBAChAAh4B0IEGd7xzyRloQAIUAIEAKEAHE2PQOEACFACBAChIB3IECc7R3zRFoSAoQAIUAIEAKOz0GbNGmSk9Bs2LDBSUkSIwQIAULAuxDABjRV4QNbVnmX8qStLhEgO1uX00qDIgQIAUKAENAhAsTZOpxUGhIhQAgQAoSALhGol7P/40SqH5HDaaP9LGl02mFFdMM8P81d60GKfuU0rwFnPtR2Tjs2voYaamxgVjCwxmy7Zfo2p4NGFGiraWgMFyonBAgBQoAQaACBlrOzE5bk1ImUM2tFrEJAk5bUbZ3b3w1TAtZxmtNAipOl9bIygw83dQVew+j9526tW+Lsmr/daA+nzd+15CMGA3+3mb1/RIJGhr9erJVY0FH75PRbBa9ar/SkJetHzHuzqUC4YfqoCUKAECAECAHXEXCKswN5ApO43j6rAYLLWbJrvsXYblozTa+Vt3/b3Ntlhu0/d26TubbpGljVPLxhxYiF4sWFcX/d1scGa8vxWlNXt+R2N3VWXzOTbp+btpZIu4VRpuYJAUKAEHArAo45++mnnwZJi45w8e8/rvnz+NTv/7tPzXRVh/6TZkkrNsBDrprHFu+5bC7bZDDBNGaFCq+x6tvmt7ibnCalTVZKbYpttWP8NNne6W3xl9uWae1T+Rr/iZ23bdu8WO6z1grYN8NLN8jLA3b9grKlwdGuIsjkrXWwQ8Umw0baFnAi7aZMAdUhBAgBQqAtEXDM2ce+OweeFuY1Lnan7z19vPSLJ9cFBAS4SdkNb84bIXuruY95w7zYFbNkZ7ridE5bIX0EK3Ruf7Di2ttVP/vstMMwRdfPleaiAeZotyu20xHy3EGvWSNmtK/6y1HWmKOdOwsSuMNf6xSvr5lt8+Yz5etylki2PmhY/SP6N2l5wFoH+2Fzn7sAEbjYSNsALknRgxN2HVY3GrhpXqkZQoAQIAQIgZZDwDFng6TxB7YWhH3zq7e4QQMrogJhaE3fDWvT5sruYktPSs7hw7u4Tc0Ss3X351lp00ixLMu90HXrpcliGRyV5q5XyLc/emqao7jeZhLEerUEB0MLMaODYffvPwKOAMdvHzaAu2E+qQlCgBCwQqD6xA+p9429ols79k9Vu26XD5u14lBV62FUW7Lv88fGy913jLjtXVMrdt56w/T1nupdzwZPC+bGxcTbhjUTJ5jV1v5gTqEfSbOF6Qv+SWjQXWzZ0MbWeu0WpBsptiiPvVdNZOdmAtAi1e2GzZfCb18LUO088taAt4g61Cgh4MMIlP3094mDJzz5Rfno5z9ch69uPvrznbEXi87VtBYktaZlt4+6a1lh0sur0Pv/vf1Ar8rzrdZ5aw2S+pEkp/agNRMo5j+W90lbt8R4hHMoW+6eB5+34464+Vj/JudGitHmhnmq7cmsU5ZQKW2ykgufcpq6SU0u3caX32GQb1ixrf7xN9yM43pu8knXO2y2ELBE7B6wTSrgrKDpPvpmPg9UnRDQHQIl65+/49ltUS/+cHTXx8/cc+vNN998V8ob6Z8/eXVoaw218ODm/ZXj3/zPP38/Fb1Pe/DVpY+1XuetNUjqpwHO/u9z/xmePBR/uPhu3R4Vq1s0qUEA+XYtnti6se0HXurGLRTCbgaZ4OMjuYKdc3fSEuw7l53jypI031cm7ElHxVaqTXps8HxZF7Zqzu10bSU1U6016TGsQ3N1NB9i8TcLsQfNIqhRzb4ZhwAxsrVx7zv/JGp0sB+2us0MmnDXvEbaBnC8yGA5QtlM73z/JEkIEAL2CBzPfmdF/vC/fPTsmK4Ovq45ueae7n5xf1j62m292vnd/plZqi3c/PZ9o/uEBDAX+oDbX/kuv5q1uedvA/x4OU+aO3G5fPsXT43p0Q5Vrnz4k/1lddZqBHfqFiRlL/lgW3GttkD0/dKP53mm5k5c/mn1qmd4m71ufPPH08e+Ejfdrkz54hhTySkhqSLnyxdvG8iXBGyrqoM+tnV+bECX2WuLhNq1+99OCLLc0jPlAgJXT5n7xnvfyl9SK/9Z9kw6/sQdLub2fVH82YjRbdMQUDazNa22e2rJe/jc0xi1QgjoE4G40cnqXwMjrPjpb1FSzB//d86xzImMu8PwBc7QP20y10Di3PZXRwUH9pudun53zt7/vnx9d//AoQt/LKur2/1qrCTd9mmRaEVzxy87R0547OP/7f15wz+m9fSXBs7fhhraVHPsv4+P7OIvBUYmPvbJ7hLWExLvWxXW3PHLwI5X/T595/7sVNZkeO8h097I2vvjiodi20uXP5l1Vq7dmFDdiS//+Niy7IP5J3K+fn5EsBR4+6cFl0THlkHXlW95sb9/51lrCi9Bq5pdrw7yF11QchEBySFn2zQC2n4x8Y2vM3a42HgbiYOOtIltL/e0BBWtFqNbW7+27r+1x0v9EQJNQsBJzj6T/WKkhbMFW/EkyJJndL7/y9Nch4Iv7guXKZHfmzPnREi9/t+3pY1w9ohXd1eIQfzy4Y2hUvzCHeftxnTh+JZ/zRttwHe64RPe2FYKemyYsxUOLd/8XJQkjX/3l2rW5N6/x/uLdwehuUy09QlptbB0Zz1oxtPG1FHtRVucsi3jadLU+Gwlp9azH/7bnQs3PX7D1JEu2O9tKMp3YllS088ra7kxuO04uCaq2Nb9N1FtqkYIeCQCXSJjo9vnbjWaLzL1ul75/z79z38+fu5aq7XsXpcb2nPlzTk7S6QrRw7qLA8lPLJfF+nkr0W8bgOpz+W9gkVxh85h7aWamhob7zhK2l82+sF3thzP+/qpiM1P/OHfBxrbON6rb2RH5szvGNo1CJZ8p07tWPvd+w3tqlGkUSHsl3/3ieSxg2Iv7xY17dMSbVVl0MgLGPyblBukdRlbzBf3rv/o4PDpN8bK4/HIOfVYpZzibI/VnhQjBAgBQqDtEYhOmDUq+PsXnlt9BKvAHaMTbrj55vHXRAmOtk2G2JFh0s87D5yTC4oLjpyVBg7rFyz5B7b3l86VlXH2rq25eMmqqlIg1ZYe/+W81KVLqHzslV0P7S+7fubMy6WdWw+Uoc12aLNU3kKORu2JvpnwVWz9y/gJz+y/5i9rNm47bEpXfQz2zUZPnjszeN26rG/WvJ87ae70QUTZTYGeOLspqFEdQoAQIAQsCATEzPn441mB/3d3/PC7X/vki//+97PUP//9mzMOIeo5+u4ZfY6/9dv/9/aGPYf3ffvmIw/863TCw3cMDZV6D7suQsr+258/23F439rn5/w116p+9oK5r3194Mi+r1557M8/Xbrh4amxHbTl+96eOm3+sjX/RcpIe/SBv+aGJ08f1VXq2X9U//YnP/vrO18fOLj57cdS/q/U3fN2rvjXUrxdBHXoUHt687JX1mjtbJu+wkcl3xmS8dijb5pn/O430dymp+QqAsTZriJG8oQAIUAI2CIQcPm0D3Zve/+3ET++cv9tt9xy93Nrz42Y8/rfZw4KscMqfPIbWzf+dfiP828aHjv01leO/+bDHV/9YSiMzm7jn/nX01eXfXrf1cNu/XzAH/4QY1X1hqceuPRK0oChN/81d8zrP3x8f19rzuvUJ7Jo1Uv33ooPe2a88EPE7z7LevfOyyEy8N60t+7otO2lKcNGP3fq1mduU5ba3TaFPZMee/mO7psfHx0z/NGfBt97Y0MddBtzz0MRhcf9fjNtjKGJ4Svcpre3NuSHPWh3TZv2+EMTvXUEpDchQAgQAi2DwKAx09WGD2xZ1TKdNN4qvvUa/lzcp0Vr7zI0LuzREmWbnx9+3adTN+77+3XKer5H6+uBypGd7YGTQioRAoQAIaAvBGrLT+dufv/JuW/9es0fZl9DhN3k2SXObjJ0VJEQIAQIAULAOQSM74zpn/j/NkS/+PWq37OFAEpNRIA4u4nAUTVCgBAgBFoHgWHPHqqr83LHOB9DxdEvnp/Yx/F++taB0vt7Ic72/jmkERAChAAhQAj4BgLu5+xLly5dvHixqqqqkidc4BaZvoEnjZIQIAQIAUKAEGgpBNzM2aDnk2dOvvfze49mPnpnxp34wwVukYmilhoEtUsIEAKEACFACPgAAu7k7Orq6vW/rH8k85HPjJ8dKD5QWF6IP1zgFpkogoAPQEpDJAQIAUKAECAEWgQBt3E2zOgNRza8vu31ovKiyprK2jo5IBwucItMFEGArO0WmUZqlBAgBAgBQsAHEHCBsw8ePPjPf/7TISZYri48V/jWT2+drz5fJ1kdaHtz7M2Z92auunMViiAAMbu1bTXsM49xzSJiywkxnzV3rTIb1rrY6OO6BtX7Xh8R/sctcsXyL+7zs9zxTCbQ8aaP8uRLm1LXO6QahID+EDi6/MZg/o/DyMVGvsK2+blu/F6Tpcog74EvK/UHAo2IEOAIOMvZIOxrrrnm1KlTDnGrra1de3htaaWDo2wfGfmIoaPh26PfoiIEIAZhu0YsgSlzZq2I9Zu3gUu4LfoUyF9usrFp7z93K48IZgkvvXVu/8Yqgegdv1uUf/33v934xV/HSBKja7+ob0JnW9pidO3XNSVv5DCR137IH5Y/+/1fOH9TIgQIAYEAyHhQ1rwS/rPc+WQ8O7Dz6C+7B/59Hw8bqWRJJ0w/zvxCjlX5wW/o+196fPSKgFOcDcIePXp0WVlZfSiAhjf9usnGwoYwjOyeoT3Lq8tX7F2BWwhAzBFnWxoGaeYs2TXfYmx7MfLl331pfmMOGFuSQm5dXldX/NoNmtG0H/L0rrqKb36HaPZyaj/gxmmln28i0vbiOSfV3YzA5ncfi1yVZkfCQ2KvsA0xMSy+b32BrtysEzVHCLQdAo1zNgh71KhRZ86caUBJvO4eLztuLwAj29/P/9N9n1ZcrBClEINww+PtP2mWtGIDPOSqeWzxWMvmsk0GE0xLG6041nErErd+cTc5TUqbrLrdrYudwN6ugjYDqsTO27ZtXqyfrS1f/t3/rRkeE+1EB0TaLoBEor6EAEzq5OH5U61d47Cp37u1o9YzzkzvH58a0p7l2XvG4Up/4MsNwp+OUsWNrnjaLW51cqr70rPlpWNthLMFYZ87p4R6rX+Ul+rkL7A/u/MzLGDfGXenjZEtqqpiruC14c15I9ZzR1jdkkmouGFe7IpZOZoM5KWtkD6qq4MjG3y69nZRBj/77LTD8LDLnm7m5rYrbkwR+wqH0+bvWiK6R4vcMZDAnftcOTVVHzmUc83AXo21b1Xevt+A2O0HT7pUh4QJAf0iwOj5sZ+Eazx70l/uS2UL2mNfLRW/cOQMmcMXr/ve93UlzzryYcH0sfKytwaWD2/99NqTorTjncV/P8cuDX9a/DXqckteeNXd61Q/ueae7sqyu1/cSz+eb9VpQlyR2z8zW3XpIKtBlTCA0Vq1cT9LNImWWmJAth06C5gV0lqoW0jPhvSy1oXNv5uRaoiznSds6NWjYw8xkMzDmVjA/u2Vv7U3slEKMQg3PhUj+mtWkaMHJ6RNtqwYb1ibNneh7SqzknP48C5uU7PE7N/9eVadNVJsr5iDCv37j4BZ7eQCeeNDJQlCgBBoAIERf3/yRr4+PfaWR44Yj9ZoRMc+8uYNB3N+0Z780Pe+P/3BRopVuP8L7l/ve8XwDvcvmMtWxdklb+qyuFGf3+qA5ps3KWCLy5bfclC8W9TV7b6/+IiONsbhIFLTn0eFNg8it9aOnb+tTEB94q+5N3WSX1fcpqfzrzu9pn5yms/4q7G3fVrErpxAypWXlXo522g0Xn311c5Y2EA+ICBg1GWjxBSk708vu1BmCDFoV7LV2YEYhBueLJjV0uBojQzfGPaRNBs0DKYEiyZYFdu2ZtnQBrysbV8m2kixvW52FWC519XdvlZxvrv10aPGCAFCwIIACLWlT6fmJvrq8Kc6u3HD+Z6/Td+6QBs6c9izS7w+jqaXPJcgzX0ZIanvtLJfo9XQqZezN2/e/OSTT75knZKSkhxqBhq+Y8Ad7QLYrhB8jf3h7g/BZzYr2SiCAMQa5my2+rxryUf2m7UZca+fm7Z2A1vungeft2OMuBH8pth37iA1Umxfo94KIO6cJWLd3XFqip+7Kf70VntWqCNCoNUR6Dvuri7ChY0N5H956/Zp12u3hMOtbb7zhgHa3WgOpJxRmhF39rNrM751izG85+t/x8243kGsa25Ppf1xgJ8fNwQ1flTFj6016JRrXmvdR7Kn3eLxtlRX8tScuJf+d9bxuHf/Db0rHlsmr7ZnddMwaBotcSncmrIL2GqI9gNkNV9Lw1CEuG1tdHsqQwyUC1g5t8XNYRuPvQNNe426s9/6r/bz6mJ4dlBZZ9Q7L7w2D1+es+7uHrLS9rg39og5AEleNkEHaG7ItE+3LUzoJJ6KRlK9nP273/1ugV2qj7P9/f2jukU9euWjordV+1dN+XgK/j7a+5G2fwhADMJ2SvEtXDxNltazVWIrCXXLFwphN4O9149QKti5qCctwb5z2TmubAubdPtcZQ+ao+IGMbKvoG6Aw6o6f7ngbxH2e9Da9Y3vvzs3r7Ep0JRXH/o6o9vMcdEuVCFRQkDXCIBMN0TMZhvO+qVO+mkZc3Bb9owlFn60WXz+pX6xrUo5jYpaFa3Zb1B3uhmN4Mkje8OG9RMvF+q/78o/xzkL1w/ZzKJ0XcQ/1X+M+Up4dHePXjCuoRXvnIXP/ZJyjHl+M0J+/7DM93fs5lm8Nsvb87fx08rf4f7Y74b/790cB7qvu3vJ5eidOes/v//1HztPfeYZ08pvOVGc/HH1kd8//xvrN40cxiRKumzapzbfDoGLXhLtMZf0Y68L21YdokFxFDO1Vct33QeF0Bse43Nr7pkAdwSvrjiQlYGeyBjxzitfmofNenUEZ18k9iY0//ejQpowJXtWPCcDI8KjASkVejlemnZebICFh132dAulbXFvRCF7kKzV4Y6BuxOYc9+p2G1XT5n7xnvfyosuzfgPTko5c/7M8p3LE/6VMPLdkTZ/yEQRBCDWjE68rer5dbO7P/8/p7W+sPe1hCnLjzotT4KEACHQogjEjU5W/1zoyLKWKVc6kXH3vWxxE//l/zZz1nx1iroGaynRVlWutbXUhVIUarli4PxtOXInok87HWyylEYddyJoWKOtfM9HobYEgTCtEmwB16aSRk2+vKtRy7Z56w6VUlXKwYCUKbFrScFbM7gwCRDJS96O5kczL7bAopalhj3ucqM2z4dawwFIPMuijj3SDT1rjX/r5eRLDV7FOnfsfPvA25fesPTW2FsjQyMD/QPxhwvcIhNFEHBqA5qTXbpFTLXhxbuke3eWhdz41LNf36qeg9awwtX73rrvb+P/NJusbLdMLDVCCLQZAobYq7Jl67UldZD3OCl2akXOjnqP0KhfDViyIV99a4aV7Z/ye9e3lVn2fkENWzMRFubMio84p9lQHdPHnLMjYmC/xjay9Zr6zO0/wdLe8/UPM229APWNCnbsrn6yo4PLcHv/u+GpUXxRQusHcdiEDbC2KjZSbN+kLUjW6rj4iLiNs9EvKK9TcKfBPQenXJ2y7KZlq6etxh8ucItMFHkcYUNpvp/Mkuy3rLkIqLU4OzelmJ2D5kRyRdaJ5kiEECAE2giBXlNf/1fI7xt0dkuSIbbbO3BPiy/AGMtMvmlwKHJVuocvWHVv56ySHcQn17z2Gl8rZ4ILrTZaDbvxtyYlh4k59I0rrxJqhxIWfy999cHa1f43OVqBbxDBXv2GliyEB7seIXBj8QDBytqxKNJM37u5n7/hNOzG63766qOVP1zN8OGrDVZfoNlWZqvPH8788Gm79w/GlLtfxVJAOyx3W6C3rW8PrJVEI8X2Q6kPJFWdRgGwbtOdnC1ou11gu64hXSO7RvYO640/XOAWmZ5I2I09LFROCBAChEATEGBrlOybI3kp+LI/xvzeZqWY2X4b7/9cXi4evnXBJv7xFMzKZ0zY7YT00q/Xq17a2KuK/wwj0c8PLX31MVuStaouNkcNe3aV0uDE3dc+YuXilcdw22Wbx3Kd1A7REkj7b2/bK+jEsIc9+z3W17m2SLY7qOoZi9qutnZDHzGDtD+fd2BWg14Ay8I7RlZk+3mVugcMhe/dxZbZLdDba60pVHbW8fcLvgets7auU99e24Nkow6fgn7vOLkHzQ/r2XdNm/b4QxOdmCASIQQIAULAhxAYNGa6OtoDW1a10chhWWLb04YW+yC6pdtvNmxiF5dTG7Sa3ZfHN+BmO9vjx0sKEgKEACFACGgQsLjJPRMWdTnAM9VTjWbHzga3K02c7XZIqUFCgBAgBLwCAf4lmsZN7nFKM0JUlwM8TjuuEL4E026JanFvgEf4xvEBGIJ9IWHowACvKzh3BcnRl9yeOW2kFSFACOgQAc/wjesQWBpSkxFoezu7pqamuKz4i5wvXt/6+h+z/og/XOAWmShq8sCoIiFACBAChAAhoDME2pizL168uC1/28LNC5fvXf7N0W82H9+MP1zgFpkogoDOEKfhEAKEACFACBACTUOgLTkbZvSPx398Z8c7209uP1l2sqqmSiwL4AK3yEQRBMjabtrUUi1CgBAgBAgBnSHQspyNaJ7//Oc/HUIGbj59/vS7P7+bW5prE1T72j7X/uOGf7w8/mUUQQBiYp1bk3B6mfbEMpwAbgnVadcdhG1K1RPD1ZN0G6juSH3t6WlOH53GenVa2L5X1md91fNX3dll+upSudKOl6P8LHc8kwkM+ctOFgDBWlZnzzMNR48IqAeMj5QDY6tHhPv5KVmWQ8jdGJ5Lj2DSmLwcgRbkbBD2Nddcc+rUKYcQYcfZt3nfHjp9yL4UsbcToxLLq8tRBAGIQbgZOOOoMznqiEL1PLgn0vq50tz1/Mo2LImD7mxeDOSKdeslTWjvBrVkvTp9zppVb/wVYa00t77md3z4tP/7797ZTZIYXfu9duqWyy2ijKP9bvoqQjkWqM/0f7x3afESzt+UCAFPRwBkPChrXgn/me4UAUGO/rJ74N/3VWuzpBOmH2d+USE8dR+wSCKUCAFdItBSnA3CHj16dFlZveffgoa/y/vOxsIGxDCyB/UYVHWxasXeFbiFAMSax9ktO3GIGbZtf14L98EOWF1ye72UnZn98LM3g7El6aoXEehn1QM9NaJ9pq8+W7fv5es6q3l9Rk+/7L+ZB4i0W3bWqHV3IIBwm5Gr7MNtDYm9QhuBk/U0LL5voDt6dEcbmhiUeN1u6Iwv13pzIVxmQw2rnxTbx350UKQJ8GkXk9pFcUuYMwUTzdfNSpYWPNtImtZQ2vVur6qlMffNgmtz5m7pFuFsEPaoUaPOnDnTgLb4vuuX0l/sBWBkt/Nvl5mbmX8uX5RCDMLODZxbpxvgg2ZJ8XfL1jWLzJ0mKTE57dtT/d1yPYsDHR5p3MTO28ZDhtbnn2bdpLGuRX2L+1zRQ2M6W7UtVNFmOdGbRv8dmf/qOlB7IH6jWBFpNwoRCXgGAjCpk4fnTw3mv2jFDw6b+r1bWXhONYeZ3j8+NaQ9y3vgS9u3UbjSH/hyw3Pd5FLFjW7vVrev2nQULHEhEKXypk7OREaupzPNAdvsjOrmfgCM5uQImGpcT6VjR0WWsJUifKc4H50nF8WZ/JDltxxUYprww8MRtlQJt6UcOIrYIYkifJgSdcQcer+opVVBE4BEDk5ycs3TD4mQm6rcyR8LpouqbBbubfxw86ZPeGvVdD9nC8I+d+5co0O4UHtByCwcvxAL2OOjx6tG9kd7LIG3VbFGG+QC2+bNlz7CFOUskea9uUFTBy5y2RfuwBEOhl17u3hKcmatmA3W3fDmvBHCb84c2vBr5yxJSFiSw+806XDa/LS5t8tZaStY12ievR8gELjSXqwVz4ORZ3MVkeBZ52Ub5iEYNxoX3dXbmyMI8o/s6TW0bwfn0JGl+vQbdnLv0SqX6pAwIdD6CDB6fuwn4RrPnvSX+1KN+JBk7Kul4qeCnCFzOEUjzHYlzzryYcH0sfKyt0bdD2/99NqTorTjncV/P8cuDX9a/DXqckteeNVbxqnO4yNbwke3PohWPWrCZPPzwDXxxxwVyUGrGb9qY1lzyrYE3FZbakCcxUEpfwenfdsAEGMf2+sKJfq4LDps0iRRC8d+X9pzhE04DkdbaxsIhJE9C5+ikes1de5toipCdYS3MfTu6d7NnO08YeOVt1sH7s6VpLNVZ7GA/cDwB+yNbJRCDMJODzdhyUdz+0O6/6RZCbsOM4vXiXT48C5ugbPE7Gk4u6MHJ6Q1tFItizOqVVl87kLetYTm5q5XcvsjN22t5u0hb78w2FmC5c+U3LA2TanrhLYkQgj4EAIj/v7kjXx9euwtjxwxHtWe2TD2kTdvOJjzi/Z70L73/ekPNlKs7v1fcP963yuGd7h/wVy2Ks4uOYqXxY36/FYHNO9OiFkMiPWIzKWNSaVe84u0Pw4QcSLZyWSaUzCZbTrt020LRQAJbX2LV1njVB790rqPRANypl0ULKsImAhSVXjwiKKWg6LDsINVAmURqhhjomfmNnBWXAYSJvU1Y0ofE6NTVEYbH4uIKKrrGnI/suEi2Tkn2CuBYGVzTunkiHUjNUixSGlKTDSLnDqLjQbgdOd8t2Rb7uRso9F49dVXO2NhY0Q442x4xHAxtE+Nn1ZUV8SGx4qVbK2RjVKI2R2IBkJ1mo+dhI/b0EoSlnVd3UfSbDwUDr3hyh40J3av2WugVGb9oQFwfMLgaCcVJTFCwHcQAKG2b+HRchN9dfhTndtww3nOwvVDNnNPMA+tzBIc16kItcmN9LsTmP9Y6xRnAScRv0pIary+OQuf+yUFe1pOZIx4p/4gmS2MqOPmGT0/u164xlXftXrwJ3IShOtai4Aaz1R+QVEjhXBif7sdj82tuvhZuK7RC9gbAKJ28+BnFsZmbvOmxAdvE6ga7NSdnL158+Ynn3zyJeuUlJTkUAEcTXpr/1sD/dmukYKyAhx8hmublWwUIRNiELZupH//EdtUz/fhtNnzpFmTuIXbxGTVnqYNRtzrra1kZ3pAc2nC541k5T1nGcyCn8/XvJUEn4A0jznkm5Ka4uduij+9KbpRHUKgeQj0HXdXF+HClo4u/8tbt0+7XrslHG5t8503DNDuRnMg5YwGjLizn12b8W3L7cx04ANWNYud/7waqlOmp8tgXQs3sIPEbNZPFTez1sUdO18EjoZhfyOzoBkDbm00IJhTQhY1QLRNW1QfqAzT4uNWWoXj/W6usCWxccmecOVQ7z//OtZifN82X0TnVMbKXBQgdfZO8N3w1CjVSGf5E3enHGuazs48Pa0q407O/t3vfrfALtXH2TCdB/cYfMeAO8RwP9n3yePfPI6/5XuWawGAAMTsDx6ftCRnyS7VmT1ivXPWLvZ417MHTdueMKzVPWRYmOZubk6sDexB06ptpZ7We86E8CKwfoTiHBc71qyyONm70FvEgKvzD9b343b4NOVvXXXi5imD6IOYVv2tUWdNQQBkuiFiNttw1i910k/LmIPb8il2YuFHm8XnX+oX26qU052pVdGa/QZ1p5tpUJCFzurnzD5Rzcaq3a86CoDdbH1kd7hox8q9zXzLFtoURf1ldziXtnEvuy7etbnaI0L4q3wF3sHqdIFleV1EIecr9SLO6DHbgNrNVaQt6yN+9hvvfWvxCrfiFb7gOnb62KubXh313qiR7460+UMmiiAgYofoICmb2Nw/lJ8WXp6cLr5gdSb9uvKOhJd3yN+yOlOBZAgB30QgbnSy+ucKAidkdzavw8h3oLw5GtfyJUTCxKVGmGXeJvZMs1ri0rqcu8k1pbxcVNL2qlxbaSJc6WofdhUdFLGeZI3VK1wo/cnaWirai6saOGpdBdVST81S5XevXy9vI7fGx0YvC2IcH166+9UpyrZ0V+bPk2XdaWe7+uoB67l31953x9/9bMKziX0Sw4PDAxDQyy8AF7hFJoogoJfoXoc3rGimB79egK+6//VLDz6inoPW8ETkr3r8Yf8n540kK9vVB5bkCQHnEciR91H5sViXRYqdx/Zev8M3WE3M6DrKzu7k9qHYk/XSr9fLdjbbwMbqaHdkDXv2+4yQ33NBV2NV9pr6+r9EVbsgl46KYNpiqZlpbBez02VxZblZ7diy487SuLq3TpUynP9woNhsptEYCLBv6DR6aTGRm9PsZ+P1m/HFnfMz38KSbR+LE99eV16sPH72eHFF8YUa9vVXUGBQeMfw3l16B7cL1gdhi0/D2ZlrTp+D1sLzTs0TAoRA4whQLM7GMSKJ1kWg7Tm7dcdLvREChAAh4CwCxNnOIkVyrYVAW/rGW2uM1A8hQAgQAoQAIaAHBLzDzvZ7YacewKYxEAKEgDcgsGBCr5cmRkJTsrO9Ybp8S0eys31rvmm0hAAhQAgQAt6LAHG2984daU4IEAKEACHgWwh4H2cHBfrdNrDza5M7/+Om4rdvMb7zm+34wwVukYkiCPjWHNJoCQFCgBAgBHwDAS/jbPDxA1d2mz7kjH/AFz8XfZpxaPnyfR/gDxe4RSaKIEC07RtPL42SEPB0BPAt68WLF6uqqip5wgVunQ4u7OmjI/1aHwEv42yY0bcNLN1e8Mkq06r95v3nqs9dqruEP1zgFpkoggDEWh9K6pEQIAQIAS0C1dXV+SX5b/745sw1M8d/Mh5/uMAtMlFEWBECTUDA4zgb0Tz/+c9/OhxJr06Bj14dvCHvk835m2vrarUygwyD5oycc+/Qe1EEAYhB2LqR8O//NLJukfL3p9jfKsXvPT7y9EOtG1l1ZOxpVRNxodHH9VkMeOp3wy/8v95yxa59jywasWeKthkmUPNczHTkBUdsfdGm1PUOqQYh0JoIDO1/6i/8Z/LiwMd5/MzFKSOU3/LwLdfyAEKqDMSe7NurNdWrp68LFy58mfPlXevuWnlg5fGy4zWXavCHC9wiE0UQ8AA1SQUvQ8CzOBuEfc0115w6dcohijfFdqqo2QNWti+dPWw2OHtoxFAUQQBiELYTq8nK2InPxvD34Kng9xcNfo9LPPyPnd3/VeyGeZs6uO7xKKfa2ZnTnauBbnN2cJX+kvPvxmr+9qFhjt8tul4+t1d16tvHJan9p0+NrHui48VSS1vdxg4sXTTsmeCasyKvsvCm7yt6D+P8TYkQ8HwEQMbTg759jf9MXj74jypoHDYopHbrV7v5b3n3mP/x1/fe7cJKSy7jPyu/xUdPtvW4YEb/5/B/XtnySnWtA3samSiCAFnbbT1R3te/B3E2CHv06NFlZWX1oTgtrnPmL5k2FjaEYWSPvXxsdU21CLwNAYhBuIHZ+Pe/9jx4NHBaK5vXLfN4XD45JDi34GnWePXdf9/pN/+w9mP20s0Hu72wa8BPNWrnpTtLcwI73jekZbShVgkBtyKwOKlT+d5D956zabT2yD4rTxuKz5yv0EZydKsWrjWG5eqCcwWLf1xsX+3OQXfumLNj4+yNKIIAxBpb22bHb9sck81O6Y576Ufr0arHdIuTud14uLa25ZY5sBsDGm07Htcg9yFpT+FsEPaoUaPOnDnTAPZDIzqYik32AjCyOwR22HZ8257CPaIUYhBueBr//XOl1DMMHnL4xg9NZbIwZGWHm2wuW9zpXCDq0KLB3zOZYd+PFLfC085vYWRf1UEKD1dKWbOiNWcd72jB2k+ubQG6vd83MKxvVJ3iHlBG1/7Vy9sXmTWWdaNPb2Xx/xX7jbiyW6OCJEAItDUCMKmrT3aOq+U/jdJHIvibeMfLgoPueVabI800BHa/vPdZJhb/se3reu+9C+M/njqoWi4Ny3zeytM+876hon13OdURinDVwVUOLexHr3oUA/hg9wf4fwhADML1gczJ0hIrhInxoBoOw4sgqLUctUtE/qqrcyJeNHpwioXlWGN1u0cvGEfk2rY/Co/gbEHY587ZvkvbQNOpvf/5i/K75ayhs4QzXDWytYG3IQZhF5GNerZvzb+Eb+0fx1D3vcejhp46JnzpA9aIxjoMlU74vbBn/E4QdugmIZxROXRK7G/X7PfbUSUVF/NSRtjj8oQf/tjenpdxjm8wgbCjz6t++9fhABgZOy2k7EHeBVz33DFQU3IU+ux/WNtScLe+HWqOwy/uQqpdVVIb1iXEhRokSgi0DQKMnsd2KevDfgiF+ZdFfs1Wr48PnS9+XMjp/fN0Fj/78+V7A/iP5a4c/7v+IC97a1QOuqdfZbQoffbyLpvgVz/6dU3I729F3d5/vOLSZ39zp1MdNPy//P/ZAwYju0uHLucvnP9478eiFGINcDan4bVzLte01GvqJ6frTH+7vo3euIfd+NtLe45Uts2zQL1yBFwlNvfD5iRho+Oy6kuh7UKFBmLT2f3D7rc3slEKMQg3rmv5Bc0qcvnJyg4PWfaCRY0Lr8qwXedWckYGhUsdHhLv5tM6hQW3G23VWXhMiBR7lbCzo5KCA3tpf3WO1Ppt90Buo7MqzJ7uFCLtvFAc3Ol9JxfIGx8qSRACXopA7dZtv/L16eMbiv0jLtP+k3X8r79c7NotTGtXf768ZH+7wJHtbQZ74ZP32CL35+aa2pKzd7Il8JID5XVcqOJEZdA9Dmi+6XDBxj1V7mBTjjCy3//5/TpJdC1BDMJN76mRmpZQl7I1bZUBI3v4cznrEPqTO9pVF7id292+F4u7XBG2qd1wz6JBtcrtHxe0GAT6a7iNOdtoNF599dWNWtgC972FVXHhceJ6xd4VVTVVCb0TxEq21shGKcQg3PBsvTeuk1RWrpEpHv+XnX6Z0usgTjAlWLny4tYGmqiUjWD+vm9t+7Jalv1uGjO9IY24DS1vkeOG/rEBuM0LdcG7rr/Hk0bk6wiAUFuO0gS4JVNe2em3rvZZfFfSAhvO189ajwVs+AXtjewWnlvQ5h27U44xLznzaT/8mVnas+K58neKeA4c5zDjd78ay9zeiO59bs1ra2cKn7oS69tev5NrXnstbsb1Bkl2xKPh+z9/5UszXPbWta07Yh59W1WQNeFDucM/17316ZkWRkM/zbcxZ2/evPnJJ598yTolJSU5BDjDdG7KFVMC/NinHQfMBzb/url9YHublWwUQQBiEG5gluC7fiik7Gn77eJsR3dxTnjoeztL9kqdmI/aYeJG8LN8FdxRKs4tD0wa59wecl7/36drwvpGiH3sVgku94wyse7uOFWWHq0K7K185+XcgxkwPSyg5Kz2fcW5eiRFCLQ2AiXLT9aNSricfbs1tP89Paq3fn1RowLc2v6HjMXan/rM+8IGny1/ppF1Nrth7D3c80+F+7qEvOaOkx2w/6tnSE/Rx7Kdy/D/D175oL2RjXyIQbhlQDXn7Ni2MKET344Ge/rQwSPnDbFXZd/teEG6V7+hJQsT7gWxO0rMGEe67I8xX318lwESih0tN2xb26YjB6qYc0p//+HTo7jfdNisV+/u2jIg6LDVNubs3/3udwvsUn2c/VVOWcfAYYl9EsU8YJc4fg/4+3DPh9qZgQDEIGw3XYFJ0+R9YQ9JxXafV6l7ysKlHbCbYXYXF7M9X6yK2KSmSccGZJSFy95vbpcjrTmfo+xBe/gfx7JCZF+33a4xR4/Rmv3Yxy4720V36jfc04L3ZrIvwdimOQd70Gp3na/tYXBleSs4/I7wul0/u7JtTYdPPg3JOxDAQvWbF7udwM9wRsiRTBPbQG75FDsixLhffOulfrH92eXVTy1x6Vsv7FAT/yygNfsN6k1BKSAg4No+14qaqw+sPlt1NjQo1GYlW5RCDMJN6cOpOsrWMcV65qvh3w1PjfKz3YoO4mSL53/+dayf8JRbJ6UhYYKDsIcsv+WgvOWtKxO1qW3fkY0q547spX+AnJpDOyEvi8U5Pb7LA1ee++boii3Ht9h/9AULe0zvMTf0nfXBz51XGeUPkpuGizfVwiEqTwT/3/wD/HOvxhO+2M4dW/Poq7mrGpclCULAFxFoZixOfL6Fk85wcIrYOg6v+HNjn8PFW9vewqKeCmj7gPaf3fZZn7A+/v4N2U5Y9n3p8s1Wm8CFr3kDJ1CbZClizAq7+CdHUkqbJ51p204BZMys+Ig1bNeHrWaiblqHx2xVkXmfD4strMNP7lBTX3z8Gh5zG9vZrk7IuoPn1h3sdk3k3dPjpg82DO7cvrO/nz/+cIFbZKIIAhBzteWWlVe/4xLb1ty7s+zMr2kn26eo56A1PJLgiK/Gdzy+hwi7ZSecWvdlBMDBkZ0jnxr1lAABpvZVy67Cn5awkQ8BiDVM2M2AEbbuxvs/l53jNtvMhm9d8B5jS+wDN4k9aIfZR2Sy//tN2WddX+fwZY94hzesfHWmbjmD95zVVreXiY4cqNJr6uv/Cvk997j7veT3B/KNOz3TXmZnY1yI/3FjTKdrL5faBR4J9D/l51eBzLq6jjWXel6s6fe/X6Wvc8su1LT0vhWnASZBQoAQ8DYEmmlni+HiaNL/Hv7v33/8u/2H2rCwQdg39785KCjI27AhfdsYAS+zs9kvoaYOZvQq48X2fkOvj546K/4+/OECt8hEERF2Gz9T1D0hQAjAuggKuiX2Fni/Zwya0btT70D/QPzhArfIRBERNj0mTUDA++zsJgySqhAChAAh4DwCbrGzRXdY28apKUjiO2x4grHpDKnFXOLOj5IkvRIB77OzvRJmUpoQIAR8EgFwc7t27Tp06BDMEy5wS4Ttk8+CewbtHXa2e8ZKrRAChAAh4AoCg8ZYAuAd2EJfWriCHcm2DAJkZ7cMrtQqIUAIEAKEACHgbgR8hbOxmFRTW3Om8sypslMnz53EHy5wi8yWPO/X3dNF7REChAAhQAj4MAI+wdlg5fLq8uNnjyNG565Tu7af3I4/XOAWmSgi2vbhnwANnRAgBAgBr0FA/5wtCDu3NHd30e6C8wWILHKp7hL+cIFbZKKIaNtrHlhSlBAgBAgBH0ZA/5x9sfbiL6W/HCk9Ap7WTnTHdh0jO0UaOhpQBAGI+fBjQEMnBAgBQoAQ8AIEdM7ZMLJLEfnqzFH7qegf1n9079GIw40iCECsHg95bsailEUZuY4nE4UOyrKXpSzLRgVWlV9ok8NM5x8VtG2T7HpwvjGSJAS8EIG8da/Kv4FFa5QfpiUv5fll2Y6jU3nhUEllQsAGAf1z9rGzx2wsbEAAIzuqaxTyD50+hFtcQMwxZ+fuNRniDVkbbanXmUcpZtoLqXN4GDINt1synWnCTiZxTipLKUkREUkp/FL00GBSXiIak6NyQsDzEcjLqb32Rf7oPxF/6H1B0CUni2vjk0XuK3MSWbhISoSAHhHQP2efrjxtP3EwsnGOIGLkFZQViFKIOeRsRtlxc+LijaamkLYeHxkaEyHQtghET54mk3Jng8ES2aqjIZKoum1nhnpvBQQCLut/9ZC4uNEj+rVCZ63fBQ4ONJ021Uns1MCIkIjOHVhEe7D1iMgRuNhbuLesWg6zDVM7NizW7nyi3KyMoqh7RyZW5C83VUwZyeNkSxLM1sXLM5Hyg6MriqX4cXFh3JResHQ1MndV9gjJqzBAGllLTb3GtctalJpVWJ73IyqETumyk2eyKpaGUKm/0spSk19xxmLWlJLpALgSU/Z+uWNN16x9pqSqC8uo+CYl3SgVHWiwvdafG+qREGguAoW71u/rOOpG/JZwlbnxW/ab3JQfOmxkVIim6ZIt77+RWVS1+4O3PlzHSrvvfnt+2ir8HKrEbw5udX7voOqS99PVhuY9mNxcfak+IdBsBHRuZwMfBNUWKA0IH4AF7NjusfZGtlbMCtLsjVmGOOZ6TrRY2uDDdLPslo4rzipUaDw1y5DMXXMzJJPRqhV4wxVXttaPDeZPl0SV1JQ4U6qyLl2YtUmawd3fkjMueeizkssjJUvprBWmttwwOoQ3PTleikfGC9Nimv3EUAOEgIcgkLfu821h48byZzr6tufET+CJhJL0Zeoqt6JphfGHvNjHROnLn1y6kwlODNi+EX71ki3fGcOEV52c6h4ys6RGAwjonLNxIn/nIGZbI+WczoEx3adzH3UlW9jfIkEMwjZIZZuM8ZyytaRdUCwlzZDJL3FCUgQvzjWb45NlQo6ZNi7eiYdOW0VidRT3e4TcfMzQuAizuZ7Nb5YOCooLC7NSxZ4c2NOsRmR4hDG93n1zTuhGIoSAZyPAtpyBe+1ZNjpx3DDJXGCzCa1j/E1TmT8dzvSIeEHzil89rFd4gNEBzXv2+Ek7n0VA/5x9WafLBBmfOn8Km8MD/ANsVrJRBAFVTPMogLIlY7q8QxV0yEkVVOvgaQFxtuEzxGxoJTFbmm1zg7m/EqrTpvI2nBfqumUQAGEzW/mFqW5xG3ET/R7/1Sm04bxlpotadSsCOudsrE+DjLsGdRWgYZc4mBt/uNAa2RCAmO1iNrOyNWQIB7NxU0YurF+LyxpOaMHVzHeOQmFzZ2yy9o07nrEYgwGv9/LONlZHMeldnGBmVCtda6sy4obKtHfORTxJ3MMRgDP7yIAZ9fF1XvamXEPcQFd3o4G4F8yMMZsO0ldiHj79Pq+ezjkb8xsUGBQXHtclqAuMabD1lvwt+DtZdlJMPTJRBAGI2TwMGse4KAEvF5r25sZMm5Fklq1vU7jsG8eicbJB9lCvlOLsfOOc6eHA1pq9iXNS1IZSTXEpTnyz5eh5BTerXaeIL8nVb7ixXs5bZa8UUJnc5T7/g9cBAOfM5qPfy4tB8CTxr7GxzewF4RB7wzjgQZe+9VKrLviydhx3oFMiBDwYAZ+IxYnd40XlRTjs7Hz1+Qu1F2rrajEj2JsWFBAU2j70im5X9AjpQRFtPfgpJdUIgbZBgGJxtg3u1Gv9CPgEZ2P4oO0LNRdOlbMlbdA2s78DgroFd+sZ0hMWticTNraF40MxdQZxkArt/qZfNCHQOggQZ7cOztSL8wj4CmcDERyZoibcwiuuJufxIklCgBDwHQSIs31nrr1lpPpfz1ZnAgwNezogICCQJ1zg1v77Lm+ZOdKTECAECAFCwNcQ8CHO9rWppfESAoQAIUAI6AwB4mydTSgNhxAgBAgBQkC3CBBn63ZqaWCEACFACBACOkPAhzgbW8era6orqivKL5TjDxe4RabOZpSGQwgQAoQAIaBXBHyFs0HP+MrLWGTc9OumDUc34A8XuEUmivQ6uzQuQoAQIAQIAT0h4BOcDVbOO5OXnZ+ddzav4mIFIoXgDxe4ZZln8oi29fRM01gIAUKAENArAvrn7JraGrCy0WwET2tnEZFCggOD2we0RxEEIKbXOaZxEQKEACFACOgDAZ1zNg5ROX/h/IHiA/az1a9bvyn9pyRFJ6EIAhCDsKNJxUFk9R/UzQrtQmch090ne+MEcSeaVM8Zl2ORUVgvffxKaRRWCFgOF+dnjcuJRefkaZFd9GzCjxDQDwLgbIdEpZMRgoaPnj1qY2FjbDCyB3QfgAsE1cb/QwBijjk7d6/JEG/I2igH4LIBhgXPErE9WoaolfeBxDmpThxZCimWUpIicMQpv3Qi7giIngJ26uR5941hnKuNfYA/3U8klHy1hrM2aPw94wD2zC+Y2XPHSmJt33gSfHKU+rezER3EoZHdLqBd5cXKo6VHRSnEHHI2o+y4OQiLRTEtffIHQoP2PASiExNF4OzoYXFdzMVnQdkHTaeixo1luWFjJl4TcGCfCItLiRDQHQIBl8VcPWTQoNEj+uluaGxA+JQLfm8RKrtDYId2/u1w4e/nn9A7IcA/YL95f2lVqRg4gn3FhsXaBQvJzcooirp3ZGJF/nJTxZSRUUwUhuk3xyq/Xro0u7J/L9PSpaZe49plsUAe5Xk/Zmbmh07pW5G9X+penLF46erMzF2V/cfFhYlaFaE7Fy9ezmW67Fy0QFvMDXWew4tHRkE+3SgVHRAtFK9GbdG/jZyDeSsxof943ivvl3VppYglA+1qehE1KBEC3oFA3g9r94SPvz0urHDX+n0dR90ont9LJYd25AXFjYwKkUcBI/yNzKKq3R+89eG6Tfmhw7rvfnt+2ir8IqrETxNedX6fyQot1VjtJe+nq1DMezDZO2AhLXWNgM7tbMydH/7H03VR12EBO7Z7LFaybYxsrZjVdGdvzDLEKQGoNZa20STNSNV4q+EiVxzSwhtdmLWJScBNLVnc6sZ0UxzPQ/jtldbFIGKRg5QspcNZDT93crwUn6zthlMwC7UtBBt3fIOweZes1zjTSsTWzs3YZJb95szZXk8vun7maXBej4C8dv3JpTtfmCpM7kZShfGHvNjHuDc9/WVUY471iQHbN/LQ298Zw5JfZL+RV1wKvN1Yn1ROCLQEAv56Xs3mwbtC2suv26ZiEwzumLAYsZJ96PQhYX+LBDH7eCHZJmM8p2xJSrRyj8ePA981lCKSZnCJmKFxEWaz7KiLT+YsG2MwwAoWxbjkqaC4sDArVeyhgeGrVrHtg2nUWN+WOrlms2RMF63CD1BYXMB6REe0gN0SPyZqs7UQiL7tOcax9/ivdnLHWcf4m6Ym4rfW2WCIiBdOdFyGMn3DeoUHGNOX0RJ4a00e9dM8BHRuZ4OGI0Mjhan969lfsYCN3WcOjWwm5idb5AqkIEiV8hiTtuyaNjOplVTffjOQcER4pCtTrmxGUw1zvk8tzsT218LspkQIeC8C0bfNnMjXrsG/krlA3kJ+Dm+qhkj5ZdiJwfEXAEb/Kdpt6E5UJBFCoA0Q0D9nR3eODgoMEtAeMB+oqqnCn42RDQGI2XI2s2k1PApXtXFTS9FcZHiEM43DbJeymIvbucSNakc73kHc8Nqb9jrbkHPdkRQh0AoI5GVny88t3NrbawcNiZHCBsb1PLZpM8tW81zTBMS9YGaM2XRQ/XbMtfokTQi0EgL65+zg9sHxhnjY1rC2YWp/dfgr/B0pPSIARiaKIAAxG87WOMaFLNzjhfXTHKdTeLeb5nbGgniyQXGOKxYw88fDs621h63kGu8qcQ5fPJcTk2cflAtfuSlOuO8d9NJKDx91Qwg0AYHOATkfiGd4wZe1N87hC9phY6be3HMHW1yy5DnZtPq1N2qO4w50SoSAByPgd9WNj959xx2PPzTRg5VsrmrYPX783HFsIK+urRYHl6JF7B7HH85BGxQ+qHfn3nY7xpvbKdUnBAgBb0dg0Jjp6hAObFnl7cMh/XWAgE9wNuYJtI3F7GNnjxVVFME3jhx8+tWjY4+oLlHB7YK9lbBhNGNrmfoYYu3aiYNXdPDU0hAIgdZBgDi7dXCmXpxHwFc4G4jgyBQ14RaecDU5jxdJEgKEgO8gQJztO3PtLSPV+Xq2dhrA0LCnAwICAnnCBW7tv+/ylpkjPQkBQoAQIAR8DQGdnzfua9NJ4yUECAFCgBDQMQI+ZGfreBZpaIQAIUAIEAK+gABxti/MMo2RECAECAFCQA8I+BBnYwMado/X1tbW8IQL3NYTM1sPU0tjIAQIAUKAENAZAr7C2aDniuqKg8UHs/Ozv837Fn+4wC0yUaSzSaXhEAKEACFACOgSAZ/gbHGmCkg6tzT3TNWZiosV+MMFbpGJIqJtXT7cNChCgBAgBHSGgL8mtJXOhiYPRxD2nqI9OFOl5lKNOAQNCRe4RSaKiLb1Ofc0KkKAECAE9IWAzu1sLFdXVlcazcaLtRe1kTcxiZd3ufym/jdd3+96FEEAYvWsbbMTuusNgcUK7Y79Rqa7Y2YhELYTTULKJjV+JLnV82xpwMWK+vpV0Gg8GwE5fDaLTWcTQpMdHk7RuTx79ki75iGgf87OO5d3oeaCPUqDDINwfOmJshMoggDEHHN27l6TId7gMDoWaiJmRyoPis2CbzjBqi7NFhhUoU4E4nLiWFIeZzMVIbsilBCcQrcGk6aXbHN4iggHmiylu3s0jelB5YSAcwjk5dRe+yJ/TJ+IP/T+smxLKK687E17ypxrhKQIAe9EQP+cXXC+wMbCFkY2jhmHbzzndA5uIcDE6ursJ5FRdtwcBNgyISiW3lPiNB7pCwmxQfU+WBqftyIQPXmaHH4LcbNDLaNAGM4jvZOGaXK8dYSkNyFQLwIBvWKuGjJo0OgR/XQJEhaz95v323P26D6jEdELhF1YLofYAH/3D+tvFywkNyujKOrekYkV+ctNFVNGRjGUYJh+c6zy66VLsyv79zItXWrqNa5dFgvWUZ73Y2ZmfuiUvhXZ+6XuxRmLl67OzNxV2X9cXJioVRG6c/Hi5Vymy85FC7TF3FDnObx4ZBTk041S0QHRQvFq1Bb928g5mLcSE/qP573yflmXVopYMtCuphdRg6X92asrou4R46VECHgoAoW71u/rOOpG/tyWbPk0vXDIjf1O7y/qPnJkVIiWy99/I7OoavcHb324blN+6LDuu9+en7YKv4gq8dOEq53fZ7JCq5rSkvfT1XbmPZjsoTCQWr6EgM7tbEylStgT+03EAna/bv1sjGwx3fa8zglvY5YhjrmXWZBpjaVtNEkzUjXearjIFYe08EYXZm1iEnBTSxa3ujHdFMfzENJ6pXUxiFjkCL80XOLwcyfHS/HJ2m44BSPwtezAbtzxDcLmXbJe40wrM3LB+JvMSaI+c7Y77iV7Wbo5aULjbnVf+qXQWD0Ogbx1n28LGzeWu4ZKtqz5noW/Vt86rbWtMP6QF/sYnOkJJekvf3LpTuZXnxiwfSP86rDOjWHJ3Nf+yhwKn+1xs0wK2SCg8/PGEQIkODBYjDn/bD4WsAd0H4CVbD/JL7ckF7a1CgfE7OOFZJuM8ZyybUk7fpziRK7niYpImsElYobGRZjNuUIqPpmzbIzBACtYFOOSp4LiwsKsVLGBDIavWsW2eaZRY31b6uSazZIxXbQKP0BhcQHrER01sMOMbUMDzzuxek4/JkKgzRBg29DAvTLL5q1b9n3YjAYYt2P8TVMZH8OZHhEvaF7xq4f1Cg8wpi+z2czWZgOjjgmBhhHwd7CEqyPMQMM9QnqIAR0pPYIt4ljG1q5kq2OFmB1ngyBVymNM2rJr2sykVlJ9jAkSjgiPdGWClM1ovGX2ysD3qcWZ2J5bmN02SbbLGzfgXVGBZAkB9yIAwma28gtTxe4LWMrbTxZ+z195F3y+p9CY/rLtfvKG+o++7bnU1Hv8V6ek0I5z984TtdYSCOjcNw4a7tulr78fGyas6kOnD+HC3siGAMRsOZvZtBoehavauMme5twzK9jz5UzjMNulLObidi5xo3qjg81zIG547U17rRuC31wSrgBKhIDHIsC2mg2YIfM10zJszIOLlLfdBTOHRcQnv6jQudODAHEvmBljNh20bEJ3ui4JEgKtiID+OTs0KHRQ+CABKUztzMOZ+BPbxdUEAYjZcLbGMS4EsaZdaEtzljY4neJVv2kfNmNBPNmgOMcVC5gtosOzrbWHreQa7ypxDl88lxOTZx+UC1+5KU647y29wEGveNKZBH3s1Yo/ROrKaQTOmc1HhVHNU3ONY/ZJN29owZdsQVxerHJaGxIkBFoXAb+RNzxyz53Jjz80sXX7bdXeqmuq887kHSg+oB6CpnYPCxuEHd01un1g+1bViTojBAgBj0dg0Jjpqo4HtqzyeH1JQf0j4BOcjWkEbZddKDt29lhRRVFVTRVysB+tR8ceUV2iOgV18lbChtGMrWXqU4q1a9o6pv/fLI2w9RAgzm49rKkn5xDwFc4GGvhWG0va+BNnp8ATHugfiD+7b7KdQ46kCAFCQO8IEGfrfYa9b3w6X8/WTgi4GfZ0x/YdQ4JC8IcL3BJhe98zSxoTAoQAIeCrCPgQZ/vqFNO4CQFCgBAgBHSCgP5jcepkomgYhAAhQAgQAj6PANnZPv8IEACEACFACBACXoKAzs8u1c4Ctp5hG1ptbW0NT7jAbT0xs71k9khNQoAQIAQIAV9CwFfsbNBz1cUqfOu1p3DPTwU/4Q8XuEUminxpxmmshAAhQAgQAt6KgE9wNli5qLxo16ldOP7seNnxU+Wn8IcL3CITRUTb3vr8kt6EACFACPgSAvrnbEHYiKKN01TKL5aL77ORcIFbZLIiom1feuhprIQAIUAIeCkCfiMnz7knebqOzy6trK7cdmJbaVWpzQz1DO2JWNpg7u0ntnfr0C3hsoTg9nLUTitJzVljiBjSihE0WMfF49zVo82RaRginZrmpb9Zn1cbJ4Qv/nxPGXAIiU9+whKBE+G+3vjuJHu0x6e4HCTEMap0porPP20eB4DOORtGNuKC7DPvs99rdl3Udd07dj9aevTnUz/jTLQhhiGgcJsjVjjRGVSmzs7IiJzWSOBsj5thG4VEtE0nXz1cEvb0kZN+ekEgLzu7JjER8W1A0u8WXitYW3vtvoESZ7sPS2rJPQjo3DcOqj5RdsKesGFkdwvuVnup9nDJYQBZj1j2Rg1hQyzR2wnbPc8MtUIItCkC0ZywkaKHxXUxF5/FFeJzGsNuoqhcbTov1HmrIKBzOxvfdGX+knnx0kUbMIWRjWBfuwp2iaJ2/u2mXDElMDDQIlm/lYmSdCMXVBzMsMhXSuPiTOkI2cHyDBuFhOxO1xarmZJ9M6zL8CRzVpaUlDJDWrlSmoGgHxa3tuKcb7j/Br3e2kHZNWyVEWeyHWSrPJHUCSHgLAKwrT+5dCdzg+ete2t9bXhJ1o+OXOPwpS81XnZ1QPZ/9pQxb/rkkve5D11xoas+dWtXO9OC7Gxn54LkWgsBndvZgLG2rlaAeVWvq8b0GdOrUy/VyNZG0VbFVORzzeaI8Ej7iWCEKSWn8pQSZ0pVolgXZm2SZiCPx8GG/5ldxhs3ZeSKJpTiVBbRWtRJnCNaYVU28hwko4m1oonPJax9nrhLu7H+U5IkS2v1P0f8NYLpy/qXuEbWPUG75Hj20qFVprWeS+qHEGgAAbAsi3gtEzbM7JPFRcafyq99EQ/zgpk9d6xcI//qlDYqjD/kxT6WmvpEQkn6y6gGuScmBmzfmG0WJnoyq5n6imVtnOAnBDwUAZ1zNhaqgwKCBPbVtdVg6wHdB+APYbPzz+Wfrz6vTgvEIKydpRiDobC4wG7eQOXxycp6cMy0cfFGk6DbiKQZfK07MjwiImkCY1d2qdZXiiVNHfAm+6eH2bNms/yvTPw4mxVzNGJMX6RQv9Ro/zFD4yLU1up/7AqKCwvxcqHt36YnD31kSS1CIPq25xjH3uO/OmWRQs8R10xg69pS2MC4fpK5wGyFUsd44TjvbDBExI8by36nuAxlMmG9wgOM6ctsWZ5AJgQ8EwF/FpZSvwk03D24uxhfbkkudol36dBFrGRrjWyUQsyGsxnjKnzcEgjJ+8K5uZ5k4Xa7rmKmvZCaCkc52FUx6d2kDrOhlcQM+5bryU0KUzOEgBaB6NtmTgw4sC+X8W6nJkPDXwAY/ac8vwx2NyVCwKMR0L+dHdUlClY1JqHiYsWxM8dwbW9kIwditpzNDWKthZuxDNYuzG+8lcue7NyMTcb4OG5TN5YKTXuFJa3UgaEr+95z95oKG6nO6BSedpj0Te3ftgP2RqI67jWFlp4aGxGVEwJtgQC2jcs+Kbi1t9cOGgKrGbvRhKcbG8izN+Ua4gYyk9uFBOJeMDPGbDpIpO0CaiTaBgjo/Lxx0DCs6r5d+wposUt86/Gt+LMxsiEAMVvO5gvObMVaOJBTVkoTmNs6cQ5bkRZZqaa4FCe/m4owFDNT2VIncQIWnnnbK4sNDdjZWL+WPdgS98k3sX/bhwvczFfeReK+d9uepMQ4vLTIhW3wcFKXhIADBDoH5HwgntoFX9beOAc70JCib5vzm4CvX0bmG8YBD7qyLo0dai8orY2jnef0yHk6An4jJj187/QZOj5TBd9xlVeX55bmYpf4pTrbo8VhYUd3jY7pFhPSPsSes902e2LDl2ZjmdtapoYIAUKgxRCgfeMtBi013EQEdO4bBypgYvAxWHl4j+GRoZEdAjsI9zgucIvMFifsJk5NM6upRrMwSdy8FN5M5ag6IUAIEAKEQBMQ0L+dLUCBtY19Z9goXlVTJaxtQduh7UMD/ANa0MIW3ZOd3YRnk6oQAm2NANnZbT0D1L8tAvq3s8WIwcqBAYFdg7v27NSzV+de+MMFbpHZ4oSN7rF4TI5x+vURAoQAIUAINA8BX+Hs5qFEtQkBQoAQIAQIgbZHgDi77eeANCAECAFCgBAgBJxBgDjbGZRIhhAgBAgBQoAQaHsEiLPbfg5IA0KAECAECAFCwBkEfIWza2trz5Sfyc7L/nj3x//c/k/84QK3yESRM0iRDCFACBAChAAh0LYI+MS3XojIedB88Jtfvtlr3pt/Nv/8RRYaJLRdaJ8ufYYaht5wxQ0DDQOtonC27ZxQ74QAIeAZCNC3Xp4xD6SFBQH929kwo01Fpn/t/tcq06r95v3nqs/h+2z84QK3yEQRBMjapp8FIUAIEAKEgIcjoPPzxnGUytmKsx/u/XBz/mabCNmDDIPmjJxz79B7UQQBiEHYwWwdThuNL7h5mrfBw2ezXvU2zGtAeTbChoeG6jbJe6Hw1ikkvS0I5L2XJD+Po9OUcCHfPx4t8vrM21BMYBECukVA53Y2rOdtJ7aBle0ncPaw2eDsoRFDUQQBiNmb2ozNYvcvBJnzdPvhtMPNeRIaZM5GG25e7Qaa7z93a92SSUygvi4mLeHjz1mSkLAkh18K+QZTi+nbWMdUrnME8n66+IKZP4ZHf7tqPKfokj2mhG951umP2j/8G4XJdQ4EDc8XEdA5Z1+6dCnzl0wbCxvzDCN77OVjq2uqP9rzEW4hADEIWz8CG96cN2K9hp4mzZ3b3xcfEhozIeBJCEQnz50UzhXqHHNlb34RNn7uDB7fSwrrOyjak5QlXQgB9yKgf842FZvsIYORjcPGtx3ftqdwjyiFmC1nb1ibNvd2h/akxVc8Wra8YZGPTtsgu9E1mRavOupMTpPSJvv5sWJmhKYxcdzwurIBr7m2OOXhiLaujaii9h57bZP1PiTc+FXUlx3ccp+2XTTyoKkYKLpbZbjYmHsfamrNVxA4l/uzNLiv4G85lRw9cGFE/65WWd8/PnreynTuPGeec8W1rjjWVVc7udV95cHx5nH6S47WcL15RFa6w1cmdokjzRo6SzjDVSN7+Z7lqjTEbNazDx/elTDYwSs7oyNpvfCW58xaEass7W6bN1/6iHuQpXlvspVvYaYrrmT4l9fPleYiY6uw1tNWMHH5xg7xDfNiV8wSfmhm6VvVBslaCtdLk1XGb7hJuY+0yWtvZ62un5s2X+vrt1OwgacAGIhGOASz0czhtPm7ZL85G5IrjenmaaOBtC4Cee/dv3DwwunCvhap5PuXH9g263HZDLfkF6Q9lXXTDjjT5++fbLjr4r+YX31Z0Cv/gF+95Pu3/j14Pfe15y+xq9i6I6LeCIFGEdC5nY0Xa3zTJVAQm87uH3a/vZGNUojZBAvp33/Etv15dgiCyueuV5Zz+89dODdtrdialrDkI07G/SfNSth1GHZz9OCENAuf2jWEqvV72pmNX2953n5J7guNTnpsibRigzDTG2xSUUDRftLtcx2Nr9FHBgLAgHsMWIqdt401w9Cap76/ONMIyRACTUeA2cbgXi3LlmAb2rDVN+3YOlfL4qKLyLn//jPjYzjTE+YKmlf86nCmB6VNpiXwps8F1WxVBHTO2f7+/nHhcQLRFXtXIBBnQu8EsZKtNbJRCjEIW2HPOFfm4ybNCdvbVfeRNLsJO87rs/GbpEeLVFI2o6k70vg+tdvXYrCq2d8iHVOjhAAIm9nKWnIGYd8Mvm6KpRz9cFZd3WftHqIt5/RkeQMC/rp2jUug4SlXTAnwC8BcHDAf2Pzr5vaB7W1WslEEAYjZcjY3ojWG8uG0eXACw6BMm6z4w+ERrm/NW559RtzwQjfE/cxElS3lwxtWbGMVYatL85jL2WGKHqwphAdemjWpdffGcaOa+/9tEogbSwOK2e8NPwDS0esQgDM7c/oKa2M67//SqhdyS7qJCcR9euOdu9b+TN+JNRFBqtZKCOjczg4ICEi4LCGxT6KAE7vEl+1chr8P93yoBRgCEIOwAwrCirW8kWy29BjzZk9akrNkl+IYxppzvZ89qZuysPzNheCNVvagWXXE3NvzeC+z949I4EWg+vUjRJ7yXbiltlUhGq9vTdzlZ6g+BR1wswUDoZ+6KQ4r7WKNwOnGXFaTKvg0Ath4tmZef/XAALZxDBvPfkqbbFDz1M+2nQCKudR5xe6zm0f7TvRFIoRAsxHwu/L6h2bNmPn4QxOb3ZSHNsDOQSs0vb/n/S3Ht9h/9AULe0zvMQ8OezAuIs6esz10SKQWIUAItAoCdHZpq8BMnbiAgM7tbCABJh7YY+CDwx+cHjd9sGFw5/ad/f388YcL3CITRRDQEWFrvgNj5kMTlpeb34ILjyCJEgKEACFACDiJgP7tbAEErO2yqrJ95n3Hzhw7X81jhLQPjeoaNcQwpFOHTjoibCfnncQIAUKgcQTIzm4cI5JoXQTA2Q/OmnGXjn3jKp44MgXMjSS+w4YFCqpGst161roTQL0RAoSAxyJAnO2xU+OziunfN65OLbi5Xbt2HTp0COYJF7glwvbZR58GTggQAoSA1yHgQ5ztdXNDChMChAAhQAgQAloEiLPpeSAECAFCgBAgBLwDAeJs75gn0pIQIAQIAUKAEPAVzsa+s5ramjOVZ06VnTp57iT+cIFbZNqEBqFnghAgBAgBQoAQ8EwEfIKzwcrl1eXHzx5HwM1dp3ZtP7kdf7jALTJRRLTtmU8naUUIEAKEACHgW+vZgrBzS3N3F+0uOF+AMCGX6i7hDxe4RSaKiLbpV0EIEAKEACHg+QjoPH42JuBi7cVfSn85UnoEPK2dj47tOkZ2ijR0NKAIAhDz/NkiDQkBQoAQIAR8GQG/Kyc+OGumbs9UgZFddL5o64mtNoSNKR8WMeyKsCtKK0u/z/seR5mOvmx0j9Ae1iG0czMWpWYVKo9HRFLKC9NEZN7sZSmbwtU77fNTX0n9NVx7+tBOupScOkcOeiJBxZXSDEUv19qqdyToxBRn6cPlVpmSRqta8RqVXW6OKhACGgRKtry/+PM9ZZaciPEpL0wNXPfqG9+dZJn81j6CdtMwpDNVmoYb1Wo5BHTO2Tj7bMfJHcfLjtsgCCP7+n7Xg6q3n9h+soz91Ht36n1Vr6usj1ixIkRO4IY25p7sZYtMkmQOV1m6uZxtwUVD1M3lbLlRl3RzSbjlfg/UslchAP5eaoydMycxYHd23mWJIwwSY/Tvwx5wF2sTZ3vV8+ATymIPmp4jaMPOPl152n4m+4f1D/QPPFt1tqCsQJRCrOGdaDHTXkhJMm/KyG3D5yLbZI6bMCFOMu1tSy3aEADqmhDQIJCXvenUoAmJBkkKG84IGylsYFw/yVxgJpwIAZ0iEBDZ78ph8UNGj+inywHCzjadNtXx95KIkIjOHTrjAmw9InIELvYW7i2rlp1scJ7HhsVa29klpuz9Uvy4uDAZm7B2xdlZhb3Gxe1flvJNxZQuOxctyPabMjKKFcNOXGrqNa54NStBFu4XLF2diZQfinuYriKfS8ologhZvDR05+LFyxV5h7OR/c3XHRNuvzZC1oKppVERjfD6mfmVlV9nQBeut5qbuauyP8/imhYfXLp0Obqv+Ibr9Sv3ZhcdyORSIUcziw026vBafsUZizEoJoOBNqKtVjeNHooaqmLI6GVaikWI8rwfZbR0+SzSoNyNQN4P35wcePOkqBBNwyU/r88qH3jDOG0mbO83Mouqdn/w1ofrNuWHDuu+++35aavwrFeJX0Teulf5fSYrHGnV3JL309XG5z2Y7O4RUHuEgMsI6P9bL0TIFqgMCB8wuvfo2O6x9kY2SlUx5yGMmTYu3mjK5hVy95qkuKGWVbTsjcyPzpO69ixTe6opLkWUJEvpixS73ZiOJWSWF2+sx5bPzdhk5l3EDLW3tEGp6eYk0W5csbIIL69+89yUOFPqMqGsVJhVzDqzaJY4Bx1LWHVOlZfGHalTmLVJmsFUNGSlsgXvBrW1glE42xU1VmLMbDCyuuiR+zAisGHABi3n54IkfQ6Bki3fGYPjBnLrGgnE/EJKSsrr3FWuZKqgVBh/yIt9LDX1iYSS9Jc/uXQnnsUnJgZs35htRsXvjGHJL7Kn8xUHNX0OVxqwhyOgc87GnrLOQcy2Rso5nQNjuk/nPgjBiYtDpw8J+1skiFlvQKtn4gwGzfaWxDiZtEHZhnHyBjVeMTI8wmghZEtbBcVS0gxFMHFCkurmjk8WDIomC4tlf72VCpq3AgekXVBcGK8ogGYjeNVcs1lpFkyvecOISJqgbGKrZ5iO1ImQNcfYlAZw6cQDDj0kYzr+QUWCPc3GF2MwFGap7xBOtEEihIAVAiUHTeeEX1yksDEPLgLtPh2f8+bzy0DF1qlj/E1TmWxngyEiftxY9hvGZSiv2Cs8wJi+bA0tN9ET5hUI+Ot5NZsH3Lys02WCjE+dP4Vd4gH+ATYr2SjSijUwbTCepfBIrYBM2syqjrNiQViOqakzpJVgKcW4bd7zAMouBMtZiM9qTRusGGGtWfN6c3ttbkMrib2dwLKHR8CE8aiuBrd3Sg3qFwFG2dFD7LeHh42ZenOM2XTQhQXt6NueS029x391SooDstcvgjQyL0VA53Y21qfB2V2DuorpgW0N5safjZENAYg1HJeT+ZnNFhtZnm/YtGbTMpPZoeHKiBu+btl9zmtEhktZzDfME3sH0DrUG3iGmJWtpb2UJClro+zpRjVmeav3aFZ8oAZjFgaELAVvtDHe+sWitZ5ZblRrtFX7BXFjILSjrrUmQj/9gLJPhYR3UQZUsjt7l8zS2JeWa7C4zJ0dMoh7wUwXyd7ZtkmOEHAjAjrnbCAVFBgUFx7XJagLjGmw9Zb8LfgT33chIRNFEICYI1hV05Z/Fu3gO2iwpdko1pm1CQwvEqppF7RB43w5WClz8stq2+VyRtIR2peBmGkzksyy+9kULvvGYcxiq7vilMYyutXSus1wmcsAoi1i9Wr1EI4HrL/LLgNTHF8r4G8dwMU9Xgk3/kKoKU9E4ByWWwyRFsd415L1L4sH6g3jgAddWpaWF8JTUhZ8WTuOO9ApEQIejIDf8Im/nT3z7scfmujBSjZXNeweLyovwmFn56vPX6i9UFtXixax6SwoICi0fegV3a7oEdKjYSO7uRq0bn03fV/dukpTb4SA5yFA32d73pz4ukY+wdmYZND2hZoLp8rZkjZom9nfAUHdgrv1DOkJC9vjCNv6BDZJcwRb4w8sq1s8rhnHmDXehY1Ec7R1uTOqQAi0HgLE2a2HNfXkHAK+wtlAA0emqAm38IqryTmsPFpKc16oSwzv0YMi5QiBtkWAOLtt8afe7RHwIc6m6ScECAFCwCUEiLNdgouEWwEB/e9BawUQqQtCgBAgBAgBQqAVEEAsTn1/od0KGFIXhAAhQAgQAoRAayBAdnZroEx9EAKEACFACBACzUfAhzgbW8era6orqivKL5TjDxe4RWbzQaQWCAFCgBAgBAiBVkDAVzgb9IyvvIxFxk2/btpwdAP+cIFbZKKoFYCmLggBQoAQIAQIgWYi4BOcDVbOO5OXnZ+ddzav4mIFAoTgDxe4ZZln8oi2m/kYUXVCgBAgBAiBVkBA/5xdU1sDVjaajeBpLaCIFBIcGNw+oD2KIACxVoCbuiAECAFCgBAgBJqMgN/wCQ/MvusevZ5dikNUzlaezfo1y4awgRcCacf3iIe1/XXu1/5+/kmXJ3UJZmeSa6C0Pt/L7UeVuHRgmebMFNeORXPt0XBJJ/umtVqKUsTkbuiUc9e0I2lfRWD7h09/XHHT3+aODxYIsPtd7DjDgVMtmSJbK9ZsuOj77GZDSA24GQGdcza2mO0p3HP0zFEb2GBkT4mZ0i6g3e5Tu4+UHkFp3659h0UMsz7EFAS2Upohh/HgBG5oMwZqyTPE3d62FXCNPrFu777RHknAixDg9Nw3Pv5oTf+FgrPz/vP6W79e9VfcWK4Ei1uJuWOMxNnuQJHacCcCOveNw85GdBB7wPp16wfCrrxYebRUpnOIQbgBaBGRC0GyNilxNN05CdQWIUAI1IfANfe/npo6d3h7tTzPaKoenTSWsXf0LdcNO2raVolLOzFClBDQJQIBPfteOWzI0NEj+ulyeLCzDxQfqJMYGXcI7NDOvx0u4AlP6J0Q4B+w37y/tKpUDBzBvmLDYq3t7BJT9n4pflxcmIxNWLvi7KzCXiwDluSCpaszWcoPnTIyChLIWmryK85YjPxdlf3HFa9OWbxcUw5zkt9n8lLRxlITa01bUym0nY5fd2YWG0RHPDEFsv14Bhr++BhvUe3C0oOspawkBL6pCN25mCsihIQ7u+iAuG+XJeskerAZolV1ZdwOHhwr4GyVstYSKGm6V6HW5dNIg2o6Aid2bzjZdfzVffEDztmytrTXtAR2KUkXj+/ZftYwerAhgLetEdP0BRt8XWnw/rTF//5P5tEOSYb9b/75nZVfZf5UFjWGVYS1zu8zWSHvQk1L3k9Xr+c9mNx0/akmIeAmBHRuZwMlP/yPp+uirpvSfwqWse2NbK2YE8AyNzmiUafylCylqzGnC7M2STNYHguRbYrjxfFG2TZPnCMqsNKNCCFtlZSaKUmSfaEsycJb88RiTPOA2azl7GUI0c3899CKxfjmSb6HZ19VUglMbUwXijE1VqI+1EqOZ8vOVtHB6x2iUt0yrgYBE35vnlLiTKy/3IxN5iSBHdPScfdOTAKJEAIuIHBwzb6ohampT0wu/+LZjypufo1dBm/N2gwTfXvWDyG3/o0/kep6uQstkygh0KoIgLP1fHYp9pSFtA8RiJqKTTC4Y8JiBnQfgNtDpw8J+1skiFlvQKtnGgyGGKmgWEqaAb7hKXFCkmTam8uvI+TsyPCIiKQJiSwLl0pL4EFOubArzWZRQU1KzZihcRF2hbIU41WexKYusHacKTUFPM3vc/eaJLlPIV9QXFiIVwfbLuOFuLXidoOtd4hK9cS4+MLignpAUrNzzWZJedVIzSpkNWIMBqilvEE01gCVEwJuQWDg1AfYWnh0D0PgwMTfDIItzS550z3Cexxe8/qqAxfd0hE1Qgi0LAI6t7NBw5GhkcLU/vXsr1jAxu4zm5VsFEGAiVltGneAe/bGLCk8smkTIm/I5gZnkkrjTWtLqQX6szQAimbvE1ZJZXnZqG1ed02rje328quG/LbB/Q1xJrxLqP6JprVMtXwTAXBsqfmozLBFxUXdDFbubJdBib7l6X+kzu7432dSUtK+Z0vjlAgBD0bAX89WNg+SHd05OigwSEzBAfOBqpoq/NkY2RCAWMOczdZ9zcKOjgyXuFuZJ0bkcUNtyNJ+xkGpEYLvYRAXuuOJwFvApvAU5pvnRisMX6O4khMsfMUtr+3OaJJlGlS8KUN0MChuVNstBDBt5+DVRfVPuAMOasNXEIiOj2svvNpYif5hT9+4BPkDsOYAwIj73hHyfrbmNER1CYGWRUD/dnZw++B4QzxsaxjTMLW/OvwV/sT3XUjIRBEEIOaIs1XvMvNBKyu+2ELOV6yF21msJjeWmAtdVFlZbGiana2uZ7MF7exl+PJsHFsQnpBk5ivqiXOwr11e8mb3VlpabNp4iZm4Vopzurc2e5syREcQaJUSC/HKCkEKtgSIBQYH3TeGJpX7MgLRtyRPxLI0nuE3dkU9/LDyzXZTIcEONfGLwKfd3IFOiRDwYAT8hk24/7677tXrmSoCeeweP37uODaQV9dWi4NLkYnd4/jDOWiDwgf17tzbese4B89Ys1SjT6GbBR9V9jUE6PtsX5txzx+v37Dx9993t845W9A2FrOPnT1WVFEE3zhy8OlXj449orpEBbcL9jTCtj6AzY3nnrmbs1tMUc//5ZCGvoAAcbYvzLJ3jdFXOBuzgiNT1IRbeMLV5F1z1gxt3c3ZzVCFqhICno8Acbbnz5Gvaajz9WztdIKhYU8HBAQE8oQL3Da6V1xfDwS2ftHp3/qaUhoNIUAI+BICPsTZvjStNFZCgBAgBAgBHSJAnK3DSaUhEQKEACFACOgSAeJsXU4rDYoQIAQIAUJAhwj4EGdjAxp2j9fW1tbwhAvcNhzLS4cTTkMiBAgBQoAQ8FoEdH7euDovoOeK6oqDxQez87O/zfsWf7jALTJR5LXTR4oTAoQAIUAI+BACPmFnizNVQNK5pblnqs5UXKzAHy5wi0wUEW370CNPQyUECAFCwGsR0D9nC8LeU7QHZ6rUXKoRh6Ah4QK3yEQR0bbXPsCkOCFACBACPoQAzlS57767Z+n17FIsV1dcqPgh/wdx9pk2Xd7l8vge8RdrL244sgFnol3X57qOQR2tP9fmp3wZkjWfNGcvW2Se4Mzx4g4eIbSGeNauVLY5ZQxtIkjWDGmli804/zizOChGLo6IYA4/5LZIuHA6mxzTrJEvwx2O1hW4nB8nSeoCgbx1r75hHJDywlScWs+uvzvJhhUxXuS4JdGZKm6BkRpxIwI6t7PB2Xnn8i7UXLCHbJBhEKj6RNkJFEEAYo72o0VEmK2CZbkR+sabQqAOHsYyOZ5xKEstS2HZZsQJEz1KPOyIwySrgigpamyzRobCxtH4US5NGi3eISgUd+NPkh4lSrZ8t52TNEslZ8Imv8ie3AUze+5YuaaeR1ePMNCYfA0B/XN2wfmCOsk24iiMbBwzDt94zukcTDkEmFidg8CkceOSzJvqoy+dPS2J05QAZYjj2djYEI2rsLigMSkqJwRaBoG87J9qR47qJTceNjxxBA8mHzYwrp9kLjC3TKfUKiHQ5gjon7PLq8sdGtmIwplbkgvaFqUQc/zdV+S0cfYWJfy4qh2qXvOL7IxFLKwfK4UNyJPWECwQxdpMRUwJl8mbyWB167cglWYsxrAa4tJSy5Kl5jGzNIOpsGjRIkt4TqaptVmNaN8GQ4P+xdyMTeakCYkMOvt+bJTRoOVAzYZ+A3biVhnCUW8bRrTNf1OkQMsjkLfuc+PlE0aE2vVUctB0yhA3kPO3kkq2vL9o2dfr338Bv6nnl2Wb4Ufnv8FFsj2u3PPCltedeiAEmoOAzjkb0KhG9sR+E2/qf1O/bv1sjGwBn70trsKaOMdpP3Bh1iZpBvMts/Dapjjh2DaqdrpSnMoiXXNGFkE7eEqJMynO5sKsYpZZnz9ZaSYFIbk3slbEUrnq1pbDVCNAtQNXt9HEJF94YUaSZNorfIjZJmM8C8WtpOxl6QofO3i2RBhvOXo3K1ec2mxUfKjZG9kuAJ6sh4Cg36pOjTvLHYzKumWcni4vG7TsmkFzfmBUtwUQYIw9YIb1ojWImXHy68bYOXMSrSibKVBh/CEv9rHU1CcSStJf/uTSnXg0n5gYsH0jOBo+dmNYMnesv+KgZguoT00SAs1AwN/ObdyMxjyvKvaUBQfKUezzz+ZjAXtA9wFYybYxsqE4xOqPF8JZm7NjIykiaQbnPviWI2QrVOtmVopBc+PijaZsKdds5naiYMFCxdms1K2nN6WZmKFxEWYzSBJmcSFeEniC5cnyCoolWRc0kjjBQtAKO6OyTNqMsuO4xcz4GwY+3iIaIEF5PTs1zqQa57KrQBkBhmx0tB5u+27QCJgORlVfy43NC5XrBwGQ8yeF186x3WYWNubBRaDdp+Nz3nRgLneMv2kqY/LOBkNE/Lix7DeKS26mh/UKDzCmL6M1cP08Ivoeic7tbNBwj5AeYgqPlB7BLnEsY2tXstXZhVhDMb7Aei20GQ1bwYVJam+WuvLoKUzq/E41vDcYmKWdbVKNatnqb9wEZpopC9qotEneuwarlyVueGN/u417Hy8oEeGRrgxK2XrHsWGvEfW07FKbJOzVCORlb9pTaEx/mb2fYqd44fepVhQdNmbqzTFm00EXfNzRtz2XmnqP/2rhOPdqcEh5H0BA/5zdt0tffz82TCxdHzp9CBf2RjYEINZgXM6YaTPg+d0k/6RjDIZC2bOcu9dU6OyDotSBM3sTt21ZO04Z8A33wMxPm41ykeGSZV83XMpS3FC79enEOJB2hsksF0EpKdk5vmbqwGpmFMxcBfLaN3IsejJ6xboAnAlKYpa903vNUcnBqNRXAuuWncWf5LwfAc6wcnpiYi982QWPdsDu7F3yTxOcnmu7oO3EqNHsgpkukr0TzZIIIeBuBPwdbJV2dx9t2B5oODQodFD4IKEDTO3Mw5n4E9vF1QQBiDUSS5vZpYUKPTNvs/BGryw2NLrHWukowlDMjE/4wbGsy9kxcQ5b2hZe7YY2nTWMIfiRr6CLxLeTWWWlS8kOnd0g7awsSVnKhi9a8dOrzTjoV5GRG+VufjECkyTsbHVXHUS07wBWOjX+iZaDUdm1DGOf9qC14Q/MQ7oO61qynlvesL2NAx50aVlaXghPSVnwZe047kCnRAh4MAJ+Q5Nm33/PbL2eqSKQr66pzjuTd6D4gHoImjojsLBB2NFdo9sHtvfgaWop1YQz3HnbuqX0oHYJAY9EgM5U8chp8WmlfIKzBW2XXSg7dvZYUUWROBMN+9F6dOwR1SWqU1An3yRstt08tXhc/ZRtczIZVt7duj9bc6Ya+w3Wd/SaT/8+afBtiwBxdtviT73bI+ArnI2R4+BxLGnjT3yHDU94oH8g/vz9db6o7/C554TpbhamXxghoC8EiLP1NZ96GI0P0RW4GfZ0x/YdQ4JC8IcL3PomYePJxbfNLX0Uqh5+HzQGQoAQIAQ8CQEf4mxPgp10IQQIAUKAECAEXEaAONtlyKgCIUAIEAKEACHQJggQZ7cJ7NQpIUAIEAKEACHgMgI+xNnYeoZtaLW1tTU84QK3juOCuAwjVSAECAFCgBAgBFocAV/hbNBz1cUqfOu1p3DPTwU/4Q8XuEUmilocZuqAECAECAFCgBBoNgI+wdlg5aLyol2nduH4s+Nlx0+Vn8IfLnCLTBQRbTf7QaIGCAFCgBAgBFocAf1ztiDs/eb9OE2l/GK5+D4bCRe4RSYrItpu8SeNOiAECAFCgBBoLgJ+Q6+bff+9ej67tLK6ctuJbaVVpTZQ9QztiVjaYO7tJ7Z369At4bKE4PZy1E5Fkp8DhkjQlrM9s5ctMk9o4mFgIhy0K5VtziGDWjgEBfGyXGymqc+ItnvnDykTYb4aG6bNGWhQ0fkemjoequeVCGz/8OmPd11gqg+c+re549lvNO8/r7+1Pr8WV+Fjf/f89EHtrPI0gs0eMJ2p0mwIqQE3IwA7W89RQmBknyg7cebCGXvYEEgbtI3onCiCAMQcecgjIlooBKcz88gjTyIhxKUcarMxKnSmVVdk5EChLI5J4zE9RMM4rMUJLfmRLqmpKUmIMy5ikTpx6DmI3lktXBkkyXoyAtsLOj+wmD8h93b86vVVB/B7zTNWX/NXnvXEiGPvvfd9JdO/qLio/9S/iYBfgtkpEQJ6REDnvnH4wEHG9pvDwdbdgrvVXqo9XHIY01qfGIrixiEEJwuU5csJUTQjzGYfB8GXH4A2HPs1t03jdrQk9QjvEcAvom+Zdp0g5egehkBVt+7hEZabNtSYuiYEWhIB/XP2uQvn7AGEkY2IXvnn8s9XnxelEHP83VckQnDaRX2G25hHvGRJveYX2RmLlECWSuBIrW1YIIq1YTfV+JJyi7yZjGUNhuZUmlGVYFrYBvS0ZKnmKbNUM5jkokWLRMxOnpBtuXHwuCH+tkGO2Klqq9aw6VljDDvQqaFn2RYIS0xPppzwplPgzZb818Cz24Yl3c3QV/C3nPKKzF0FU+OqcPM/n2S/gTRheGsS3Otp32d/+LRcCtf64+xyIbfauaud3zuq6tmQkHY+iIDOORszWlvH1r2Qrup11Zg+Y3p16qUa2doo2qqY/UOQOAfBqVc6ZWsXZm2SZjBvNotmjSiX3LFtVO10pRg+YdnZLIJhCj9xnEnppDCrmGXW5y5WmklBDO+N2VBYLJWLZpIl7sZmi9EI0q3mqZxsNDHJF16YkSSZ9grSzjYZ45Ug2tbDLxRBudPNSRNYtG8k2anNh8j7ZnyeLLqx1jd7mUWBxh3f9kDkZmwyy35z5mxHx/IagROudx/8Jet9yNs/TP/16qSxWqd33n/SvwsZ8xtuhkff8vQ/hLt8cvkXwoVulQ6u2Re1UJQ++1HFza+xy+CtWZtB79uzfgi5VXjVyamu98dIB+PTOWcjeFdQQJCYp+raarA1LGx7IxulEINwPTPKWZszVCMpImkG6EWSIsOxTitoDpdqJaVYipk2Lt5oypZyzWZuOrKUmlVYWFzAZZW69fSmNKO6rAuKC2V2Bb8aJebGLiiWZF0Y0U6wELTCzqgskzaj7DiZkm16VBabsfFNsdUV41nuh43PmO7ASq//RcDRqBwAEWMwYFC0gN3YM+cD5bCTU3ZELZwvdpvxxGxjxr12LBt9y3XDyooLa2xgGTj1AbbIzZzpAxM5zat+dfjcD69xQPM+ACwN0QsR0D9ndw/uLuYltyQXu8S7dOgiVrK1RjZKIVY/Z3PWc34blkvPgUKLDixVV9qRN6nxVpwzRPHeYGCWdrbJYkXX16PydiBH3OZugSTxLsI3yjFO1/r7gbbZHBEe6coI7IDgJn2cCQ036Lh3pQ+S9T4EQNjgaysTGIT9Cfhay+HNGBc30Wd3/O8z5BtvBopUtbUQ0D9nR3WJwtI18Ky4WHHszDFc26xkowg5EGuIs0FNM7AZbZNZTAyzAWXPcu5eU6Gzs6XUged6E7dtuS3pjAHfcA/M1rXZKBcZLln8+fBfS3FDmQPAKiXGgbQzTGYHRTaSbJAGQwys90KZia2HzYgbiwDwHCiJmfFOLigogDoEAsSNJQDFi+8s0CSnFwTy/vND1U3cRLak7VnGqKlTLTa31VhRYU/fuARXN44z4r53xFHTNtu1cL0ASePQCwL+ev7SS5JAw7Cq+3btK+YLu8S3Ht+KPxsjGwIQa5CzmUE5zlCo0DPzNou13pXFBovzu5HHIsJQzOxR+MGx1MzXeBPnsKVtefdYk79kAmXyFXSRuFVqlZUuJTu0vUHaWVmS46VsPhTF467o62DY6s4xdKJdtrZSoHEPtz0Q6g42dC5WHBLj4mkPml7+5XFyHNh4dmDNs8oPhG8b02w3s2wcY+5znt7YFfXwwy5966VW/bjC9u3ASSVJjBBoPQT8hlw364F773v8oYmt12fr9oTd4OXV5bmluXln8i7V2R4tDgs7umt0TLeYkPYhjXB266rdOr2JnV+N7xBrHW2oF0LAwxCgM1U8bEJIHUn/nI1JFrRdXF5cUF6AA9GwGQ2Z7QPa4/izyJDI8JBw3yRsvre8eJxM2TYnk7n5WDKbI92wdu3cojv9RAmBtkSAOLst0ae+HSHgE5wtaBv7zvA1dlVNlbC2YWF3COwQ2j40wD/ANy3sdCNRJ/2rQAg0hABxNj0fnoaAzs8uVeEGKwcGBHYN7tqzU89enXvhDxe4RaYPEjZg4Zuyydb1tN8j6UMIEAKEQEMI6HzfOE0+IUAIEAKEACGgGwSIs3UzlTQQQoAQIAQIAZ0j4K/rsF46nzwaHiFACBAChIBPIUB2tk9NNw2WECAECAFCwIsR8BXOxr7x6prqU2WnDp8+fKDoAP5wgVtkOg7n5cVzSqoTAoQAIUAI6BMBn+DsS5culVaWHiw+ePD0wUOnDx0q4X+nD+EWmSiCgD6nl0ZFCBAChAAhoCME9M/ZMKPPVJ0BPR85c6SksgQHqiCHmd211bhFJoogQNa2jp5qGgohQAgQAvpEwG/IuHsfmHW/js8uvXDxws+nfj55/qTNBOKAcYTmFAG+eoX2urLnlUHt5KidiqT28C5Hx49YnSPm0vMhAl7j8+gmNGFzYBn6dfOZZS6NhIQJgVZHoGTL+4s/31PG+40Yn/LCVHYafd66V9/4jv3K1Rw36EVnqrgBRGrCrQjo3M6G07uwvPBU+Sl70GLDYuPC40SkTghAzJGHXAkQmRJnsg/lzKJZNfOsbksToOLGI2mwYfDTUHgsTEU5J3RwunW3Pl3UGCHQEgicM5s7jk/hP4NUQdhg8feMA1jWgpk9d6xcgyg5lAgBXSKgc87GnOWfy7cPDSKMbJC0CPAFAYg1NMFKAGldPgQ0KELAyxAINoR30ahcctB0KmrcWMbeYWMmXhNwYB+RtpfNKKnrLAIBEVFDrxw2fPSIfs7W8Co5sLLRbKytq7XReljEsC4dupw6fyqnhHE2Us2lGkT38vfXvsSUmLL3S/Hj4sLYi7x8vX9ZyjfHKr9eujS7sn8v09Klpl4oh4d7qcmvOGPx0tWZuyr7jytenbJ4eWZmZn7olJFRqAwrl99n8lK0p7bMa/ZiFdKNUtEBJlB5cGnGMS4lan6s3lgNQqsci/axAH1burTKqPjG0rrSsFdNIylLCGgZ+sD/vt24cQP/PVXxB7pw1/p9HUfdKH4zl0oO7cgLihsZFSLXgRH+RmZR1e4P3vpw3ab80GHdd789P22VWpl51fl9Jiu0VGO1l7yfrnY878FkmgZCoM0R0Pl549hZdvHSRYFybPfYOANzhtsY2aIUYg1tQ8vemCXFDWXv8ZJkNEkz7M7qLszaxHJTeRxrxLdkl/HGTSyUterO5qUbsx1MOvzdyfFsXRpHgE9DaG7TXmEnZJuM8Q2EtxYticVx4SlMltKZhx3qGtAYS3Cca1sXQ6BECHgvAmFjHlzEn23mB39/Wba58aFUGH/Ii30sNfWJhJL0lz+5dCcqPzExYPtG1C3Z8p0xLPlF1t4rcxINjbdFEoRAWyKgc9844n+0828nAO7aoSsWsMHcWMlGLC8sYJ+uPK1iDzFHwUIKwcAspUvJakANhywakTRjGuPDyHAsM09IZO3iUmketCqaMUpmc2NuO/jhZdJmlB3H22ooFRQXKmoqHaBrY/oi8cJAiRDQKQLMD97FXHy28eF1jL9pKuPjzgZDRLxwouMylFUM6xUeYExfRkvgjaNIEp6AgP45G1QtgD5cchi7xCNCIrQr2eocQMwRZyvbvJqz10zeGy5vHHNi1mOmjTMwSzvbZJbpv7FKzEJXEnu3YFvbUmdIK/Ga4NzGtsY6oHJCwIMRAP9K5gLZ3sYONckQ6bzBHH3bc6mp9/ivTkl53imb3YNxINV8AAGdczZmsE/nPgiVjQucnYIFbKxY2xvZEIBYS0037OCI8EjWeu5eU6FTvSTGgbQzTGbFHd9gJWZUy054KzlG3PDPmxw5453SgoQIAY9GAG7t7bWDhsRIYQPjeh7btJn5ldQ81zQHcS+YGWM2HXTC0e5ayyRNCLgVAZ1zNhiaGdYhPQVo2HFmKjbhT2wXVxMEIGa9Ac19MCdigVq42FcWG1R3uW37iXHxxvSUFNmhDdLOypIaXcrmjYCb+Sq6SLwBbF0TCT59/iWYdevuGxu1RAi0OgLYMyae7gVf1t44h3/rFTZm6s09d7DfgCXPSb2wQ+0FpbVx3IFOiRDwYAT84sfd89tZD+j4TBXsLIOFjZNK2RfYdbZnlMLCBlsP6D4AG9Mc+cbbbOrAutjJ5sSX122mIXVMCOgeATpTRfdT7HUD1LmdjfkAE2OtGqzcr2u/sOCw9gHtkYOEC9wiE0X1LGa33WzmZmyy7D5TjWZhXNACddvNC/VMCBAChECbIuAXn3jPb2fr2c4W8LKPvmov4oDxsuoyXCCnXUC7Tu07gbZx4WkWdrrR0VGpbfqgUOeEgA8iQHa2D066hw/ZVzjbw6eB1CMECAEPRIA42wMnxcdV0r9v3McnmIZPCBAChAAhoBsEiLN1M5U0EEKAECAECAGdI0CcrfMJpuERAoQAIUAI6AYBnZ83rpt5ooEQAoQAIUAIEAK+Ymdj33hNbc2ZyjOnyk6dPHcSf7jALTIbCg1CDwghQAgQAoQAIeAxCPgEZ4OVy6vLj589jhPQdp3atf3kdvzhArfIRBHRtsc8kKQIIUAIEAKEQL0I6J+zBWHnlubuLtpdcL6gqqYKp6HhDxe4RSaKiLbpJ0IIEAKEACHg+Qjon7Nxgsovpb8cKT1ic3Bpx3YdIztFGjoaUAQBcdAKJUKAECAECAFCwGMRwJkqd/929m/1et44jOyi80VbT2y1P2l8WMSwK8KuwFHk3+d9j1PHR182ukdoD9sD0XBsKEJes4Rolw0c/i2H22zq8eCsepZVxC86B81jfzKkWJsjgCAhb3x3kqkRMT7lBR4kBJE+Fn++pwxXIfHJT8xxV6gPOlOlzSebFLBBQOecfenSpR0ndxwvO24zbBjZ1/e7HlS9/cT2k2Xs19+7U++rel1lFdpLS8S5GRkF06YlsoBZLRi6w6XWod5KaQaLlk2JEPAlBPLWZ+RfOY3RMsj73cJrQdEBWzK295h2I34LjLy/D3tAMHmzE3F2syGkBtyMgM5947CzT1eetsesf1j/QP/As1VnC8oKRCnEbHeiIe51fBwLZIkUwwibEiFACLQ9AtGTOWEjdTYYQvlF2BhO2OyqV3intleRNCAEWgqBgB5RQ64cduXoEf1aqoc2bRd2tum0qU6qgxaIudm5Q2dcgK1HRI7Axd7CvQgZIhSE8zw2LNbKzo6qyF+e/nVl/3FxYUJGeMqLDmRm7kJu8eqUb45Vfr10aXZl/16mpUtNvSAI43epya84Y/HS1UJK1EXNxcszkfIrK7/O4JKOcPl1Z2axYcrIKKU3UUduBk0vYK2ikdApXXYyb3p53o/8Tq7RplBT54RAqyNQuGv9vo6jbtT+mkoO/G97eZ9rR0aFqNrA9H4js6hq9wdvfbhuU37osO67356ftgo/rCrx+4S1zu8zWaG2oiQteT9dbWbeg8mtPkDqkBCwRUDndjaGG+AXIAY9IHzA6N6jY7vH2hvZWjENQolzUlPiTKlq/EvcJ8ezle1U2SNtNEkz1BulYmHWJpabmpIkZW3MRi7INt2clIKs1NS4Yut16/qeSOEl5wkqrMzIlbI3ZhnQM0tYNo+Z9kJKUgRWvfkdJULABxHIW/f5trBxY7VO8JIta/57atAEu+XsCuMPebGPpaY+kVCS/vInl+7Er+iJiQHbN2ab4Uz/zhiW/CL7Yb3itnVwH5wNGnIrIaBzzsaess5BzLZGyjmdA2O6T+c+UV2jcHHo9CFhf4sEMUcROcGN+C0nS+kOw1bHj3OwmhyRNIPnxgyNizCbcyWJ+dgVwcQJSRFOTG2u2SwZ00W8bNjThcUFUmR4hDF9EcibEiFACMA2TgH3alkW5vQLrxtjH3O0lN0x/qapjMjhTI+IFzSv+NXhTA8wpi9bQ78seqq8AgF/RJb2CkWbpiRo+LJOlwkyPnX+FHaJB/gH2Kxko0gr5qijxDnJ8UYTs5mbkMC/EeGRLlfkNrSShGWdmjpDWqla/S63SBUIAX0gAMJmtrKWnEHYS8HXTbGUo297LjX1Hv/VKSnPL4PdTYkQ8GgEdG5nY30anN01qKuYBNjWYG782RjZEICY1WI2pLOXLVNomtm9TU2wt2UnOWtzo1O+8RiDoVA41q0TI+5mvD40dQhUjxDwHATgzD4yYIb1vvC87J9qx3FLuokJxL1gZozZdLDpP/Qm9kzVCAGXEPDXs5XNkQgKDIoLj+sS1AXGNNh6S/4W/Invu5CQiSIIQMwWuMQJ4ZuEezol1RSXwteNE+Pimc/aJR91zLQZSWbZ0W0Kd8o3LiXOSVHrpHC/PFa4RUqXkrkq/F0Ai+3qi4VLE0/ChICXInDObD76PdtlIhIzjktOFhcZ019W8xa54OlmLnVeccGXzaN9L4WT1PYyBPwGj73rwfse1OuZKmI2sHu8qLwIh52drz5/ofZCbV0tMrE3LSggKLR96BXdrugR0sPWyG6peXTpE+yWUoLaJQQIAWcQoO+znUGJZFoTAZ/gbEHbF2ounCpnS9qgbWZ/BwR1C+7WM6QnLOzWImy2hTy1eFzqHEk9X41PdsOHrLXm80B9EQKEgAUB4mx6GjwNAV/hbOCOI1PUhFt4xdXUwrNiOQFVojNJWxhrap4QcCMCxNluBJOacgsCPsTZbsGLGiEECAHfQYA423fm2ltG+v8BP+whyVREaNoAAAAASUVORK5CYII=)

[TestMethod, Description(&quot;Expect exception thrown when initializing with negatives&quot;)]

[ExpectedException(typeof(ArgumentException))]

φ **public void Domain\_Exception\_Test()**

We test for negative number initialization. The method properly throws an exception, passing the test.

        {

            var negative\_natural = new Natural(-5);

        }





[TestMethod, Description(&quot;Test for default initialization&quot;)]

φ **public void Constructor\_Init\_Test()**

Here we test for number initialization. The objects properly equate to zero, passing the test.

        {

            var zero\_natural = new Natural(0);

            var default\_natural = new Natural();

            var valid\_natural = new Natural(Int32.MaxValue);

            Assert.AreEqual(zero\_natural.GetIntValue(), default\_natural.GetIntValue());

            Assert.IsNotNull(default\_natural.GetIntValue());

            Assert.AreNotSame(zero\_natural.GetIntValue(), valid\_natural.GetIntValue());

            Assert.AreEqual(zero\_natural.GetIntValue(), valid\_natural.GetIntValue() - valid\_natural.GetIntValue());

            Console.WriteLine(zero\_natural.GetIntValue());

            Console.WriteLine(default\_natural.GetIntValue());

            Console.WriteLine(valid\_natural.GetIntValue());

        }

 ![](data:image/*;base64,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)

[TestMethod, Description(&quot;Addition test must meet expected output&quot;)]

φ **public void Addition\_Test()**

        {

            var natural1 = new Natural(50);

            var natural2 = new Natural(50);

            int expected = 100;

            var actual = natural1.Add(natural2);

            Assert.AreEqual(expected, actual.GetIntValue());

            Console.WriteLine(actual.GetIntValue());

        }

 ![](data:image/*;base64,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)

[TestMethod, Description(&quot;Test all arithmetic through complex method chaining!&quot;)]

φ **public void Arithmetic\_Test()**

Here we try stressing the consistency and limits of our function chain, such that despite its length, it would still return our expected values.

        {

            var natural1 = new Natural(10);

            var natural2 = new Natural(2);

            var natural3 = new Natural(7);

            int expected = 50;

            var actual = natural1.Add(natural2).Subtract(natural2).Multiply(natural1).Divide(natural2);

            BigInteger expected2 = 20248916;

            var actual2 = natural3.Pow(actual.GetBigValue()).Divide(new Natural(new Natural(5).Pow(50).GetBigValue()));

            Assert.AreEqual(expected, actual.GetIntValue());

            Assert.AreEqual(expected2, actual2.GetBigValue());

            Console.WriteLine(actual.GetBigValue());

            Console.WriteLine(actual2.GetBigValue());

        }

 ![](data:image/*;base64,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)

Notable from our tests so far is that these operations are effectively confined; **natural1.Add(natural2)** is equivalent to writing **(10 + 2)**, completing the operations before moving to the next method in the queue. Our next test involves an array of Natural objects.

**More Natural Methods:**

± **public Natural Modulo(Natural value)**

        {

            try

            {

                if (value.value \&lt;= 0 || this.value \&lt;= 0)

                    throw new ArgumentException(&quot;You cannot divide by zero!&quot;);

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

± **public Natural[] DivideAndRemainder(Natural value)**

Whenever division is involved, we must always check the values of the involved objects.

Here, we return an array of the Naturals, first index has the quotient, the second index has the remainder.

        {

            Natural[] divided = new Natural[2];

            try

            {

                if (value.value \&lt;= 0 || this.value \&lt;= 0)

                    throw new ArgumentException(&quot;You cannot divide by zero!&quot;);

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

± **public Natural Pow(BigInteger power)**

        {

            BigInteger var = 1;

            if (power \&gt; 0)

            {

                for (int i = 1; i \&lt;= power; ++i)

                {

                    var \*= this.value;

                }

            }

            else if (power \&lt; 0)

            {

                for (int i = -1; i \&gt;= power; --i)

                {

                    var /= this.value;

                }

            }

            this.value = var;

            return this;

        }

± **public Natural ModPow(Natural exponent, Natural mod)**

Since we already created a Power and Modulo method, we can use this in the composite method.

        {

            BigInteger exp = exponent.value, m = mod.value;

            this.value = this.Pow(exp).Modulo(mod).value;

            return this;

        }



[TestMethod, Description(&quot;Test all arithmetic through complex method chaining!&quot;)]

φ**public void Arithmetic\_Test2()**

        {

            var natural1 = new Natural(10);

            var natural2 = new Natural(6);

            var natural3 = new Natural(3);

            var natural4 = new Natural(10);

            int expected = 2;

            int expected2 = 12;

            var natural\_array = natural1.DivideAndRemainder(natural2);

            natural\_array[0].Add(natural3);

            natural\_array[0].Add(natural2.Divide(natural3));

            var actual = natural\_array[1].Gcd(natural\_array[0]);

            Assert.AreEqual(expected, actual.GetIntValue());

            Assert.AreEqual(2, natural\_array[1].GetIntValue());

            var actual2 = actual.ModPow(natural\_array[0], natural3.Add(natural4));

            Assert.AreEqual(expected2, actual2.GetIntValue());

            Console.WriteLine(actual.GetBigValue());

            Console.WriteLine(actual2.GetBigValue());

        }

 ![](data:image/*;base64,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)

**More Natural Methods:**

± **public Natural Max(Natural value)**

        {

            return this.value \&gt; value.value ? this : value;

        }

± **public Natural Min(Natural value)**

        {

            return this.value \&lt; value.value ? this : value;

        }

± **public int CompareTo(Natural value)**

        {

            return this.value == value.value ? 0 : this.value \&lt; value.value ? -1 : 1;

        }

[TestMethod, Description(&quot;Various methods of comparison&quot;)]

φ**public void Comparison\_Test()**

        {

            var natural1 = new Natural(50);

            var natural2 = new Natural(25);

            int larger = 50, smaller = 25;

            int expected = -1;

            Natural actual;

            actual = natural1.Max(natural2);

            Assert.AreEqual(larger, actual.GetIntValue());

            Console.WriteLine(actual.GetIntValue());

            actual = natural1.Min(natural2);

            Assert.AreEqual(smaller, actual.GetIntValue());

            Console.WriteLine(actual.GetIntValue());

            int output = actual.CompareTo(natural1);

            Assert.AreEqual(expected, output);

            Console.WriteLine(output);

        }

 ![](data:image/*;base64,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)
 ![](data:image/*;base64,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)

± **public Natural Gcd(Natural value)**

First, we assign the value members of the objects to local variables.

To get the GCD, we apply a non-recursive implementation of Euclid&#39;s algorithm that states that every common divisor of a and b is a common divisor of b and r; thus, computing the larger number first and the remainder, then exchanging it with the larger number until you reach zero, will result in the GCD. See Figure 1.

{

            BigInteger x = this.value, y = value.value, temp = 0;

            if (x \&lt;= 0 || y \&lt;= 0)

                throw new ArgumentException(&quot;You cannot divide by zero!&quot;);

            else if (y \&lt; x)

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

± **public Natural Lcm(Natural value)**

The LCM two integers is the smallest integer that is a multiple of both numbers, we can get this and the GCD simultaneously as the GCD is the largest integer that divides both numbers. If we follow the division algorithm, we can get the missing multiple.

        {

            Natural temp = new Natural(this.value);

            BigInteger z = temp.Gcd(value).value;

            this.value = (this.value / z) \* value.value;

            return this;

        }

± **public Boolean IsPrime()**

First, we dispose of numbers less than 0, as these are not natural. Next, since the case for 1 and 2 are constant, we can return these immediately, otherwise, we check the most obvious divisibilities, if they equate to zero, then they are not prime. Finally, we run the numbers into our program, constantly checking increasing levels of divisibility. Normally you would make the square root of the number the limit of checking, however in this case, it is difficult to approximate BigInteger values through this method. Though it takes much longer, checking up to half the total should satisfy the requirement.

        {

            BigInteger num = this.value;

            try

            {

                if (this.value \&lt; 0)

                    throw new ArgumentException(&quot;Number should be within the domain of natural numbers.&quot;);

                if (this.value == 1)

                    return false;

                if (this.value == 2 || this.value == 3)

                    return true;

                if (this.value % 2 == 0 || this.value % 3 == 0)

                    return false;

                int i;

                for (i = 2; i \&lt;= num / 2; i++)

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

± **public Boolean IsRelativelyPrimeTo(Natural value)**

All numbers are said to be relatively prime if their gcd is 1.

        {

            return (this.Gcd(value).value == 1) ? true : false;

        }



[TestMethod, Description(&quot;Basic observations on Number Theory&quot;)]

φ **public void NumberTheory\_Basic\_Test()**

        {

            var natural = new Natural(9);

            var relative\_natural = new Natural(38);

            var valid\_natural = new Natural(36);

            int relativelyprime = 1, gcd = 9, lcm = 342;

            Natural actual;

            actual = natural.Gcd(relative\_natural);

            actual = relative\_natural.Gcd(natural);

            Assert.AreEqual(relativelyprime, actual.GetIntValue());

            Console.WriteLine(&quot;Relatively Prime (38,9): &quot; + actual.GetIntValue());

                  natural = new Natural(9);

            var IsRelativelyPrime = natural.IsRelativelyPrimeTo(relative\_natural);

            Assert.AreEqual(true, IsRelativelyPrime);

            Console.WriteLine(&quot;Relatively Prime (38,9): &quot; + IsRelativelyPrime);

            natural = new Natural(9);

            var IsPrime = natural.IsPrime();

            Console.WriteLine(&quot;Is 38 Prime?: &quot; + IsPrime);

            natural = new Natural(9);

            actual = natural.Lcm(relative\_natural);

            Assert.AreEqual(lcm, actual.GetIntValue());

            Console.WriteLine(&quot;Valid LCM (38,9): &quot; + actual.GetIntValue());

            natural = new Natural(9);

            actual = natural.Gcd(valid\_natural);

            Assert.AreEqual(gcd, actual.GetIntValue());

            Console.WriteLine(&quot;Valid GCD (36,9): &quot; + actual.GetIntValue());

        }

 ![](data:image/*;base64,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)

± **public override String ToString()**

In C#, everything is derived from Object, therefore, when creating similar methods it is important to either write new or override into the method signature to indicate that you want to use _this_ implementation. The work of this method is pretty barebones but the override carries over to the overloaded method below that takes one parameter.

        {

            return Convert.ToString(this.value);

        }

± **public String ToString(Integer num)**

We could use a dictionary map tinstead of iterating through a character array, but I believe that results in writing overall more lines than this solution. In C#, the maximum value of int64 is 9223372036854775807, which may be larger than the long of some other language (Int64 is equivalent to long).  2,147,483,647 is the maximum value of Int32. Note the Integer type, C# has no concept of boxed data types as the functions of these are already inherently usable on C# primitive types, I could simply write Int32 as the formal parameter, but to preserve the java similarities, an Integer class was included to mimic its usage.

        {

            try

            {

                if (num.Value \&lt;= 1 || num.Value \&gt;= 63)

                    throw new ArgumentException(&quot;Number should be greater than or equal to 2, and less than or equal to 62&quot;);

                char[] map = new char[] { &#39;0&#39;,&#39;1&#39;,&#39;2&#39;,&#39;3&#39;,&#39;4&#39;,&#39;5&#39;,&#39;6&#39;,&#39;7&#39;,&#39;8&#39;,&#39;9&#39;,

                                         &#39;A&#39;,&#39;B&#39;,&#39;C&#39;,&#39;D&#39;,&#39;E&#39;,&#39;F&#39;,&#39;G&#39;,&#39;H&#39;,&#39;I&#39;,&#39;J&#39;,&#39;K&#39;,&#39;L&#39;,&#39;M&#39;,&#39;N&#39;,&#39;O&#39;,&#39;P&#39;,&#39;Q&#39;,&#39;R&#39;,&#39;S&#39;,&#39;T&#39;,&#39;U&#39;,&#39;V&#39;,&#39;W&#39;,&#39;X&#39;,&#39;Y&#39;,&#39;Z&#39;,

                                         &#39;a&#39;,&#39;b&#39;,&#39;c&#39;,&#39;d&#39;,&#39;e&#39;,&#39;f&#39;,&#39;g&#39;,&#39;h&#39;,&#39;i&#39;,&#39;j&#39;,&#39;k&#39;,&#39;l&#39;,&#39;m&#39;,&#39;n&#39;,&#39;o&#39;,&#39;p&#39;,&#39;q&#39;,&#39;r&#39;,&#39;s&#39;,&#39;t&#39;,&#39;u&#39;,&#39;v&#39;,&#39;w&#39;,&#39;x&#39;};

                string builder = string.Empty;

                do

                {

                    builder = map[(Int64)this.value % num.Value] + builder;

                    value = value / num.Value;

                }

                while (value \&gt; 0);

                return builder;

            }

            catch (ArgumentException e)

            {

                Console.WriteLine(e);

                return null;

            }

        }



[TestMethod, Description(&quot;String map, number conversion to specified base&quot;)]

φ **public void String\_Test()**

        {

            var natural1 = new Natural(Int32.MaxValue);

            var natural2 = new Natural(Int64.MaxValue);

            string intmax = &quot;2jg3E7&quot;;

            string longmax = &quot;Ca06U74ZPEa7&quot;;

            Console.WriteLine(natural1.ToString());

            Console.WriteLine(natural2.ToString());

            var actual = natural1.ToString(60);

            Assert.AreEqual(intmax, actual);

            Console.WriteLine(&quot;2,147,483,647 in base 60: &quot; + actual);

            var actual2 = natural2.ToString(42);

            Assert.AreEqual(longmax, actual2);

            Console.WriteLine(&quot;9,223,372,036,854,775,807 in base 42: &quot; + actual2);

        }

 ![](data:image/*;base64,iVBORw0KGgoAAAANSUhEUgAAAUwAAACbCAIAAACGQDUrAAAAAXNSR0IArs4c6QAAIjBJREFUeF7tXQt8FNXVn0DYACa0KpZXUIIm8ig+Ikp4FURCixE+4gOwmGhtQdnIq2AttBWorVZBAe2uAgKW4MejChQao1lBEIFoISg0PLI8FAJiC/0kUJAE2O/cO687M3dmZzc7yWb3zI8fv83Mveee+z9z7j33zj3nJAQCAQEvRAARiF0EGsVu17BniAAiQBBAJcf3ABGIcQRQyWNcwNg9RACVHN8BRCDGEUAlj3EBY/cQAVRyfAcQgRhHAJU8xgWM3UMELJTc7+2ZoLsKfOEi5isAUtcV+KpkAoR6T68/XHoO17tU/ITU9aaTPrJo68r+V++yLmHJKKmuhTix/8JDDvcNyccbAhZK3iHvb8fJtfIxQXhsJf35XJ+g+JzcMPWedlO4g4Gr6s3HX9xWE5REfRcA1euV23wjHBMKBC5/nn6AaDloPU+ZG3Ua/9l3c+4Ol2NSnbRS896YpIm0wUubRt8YhBqw1xOHgnAhj8d6FkreJOUHbcl1dXNBaH41/XlNs6AYnT2waeOJC9ximTk5wvOTX98X7Wp+5Uj57rFDRc1t1Mn9ZNg6HBQsLIAI1AECIa7Ja756b0qf65ISEpKu6zPjo29AXU9vmXFPuxRic6ZM+Rhs8IyCUkHwDkpI4Jj2A3+32H3w6adXHtN0jM79IoXOjyyjQwAx7nu+sGbeQLidctcft33lm9IZfiZ1HLFCNPBP7/A+Qu6QKkv+CWPKyb+OSGk/caOyGqgNdInZwx6dm81MljCNN7l3wcW5AxKINU0m9fFesLPhD788q9Lp9Y0PROtbtbkVs5/UsDn/KnUkMqpND7YE/JHVeULp5jE3JdRimVAbdLBuw0OAGqWWV4lbENwlpEj11mmpqe6ik9WB6pPrRrd05f/tzIYJLmHIW5XVCoUKT5ZcnKVKiGR5KgKnVj/sajm66FSAlCM3AoEz+78oP30eqB9ekC24JmyAW6S0q++8XVVVe+b1dQmuVPfqyirSpNBy2tZA4GhhTnLfeXugzvk9s7OELrN2B75eNTw5dcKGM8E6Y/f55X3z7gRhSkY0a1AT21po3G/BQWrN75uXRX/S8uJd8pPWIz/kgmwlIw+qua7+kmkzd8SKSpt2+4Ll4hyBkGbyLatmV1Z6c1q7Elythy48VV1R+U16Vk7y+qdyx3s/PHDWjhl+be6Li3r85YlXtl1SxsNmTSuLxt2XkdHhljE+obrmsvQgc+Tg21JSfjh4ZKbQIn9UbruUVkMeGi6c+va/wpHiBUXntkzo1jwhoXm3KaXC3iMnhdYPrTx7bO6AFpEaZcXVcs2a8wN4E2bSuOnGpXPjfq8vIncbZQx65PZdBw8JxOyXCyb+eBIdNYKttw/6dxGLgVyNYcYu3Xu0UVrXWzR2RTAa+BwR0CIQkpKTqjmFXyvj4nZ3evuRK0/sX/PYVe/+rFPbESu0djgf6/YjZs1KfX70c59IY8Jnf+yTszrz5Z3lx8+SCZx33dTuOv1tOqPLlyfbIbEmDva89+jr66z2181bvnLQvzury/WhsibP/bRzsKlHh5vqNy48nIAGeqhYYnmKQEhK3n3ASFfR1OfWH78g1Jw9sGo2XSA3Sbl5oPuF+dP6nSsqhb9btUkThG/+RZbrJleTzmNfnla1fPlO8fmZf1cK7Vq3aXrp+Jq/rrIllbSeQ7ucmv3rVz8H2+HC8U9eWLAxsmvyS8UF8nczUNRdtnjiFIIZ/eHz4/4sjhCXPpgz4R/BKTW6Kf2WzXIdpjjR9Jrwx5vgDWOJGEYgJCVvMfSVrZ5+G3+a2jwhuePwZY2vbyV8PI1swyW4bv9D4+kf/m6AILT40c8mpK1/pHXyRFA9MzXv9cxid0vpYf+n5t+7+fHWydeP+fcPc+0h3W3Ce0XjrjzXo4Ur4Qd3TT/aqr29anZLJf54XNoz4ufrxj9cPbqcfCKjm3HixptdMrAz/9TSl7aKtndy8a12zHUhcfDr++Q64tSt7MM1yW1eTFihgwduvNkWAxZMAJsQUagDBEBXk0tG1uKbeh3wiE3EJgIhzeSxCUFd9OrKfu/0v8C3d/UkHZ3f8StYXYAf923gTO7gKyB+X6cNwHbageCH2RzkBUnHLwKo5PEre+x5nCCA5nqcCBq7Gb8IoJLHr+yx53GCACp5nAgauxm/CKCSx6/ssedxggAqeZwIGrsZvwigksev7LHncYIAKnmcCBq7Gb8IoJLHr+yx53GCACp5nAgauxm/COCJtyCyv3LlymV6iZ48xDONXo0a4fgYv2rTsHqOSm4lr+rq6q+rvl61f9XWY1tP/vckFG19Veve7XsP7zS8TYs2LperYQkbuY1PBFDJTeV+8eLFv/v//vKnL1dfrtYVcjV2Te4x+b70+5KSkuLzvcFeNyAEUMn5woI5fH3F+he2vWAhy6m9pg7JGILzeQN63eOT1brKoALont6xZKwYeznpulsf8ZZaRIiqT1nA2hvW4WClwxxu5OPBLg/uGLNjYz4JewMFoJgx6gabFyWkUDL2u22S68E+ASwZRwjUVQaVmm2/ue3OJ7d1m7Pp0PFD25bcf/KZnt0n+k6bIm2RiMVh6ZCgx5cvwzrcaKVDy2O7j4X/l3y+BP6HAlAMRgQjR0rI5n/ev7CrZaIlh3uD5BEBq0COkcygcmzZjOe/G71m49zhd3Rs2/GO+6YXv/f0d96JS/aYicAiEYvDUhOVHHbauNP495p+79zFc8t2LxOfQjGukst1lfDMDjON5BEBcwRC/A4UZgaVqh0+n2v4Q9nXKow06fuTUa69m744KWZLkTIfSr8NiVhIwpRbScTIlM7jisgmt5JBhaRQ8e6gFkHk0q6Anot76bpLnMYX7VoUEKTAeFDMVpA8xoKXQz7pEqXo86YImsQplBHlTmL/BfbDSeLbH/cIhKTkNdtm9HniwrR/ngtUH13cxfOTXxVXbXxu4Myrnt9PMqicnf2jdPd2JYMKGwz9m6+PCJldOzRh4W6fkSmcrjrLk4COzLFlj/aedHTkGn9V1fZfXPnqrOBfkAs3xm46ff58ZXH+0Um9f7lOyo9UVnys35oTe+bd/sVv7+6ztveHJ06ue/TsqnFvbRMEoHL3irv++i9Iu7L9F4ceH+ExtSI0LJXklcAiPO+WPFiN66ZxGy8PRGL+ZdKoATfKmQ0h/clLpTMh4isEffv9ATELC8lxqPuT6HPvJ5stp7HXIcPDYBq1dWznX/WmWRGr37i0VIwqhRciEByBkJQ87AwqKS2uFcoqtKkXjlWUCWltWgVn8eTmFUUtpvxpap/rIaHK+InZiUc+WrYFboy/45pmzdr1KZj0QPXSDz4V6UQm7QrsDcL3cJHigp1EnX5++8+N0zjch2JQ2NiHyyRZGVwQRtknhnaTZmopLYpAA6yPUZbruj9J8hWa74zSuHfBpV0H/Qf95RNpSGaahXHmmODAYQlEgCIQkpKTCmFlUGl9a/8u1W+veE/daKvyvft2dXZ29xbCVd+XI7CbiOTC+Srh6mQpn2qT9HRI3iCoN2glV5PGhsrhpl0Rz7TBiReR4jt73znz3ZnkpGTuNA7FuEfflDQoYgxmshn+Ync6b5OkaORKHDw/EDg3aIWUHlH3JxRQ0rCJk33akfId+M4iAuEgEJKSh59BpduY1yY0XZg7YOKqnYdPHN65asrA+71Np814BNIitLmhs1D2/scHzp49vn7tOrkPTCIWkjDFP2PCC58chSKfrNl4JO3ukVlw49Wd/7kACVQ8c95NHTu0e7DO2067Iio5nGmDEy8i0dd3vC7+YFfjZGhp7IJiNs63kjwsibffRCd031rG0AbVvrzvlYtvbxSX2OqfJAHaa8SsVy6S3UG+QwI8o7keTOL4XEYgJCWvRQaVFgNm7dg+p9tHBb1ubHdjrwJfxov/+PyPvcgiPW3kn/5w53Z3p5YdR+y8qofMF5uIpduEjRunNvnz4BtatOg0euOFZkL66LVw48X+1zZv3jG3qOvbJbNsZDq0m3YFlBz0Fk6tTukxReQGJvPuC7rDv8LdheybAwWgGNdc175gxLwm+VdIJpW/J9KZXNlEgxwtjy8anbZfTHpMUrbAn2QNv239zZK9LuZtgbxs8h3Xk4n5aK6jEttFAE+8mSIFx1qL/EWzP53NPdYKGp6TnoPHWu2+aFiu/hBAJbfCHh1U6u/NxJYjhgAqeRAo0dU0Yu8aEqonBFDJ6wl4bBYRqCsEQtp4qyumsB1EABGIHAKo5JHDEikhAlGJACp5VIoFmUIEIocAKnnksERKiEBUIoBKHpViQaYQgcghgEoeOSyREiIQlQigkkelWJApRCByCKCSRw5LpIQIRCUCqORRKRZkChGIHAKo5JHDEikhAlGJACp5VIoFmUIEIocAKnnksERKiEBUIoBKHpViQaYQgcghgEoeOSyREiIQlQhETMmV0OgkCdJLn0WgsxB9XQnIbp8cib5e4NOXh3jxM4bSyO0JKe3umbL+0AX7FLEkItCwEYiQksuh0fcdP3581+K7m5wDVHYvGnprzgJ/FOBzbFluRs6ixLzlu44fL//gtx1XP9jlx959Naachct5uPWiACJkIYYRiJCS799eVD3kqTF9OrZt27bLkLmTBgBk35St3/2fS/WPXc2W1yYVZc4rWTllYBfgrtfYhZvf6Ldl0p+KpYQMRg7D5TzcevWPEXIQ0wjQJB21vs5smJAqJN85ed3B8yKtEreCWpanIvD1h78e0DaZ3EruNKpwL0m4QkpkzfRM7gS3XWnDxZuBU//wjJLuTBt9h0DqBgJfvDnklpYkPrKrZe/pH5+COzRPywNuUtldEqj+smhyb1Ig+c7pTz8gkFvMVfZ8ukRHuXl4fl+h5bStIhmptPxbx7nI5uLpMn21eet6tYYUCSACEUIgQjM5RFz+pOgJYf7Qm77fccQysISzPaIWg5Jud6cLzVMffm0PZCiqPvxK+7d/Pn+LNAKUfXhmGKQy+mhSs1X0ZpXv2cEFhx4urjz/7ZZxSXt2SsWu6TF9/eFzkN/o/bwDM3/z7hHp9uaafpv+E/Bk+xeOzPnL9XN3V50/UZheuVk/Jp+q9AuZ6ens7bS0bsKpb//LHb11nJMypcXHBq48+m3llqcbzxyopGTS1ebUi+nZATvXYBCIkJILQpMb7p392b8qt8y5bVvebb+Qc5PJODRrWlk07r6MjA63jPEJ1TWXpfuZIx/s0y6lVf97+gvVB0+cFHYUvXkqp2BMn3Yk/9HDeTDN0qvZd7tfHdUzo+P1P5lzSqi5JC8Bhj80pBVEbj/y0YrSlmOeGnVzSrOUm0f9bLgee5KiZc8ReWSgT48c2SOkpwbJ3KLSYVmqrqj8psFIFxlFBACBIIEc33///crKysTERAWsxx57zBq4qjU//d79V5cEPEJBwqAyTwWZyD+b0b7HBxN3lYy/LWUT3BXgaTZsg8uPSUJS+jt9bsKg/1t95n9zW0Ab+17t3mX54xXb7995/w3jWq74fF5uu0pvz4zCPCApwI+CTEJGEEgO1LlDyyqm3g6VIAuRK6eJ+EC6qtY9et3/VMza+/H4zlLGRVJjet+PT7yUvvK+Nnk3qGQkknrWjCx9GrSeKUjvvPPOuXNkYxIvRKCOELAw+4uLiw8dOmRrXbDhlcc9vnLYWj+0ZV5OSyF78dFAgKyF03+3nSzSieX+wLKT1ecrV4+G+ZOuZmVrXl7B06X78lyXq+/zWyqrqr5a504VzX2yWCZ0qqt2zYa5nS7T2cV04NPpqUJq/sr9VVWnd8zrC0tz7ZocSs+Hu6m5swiH5b5Zw9NcrpxC4DAQ2DDBJXR5xgft7WJqMpxTNl195+2qAuYJS6nTP7VVzxZsWAgRqAMEBIs2Fi5caJcDZWtMSG47YHLRl2QTrXrv/HvIXlvf+Yfh572wMeZqee/8eaMtlBy20FaPpftusMO2eGaWqNGnSujuXHKnyR75lkbJYbduFiFPN/UU+hrWzx9cN1ne+VMYJCUqltN9PqhJ9vmk4YHhnCr5HaOnwcDAbBraqGcXOSyHCDiNgJW5/tZbbwU1zuvI3qi/ZljTvf64wJYRgfARiNjGW/gsYE1EABFwEgFUcifRRdqIQBQggEoeRAjw+Zt+6ccLEWioCKCSN1TJId+IgE0EUMltAoXFEIGGigAqeUOVHPKNCNhEAJXcJlBYDBFoqAigkjdUySHfiIBNBFDJbQKFxRCBhooAKnlDlRzyjQjYRACV3CZQWAwRaKgIOKLkJJiieGlDKvJDMyqhF8ljzcXW1tZVivb0SkHkTNo0FqSSUsM9qvXEphWCDVWiyDcioEPACSX3+buSoE3EnVQYJCkNVbb88kw5DoTCht/7rFf6I929XfHHATezLM9E1SncN7eglKmTTzy/SQOZBflUzf3CMLHNCk/ZIHlwIH7j5b8XabKn1pg2SQgb5QKPM/fv8XQbKkmMIeCEkme7ZUXp0FVWaqrA2yd21cPnm1uY51HjwcmPQaczGXUDrRQ8JB6beH1ZXuoeRgeA7GHu0vIv4Ud6drZ49DQ9Oy+rzE+nd0KkhIkeoRLntgmNlLHjSoxJGrsTtwg4oeQqmKCNuuhqWqB9BYME3tTpW8uqm9+bX5jHzOoCjB3etTS2um+tV1J3mbDfVyjkUYX3+8vcXf3SCkC1ws3ahIrsuBK3bwR2POYQcFLJQZ0sp0aibryZlkypop6Si6r4Uo0RDWYBLATICvrZrhXyVC2tvvOFpZJlDiOMt0Cy1hWz3qxNOu2L1gFeiEBsIeCUkpP9rLXDLPy3QCcZDWVB1UypvgJYVeu8wIg6A21yLRXy5c09aUVP7ijTtrKsF8168zbBJEBTPbbebOyNioBF6JklS5aEF5iGbGBpQp/LZOh2Gt0gY6KbS7xID0j4NqUyjfKkvdwlKhGJkK4t+bmmHGHJbVj7y20CO8rP8LqMtRCBqEXAKsZbmErOaqmu31r9lB9qxgR+Ebptzg4QsmJDXRrssaRE2tAnw4eksGSIEMupv7htkjr8USlq5YaMIQK2EXDAXCdrYbpgDuvDc7C9OpjXsz3kO5lIHVb1xJhPF9ZmSO1Jd6CcunQncZw52+zKZp2/LKtrB7TvEIHYRAADOcamXLFXiICCgAMzOaKLCCAC0YQAKnk0SQN5QQQcQACV3AFQkSQiEE0IoJJHkzSQF0TAAQRQyR0AFUkiAtGEACp5NEkDeUEEHEDAGSVXnLSVA6aqrzjrKqJ3O7dViu92zqtKshprP9ZzSwGsCsOMl6r+Mz/jea5zOrf0Tuc7rLOdUNzmDVzQvMwaPtD93QEliHmSkT/WSo6XqYdXxV8VHo90zlU9fFbiEU+40jOuYrGSEqkUc2xNPstmPLXGHoPjNqCcfbNqgGlewYJhkj0/xz/6Kp69NZ6Y4xyjU2/xH8pgySf1VBjUX6rA8Jye7TNf8V3QgWOt7LvHOaTKeTUjWYrqrJwAnT0Er9NQhQ3eOVqGR7Yc9+grOfYOHvGGnOjKKVx26LA4LM/wIf+0RNL0/G98v9DYeyMCkTfXwY1bY/6IQR2UCx4bjpAaj7Ia/cQF1VFcocV1HZMb0DSUnp6p5UNt4MtyIU+Yqw1XxXNYV0/rssZ6CN7prHcdMFdaIB7ElY11wmKhj0a5kVziLXuA7u8xb2RHroPOmOvSvEYtWXaO49ncGktU8k7T14H+Gmxl7lSmcUphqiiTor4ByqLBo0Vxk+NY6ISCxB/PaJAXIPqpnW9cM2sb0Y+GXCp6vB6YNYBzGCLARyDyMzn4hSyV/UfyhTy3Mm+TPSQI6RBgPUUMbudSyLVha5kpTgz9pnEUF+c7XSQXXgOG0ZDTgBLYTQ4dxXdYl0llT/TQAFOheaebOKynQ1A50cYAKAg65ILeB4knie7vkZvmYp+SA0pO3b/EIWV7erlXjP8EGkFeYU34B3itSewHnntYtqfELUV4kmVAxg5BtGfJRXScjeRiaEBjoRsWCUoDUEwvZWIuy8HeiBLqGJGKk9CSssk9yCuA450aOXYtE9lGLA5aqQa74b1WZP0gR8KCYYT01LwHQanF/ouLPQwBgcib65rtX2WbnWdtGyxaeXNddQDnOoqz2+pSa7yoD8a9aWX3nvUw5xRTDXLGPV3uF2ejW2uKW26r6/BWlhes3a7cNNldx211NMxDQcCB3XU16oui2PoIL0S7pcWxPB7R0A9qIBhmG1oZsdgxQfee8xoAGJQ22D0CkR476Ci1eSFpjFWDfC3j7BUYbqmd1666pb6qN/U9ILLFffVQ3nAsG0B/8hCsHiyKCDREBBxZkzdEIJBnRCBWEUAlj1XJYr8QAQkBVHJ8FRCBGEcAlTzGBYzdQwRQyfEdQARiHAFU8hgXMHYPEXBEyc3yk8twq/7XjADUBOSWecr5NMz9wU0OiHJct4GybR5IQW3ude6rBMUcyXdux/3dwJBRKkF6wRGjRjQAgC1RoZbVNwIOnHjjOIorrdDDHSRhEcd/g+OEYnbwQ+vDrRwMY/zAjZ7pvJN42t5T5owuKeEfPgm/poVYjCfuTA7G6TpndN+3PieiHDZkvIqsOuRIZ/EoSwQQcGIm5+Unl8cy6h/iGaYf2nQJyJXHujzlyjSuyWpODqaLB8PV5OTZ2VKGUiWDuUKT5iHXpkmlz0LkoZ5GZw73zLF36dQ7jzcrqXD7wkv5btFpE1HVE0zYLIOAE0qukreR80hUL10CckWZublG9T7cRk9spoNGz3SeA3moPCh2OJi0BT7ZruUb8F/KEZzkx6oZLNvyqtUrlTHcUHpk5J7rdk75MnnTFakwqwkmzJRXX5XjyW+kjH5x0TuuOKnkwfKTS6hwEpCLT7R5yhXFN2Y1h+RoeYUkBAOb5lhSJfBz07q50XgNhV1p5CmSU43qQog8aOTpHSTmUQa/uWe9spOcUqK04FnRgVRpC3K5yV41mQVzSetkEpTiXhFeJYc6WgjysGuUlct9SK8XTyqQIFrmYKlQ6JXpGVK+kwey551ms4MvqpD4wsKOIeCUkgfNT67qrDEBuaTjBodx+v4bs5rzPbF5juNyo7JTp2Te85Kgm/Ogl4W7RBxFjAsDcjdLXhkwTqvytAkeqsQxXSCBaAapO3Qw0yqaJBdhG9Vxz303oPccF14TqRBbgPWtlSnyUr6rexaM2zCGqXFMQSNB2BElt3AU1/EMMwB1xSZXhuifrcRL1TmMk5pcH26OJzbTisEz3eBAXj43JB5qizpoOAxrdJqWvd+oMpGgGEqkDHZbUuODz3F/t3acV9k1l0qQVZXOk98IgN63v7YQYf3IIuCAkpMNLGlyC8qrEl5C9aCUJiCyEDSkE1YMXdGNFFQBNIDMg7KdDLVKSZQKn09ekJJhxM1GlyAzrlweBg0hb6JHCnFhj4egfdIWkOK20cUHZQQ0SgqWQ5hVCxMoxEgZbIcMrem5hw1Hzi0SZ0a7JreSCkOAskkb9fuUAB0UJrqzyb24ogoRJizuIAIOKDkvP7mvINTvxfrZxZwCSUOeKUVFlBORd/A/K4VmVFOTKxSUJbyc3dwMX5v7hpbiycosJzM0GCpSjnSyAS5ym1+eKcZ0U3biILc6jHFshxIM3/k53IO1IgGgJmfXM2WZNV4lACGo8siHRPhSwUv5DveVlYTCWSRgcvAVR9JOBI0wftmr8LjlGOthfvaLBgphsh691cxCYfLjy0dvP5AzawQcmMm5azaBRnoL+yIWYX1TCJv5aK3I/TQWxDSP1r4gX1YIWIwBS5YswTEyNhHQBaZmo2dxM0jEJgrx0isM/4RzACIQ4wjUibke4xhi9xCBqEYAlTyqxYPMIQK1RwCVvPYYIgVEIKoRcEbJjfnJZRAsfZQts5lLFIwZxvkpuy192g3+2CalDfnNFVka/dEZNkzTlxtRUJKP83vBTWNuoKIee9GxFcTdu5694kk/2NACwcIQqIpkdPHhKBlfeFqE9A7/8hkivjSkRlSe9cXEE4ss6kYXJCbHpZZpyzZrN4hEfnedyQVicH3muJpzM4ube4NzUpgzXVDzGpp7T2tyIop+7TzXaTbJih4kjgO7qTe11vXdCLdlvhWLXClGHjgdY5oL3907/JrBtq812FiFIdCKmPH5V98eXVtcH3vD+6jvGg9vbh4PzjcIpRxDlE2QE8rpg8jmyHHgMAzLoPn7wXsSSn4hNQ+5Kl1bhzs0hQwtqk8tcNZKURQe3AslfbnMdJB0K7zsT2JVIw/WHavFa+OYkpukdrdKEWOXF95LGARrgqoRJeMwwE1Hz9Zkq8i/7fKtl22wYdLW88ib60Hyk8t2B+csJCd1OSdPuWKsQoZAzZl0Tp5TUlbfkOZvOCZO/cDkSz0fAsy4u/p7KuY0ay/xHNhDS1/OtKdLzarpBSeNuVzTyINlx/ip3OXoVHXuFS9a6oMEOcWj1hpVemI8gS+lbtdbr3r7netjzw8kYG0I6/zrzHgm9+36axjWnXrP/4j79EVeyYn7ppwHVOuCwcDJcWoGl+4C9YU38waXlnGgewZHceKVrdV68U0qk70orcRpcJ0mSlsgeYvByfB8jac4x4GddRLPkBbJQUXPYVlzS/HfIc7oupU+14nepIs23L3r1CteUnG+WliJzOyYvMFFn7dG5wUSCLLW1QrITJ7mcmbPD+oc8VnZauIQcN/jWq3JI6/kpvnJlSm4gGoo60FpzCxu4Q1u8sg4V9n2aQfOeK7Tio+13lOc78Au9c9G+nLVGDEMQEHTmDMo2k5nbmdqqFOveNPU7jqRGbzi9ZaXaoJJ4Xd4/veMgthxxWfnIiYykQXPxnlEyWktlCjvubIml+9IExlxsaYZ6sXLgRA7Dig5Nz85827qc5LzUpfLxTl5yk0e6VN2m3pPa94T/cyguk5DMbPR09qBXZaVefpyRpx6B07bicc5PJh2zAl371p5xZukdrcRhkBdpLDCMTLD87HnuOKDP0Qmq2A6ibPSMEtHz48YqCg0J3KHpMsFCRD+hC6pNfl9bb8Bocztkd9dVynyNjMNu1OcvSVuGnGRrNkj4xao6Rls4yY0Nwm6+V418/mAswVvDKbK2c7hb/KYFBS32bTxbXk8mHBsY/OTRY+796TsZ8ttqL1kOZFkRD39jfe5rxq7J815NwxRfemGvFqwxA2/eczwdtc59zRcEm1jeDDdq1Qf2Nrq1e2TyntrclOaVmuxP2quyQ7srnPyk8MtOrZpxiwx+jEVGmtQwSct5h6Tp5z+5D3S7jUbB0cpzLI6mihEZOoMX7ok6JQztZixgnSH4csqfTkzotnY62Xw0uOgmQCMeeDZzzXm743CQlAlz3K7JTHJlFUM4ZFOuDICDKym34+UpjnvhtmgZxCXkRkWH0YgSkGtLsvvn4ZL88FR5ln/7gIZQpdXUVNUCxcboDykTXhbO+ukkBNKbmw8GrzBkQfbLwUWjC0EHFmT65cL0eANjjyEsojDsrGEALqaxpI0sS+IAAeBOpnJEXlEABGoPwRQyesPe2wZEagTBFDJ6wRmbAQRqD8ErJS8adOmVVVV9ccbtowIIAIRQMBq4w3Iw9mTpKSkxo0bR6ApJEERADwvXryIYCACdYZAECWvMz6wIUQAEXAIAVyTOwQskkUEogUBVPJokQTygQg4hAAquUPAIllEIFoQQCWPFkkgH4iAQwigkjsELJJFBKIFAVTyaJEE8oEIOIQAKrlDwCJZRCBaEPh/trB4sLzw77UAAAAASUVORK5CYII=)













± **public Int32 countRelativelyPrimes()**

Euler&#39;s Totient noted with the greek letter phi (φ) is the value representing the number of integers less than n that are coprime with n. φ(n)= n ∏

# i=1
(1−1/p
# i
) where p is a distinct prime factor of n. Casting to double is required for precision, therefore some precision may be lost if this.value is strictly within the domain of BigIntegers.

        {

            Double n = (Double)this.value;

            Double p = 1;

            var distinct\_factors = this.DistinctPrimeFactors();

            foreach(var element in distinct\_factors)

            {

                p \*= 1-(1/(Double)element.value);

            }

            n \*= p;

            return (Int32)n;

        }

± **public List\&lt;Natural\&gt; PrimeFactorize()**

The prime factorization method used is called the direct search method. It consists of searching for factors of a number by systematically performing trial divisions. In this case, we first check the divisibility by 2, and decompose these to their lowest forms. Whether or not they were initially divisible by 3 or odd numbers, they are divisible after the first loop. The same is performed with increasing prime divisibility checks; we then add these to a list.

        {

            var factors = new List\&lt;Natural\&gt;();

            BigInteger value = this.value;

            Double squared = Math.Sqrt((double)value);

            while (value % 2 == 0)

            {

                factors.Add(new Natural(2));

                value = value / 2;

            }

            for (int i = 3; i \&lt;= squared; i = i + 2)

            {

                while (value % i == 0)

                {

                    factors.Add(new Natural(i));

                    value = value / i;

                }

            }

            if (value \&gt; 2)

                factors.Add(new Natural(value));

            return factors;

        }



± **public List\&lt;Natural\&gt; DistinctPrimeFactors()**

In this block we make use of a C# linq iteration; this allows us to perform query capable instructions, in this case, we&#39;ve grouped each element such that it corresponds to a value and select the first ocurrence of these, creating a unique list.

        {

            var list = this.PrimeFactorize();

            List\&lt;Natural\&gt; unique = new List\&lt;Natural\&gt;();

            unique = list.GroupBy(elem =\&gt; elem.value).Select(group =\&gt; group.First()).ToList();

            return unique;

        }

[TestMethod, Description(&quot;Tests various cases of primality&quot;)]

φ **public void Primality\_Test()**

{

            var natural1 = new Natural(Int32.MaxValue - 1);

            var natural2 = new Natural(678);

            var hardphi = new Natural(667);

            var actual = natural1.PrimeFactorize();

            Console.WriteLine(&quot;\nFactors of {0} are: &quot;, natural1);

            foreach (var element in actual)

            {

                Console.Write(element + &quot; &quot;);

            }

            var actual2 = natural2.PrimeFactorize();

            Console.WriteLine(&quot;\nFactors of {0} are: &quot;, natural2);

            foreach (var element in actual2)

            {

                Console.Write(element + &quot; &quot;);

            }

            var distinctlist = natural1.DistinctPrimeFactors();

            Console.WriteLine(&quot;\nDistinct Factors of {0} are: &quot;, natural1);

            foreach (var element in distinctlist)

            {

                Console.Write(element + &quot; &quot;);

            }

            var distinctlist2 = hardphi.DistinctPrimeFactors();

            Console.WriteLine(&quot;\nDistinct Factors of {0} are: &quot;, hardphi);

            foreach (var element in distinctlist2)

            {

                Console.Write(element + &quot; &quot;);

            }

            int expected = 616;

            var phi = hardphi.countRelativelyPrimes();

            Console.Write(&quot;\nφPhi of {0} is: &quot; + phi, hardphi);

            Assert.AreEqual(expected, phi);

}



 ![](data:image/*;base64,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)

± **public Natural NextProbablePrime()**

        {

            Natural n = new Natural(++this.value);

            if (n.value \&lt; 0)

                throw new ArgumentException(&quot;Number should be within the domain of natural numbers.&quot;);

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







[TestMethod, Description(&quot;Basic primality&quot;)]

φ **public void NumberTheory2\_Basic\_Test()**

For this unit test, we increment the value of n by 12 every iteration, then we select the next prime number strictly _after_ the number given, we then perform an assertion check to see if this passes the test of primality.

        {

            int n = 19;

            var natural = new Natural(n);

            bool expected = true;

            var actual = natural.NextProbablePrime();

            for (int i = 1; i \&lt; 50; i+=6)

            {

                Console.WriteLine(n + i);

                natural = new Natural(n + i);

                actual = natural.NextProbablePrime();

                Assert.AreEqual(expected, actual.IsPrime());

                Console.WriteLine(&quot;The next probable prime after {0} is: &quot; + actual.GetIntValue(), n + i);

                n += 6;

            }

        }

 ![](data:image/*;base64,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)





± **public String DivisionAlgorithm(Natural value)**

Due to the nature of division, some precision may be lost in calculating BigInteger values. A BigDecimal type may have been more optimal. As I coded this solution the nature of method chaining seems to lose its value when I have to implicitly create new instances this way to avoid overriding values, something notable.

        {

            Natural X = new Natural(this.value); Natural X2 = new Natural(this.value);

            Natural Y = new Natural(value.value);

            if(X.value \&lt;= 0 || Y.value \&lt;=0)

                throw new ArgumentException(&quot;Invalid arguments detected!&quot;);

            BigInteger q = X.Divide(value).value, r = X2.Modulo(Y).value;

            return string.Format(&quot;{0} = {1} \* {2} + {3}&quot;, X.value, Y.value, q, r);             }

[TestMethod, Description(&quot;Division Algorithm&quot;)]

φ **public void Division\_Algorithm\_Test()**

        {

            var natural = new Natural(158);

            var natural2 = new Natural(17);

            var actual = natural.DivisionAlgorithm(natural2);

            Console.WriteLine(&quot;The Division Algorithm of {0} / {1} is: &quot; + actual, natural, natural2);

            natural = new Natural(int.MaxValue);

            natural2 = new Natural(86340);

            actual = natural.DivisionAlgorithm(natural2);

            Console.WriteLine(&quot;The Division Algorithm of {0} / {1} is: &quot; + actual, natural, natural2);

        }

 ![](data:image/*;base64,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)

# Source Code





# Conclusion

\&lt;Simply state whatever you have learned from doing the project. DELETE THIS PART AFTER EDIT.\&gt;
