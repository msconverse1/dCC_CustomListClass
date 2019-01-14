using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSC_CustomListClass;
namespace ListTest
{
    [TestClass]
    public class SortedList
    {
        [TestMethod]
        public void Sort_ByLowestInt_ReturnSortedList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> SortedList = new CustomList<int>();
            customList.Add(3);
            customList.Add(2);
            customList.Add(0);
            customList.Add(9);
            SortedList.Add(0);
            SortedList.Add(2);
            SortedList.Add(3);
            SortedList.Add(9);

            //Act

            customList.Sort(customList);
            //Assert
            for (int i = 0; i < SortedList.Count; i++)
            {
                Assert.AreEqual(SortedList[i], customList[i]);
            }
        }
        [TestMethod]
        public void Sort_ByString_ReturnSortedList()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> SortedList = new CustomList<string>();
            customList.Add("dddd");
            customList.Add("aaaa");
            customList.Add("bbbb");
            customList.Add("cccc");
            SortedList.Add("aaaa");
            SortedList.Add("bbbb");
            SortedList.Add("cccc");
            SortedList.Add("dddd");

            //Act

            customList.Sort(customList);
            //Assert
            for (int i = 0; i < SortedList.Count; i++)
            {
                Assert.AreEqual(SortedList[i], customList[i]);
            }
        }
        [TestMethod]
        public void Sort_ByStringofNum_ReturnSortedList()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> SortedList = new CustomList<string>();
            customList.Add("4");
            customList.Add("6");
            customList.Add("0");
            customList.Add("2");
            SortedList.Add("0");
            SortedList.Add("2");
            SortedList.Add("4");
            SortedList.Add("6");
            //Act
            customList.Sort(customList);
            //Assert
            for (int i = 0; i < SortedList.Count; i++)
            {
                Assert.AreEqual(SortedList[i], customList[i]);
            }
        }
    }
}
