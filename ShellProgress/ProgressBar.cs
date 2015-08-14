using System;

namespace ShellProgress
{
    public class ProgressBar : IProgressing
    {
        private readonly Int32 maxValue;

        public ProgressBar(Int32 maxValue)
        {
            if (maxValue <= 0)
                throw new ArgumentException("Max value should be greater than zero.", "maxValue");

            this.maxValue = maxValue;
            BarSize = 10;
            ProgressCharacter = '.';
        }

        public Int32 BarSize { get; set; }

        public Char ProgressCharacter { get; set; }

        public void Update(int completed)
        {
            Console.CursorVisible = false;
            int left = Console.CursorLeft;
            decimal perc = (decimal)completed / (decimal)maxValue;
            int chars = (int)Math.Floor(perc / ((decimal)1 / (decimal)BarSize));
            string p1 = String.Empty, p2 = String.Empty;

            Console.Write('[');

            for (int i = 0; i < chars; i++)
                p1 += ProgressCharacter;
            for (int i = 0; i < BarSize - chars; i++)
                p2 += ProgressCharacter;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(p1);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(p2);

            Console.ResetColor();
            Console.Write(']');
            Console.Write(" {0}%", (perc * 100).ToString("N2"));
            Console.CursorLeft = left;
        }

        public void Complete()
        {
            Update(maxValue);
            Console.Write(Environment.NewLine);
        }
    }
}