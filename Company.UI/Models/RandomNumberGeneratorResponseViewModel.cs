using System.Collections.Generic;

namespace Company.UI.Models
{
    public class RandomNumberGeneratorResponseViewModel
    {
        public List<int> LotteryNumbers { get; set; }

        public RandomNumberGeneratorResponseViewModel()
        {
            LotteryNumbers = new List<int>();
        }
    }
}
