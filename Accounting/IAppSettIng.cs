using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting
{
    public interface IAppSettIng
    {
        string DataPath { get; }
        string OptDataPath { get; }
    }
}
