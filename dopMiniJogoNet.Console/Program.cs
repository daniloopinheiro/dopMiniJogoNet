using dopMiniJogoNet.Console.Models;
using dopMiniJogoNet.Console.Services;

var engine = new GameEngine();
var display = new DisplayService();
int playerScore = 0, computerScore = 0;

display.ShowWelcome();

bool jogarNovamente = true;
while (jogarNovamente)
{
	display.ShowOptions();
	Console.Write("Digite sua escolha (1-3): ");
	if (!int.TryParse(Console.ReadLine(), out int escolha) || escolha < 1 || escolha > 3)
	{
		Console.WriteLine("Escolha inválida. Tente novamente.\n");
		continue;
	}
	var player = (GameOption)escolha;
	var computer = engine.GetComputerChoice();
	var result = engine.GetResult(player, computer);
	display.ShowRound(player, computer, result);
	if (result == GameResult.Vitoria) playerScore++;
	else if (result == GameResult.Derrota) computerScore++;
	display.ShowScore(playerScore, computerScore);
	Console.Write("Deseja jogar novamente? (S/N): ");
	var resp = Console.ReadLine();
	jogarNovamente = resp != null && resp.Trim().ToUpper() == "S";
}
