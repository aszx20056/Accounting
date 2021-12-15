using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting.Model
{
    public class AccRecord
    {
        public DateTime? AcDate { get; set; }
        public string PRCIE { get; set; }
        public string AcTp { get; set; }
        public string DC { get; set; }
    }
}
