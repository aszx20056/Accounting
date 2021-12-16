using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.Model
{
    public class AccRecordQuery: AccRecord
    {
        public IEnumerable<string> InAcTp { get; set; }
    }
}
