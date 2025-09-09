using Microsoft.AspNetCore.Mvc;
using dopMiniJogoNet.Mvc.Models;
using dopMiniJogoNet.Mvc.Services;

namespace dopMiniJogoNet.Mvc.Controllers
{
    public class GameController : Controller
    {
        private static int _playerScore = 0;
        private static int _computerScore = 0;
        private readonly GameEngine _engine = new();

        public IActionResult Index()
        {
            var model = new GameViewModel
            {
                PlayerScore = _playerScore,
                ComputerScore = _computerScore
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Play(int playerChoice)
        {
            var player = (GameOption)playerChoice;
            var computer = _engine.GetComputerChoice();
            var result = _engine.GetResult(player, computer);
            if (result == GameResult.Vitoria) _playerScore++;
            else if (result == GameResult.Derrota) _computerScore++;
            var model = new GameViewModel
            {
                PlayerChoice = player,
                ComputerChoice = computer,
                Result = result,
                PlayerScore = _playerScore,
                ComputerScore = _computerScore
            };
            return View("Index", model);
        }
    }
}
