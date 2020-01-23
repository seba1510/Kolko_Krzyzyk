using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kolko_Krzyzyk;
using Kolko_Krzyzyk_Library;

namespace Kolko_Krzyzyk_test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Game test = new Game();
			test.RandomList(10, 30);


			OnePlayer test1 = new OnePlayer();
		}
	}
}
