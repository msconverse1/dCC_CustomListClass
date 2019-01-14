using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSC_CustomListClass;
namespace ListTest
{
    [TestClass]
    public class IterableTest 
    {
        [TestMethod]
        public void Add_IteratethroughList_ReturnInts()
        {
            CustomList<int> customList = new CustomList<int>
            { 3,3,5};
            //Act
            foreach (var item in customList)
            {
                Console.WriteLine(item);
            }
            
        }
        [TestMethod]
        public void TestMethod1()
        {
            CustomList<string> customList = new CustomList<string>{"3","3","5"};
            //Act
            foreach (var item in customList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
