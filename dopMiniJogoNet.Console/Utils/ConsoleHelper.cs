namespace dopMiniJogoNet.Console.Utils
{
    public static class ConsoleHelper
    {
        public static void WriteColor(string text, ConsoleColor color)
        {
            var previous = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = previous;
        }
    }
}
