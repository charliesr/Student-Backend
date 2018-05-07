using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Backend.Common.Logic.Contracts
{
    public interface IMyLog
    {
        void Init(Type declaringType);
        void Debug(object message);
        void Fatal(object message);
        void Warn(object message);
        void Error(object message);
        void Info(object message);
        void Error(Exception ex);
    }
}
