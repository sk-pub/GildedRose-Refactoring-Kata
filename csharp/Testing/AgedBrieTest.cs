using System.Collections.Generic;

using csharp;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	[TestClass]
	public class AgedBrieTest
	{
		[TestMethod]
		public void UpdateShouldIncreaseQuality()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(21, Items[0].Quality);
		}

		[TestMethod]
		public void UpdateShouldNotIncreaseQualityOverFifty()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 10, Quality = 50 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(50, Items[0].Quality);
		}
	}
}
