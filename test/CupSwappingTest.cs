using NUnit.Framework;
using System;

namespace csharp_codewars
{
    [TestFixture]
	public class Tests
	{
		[Test]
		public void TestCupSwapping()
		{
			var i = 1;
			Assert.AreEqual(CupSwapping.CupSwapp(new String[] { "AB", "CA" }), "C", $"Test {i++}");
			Assert.AreEqual(CupSwapping.CupSwapp(new String[] { "AB", "CA", "AB" }), "C", $"Test {i++}");
			Assert.AreEqual(CupSwapping.CupSwapp(new String[] { "AC", "CA", "CA", "AC" }), "B", $"Test {i++}");
			Assert.AreEqual(CupSwapping.CupSwapp(new String[] { "BA", "AC", "CA", "BC" }), "A", $"Test {i++}");
			Assert.AreEqual(CupSwapping.CupSwapp(new String[] { "BC", "CB", "CA", "BA" }), "A", $"Test {i++}");
			Assert.AreEqual(CupSwapping.CupSwapp(new String[] { "BC" }), "C", $"Test {i++}");
			Assert.AreEqual(CupSwapping.CupSwapp(new String[] { "BA", "CA", "CB", "CA" }), "B", $"Test {i++}");
			Assert.AreEqual(CupSwapping.CupSwapp(new String[] { }), "B", $"Test {i++}");
		}
	}
}
