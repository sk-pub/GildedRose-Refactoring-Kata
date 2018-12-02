using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	[TestClass]
	public class BackstagePassesItemTest
	{
		private const string ItemName = "Backstage passes to a TAFKAL80ETC concert";

		[TestMethod]
		public void UpdateShouldNotChangeName()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(ItemName, i => i.Name);
		}

		[TestMethod]
		public void UpdateShouldIncreaseQuality()
		{
			new ItemTestHelper(ItemName, 15, 20)
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
			new ItemTestHelper(ItemName, 15, 50)
				.VerifyUpdate(50, i => i.Quality);
		}

		[TestMethod]
		public void UpdateShouldIncreaseQualityByTwoIfSellInIsLessThanTen()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(22, i => i.Quality)
				.VerifyUpdate(24, i => i.Quality);
		}

		[TestMethod]
		public void UpdateShouldIncreaseQualityByThreeIfSellInIsLessThanFive()
		{
			new ItemTestHelper(ItemName, 5, 20)
				.VerifyUpdate(23, i => i.Quality)
				.VerifyUpdate(26, i => i.Quality);
		}

		[TestMethod]
		public void UpdateShouldDecreaseQualityToZeroAfterTheConcert()
		{
			new ItemTestHelper(ItemName, 0, 20)
				.VerifyUpdate(0, i => i.Quality);
		}
	}
}
