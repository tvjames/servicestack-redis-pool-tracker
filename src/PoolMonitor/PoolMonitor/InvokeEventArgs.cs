using System;
using System.Reflection;

namespace PoolMonitor
{
    public class InvokeEventArgs : EventArgs
    {
        public MethodInfo MethodInfo { get; private set; }

        public InvokeEventArgs(MethodInfo methodInfo)
        {
            MethodInfo = methodInfo;
        }
    }
}