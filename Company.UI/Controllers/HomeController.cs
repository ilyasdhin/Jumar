using Company.Logic.Services;
using Company.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Company.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly ILotteryService lotteryService;

        public HomeController(ILogger<HomeController> logger, ILotteryService lotteryService)
        {
            this.logger = logger;
            this.lotteryService = lotteryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Generate()
        {
            logger.LogDebug($"{nameof(Generate)} started");

            var viewModel = new RandomNumberGeneratorResponseViewModel();
            viewModel.LotteryNumbers = lotteryService.GenerateNumbers(1, 49, 6);

            logger.LogDebug($"{nameof(Generate)} completed");
            return View(viewModel);
        }
    }
}
