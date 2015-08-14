using System;

namespace ShellProgress
{
    public interface IProgressing
    {
        void Update(Int32 completed);

        void Complete();
    }
}