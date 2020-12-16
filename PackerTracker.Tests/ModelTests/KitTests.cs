using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class KitTests
  {
    [TestMethod]
    public void KitConstructor_CreatesInstanceOfKit_Kit()
    {
      Kit newKit = new Kit("name", 5, 1, true, true);
      Assert.AreEqual(typeof(Kit), newKit.GetType());
    }
    
    [TestMethod]
    public void KitConstructor_ReturnsPropertiesOfKit_Properties()
    {
      Kit newKit = new Kit("flashslight", 5, 1, true, true);
      Assert.AreEqual(name, newKit.Name);
      Assert.AreEqual(5, newKit.Price);
      Assert.AreEqual(1, newKit.Weight);
      Assert.AreEqual(true , newKit.Purchased);
      Assert.AreEqual(true, newKit.Packed);
    }
  }
}