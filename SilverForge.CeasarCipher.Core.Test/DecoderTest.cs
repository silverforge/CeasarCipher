using FluentAssertions;
using NUnit.Framework;

namespace SilverForge.CeasarCipher.Core.Test
{
	[TestFixture]
	public class DecoderTest
	{
		[Test]
		public void ExecuteTest()
		{
			const string key = "rabbit";
			//const string text = "The quick brown fox jumps over the lazy dog.";
			const string text = "Alma";
			var encoder = new Encoder();
			var cipher = encoder.Execute(text, key);

			cipher.Should().NotBeNullOrEmpty();

			var decoder = new Decoder();
			var textBack = decoder.Execute(cipher, key);

			textBack.Should().NotBeNullOrEmpty();
			textBack.ShouldBeEquivalentTo(text);
		}
	}
}
