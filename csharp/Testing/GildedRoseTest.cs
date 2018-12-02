using System.Collections.Generic;

using csharp;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	[TestClass]
	public class GildedRoseTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual("fixme", Items[0].Name);
		}
	}
}
