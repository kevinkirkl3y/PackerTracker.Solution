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
      Kit newKit = new Kit();
      Assert.AreEqual(typeof(Kit), newKit.GetType());
    }
  }
}