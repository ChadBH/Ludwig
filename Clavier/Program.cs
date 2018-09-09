using System;
using Ludwig;

namespace Clavier
{
    class Program
    {
        static void Main(string[] args)
        {
            var song = Songs.Choices[0];
            Console.WriteLine(song.Item1);
            PrettyPrint(song.Item2);

            ConsoleKeyInfo cki;
            var track = new Track();
            do
            {
                cki = Console.ReadKey(true);

                if (Keys.Mappings.ContainsKey(cki.Key))
                {
                    var key = Keys.Mappings[cki.Key];
                    Console.ForegroundColor = key.Color;
                    track.Play(key.Hz);
                }
                Console.Write(cki.KeyChar.ToString().ToUpper());

            } while (cki.Key != ConsoleKey.Escape);
        }

        private static void PrettyPrint(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return;

            foreach (var c in input)
            {
                var asString = c.ToString();

                if (Enum.TryParse(asString, out ConsoleKey consoleKey))
                {
                    if (Keys.Mappings.ContainsKey(consoleKey))
                    {
                        var key = Keys.Mappings[consoleKey];
                        Console.ForegroundColor = key.Color;
                    }
                }
                Console.Write(asString);
            }
            Console.Write("\r\n");
        }
    }

}