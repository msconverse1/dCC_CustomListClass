using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSC_CustomListClass;

namespace ListTest
{
    [TestClass]
    public class MinusOperatorOverload
    {
        [TestMethod]
        public void Remove_OneInstance()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            CustomList<int> intList2 = new CustomList<int>();
            CustomList<int> intList3 = new CustomList<int>();
            int expectedSize = 6;
            int expectedResult   = 1;
            int expectedResult2 = 3;
            int expectedResult3 = 5;

            int expectedResult4 = 2;
            int expectedResult5 = 1;
            int expectedResult6 = 6;
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult2);
            intList.Add(expectedResult3);

            intList2.Add(expectedResult4);
            intList2.Add(expectedResult5);
            intList2.Add(expectedResult6);

            

            //Assert
            Assert.AreEqual(expectedSize, intList3.Count);
        }
    }
}
