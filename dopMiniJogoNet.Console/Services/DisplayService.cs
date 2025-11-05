using dopMiniJogoNet.Console.Models;
using dopMiniJogoNet.Console.Utils;

namespace dopMiniJogoNet.Console.Services
{
    public class DisplayService
    {
        public void ShowWelcome()
        {
            ConsoleHelper.WriteColor("=========================================", ConsoleColor.Cyan);
            ConsoleHelper.WriteColor("    🎮 PEDRA, PAPEL E TESOURA 🎮", ConsoleColor.Yellow);
            ConsoleHelper.WriteColor("=========================================", ConsoleColor.Cyan);
            Console.WriteLine();
            Console.WriteLine("Bem-vindo ao jogo Pedra, Papel e Tesoura!");
            Console.WriteLine("Você jogará contra o computador.\n");
            Console.WriteLine("Regras:");
            Console.WriteLine("🪨 Pedra vence Tesoura");
            Console.WriteLine("✂️  Tesoura vence Papel");
            Console.WriteLine("📄 Papel vence Pedra\n");
        }

        public void ShowOptions()
        {
            Console.WriteLine("Escolha sua jogada:");
            Console.WriteLine("1 - Pedra 🪨");
            Console.WriteLine("2 - Papel 📄");
            Console.WriteLine("3 - Tesoura ✂️\n");
        }

        public void ShowRound(GameOption player, GameOption computer, GameResult result)
        {
            Console.WriteLine($"Você escolheu: {player}");
            Console.WriteLine($"Computador escolheu: {computer}");
            switch (result)
            {
                case GameResult.Vitoria:
                    ConsoleHelper.WriteColor("🎉 Você venceu esta rodada!", ConsoleColor.Green);
                    break;
                case GameResult.Derrota:
                    ConsoleHelper.WriteColor("😢 Você perdeu esta rodada!", ConsoleColor.Red);
                    break;
                default:
                    ConsoleHelper.WriteColor("🤝 Empate!", ConsoleColor.Gray);
                    break;
            }
        }

        public void ShowScore(int playerScore, int computerScore)
        {
            Console.WriteLine($"\nPlacar: Você {playerScore} x {computerScore} Computador\n");
        }
    }
}
