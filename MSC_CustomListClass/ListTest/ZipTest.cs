using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSC_CustomListClass;
namespace ListTest
{
    [TestClass]
    public class ZipTest
    {
        [TestMethod]
        public void AddTwoList_3IndexsofInts_ReturnNewList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3 = new CustomList<int>();
            CustomList<int> customList4 = new CustomList<int>();
            //ListOne
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            //ListTwo
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            //Expected
            customList4.Add(1);
            customList4.Add(2);
            customList4.Add(3);
            customList4.Add(4);
            customList4.Add(5);
            customList4.Add(6);

            //Act
            customList3=customList3.Zip(customList, customList2);

            //Assert
            for (int i = 0; i < customList4.Count; i++)
            {
                Assert.AreEqual(customList4[i], customList3[i]);
            }
            
        }
        [TestMethod]
        public void AddTwoList_3IndexsofStrings_ReturnNewList()
        {
            //Arrange
            CustomList<string> customList =   new CustomList<string>();
            CustomList<string> customList2 = new CustomList<string>();
            CustomList<string> customList3 = new CustomList<string>();
            CustomList<string> customList4 = new CustomList<string>();
            //ListOne
            customList.Add("1");
            customList.Add("3");
            customList.Add("5");
            //List2
            customList2.Add("2");
            customList2.Add("4");
            customList2.Add("6");
            //ExpectedList
            customList4.Add("1");
            customList4.Add("2");
            customList4.Add("3");
            customList4.Add("4");
            customList4.Add("5");
            customList4.Add("6");

            //Act
            customList3 = customList3.Zip(customList, customList2);

            //Assert

            for (int i = 0; i < customList4.Count; i++)
            {
                Assert.AreEqual(customList4[i], customList3[i]);
            }
        }
        [TestMethod]
        public void AddTwoList_Index0Null_ReturnNewList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3 = new CustomList<int>();
            CustomList<int> customList4 = new CustomList<int>();
            
            customList[1]=(3);
            customList[2]=(5);
            
            customList2[1]=(4);
            customList2[2]=(6);
            customList4.Add(1);
            customList4.Add(2);
            customList4.Add(3);
            customList4.Add(4);
            customList4.Add(5);
            customList4.Add(6);

            //Act
            customList3 = customList3.Zip(customList, customList2);

            //Assert
            for (int i = 0; i < customList4.Count; i++)
            {
                Assert.AreEqual(customList4[i], customList3[i]);
            }
        }
        [TestMethod]
        public void AddTwoList_Addnewdata_ReturnNewList()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();
            CustomList<int> customList3 = new CustomList<int>();
            CustomList<int> customList4 = new CustomList<int>();
            customList.Add(1);
            customList.Add(3);
            customList.Add(5);
            customList2.Add(2);
            customList2.Add(4);
            customList2.Add(6);
            customList4.Add(1);
            customList4.Add(2);
            customList4.Add(3);
            customList4.Add(4);
            customList4.Add(5);
            customList4.Add(6);
            customList4.Add(8);
            //Act
            customList3 = customList3.Zip(customList, customList2);
            customList3.Add(8);
            //Assert
            for (int i = 0; i < customList4.Count; i++)
            {
                Assert.AreEqual(customList4[i], customList3[i]);
            }
        }

    }
}
