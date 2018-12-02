using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing
{
	[TestClass]
	public class ItemTest
	{
		private const string ItemName = "foo";

		[TestMethod]
		public void UpdateShouldNotChangeName()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(ItemName, i => i.Name);
		}

		[TestMethod]
		public void UpdateShouldDecreaseQuality()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(19, i => i.Quality);
		}

		[TestMethod]
		public void UpdateShouldDecreaseSellIn()
		{
			new ItemTestHelper(ItemName, 10, 20)
				.VerifyUpdate(9, i => i.SellIn);
		}

		[TestMethod]
		public void UpdateShouldDecreaseQualityTwiceIfSellInLessThanZero()
		{
			new ItemTestHelper(ItemName, 0, 20)
				.VerifyUpdate(18, i => i.Quality)
				.VerifyUpdate(16, i => i.Quality);
		}

		[TestMethod]
		public void UpdateShouldNotDecreaseQualityBelowZero()
		{
			new ItemTestHelper(ItemName, 0, 0)
				.VerifyUpdate(0, i => i.Quality);
		}
	}
}
