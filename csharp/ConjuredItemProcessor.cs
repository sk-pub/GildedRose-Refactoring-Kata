namespace csharp
{
	public class ConjuredItemProcessor : IItemProcessor
	{
		public void Process(Item item)
		{
			if (item.Quality > 0)
			{
				item.Quality = item.Quality - 2;
			}

			item.SellIn = item.SellIn - 1;

			if (item.SellIn < 0 && item.Quality > 0)
			{
				item.Quality = item.Quality - 2;
			}
		}
	}
}
