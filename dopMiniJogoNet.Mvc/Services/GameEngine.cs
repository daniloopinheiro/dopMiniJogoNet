using dopMiniJogoNet.Mvc.Models;

namespace dopMiniJogoNet.Mvc.Services
{
    public class GameEngine
    {
        private readonly Random _random = new();

        public GameOption GetComputerChoice()
        {
            return (GameOption)_random.Next(1, 4);
        }

        public GameResult GetResult(GameOption player, GameOption computer)
        {
            if (player == computer)
                return GameResult.Empate;
            if ((player == GameOption.Pedra && computer == GameOption.Tesoura) ||
                (player == GameOption.Papel && computer == GameOption.Pedra) ||
                (player == GameOption.Tesoura && computer == GameOption.Papel))
                return GameResult.Vitoria;
            return GameResult.Derrota;
        }
    }
}
