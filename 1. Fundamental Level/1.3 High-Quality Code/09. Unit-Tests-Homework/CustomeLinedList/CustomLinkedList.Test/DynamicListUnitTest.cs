using System;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedList.Test
{
    [TestClass]
    public class DynamicListUnitTest
    {
        DynamicList<int> dynamicList;
        int check;

        [TestInitialize]
        public void TestInitialize()
        {
            dynamicList = new DynamicList<int>();
            check = 0;
        }

        [TestMethod]
        public void Add()
        {
            dynamicList.Add(2);

            Assert.AreEqual(2, dynamicList[0]);
        }

        [TestMethod]
        public void RemoveAt()
        {
            for (int i = 0; i < 10; i++)
            {
                dynamicList.Add(i);
            }

            dynamicList.RemoveAt(0);

            Assert.AreEqual(1, dynamicList[0]);
        }

        [TestMethod]
        public void Remove()
        {
            for (int i = 0; i < 10; i++)
            {
                dynamicList.Add(i);
            }

            dynamicList.Remove(0);

            Assert.AreEqual(1, dynamicList[0]);
        }

        [TestMethod]
        public void Contains()
        {
            for (int i = 0; i < 10000; i++)
            {
                dynamicList.Add(i);
            }

            Assert.IsTrue(dynamicList.Contains(2000), "True");
        }

        [TestMethod]
        public void Count()
        {
            for (int i = 0; i < 10000; i++)
            {
                dynamicList.Add(i);
            }

            Assert.AreEqual(dynamicList.Count, 10000);
        }

        [TestMethod]
        public void IndexOf()
        {
            for (int i = 0; i < 10000; i++)
            {
                dynamicList.Add(i);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CheckPositionOfRemovedElement()
        {
            for (int i = 0; i < 10000; i++)
            {
                dynamicList.Add(i);
            }

            dynamicList.RemoveAt(9999);

            int check = dynamicList[9999];
        }
    } 
}
