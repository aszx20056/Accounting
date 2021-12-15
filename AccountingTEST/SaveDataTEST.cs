using Accounting.FileSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
namespace AccountingTEST
{
    [TestClass]
    public class SaveDataTEST
    {
        SaveData sd = new SaveData();
        [TestMethod]
        public void ClearSave()
        {
            sd.ClearSave();
            sd.HasFile.Should().BeFalse();
        }
        [TestMethod]
        public void CreatSave()
        {
            sd.ClearSave();
            sd.CreatSave();
            sd.HasFile.Should().BeTrue();
        }
    }
}
