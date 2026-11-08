using System;
using System.Collections.Generic;
using System.Text;

namespace Extensibility
{
    public interface Ilogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}
