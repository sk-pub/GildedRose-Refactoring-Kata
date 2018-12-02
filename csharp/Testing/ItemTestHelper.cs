using System;
using System.Collections.Generic;

using csharp;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	public class ItemTestHelper
	{
		private readonly GildedRose _app;
		private readonly List<Item> _items;

		public ItemTestHelper(string itemName, int sellIn, int quality)
		{
			_items = new List<Item> { new Item { Name = itemName, SellIn = sellIn, Quality = quality } };
			_app = new GildedRose(_items);
		}

		public ItemTestHelper VerifyUpdate<T>(
			T expectedValueAfterUpdate,
			Func<Item, T> actualValueAfterUpdate)
		{
			_app.UpdateQuality();
			Assert.AreEqual(expectedValueAfterUpdate, actualValueAfterUpdate(_items[0]));

			return this;
		}
	}
}
