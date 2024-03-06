static class Util
{
    public static string GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        // Gör om eventuell null till tom string. Inte så troligt scenario vid keyboard input men skönt att slippa varningar :) 
        return Console.ReadLine() ?? string.Empty;
    }
    // Testar method overloading, hade kanske egentligen döpt metoden till något annat.
    public static string GetInput(string prompt, int minWords)
    {
        string input;
        do
        {
            Console.WriteLine(prompt);
            input = Console.ReadLine() ?? string.Empty;

            // StringSplitOptions hanterar fallet med flera mellanslag irad i input.
        } while (input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length < minWords);
        return input;
    }
    public static uint GetInputToInt(string prompt)
    {
        uint number;
        do
        {
            Console.WriteLine(prompt);
        } while (!uint.TryParse(Console.ReadLine(), out number));

        return number;
    }
    // Testar default values, hade väl lika egentligen skickat med 10 från Program.cs
    public static string Repeater(string phrase, int count = 10)
    {
        string response = string.Empty;
        for (int i = 1; i < count + 1; i++)
        {
            response += $"{i}: {phrase} ";
        }
        return response;
    }
    public static string ThirdWord(string userString)
    {
        var stringSplit = userString.Split(' ');
        return stringSplit[2];
    }
}
