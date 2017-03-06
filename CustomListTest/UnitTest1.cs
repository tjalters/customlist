using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddInteger_IntegerIsPresent()
        {
            //arrange
            CustomList<int> custom = new CustomList<int>();
            int addedItem = 3;
            //act
            custom.Add(addedItem);

            //assert
            Assert.AreEqual(custom[0], addedItem);
        }
        [TestMethod]
        public void Add_AddInteger_ItemLocationIsCorrect()
        {
            CustomList<int> custom = new CustomList<int> { 1, 2 };
            int addedItem = 3;

            custom.Add(addedItem);
           
            Assert.AreEqual(custom[2], custom.data.Length);
        }
        [TestMethod]

        public void Indexer_IntGetValue_ValueOfIndexReturned()
        {
            CustomList<int> custom = new CustomList<int>();
            int addedItem = 4;

            custom.Add(addedItem);

            Assert.AreEqual(custom[0], addedItem);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexerInt_IndexOutOfRange_IndexOutOfRangeException()
        {
            CustomList<int> custom = new CustomList<int>();
            int addedItem = 12;

            custom.Add(addedItem);

            Assert.AreEqual(custom[1], addedItem);
            
        }
        [TestMethod]
        public void Add_AddInt_SeeIfCountIsCorrect()
        {
            CustomList<int> custom = new CustomList<int>();
            int addedItem = 7;

            custom.Add(addedItem);

            Assert.AreEqual(custom.Count, 1);
        }
        
        [TestMethod]
        public void Remove_RemoveInteger_IntegerIsGone()
        {
            CustomList<int> custom = new CustomList<int>();
            int removedItem = 3;                                    //bool isRemoved 
                                                                    //isRemoved = true;
            custom.Remove(removedItem);                      //custom.removeInteger;
                                                                    //else isRemoved = false;
            Assert.AreEqual(0, removedItem);
        }
        //[TestMethod]
        //public void RemoveTwoIntegers()
        //{
        //    CustomList<int> custom = new CustomList<int>();

        //    custom.RemoveInteger(4);
        //    custom.RemoveInteger(9);

        //    Assert.AreEqual(0, 0, custom.test.Length);
        //}
        //[TestMethod]
        //public void RemoveAString()
        //{
        //    CustomList<string> custom = new CustomList<string>();

        //    custom.RemoveString("Stop");

        //    Assert.AreEqual("", custom.test.Length);
        //}
        //[TestMethod]
        //public void RemoveTwoStrings()
        //{
        //    CustomList<string> custom = new CustomList<string>();

        //    custom.RemoveString("Stop");
        //    custom.RemoveString("Go");

        //    Assert.AreEqual("" + "", custom.test.Length);
        //}
        [TestMethod]
        public void Add_AddString_StringIsPresent()
        {
            //arrange
            CustomList<string> custom = new CustomList<string>();
            string addedItem = "go";
            //act
            custom.Add(addedItem);
            //assert
            Assert.AreEqual(custom[0], addedItem);
        }
        [TestMethod]
        public void Add_AddString_ItemLocationCorrect()
        {
            //arrange
            CustomList<string> custom = new CustomList<string> { "go", "stop" };
            string addedItem = "boo";
            //act
            custom.Add(addedItem);
            //assert
            Assert.AreEqual(custom[2], addedItem);
        }
        [TestMethod]
        public void Indexer_GetValue_ValueOfIndexReturned()
        {
            //arrange
            CustomList<string> custom = new CustomList<string>();
            string addedItem = "go";
            //act
            custom.Add(addedItem);
            //assert
            Assert.AreEqual(custom[0], addedItem);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]

        public void Indexer_IndexOutOfRange_IndexOutOfRangeException()
        {
            //arrange
            CustomList<string> custom = new CustomList<string>();
            string addedItem = "stop";
            //act
            custom.Add(addedItem);
            //assert
            Assert.AreEqual(custom[1], addedItem);
        }
        [TestMethod]
        public void Add_AddString_SeeIfCountIsCorrect()
        {
            //arrange
            CustomList<string> custom = new CustomList<string>();
            string addedItem = "stop";
            //act
            custom.Add(addedItem);
            //assert
            Assert.AreEqual(custom.Count, 1);
        }
        [TestMethod]
        public void Add_AddTwoIntegersFromTwoLists()
        {
            //arrange
            CustomList<int> myListOne = new CustomList<int>();
            CustomList<int> myListTwo = new CustomList<int>();
            int addedItem = 3;
            int addedItemTwo = 4;
            //act
            myListOne.Add(addedItem);
            myListTwo.Add(addedItemTwo);
            CustomList<int> result = myListOne + myListTwo;
            //assert
            Assert.AreEqual(2, result.data.Length);

        }
       
        [TestMethod]
        public void Add_AddTwoIntegers_PlaceInProperIndex()
        {
            //arrange
            CustomList<int> custom = new CustomList<int> { 1, 2, 3, 4, 5 };
            int addedItem = 6;
            int addedItemTwo = 7;
            //act
            custom.Add(addedItem);
            custom.Add(addedItemTwo);
            //assert
            Assert.AreEqual(custom[5], custom[6], custom.data.Length );
        }
       
        [TestMethod]
        public void Add_AddTwoStrings_PlaceInProperIndex()
        {
            //arrange
            CustomList<string> custom = new CustomList<string> { "go", "stop", "move", "run", "flip" };
            string addedItem = "jump";
            string addedItemTwo = "walk";
            //act
            custom.Add(addedItem);
            custom.Add(addedItemTwo);
            //assert
            Assert.AreEqual(addedItem, custom[5]);
            Assert.AreEqual(addedItemTwo, custom[6]);

        }
        [TestMethod]
        public void Add_AddTwoStringsFromTwoSeperateLists()
        {
            //arrange
            CustomList<string> stringListOne = new CustomList<string>();
            CustomList<string> stringListTwo = new CustomList<string>();
            string addedItem = "go";
            string addedItemTwo = "stop";
            //act
            stringListOne.Add(addedItem);
            stringListTwo.Add(addedItemTwo);
            CustomList<string> result = stringListOne + stringListTwo;
            //assert
            Assert.AreEqual(2, result.data.Length);

        }
        [TestMethod]
        public void Remove_RemoveInteger_PlaceRemainingIntegersInProperIndex()
        {
            CustomList<int> custom = new CustomList<int> { 1, 2, 3 };

            custom.Remove(1);

            Assert.AreEqual(2, custom[0]);

        }
        [TestMethod]
        public void Remove_RemoveString_PlaceRemainingStringsInProperIndex()
        {

        }
        [TestMethod]
        public void Remove_RemoveIntegerFromOneList_CombineRemainingIntegers()
        {
            CustomList<int> myListOne = new CustomList<int> { 1, 2 };
            CustomList<int> myListTwo = new CustomList<int> { 3, 4 };
            int removedItem = 2;

            myListTwo.Remove(removedItem);
            CustomList<int> result = myListOne + myListTwo;

            Assert.AreEqual(3, result.data.Length);
        }
        [TestMethod]
        public void Remove_RemoveStringFromOneList_CombineRemainingStrings()
        {

        }
     
        [TestMethod]
        public void Convert_IntListToString()
        {
            CustomList<int> custom = new CustomList<int>();
            custom.Add(1);
            custom.Add(2);
            custom.Add(3);

            string expected = "123";

            string result = custom.ToString();

            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void Add_AddTwoIntegersToZipList_PlaceInProperIndex()
        {
            CustomList<int> listOne = new CustomList<int> { 1, 2 };
            CustomList<int> listTwo = new CustomList<int> { 3, 4 };
            int addedItem = 5;
            addedItem = 6;

            CustomList<int> zipList = listOne + listTwo;
            zipList.Add(addedItem);
            zipList.Add(addedItem);

            Assert.AreEqual(addedItem, zipList[4]);
            Assert.AreEqual(addedItem, zipList[5]);
        }
        public void Add_AddTwoStringsToZipList_PlaceInProperIndex()
        {
            CustomList<string> listOne = new CustomList<string> { "go", "stop" };
            CustomList<string> listTwo = new CustomList<string> { "run", "jump" };
            string addedItem = "walk";
            addedItem = "skip";

            CustomList<string> zipList = listOne + listTwo;
            zipList.Add(addedItem);
            zipList.Add(addedItem);

            Assert.AreEqual(addedItem, zipList[4]);
            Assert.AreEqual(addedItem, zipList[5]);


        }
        public void ZipList_CheckToSeeIfPlacedInProperIndex()
        {
            CustomList<int> listOne = new CustomList<int> { 1, 2 };
            CustomList<int> listTwo = new CustomList<int> { 3, 4 };

            CustomList<int> zipList = listOne + listTwo;
            listOne.ZipList(listOne, listTwo);
            listTwo.ZipList(listOne, listTwo);

            Assert.AreEqual(2, zipList[2]);
            Assert.AreEqual(3, zipList[1]);
        }


    }
}
