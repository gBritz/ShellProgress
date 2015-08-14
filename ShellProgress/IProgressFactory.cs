using System;

namespace ShellProgress
{
    public interface IProgressFactory
    {
        IProgressing CreateInstance(Int32 maxValue);
    }
}