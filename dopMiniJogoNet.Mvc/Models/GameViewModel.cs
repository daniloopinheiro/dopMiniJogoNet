using dopMiniJogoNet.Mvc.Models;

namespace dopMiniJogoNet.Mvc.Models
{
    public class GameViewModel
    {
        public GameOption? PlayerChoice { get; set; }
        public GameOption? ComputerChoice { get; set; }
        public GameResult? Result { get; set; }
        public int PlayerScore { get; set; }
        public int ComputerScore { get; set; }
    }
}
