using System;
using MSC_CustomListClass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListTest
{
    [TestClass]
    public class RemoveTest
    {
        [TestMethod]
        public void Remove_SingleInt()
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange
            
            int expectedInt = 5;
            bool  expetedResult = false;
            //Act
            customList.Add(expectedInt);
          bool actual =  customList.Remove(expectedInt);

            //Assert
            Assert.AreEqual(expetedResult, actual);
        }
        [TestMethod]
        public void Remove_SingleInt_AtAnyIndex()
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange
            
            int expectedInt = 5;
            int expectedInt1 = 0;
            int expectedInt2 = 2;

            bool expetedResult = false;

            //Act
            customList.Add(expectedInt1);
            customList.Add(expectedInt);
            customList.Add(expectedInt2);
            bool actual = customList.Remove(expectedInt);

            //Assert
            Assert.AreEqual(expetedResult, actual);
            
        }
        public void Remove_SingleInt_ReturnListWhenNoFound()
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange

            int expectedInt = 5;
            int expectedInt1 = 0;
            int expectedInt2 = 2;

            bool expetedResult = false;

            //Act
            customList.Add(expectedInt1);
            customList.Add(expectedInt2);
            customList.Add(expectedInt2);
            bool actual = customList.Remove(expectedInt);

            //Assert
            Assert.AreEqual(expetedResult, actual);
        }
        public void Remove_FirstOccurrenceFromListContainMultiSame_ReturnsList()
        {
            CustomList<int> customList = new CustomList<int>();
            //Arrange

            int expectedInt = 5;
            int expectedInt1 = 0;
            int expectedInt2 = 2;

            bool expetedResult = false;

            //Act
            customList.Add(expectedInt);
            customList.Add(expectedInt1);
            customList.Add(expectedInt);
            customList.Add(expectedInt2);
            bool actual = customList.Remove(expectedInt);

            //Assert
            Assert.AreEqual(expetedResult, actual);
        }
        [TestMethod]
        public void Remove_SingleString()
        {
            CustomList<string> customList = new CustomList<string>();
            //Arrange

            string expectedInt = "Hello";
            bool expetedResult = false;

            //Act
            customList.Add(expectedInt);
            bool actual = customList.Remove(expectedInt);

            //Assert
            Assert.AreEqual(expetedResult, actual);
        }
        [TestMethod]
        public void Remove_OneString_ListContainsMorethanone()
        {
            CustomList<string> customList = new CustomList<string>();
            //Arrange

            string expectedString = "World";
            string expectedString1 = "Matthew";
            string expectedString2 = "Hello";
            string expectedString3 = "Test";
            string expectedString4 = "Hello";
            bool expetedResult = true;

            //Act
            customList.Add(expectedString);
            customList.Add(expectedString1);
            customList.Add(expectedString2);
            customList.Add(expectedString3);
            customList.Add(expectedString4);

            bool actual = customList.Remove(expectedString2);

            //Assert
            Assert.AreEqual(expetedResult, actual);
        }
        [TestMethod]
        public void Remove_SingleBool()
        {
            CustomList<bool> customList = new CustomList<bool>();
            //Arrange

            bool expectedInt = true;
            bool expetedResult = false;

            //Act
            customList.Add(expectedInt);
            bool actual = customList.Remove(expectedInt);

            //Assert
            Assert.AreEqual(expetedResult, actual);
        }

    }
}
