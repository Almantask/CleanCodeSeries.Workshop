using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeSeries.Workshop.Lesson2.Functions
{
    class BigFunctionV1
    {
        public void Main(string[] args)
        {
            var sum = 0;
            foreach (var arg in args)
            {
                if (int.TryParse(arg, out var number))
                {
                    sum += number * number * number * number;
                }
            }

            const int max = 500;
            if (sum > max)
            {
                throw new Exception($"Exceeded max {max} sum: {sum}.");
            }
            else
            {
                var bankAccount = new BankAccount();
                bankAccount.AddFunds(sum);
            }
        }
    }

    class BigFunctionV2
    {
        public void Main(string[] args)
        {
            var sum = CountSumOfSquaredSquareNumbers(args);
            AddFunds(sum);
        }

        private static int CountSumOfSquaredSquareNumbers(string[] args)
        {
            var sum = 0;
            foreach (var arg in args)
            {
                if (int.TryParse(arg, out var number))
                {
                    sum += number;
                }
            }

            return sum;
        }

        private static void AddFunds(int sum)
        {
            const int max = 500;
            if (sum > max)
            {
                throw new Exception($"Exceeded max {max} sum: {sum}.");
            }
            else
            {
                var bankAccount = new BankAccount();
                bankAccount.AddFunds(sum);
            }
        }

    }

    class BigFunctionV3
    {
        public void Main(string[] args)
        {
            var numbers = GetNumbers(args);
            var sum = Sum(numbers);
            AddFunds(sum);
        }

        private static List<int> GetNumbers(string[] args)
        {
            var numbers = new List<int>();
            foreach (var arg in args)
            {
                if (int.TryParse(arg, out var number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }

        private static int Sum(List<int> numbers)
        {
            var sum = 0;
            numbers.ForEach(n => sum += n);
            return sum;
        }

        private static void AddFunds(int sum)
        {
            const int max = 500;
            if (sum > max)
            {
                throw new Exception($"Exceeded max {max} sum: {sum}.");
            }
            else
            {
                var bankAccount = new BankAccount();
                bankAccount.AddFunds(sum);
            }
        }
    }
}
       
