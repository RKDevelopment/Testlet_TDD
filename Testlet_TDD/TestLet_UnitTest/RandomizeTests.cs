using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using Testlet;

namespace Testlettest
{
    [TestClass]
    public class RandomizeTest
    {
        public static Testlet.Testlet DataList()
        {
            return new Testlet.Testlet("First Test", new List<Item>(){
                new Item() {ItemId = "PreTest Item 1", ItemType = ItemTypeEnum.Pretest},
                new Item() {ItemId = "PreTest Item 2", ItemType = ItemTypeEnum.Pretest},
                new Item() {ItemId = "PreTest Item 3", ItemType = ItemTypeEnum.Pretest},
                new Item() {ItemId = "PreTest Item 4", ItemType = ItemTypeEnum.Pretest},

                new Item() {ItemId = "Operational Item 1", ItemType = ItemTypeEnum.Operational},
                new Item() {ItemId = "Operational Item 2", ItemType = ItemTypeEnum.Operational},
                new Item() {ItemId = "Operational Item 3", ItemType = ItemTypeEnum.Operational},
                new Item() {ItemId = "Operational Item 4", ItemType = ItemTypeEnum.Operational},
                new Item() {ItemId = "Operational Item 5", ItemType = ItemTypeEnum.Operational},
                new Item() {ItemId = "Operational Item 6", ItemType = ItemTypeEnum.Operational}
            });

        }

        [TestMethod]
        public void TestRandomize()
        {
            Testlet.Testlet test = DataList();

            var randomizedlist1 = test.Randomize();
            var randomizedlist2 = test.Randomize();

            //compare that in both lists  
            Assert.IsNotNull(randomizedlist1.FirstOrDefault(s => randomizedlist2[randomizedlist1.IndexOf(s)].ItemId != s.ItemId));

        }

         
    }
}
