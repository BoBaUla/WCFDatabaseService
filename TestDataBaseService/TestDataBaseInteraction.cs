using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFDataBaseService;

namespace TestDataBaseInteraction
{

    [TestClass]
    public class TestDataBaseInteraction
    {

        [TestMethod]
        public void InitProxy()
        {

            MockProxy.DataBaseServiceMock _proxy = new MockProxy.DataBaseServiceMock();
        }

        [TestMethod]
        public void GetName()
        {
            MockProxy.DataBaseServiceMock _proxy = new MockProxy.DataBaseServiceMock();
            Person person = _proxy.GetName("1");
            if (person.ID != "1")
                throw new Exception("");
        }

        [TestMethod]
        public void GetTable()
        {
            MockProxy.DataBaseServiceMock _proxy = new MockProxy.DataBaseServiceMock();
            int count = _proxy.GetTable().Count;
            if (count != 6)
                throw new Exception("");
        }

        [TestMethod]
        public void AddName()
        {
            MockProxy.DataBaseServiceMock _proxy = new MockProxy.DataBaseServiceMock();
            int countBefore = _proxy.GetTable().Count;
            string newName = "ABC";
            _proxy.AddName(newName);
            int countAfter = _proxy.GetTable().Count;
            if (countBefore + 1 != countAfter)
            {
                throw new Exception("Invalid number");
            }

            if (_proxy.GetTable()[countBefore].Fullname != newName)
            {
                throw new Exception("Adding failed");
            }
        }

        [TestMethod]
        public void UpdateName()
        {
            MockProxy.DataBaseServiceMock _proxy = new MockProxy.DataBaseServiceMock();
            Person oldEntry = _proxy.GetTable()[0];
            int countBefore = _proxy.GetTable().Count;
            string newName = "ABC";
            _proxy.ChangeName("1", newName);
            Person newEntry = _proxy.GetTable()[0];
            int countAfter = _proxy.GetTable().Count;
            if (newEntry.Fullname != newName)
            {
                throw new Exception("Wrong name");
            }
            if (countBefore != countAfter)
            {
                throw new Exception("Invalid number");
            }

        }
    }
}
