using System;
using System.Collections.Generic;
using System.Linq;

namespace Company.Logic.Services
{
    public class LotteryService : ILotteryService
    {
        private Random random = new Random();

        public List<int> GenerateNumbers(int from, int to, int total)
        {
            var randomNumbers = new List<int>();
            var availableNumbers = CreateSequentialList(from, to);

            for (var i = 1; i <= total; i++)
            {
                var randomNumber = GenerateRandomNumber(availableNumbers);
                randomNumbers.Add(randomNumber);

                availableNumbers.Remove(randomNumber);
            }

            randomNumbers.Sort();

            return randomNumbers;
        }

        private int GenerateRandomNumber(List<int> items)
        {
            var index = random.Next(0, items.Count);
            var result = items.ElementAt(index);
            return result;
        }

        private List<int> CreateSequentialList(int from, int to)
        {
            var result = new List<int>();

            for (var i = from; i <= to; i++)
            {
                result.Add(i);
            }

            return result;
        }
    }
}
