using Accounting.FileSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Accounting;

namespace AccountingTEST
{
    [TestClass]
    public class TxtReaderTEST
    {

        [TestMethod]
        public void ClearSave()
        {
            TxtReader sd = new TxtReader(TestSeeting.TxtPath);
            sd.ClearSave();
            sd.HasFile.Should().BeFalse();
        }
        [TestMethod]
        public void CreatSave()
        {
            TxtReader sd = new TxtReader(TestSeeting.TxtPath);
            sd.ClearSave();
            sd.CreatSave();
            sd.HasFile.Should().BeTrue();
        }
    }
}
