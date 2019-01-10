using System;
using MSC_CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            int expectedResult = 5;
            int expectedResult1 = 7;
            int expectedCount = 2;
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult1);

            //Assert
            Assert.AreEqual(expectedCount, intList.Count);
        }


        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            int expectedResult = 5;
            //Act
            intList.Add(expectedResult);

            //Assert
            Assert.AreEqual(expectedResult, intList[0]);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            int expectedResult = 5;
            int expectedResult1 = 7;
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult1);

            //Assert
            Assert.AreEqual(expectedResult, intList[0]);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            int expectedResult = 5;
            int expectedResult1 = 7;
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult1);

            //Assert
            Assert.AreEqual(expectedResult1, intList[1]);
        }
       

    }
}