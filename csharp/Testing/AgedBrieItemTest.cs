using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	[TestClass]
	public class AgedBrieItemTest
	{
		private const string ItemName = "Aged Brie";

		[TestMethod]
		public void UpdateShouldNotChangeName()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(ItemName, i => i.Name);
		}

		[TestMethod]
		public void UpdateShouldIncreaseQuality()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(21, i => i.Quality);
		}

		[TestMethod]
		public void UpdateShouldDecreaseSellIn()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(9, i => i.SellIn);
		}

		[TestMethod]
		public void UpdateShouldNotIncreaseQualityOverFifty()
		{
			new ItemTestHelper(ItemName, 10, 50)
				.VerifyUpdate(50, i => i.Quality);
		}
	}
}
