namespace csharp
{
	public class ItemProcessor : IItemProcessor
	{
		public void Process(Item item)
		{
			if (item.Quality > 0)
			{
				item.Quality = item.Quality - 1;
			}

			item.SellIn = item.SellIn - 1;

			if (item.SellIn < 0 && item.Quality > 0)
			{
				item.Quality = item.Quality - 1;
			}
		}
	}
}
