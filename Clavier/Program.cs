using System;

namespace Clavier
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            var track = new Ludwig.Track();
            do
            {
                cki = Console.ReadKey(true);
                if (!Ludwig.Keys.Mappings.ContainsKey(cki.Key)) continue;
                var key = Ludwig.Keys.Mappings[cki.Key];
                Console.ForegroundColor = key.Color;
                Console.Write(cki.KeyChar);
                track.Play(key.Hz);
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}