namespace csharp
{
	public class AgedBrieItemProcessor : IItemProcessor
	{
		public void Process(Item item)
		{
			if (item.Quality < 50)
			{
				item.Quality = item.Quality + 1;
			}

			item.SellIn = item.SellIn - 1;

			if (item.SellIn < 0 && item.Quality < 50)
			{
				item.Quality = item.Quality + 1;
			}
		}
	}
}
