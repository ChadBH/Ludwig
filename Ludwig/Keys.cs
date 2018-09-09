using System;
using System.Collections.Generic;

namespace Ludwig
{
    public static class Keys
    {
        public static Dictionary<ConsoleKey, Key> Mappings = new Dictionary<ConsoleKey, Key>
        {
            {ConsoleKey.Spacebar, new Key(20, ConsoleColor.Black)},
            {ConsoleKey.A, new Key(220, ConsoleColor.Red)},
            {ConsoleKey.B, new Key(246.94M, ConsoleColor.Yellow)},
            {ConsoleKey.C, new Key(261.63M, ConsoleColor.Magenta)},
            {ConsoleKey.D, new Key(293.66M, ConsoleColor.Blue)},
            {ConsoleKey.E, new Key(329.63M, ConsoleColor.White)},
            {ConsoleKey.F, new Key(349.23M, ConsoleColor.Cyan)},
            {ConsoleKey.G, new Key(392, ConsoleColor.Green)},
            {ConsoleKey.H, new Key(440, ConsoleColor.Red)}, //A
            {ConsoleKey.I, new Key(493.88M, ConsoleColor.Yellow)},//B
            {ConsoleKey.J, new Key(523.25M, ConsoleColor.Magenta)},//C
            {ConsoleKey.K, new Key(587.33M, ConsoleColor.Blue)},//D
            {ConsoleKey.L, new Key(659.26M, ConsoleColor.White)},//E
            {ConsoleKey.M, new Key(698.46M, ConsoleColor.Cyan)},//F
            {ConsoleKey.N, new Key(783.99M, ConsoleColor.Green)},//G
            {ConsoleKey.O, new Key(880, ConsoleColor.Red)},//A
            {ConsoleKey.P, new Key(987.77M, ConsoleColor.Yellow)},//B
            {ConsoleKey.Q, new Key(1046.5M, ConsoleColor.Magenta)},//C
            {ConsoleKey.R, new Key(1174.66M, ConsoleColor.Blue)},//D
            {ConsoleKey.S, new Key(1318.51M, ConsoleColor.White)},//E
            {ConsoleKey.T, new Key(1396.91M, ConsoleColor.Cyan)},//F
            {ConsoleKey.U, new Key(1567.98M, ConsoleColor.Green)},//G
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
