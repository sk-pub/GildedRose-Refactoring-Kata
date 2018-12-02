using System.Collections.Generic;

namespace csharp
{
	public static class ItemProcessingFactory
	{
		private static readonly IItemProcessor _defaultProcessor = new ItemProcessor();

		private static readonly Dictionary<string, IItemProcessor> _itemTypes =
			new Dictionary<string, IItemProcessor>
			{
				{ "Aged Brie", new AgedBrieItemProcessor() },
				{ "Backstage passes to a TAFKAL80ETC concert", new BackstagePassesItemProcessor() },
				{ "Sulfuras, Hand of Ragnaros", new SulfurasItemProcessor() },
				{ "Conjured Mana Cake", new ConjuredItemProcessor() }
			};

		public static void Process(Item item)
		{
			GetProcessor(item.Name).Process(item);
		}

		private static IItemProcessor GetProcessor(string itemName)
		{
			if (_itemTypes.TryGetValue(itemName, out IItemProcessor processor))
				return processor;

			return _defaultProcessor;
		}
	}
}
