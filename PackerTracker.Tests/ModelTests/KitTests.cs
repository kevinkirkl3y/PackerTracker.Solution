using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System;
using System.Collections.Generic; 

namespace PackerTracker.Tests
{
  [TestClass]
  public class KitTests : IDisposable
  {
    public void Dispose()
    {
      Kit.ClearAll();
    }

    [TestMethod]
    public void KitConstructor_CreatesInstanceOfKit_Kit()
    {
      Kit newKit = new Kit("name", 5, 1, true, true);
      Assert.AreEqual(typeof(Kit), newKit.GetType());
    }
    
    [TestMethod]
    public void KitConstructor_ReturnsPropertiesOfKit_Properties()
    {
      Kit newKit = new Kit("flashlight", 5, 1, true, true);
      Assert.AreEqual("flashlight", newKit.Name);
      Assert.AreEqual(5, newKit.Price);
      Assert.AreEqual(1, newKit.Weight);
      Assert.AreEqual(true , newKit.Purchased);
      Assert.AreEqual(true, newKit.Packed);
    }

    [TestMethod] 
    public void GetId_ItemsAreInstantiatedWithAnIdAndGetterReturns_Int()
    {
      Kit newKit = new Kit("flashlight", 5, 1, true, true);
      int result = newKit.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_KitList()
    {
      List<Kit> newList = new List<Kit> { };
      List<Kit> result = Kit.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllItemsOfTheKit_KitList()
    {
      Kit newKit1 = new Kit("flashlight", 5, 1, true, true);
      Kit newKit2 = new Kit("food", 3, 2, false, false);

      List<Kit> newList = new List<Kit> {newKit1, newKit2};
      List<Kit> result = Kit.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    
  }
}