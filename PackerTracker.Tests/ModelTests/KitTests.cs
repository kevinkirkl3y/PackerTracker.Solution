using Microsoft.VisualStudio.TestTools.UnitTesting;
using PackerTracker.Models;

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
      Kit newKit = new Kit();
      Assert.AreEqual(typeof(Kit), newKit.GetType());
    }
  }
}