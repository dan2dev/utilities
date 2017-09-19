using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dan2Dev.Utilities;

namespace Dan2Dev.Tests {
	[TestClass]
	public class StringUtil {
		[TestMethod]
		public void CamelCase() {
			Assert.AreEqual("Dan2Dev", "dan-2-dev".ToPascalCase());
			Assert.AreEqual("dan2Dev", "dan-2-dev".ToCamelCase());
			Assert.AreEqual("loremIpsumDolorSitAmet", "Lorem-IpsUm-Dolor_sit.amet".ToCamelCase());
			Assert.AreEqual("LoremIpsumDolorSitAmet", "Lorem-IpsUm-Dolor_sit.amet".ToPascalCase());
		}
	}
}
