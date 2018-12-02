using System;
using System.Collections.Generic;
using System.Text;

using ApprovalTests;
using ApprovalTests.Reporters;

using csharp;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	[TestClass]
	public class ApprovalTest
	{
		[TestMethod]
		[UseReporter(typeof(DiffReporter))]
		public void GoldenMaster()
		{
			var actualContent = new StringBuilder();
			actualContent.AppendLine("OMGHAI!");

			IList<Item> Items = new List<Item>{
				new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
				new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
				new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
				new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
				new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 15,
					Quality = 20
				},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 10,
					Quality = 49
				},
				new Item
				{
					Name = "Backstage passes to a TAFKAL80ETC concert",
					SellIn = 5,
					Quality = 49
				},
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
			};

			var app = new GildedRose(Items);


			for (var i = 0; i < 31; i++)
			{
				actualContent.AppendLine("-------- day " + i + " --------");
				actualContent.AppendLine("name, sellIn, quality");
				for (var j = 0; j < Items.Count; j++)
				{
					actualContent.AppendLine(Items[j].ToString());
				}
				actualContent.AppendLine("");
				app.UpdateQuality();
			}

			Approvals.Verify(actualContent);
		}
	}
}
