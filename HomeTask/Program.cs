namespace HomeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///01 Convert decimal to binary

            //Console.Write("Enter a decimal number: ");
            //int decimalNumber = int.Parse(Console.ReadLine());
            //string binaryNumber =Convert.ToString(decimalNumber, 2);
            //Console.WriteLine($"Binary representation: {binaryNumber}");

            ///02 Factorial

            //int number, fact = 1;
            //Console.Write("Enter the your number: ");
            //if (int.TryParse(Console.ReadLine(), out number))
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        fact *= i;
            //    }
            //    Console.WriteLine($"Number is factorial: {fact}");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter the number!");
            //}
            //Console.WriteLine();
            //Main(args);

            ///03 Difference between Max and Min

            //int number1, number2, number3, number4,max,min,difference;
            //Console.Write("Enter the first number: ");
            //int.TryParse(Console.ReadLine(), out number1);
            //Console.Write("Enter the second number: ");
            //int.TryParse(Console.ReadLine(), out number2);
            //Console.Write("Enter the three number: ");
            //int.TryParse(Console.ReadLine(), out number3);
            //Console.Write("Enter the four  number: ");
            //int.TryParse(Console.ReadLine(), out number4);
            //max=Math.Max(number1, Math.Max(number2, Math.Max(number3, number4)));
            //min=Math.Min(number1, Math.Min(number2, Math.Min(number3, number4)));
            //difference=max-min;
            //Console.WriteLine($"Diffirence Max and Min: {max-min}");
            //Console.WriteLine();
            //Main(args);

            ///04 [1;100] divisible 

            //int number;
            //Console.Write("Enter the your number: ");
            //if (int.TryParse(Console.ReadLine(), out number)) 
            //{
            //    if (number >= 1 && number <= 100)
            //    {
            //        for (int i = 1; i <= 100; i++)
            //        {
            //            if (number % i == 0)
            //            {
            //                Console.Write($"{i};");
            //            }

            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a number in the range!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please emter the number!");
            //}
            //Console.WriteLine();
            //Main(args);

            ///05 Multiplication table 

            //Console.WriteLine("Welcome the Multiplication table !");
            //for (int i = 1; i <=10; i++)
            //{
            //    for (int j = 1; j <=10; j++)
            //    {
            //        Console.Write($"{i*j} ");
            //    }
            //    Console.WriteLine();
            //}

            /// 06 Factorial

            //int number, fact = 1;
            //Console.Write("Enter the your number: ");
            //if (int.TryParse(Console.ReadLine(), out number))
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        fact *= i;
            //    }
            //    Console.WriteLine($"{number} is factorial: {fact}");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter the number!");
            //}
            //Console.WriteLine();
            //Main(args);

            ///07 Perfect Numbers

            //int startNumber, endNumber, sum = 0;
            //Console.Write("Enter starting range: ");
            //int.TryParse(Console.ReadLine(), out startNumber);
            //Console.Write("Enter ending range: ");
            //int.TryParse(Console.ReadLine(), out endNumber);
            //for (int i = startNumber; i < endNumber; i++)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            sum += j;
            //        }

            //    }

            //    if (sum == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    sum = 0;

            //} 

            ///08 Prime number

            //int number, countt = 0, primeCount = 0;
            //Console.Write("Enter the number:");
            //int.TryParse(Console.ReadLine(), out number);
            //for (int i = 1; i < number; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            countt++;
            //        }
            //    }

            //    if (countt == 2)
            //    {
            //        primeCount++;
            //    }

            //    countt = 0;
            //}
            //Console.WriteLine($"The number of prime numbers up to: {primeCount}");
              
            ///09 Fibonacci
              
            //Console.Write("Enter the number of terms in the Fibonacci series: ");
            //int limit = int.Parse(Console.ReadLine());

            //int firstTerm = 0, secondTerm = 1;
            //Console.Write("{0} {1}", firstTerm, secondTerm);

            //for (int i = 2; i < limit; i++)
            //{
            //    int nextTerm = firstTerm + secondTerm;
            //    Console.Write(" {0}", nextTerm);
            //    firstTerm = secondTerm;
            //    secondTerm = nextTerm;
            //}

            //Console.WriteLine();

        }
    }
}