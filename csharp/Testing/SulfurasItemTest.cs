using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	[TestClass]
	public class SulfurasItemTest
	{
		private const string ItemName = "Sulfuras, Hand of Ragnaros";

		[TestMethod]
		public void UpdateShouldNotChangeName()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(ItemName, i => i.Name);
		}

		[TestMethod]
		public void UpdateShouldNotChangeQuality()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(20, i => i.Quality);
		}

		[TestMethod]
		public void UpdateShouldNotChangeSellIn()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(10, i => i.SellIn);
		}

		[TestMethod]
		public void UpdateShouldNotDecreaseQualityBelowZero()
		{
			new ItemTestHelper(ItemName, 0, 0)
				.VerifyUpdate(0, i => i.Quality);
		}
	}
}
