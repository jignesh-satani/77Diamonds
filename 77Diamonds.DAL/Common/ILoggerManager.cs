using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _77Diamonds.DAL
{
    public interface ILoggerManager
    {
        void LogError(string controller, string action, string message, string stackTrace, string user);
    }
}
