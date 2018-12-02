using System.Collections.Generic;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
				var item = Items[i];

				switch (item.Name)
				{
					case "Aged Brie":
						if (item.Quality < 50)
						{
							item.Quality = item.Quality + 1;
						}

						item.SellIn = item.SellIn - 1;

						if (item.SellIn < 0 && item.Quality < 50)
						{
							item.Quality = item.Quality + 1;
						}
						break;
					case "Backstage passes to a TAFKAL80ETC concert":
						if (item.Quality < 50)
						{
							item.Quality = item.Quality + 1;

							if (item.SellIn < 11 && item.Quality < 50)
							{
								item.Quality = item.Quality + 1;
							}

							if (item.SellIn < 6 && item.Quality < 50)
							{
								item.Quality = item.Quality + 1;
							}
						}

						item.SellIn = item.SellIn - 1;

						if (item.SellIn < 0)
						{
							item.Quality = item.Quality - item.Quality;
						}
						break;
					case "Sulfuras, Hand of Ragnaros":
						break;
					default:
						if (item.Quality > 0)
						{
							item.Quality = item.Quality - 1;
						}

						item.SellIn = item.SellIn - 1;

						if (item.SellIn < 0 && item.Quality > 0)
						{
							item.Quality = item.Quality - 1;
						}
						break;
				}
            }
        }
    }
}
