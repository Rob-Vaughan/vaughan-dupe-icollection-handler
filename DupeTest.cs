using System.Collections;
using Vaughan_Generic_Duplicate_Handler;

using System.Linq;
namespace UnitTest
{
    [TestClass]
    public class DupeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> starting = new List<string>() {
            "O'ahu",
            "Maui",
            "Hawai'i",
            "Hawai'i",
            "Moloka'i",
            "Lana'i",
            "Lana'i",
            "Lana'i",
            "Ni'ihau",
            "Kaho'olawe"
            };

            List<string> expected = new List<string>() {
            "O'ahu",
            "Maui",
            "Hawai'i",
            "Moloka'i",
            "Lana'i",
            "Ni'ihau",
            "Kaho'olawe"
            };

            var actual = (List<string>)GenericDuplicateHandler.removeDuplicates<string>(starting);
            //for (int i = 0; i < expected.AsEnumerable().Count(); i++)
            //{
            //    Assert.AreEqual(expected, actual, "test item is not equal");
            //}
            //Assert.AreEqual(expected, actual, "test item is not equal");
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<string> newListString = new List<string>
             {
                 "Hello",
                 "World",
                 "Hello",
                 "Hello"
             };
            List<string> expected = new List<string>
             {
                 "Hello",
                 "World"
             };
            var actual = (List<string>)GenericDuplicateHandler.removeDuplicates<string>(newListString);
            //Assert.AreEqual(expected, actual, "test item is not equal");
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void TestMethod3()
        {
            List<int> newListInt = new List<int>
            {
                1,2,3,4,5,1,2,3,3
            };
            List<int> expected = new List<int>
            {
                1,2,3,4,5
            };
            var actual = (List<int>)GenericDuplicateHandler.removeDuplicates<int>(newListInt);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void TestMethod4()
        {
            List<Page> newListObj = new List<Page>();
            Page newPage = new Page
            {
                Id = 1,
                FileName = "TestFile.txt",
                DocumentType = "TestDocType",
                ImportDate = DateTime.Now,
                PageNumber = 1
            };
            newListObj.Add(newPage);
            newListObj.Add(newPage);
            newListObj.Add(newPage);
            List<Page> expected = new List<Page>();
            expected.Add(newPage);
            var actual = (List<Page>)GenericDuplicateHandler.removeDuplicates<Page>(newListObj);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}