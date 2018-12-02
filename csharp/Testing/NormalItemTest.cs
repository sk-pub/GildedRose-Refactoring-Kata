using System.Collections.Generic;

using csharp;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	[TestClass]
	public class NormalItemTest
	{
		[TestMethod]
		public void UpdateShouldNotChangeName()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual("foo", Items[0].Name);
		}

		[TestMethod]
		public void UpdateShouldDecreaseQuality()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(19, Items[0].Quality);
		}

		[TestMethod]
		public void UpdateShouldDecreaseSellIn()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(9, Items[0].SellIn);
		}

		[TestMethod]
		public void UpdateShouldDecreaseQualityByTwoIfSellInLessThanZero()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 20 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(18, Items[0].Quality);
			app.UpdateQuality();
			Assert.AreEqual(16, Items[0].Quality);
		}

		[TestMethod]
		public void UpdateShouldDecreaseQualityBelowZero()
		{
			IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
			GildedRose app = new GildedRose(Items);
			app.UpdateQuality();
			Assert.AreEqual(0, Items[0].Quality);
		}
	}
}
