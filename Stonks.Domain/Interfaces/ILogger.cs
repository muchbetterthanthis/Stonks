using System;
using System.Collections.Generic;
using System.Text;

namespace Stonks.Domain.Interfaces
{
    public enum LogSeverity { Debug, Info, Warning, Error, Fatal }

    public interface ILogger
    {
        void Log(string message, LogSeverity severity);
    }
}
