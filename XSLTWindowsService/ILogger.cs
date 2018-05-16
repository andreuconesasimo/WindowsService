using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XSLTWindowsService
{
    public interface ILogger
    {
        #region Properties
        TimeSpan ExecutionTime { get; set; }
        int counter { get; set; }
        #endregion

        #region Methods
        void Debug(string message);
        void Error(string message);
        void Exception(Exception exception, string message);
        void Exception(Exception exception);
        #endregion
    }
}
