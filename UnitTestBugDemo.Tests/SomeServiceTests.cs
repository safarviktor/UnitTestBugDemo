using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBugDemo.Tests
{
	[TestClass]
	public class SomeServiceTests
	{
		[TestMethod]
		public void SomeServiceReturns()
		{
			var underTest = new SomeService();
			Assert.IsTrue(underTest.GetValue());
		}
	}
}