using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Определение интерфейса логгера
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}
