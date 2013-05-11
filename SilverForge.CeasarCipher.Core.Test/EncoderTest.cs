using NUnit.Framework;
using FluentAssertions;

namespace SilverForge.CeasarCipher.Core.Test
{
	[TestFixture]
	public class EncoderTest
	{
		[Test]
		public void ExecuteTest()
		{
			var encoder = new Encoder();
			var cipher = encoder.Execute("The quick brown fox jumps over the lazy dog.", "rabbit");

			cipher.Should().NotBeNullOrEmpty();
		}
	}
}
