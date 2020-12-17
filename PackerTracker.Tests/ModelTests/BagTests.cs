using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System;
using System.Collections.Generic; 

namespace PackerTracker.Tests
{
  [TestClass]
  public class BagTests
  {
    [TestMethod]
    public void BagConstructor_CreatesInstanceOfBagObject_Bag()
    {
      Bag newBag = new Bag(40);
      Assert.AreEqual(typeof(Bag), newBag.GetType());
    }
    [TestMethod]
    public void AddKit_AssociatesKitWithBag_KitList()
    {
      Kit newKit1 = new Kit("flashlight", 5, 1, true, true);
      List<Kit> newList = new List<Kit>{newKit1};
      int weightCapacity = 80;
      Bag newBag = new Bag(weightCapacity);
      newBag.AddKit(newKit1);
      List<Kit> result = newBag.Kits;
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetWeight_CorrectlyAddsWeightOfKits_Int()
    {
      Kit newKit1 = new Kit("flashlight", 5, 1, true, true);
      Kit newKit2 = new Kit("food", 3, 2, false, false);
      Bag newBag = new Bag(40);
      List<Kit> result = Kit.GetAll();
      newBag.AddKit(newKit1);
      newBag.AddKit(newKit2);
      
      int totalWeight = newBag.GetWeight();
      Assert.AreEqual(3, totalWeight);

      
    }

  }
}