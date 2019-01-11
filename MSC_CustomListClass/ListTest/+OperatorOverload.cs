using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSC_CustomListClass;

namespace ListTest
{
    [TestClass]
    public class OperatorOverload
    {
        [TestMethod]
        public void Add_ListSizeOneTogether()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>() ;
            CustomList<int> intList2 = new CustomList<int>();
            CustomList<int> intList3 = new CustomList<int>();
            int expectedSize = 6;
            int expectedResult = 5;
            int expectedResult2 = 2;
            int expectedResult3 = 2;

            int expectedResult4 = 1;
            int expectedResult5 = 2;
            int expectedResult6 = 3;
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult2);
            intList.Add(expectedResult3);

            intList2.Add(expectedResult4);
            intList2.Add(expectedResult5);
            intList2.Add(expectedResult6);

            intList3.Add(intList, intList2);
            
            //Assert
            Assert.AreEqual(expectedSize, intList3.Count);
        }
        [TestMethod]
        public void Add_ListSizeThreeTogether()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            CustomList<int> intList2 = new CustomList<int>();
            CustomList<int> intList3 = new CustomList<int>();
            CustomList<int> intList4 = new CustomList<int>();
            int expectedSize = 10;
            int expectedResult = 5;
            int expectedResult2 = 2;
            int expectedResult3 = 2;

            int expectedResult4 = 1;
            int expectedResult5 = 2;
            int expectedResult6 = 3;
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult2);
            intList.Add(expectedResult3);

            intList2.Add(expectedResult4);
            intList2.Add(expectedResult5);
            intList2.Add(expectedResult6);
            
            intList3.Add(intList, intList2);
            intList4.Add(expectedResult);
            intList4.Add(expectedResult2);
            intList4.Add(expectedResult4);
            intList4.Add(expectedResult5);
            intList4.Add(intList4,intList3);
            //Assert
            Assert.AreEqual(expectedSize, intList4.Count);
        }
        [TestMethod]
        public  void Add_ListsStringType()
        {
            CustomList<string> intList =  new CustomList<string>();
            CustomList<string> intList2 = new CustomList<string>();
            CustomList<string> intList3 = new CustomList<string>();
            CustomList<string> intList4 = new CustomList<string>();
           int expectedSize = 11;
           string expectedResult = "5";
           string expectedResult2 = "2";
           string expectedResult3 = "2";
           
           string expectedResult4 = "1";
           string expectedResult5 = "2";
            string expectedResult6 = "3";
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult2);
            intList.Add(expectedResult3);

            intList2.Add(expectedResult4);
            intList2.Add(expectedResult5);
            intList2.Add(expectedResult6);

            intList3.Add(intList, intList2);
            intList4.Add(expectedResult);
            intList4.Add(expectedResult2);
            intList4.Add(expectedResult4);
            intList4.Add(expectedResult5);
            intList4.Add(intList4, intList3);
            intList4.Add(expectedResult3);
            //Assert
            Assert.AreEqual(expectedSize, intList4.Count);
        }
        [TestMethod]
        public void Add_ListCombineListAddToComBinedList()
        {
            CustomList<int> intList = new CustomList<int>();
            CustomList<int> intList2 = new CustomList<int>();
            CustomList<int> intList3 = new CustomList<int>();
            CustomList<int> intList4 = new CustomList<int>();
            int expectedSize = 11;
            int expectedResult = 5;
            int expectedResult2 = 2;
            int expectedResult3 = 2;

            int expectedResult4 = 1;
            int expectedResult5 = 2;
            int expectedResult6 = 3;
            //Act
            intList.Add(expectedResult);
            intList.Add(expectedResult2);
            intList.Add(expectedResult3);

            intList2.Add(expectedResult4);
            intList2.Add(expectedResult5);
            intList2.Add(expectedResult6);

            intList3.Add(intList, intList2);
            intList4.Add(expectedResult);
            intList4.Add(expectedResult2);
            intList4.Add(expectedResult4);
            intList4.Add(expectedResult5);
            intList4.Add(intList4, intList3);
            intList4.Add(expectedResult3);
            //Assert
            Assert.AreEqual(expectedSize, intList4.Count);
        }
    }
}
