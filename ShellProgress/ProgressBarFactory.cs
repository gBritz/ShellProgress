using System;

namespace ShellProgress
{
    public class ProgressBarFactory : IProgressFactory
    {
        public IProgressing CreateInstance(Int32 maxValue)
        {
            return new ProgressBar(maxValue)
            {
                BarSize = 50,
                ProgressCharacter = '='
            };
        }
    }
}