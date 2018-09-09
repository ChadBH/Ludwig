using System;
using System.Collections.Generic;

namespace Ludwig
{
    public static class Keys
    {
        public static Dictionary<ConsoleKey, Key> Mappings = new Dictionary<ConsoleKey, Key>
        {
            {ConsoleKey.A, new Key(440, ConsoleColor.Red)},
            {ConsoleKey.B, new Key(987.7666M, ConsoleColor.DarkYellow)},
            {ConsoleKey.C, new Key(523.2511M, ConsoleColor.Gray)},
            {ConsoleKey.D, new Key(587.3295M, ConsoleColor.Blue)},
            {ConsoleKey.E, new Key(659.2551M, ConsoleColor.White)},
            {ConsoleKey.F, new Key(698.4565M, ConsoleColor.Magenta)},
            {ConsoleKey.G, new Key(698.9909M, ConsoleColor.Green)},
            {ConsoleKey.H, new Key(440, ConsoleColor.Red)},
            {ConsoleKey.I, new Key(493.883M, ConsoleColor.DarkYellow)},
            {ConsoleKey.J, new Key(277.1826M, ConsoleColor.Gray)},
            {ConsoleKey.K, new Key(293.6648M, ConsoleColor.Blue)},
            {ConsoleKey.L, new Key(329.6276M, ConsoleColor.White)},
            {ConsoleKey.M, new Key(349.2282M, ConsoleColor.Magenta)},
            {ConsoleKey.N, new Key(391.9954M, ConsoleColor.Green)},
    };
    }

    public class Key
    {
        public decimal Hz;
        public ConsoleColor Color;

        public Key(decimal hz, ConsoleColor color)
        {
            Hz = hz;
            Color = color;
        }
    }
}
