using System.Collections.Generic;

namespace Company.Logic.Services
{
    public interface ILotteryService
    {
        List<int> GenerateNumbers(int from, int to, int total);
    }
}
