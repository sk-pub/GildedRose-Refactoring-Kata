using System.Collections.Generic;

using csharp;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	[TestClass]
	public class BackstagePassesTest
	{
		[TestMethod]
		public void UpdateShouldIncreaseQuality()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(21, Items[0].Quality);
		}

		[TestMethod]
		public void UpdateShouldNotIncreaseQualityOverFifty()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 15, Quality = 50 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(50, Items[0].Quality);
		}

		[TestMethod]
		public void UpdateShouldIncreaseQualityByTwoIfSellInIsLessThanTen()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(22, Items[0].Quality);
			app.UpdateQuality();
			Assert.AreEqual(24, Items[0].Quality);
		}

		[TestMethod]
		public void UpdateShouldIncreaseQualityByThreeIfSellInIsLessThanFive()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 5, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(23, Items[0].Quality);
			app.UpdateQuality();
			Assert.AreEqual(26, Items[0].Quality);
		}

		[TestMethod]
		public void UpdateShouldDecreaseQualityToZeroAfterTheConcert()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(0, Items[0].Quality);
		}
	}
}
