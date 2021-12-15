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
    public class SaveDataTEST
    {

        [TestMethod]
        public void ClearSave()
        {
            AppSettIng seeting = new AppSettIng();
            SaveData sd = new SaveData(seeting.DataPath);
            sd.ClearSave();
            sd.HasFile.Should().BeFalse();
        }
        [TestMethod]
        public void CreatSave()
        {
            AppSettIng seeting = new AppSettIng();
            SaveData sd = new SaveData(seeting.DataPath);
            sd.ClearSave();
            sd.CreatSave();
            sd.HasFile.Should().BeTrue();
        }
    }
}
