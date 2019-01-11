using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSC_CustomListClass;

namespace ListTest
{
    [TestClass]
    public class MinusOperatorOverload
    {
        [TestMethod]
        public void RemoveOneInstance_ints_ReturnListCount()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            CustomList<int> intList2 = new CustomList<int>();
            CustomList<int> intList3 = new CustomList<int>();
            int expectedSize = 2;
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

            intList3 = intList - intList2;

            //Assert
            Assert.AreEqual(expectedSize, intList3.Count);
        }
        [TestMethod]
        public void RemoveOneInstance_AddNewItem_ReturnListCount()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            CustomList<int> intList2 = new CustomList<int>();
            CustomList<int> intList3 = new CustomList<int>();
            int expectedSize = 3;
            int expectedResult = 1;
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

            intList3 = intList - intList2;
            intList3.Add(expectedResult6);

            //Assert
            Assert.AreEqual(expectedSize, intList3.Count);
        }
        [TestMethod]
        public void RemoveOneInstance_strings_ReturnListCount()
        {
            //Arrange
            CustomList<string> intList = new CustomList<string>();
            CustomList<string> intList2 = new CustomList<string>();
            CustomList<string> intList3 = new CustomList<string>();
            int expectedSize = 3;
            string expectedResult = "1";
            string expectedResult2 = "3";
            string expectedResult3 = "5";
            string expectedResult4 = "2";
            string expectedResult5 = "1";
            string expectedResult6 = "6";
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult2);
            intList.Add(expectedResult3);

            intList2.Add(expectedResult4);
            intList2.Add(expectedResult5);
            intList2.Add(expectedResult6);

            intList3 = intList - intList2;
            intList3.Add(expectedResult6);

            //Assert
            Assert.AreEqual(expectedSize, intList3.Count);
        }
        [TestMethod]
        public void RemoveOneInstance_AddNewstrings_ReturnListCount()
        {
            //Arrange
            CustomList<string> intList = new CustomList<string>();
            CustomList<string> intList2 = new CustomList<string>();
            CustomList<string> intList3 = new CustomList<string>();
            int expectedSize = 3;
            string expectedResult = "1";
            string expectedResult2 = "3";
            string expectedResult3 = "5";
            string expectedResult4 = "2";
            string expectedResult5 = "1";
            string expectedResult6 = "6";
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult2);
            intList.Add(expectedResult3);

            intList2.Add(expectedResult4);
            intList2.Add(expectedResult5);
            intList2.Add(expectedResult6);

            intList3 = intList - intList2;
            intList3.Add(expectedResult6);

            //Assert
            Assert.AreEqual(expectedSize, intList3.Count);
        }
        [TestMethod]
        public void RemoveOneInstance_NothingToRemove_ReturnListCount()
        {
            //Arrange
            CustomList<string> intList = new CustomList<string>();
            CustomList<string> intList2 = new CustomList<string>();
            CustomList<string> intList3 = new CustomList<string>();
            int expectedSize = 3;
            string expectedResult = "1";
            string expectedResult2 = "3";
            string expectedResult3 = "5";
            string expectedResult4 = "2";
            string expectedResult5 = "6";
            string expectedResult6 = "0";
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult2);
            intList.Add(expectedResult3);
            intList2.Add(expectedResult4);
            intList2.Add(expectedResult5);
            intList2.Add(expectedResult6);

            intList3 = intList - intList2;
            //Assert
            Assert.AreEqual(expectedSize, intList3.Count);
        }
    }
}
