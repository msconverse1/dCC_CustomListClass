using System;
using MSC_CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListTest
{
    [TestClass]
    public class List_Add
    {
        [TestMethod]
        public void Add_SingleIntToList()
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
        public void Add_TwoIntsToList_ReturnResultAtIndexZero()
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
        public void Add_TwoIntsToList_ReturnResultAtIndexOne()
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
        [TestMethod]
        public void Add_MultipleIntsToList_ReturnTheListCount()
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
            public void Add_SingleStringToList_ReturnAtIndexZero()
        {
            //Arange
            CustomList<string> stringList = new CustomList<string>();
            string expectedResult = "Hello";

            //Act
            stringList.Add(expectedResult);
            //Assert
            Assert.AreEqual(expectedResult, stringList[0]);
        }
        [TestMethod]
        public void Add_MultipleStringToList_ReturnAtIndexOne()
        {
            //Arange
            CustomList<string> stringList = new CustomList<string>();
            string expectedResult = "Hello";
            string expectedResult1 = "World";
            //Act
            stringList.Add(expectedResult);
            stringList.Add(expectedResult1);
            //Assert
            Assert.AreEqual(expectedResult1, stringList[1]);
        }
        [TestMethod]
        public void Add_SingleBool_ReturnAtIndex()
        {
            //Arange
            CustomList<bool> boolList = new CustomList<bool>();
            bool expectedResult = true;
            
            //Act
            boolList.Add(expectedResult);
            
            //Assert
            Assert.AreEqual(expectedResult, boolList[0]);
        }
        [TestMethod]
        public void Add_MultipleBool_ReturnAtIndexOne()
        {
            //Arange
            CustomList<bool> boolList = new CustomList<bool>();
            bool expectedResult = true;
            bool expectedResult1 = false;
            //Act
            boolList.Add(expectedResult);
            boolList.Add(expectedResult1);
            //Assert
            Assert.AreEqual(expectedResult1, boolList[1]);
        }

    }
}