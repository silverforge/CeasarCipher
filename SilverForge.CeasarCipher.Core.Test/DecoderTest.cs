using System;
using FluentAssertions;
using NUnit.Framework;

namespace SilverForge.CeasarCipher.Core.Test
{
	[TestFixture]
	public class DecoderTest
	{
		private readonly Encoder _encoder = new Encoder();
		private readonly Decoder _decoder = new Decoder();

		[Test]
		public void ExecuteTest()
		{
			const string key = "rabbit";
			const string text = "The quick brown fox jumps over the lazy dog.";
			var cipher = _encoder.Execute(text, key);

			cipher.Should().NotBeNullOrEmpty();

			var textBack = _decoder.Execute(cipher, key);

			textBack.Should().NotBeNullOrEmpty();
			textBack.ShouldBeEquivalentTo(text);
		}

		[Test]
		[ExpectedException(ExpectedException = typeof(ArgumentException))]
		public void Execute_Empty_Text_Valid_Key_Test()
		{
			var cipher = _decoder.Execute(string.Empty, "rabbit");
		}

		[Test]
		[ExpectedException(ExpectedException = typeof(ArgumentException))]
		public void Execute_Empty_Key_Valid_Text_Test()
		{
			var cipher = _decoder.Execute("rabbit", string.Empty);
		}
	}
}
