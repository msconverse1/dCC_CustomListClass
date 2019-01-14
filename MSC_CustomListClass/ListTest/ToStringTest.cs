using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSC_CustomListClass;
namespace ListTest
{
    [TestClass]
    public class ToStringTest
    {
        [TestMethod]
        public void Convert_ListOfInts_ReturnString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            string convertedList;
            string expected = "1,2,3,";
            //Act
            convertedList = customList.ToString();

            //Assert
            Assert.AreEqual(expected, convertedList);
        }

    }
}
