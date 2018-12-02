using System.Collections.Generic;

using csharp;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	[TestClass]
	public class SulfurasTest
	{
		[TestMethod]
		public void UpdateShouldNotChangeQuality()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(20, Items[0].Quality);
		}

		[TestMethod]
		public void UpdateShouldNotChangeSellIn()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 10, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(10, Items[0].SellIn);
		}
	}
}
