using System;
using NUnit.Framework;
using FluentAssertions;

namespace SilverForge.CeasarCipher.Core.Test
{
	[TestFixture]
	public class EncoderTest
	{
		private readonly Encoder _encoder = new Encoder();

		[Test]
		public void Execute_Test()
		{
			var cipher = _encoder.Execute("The quick brown fox jumps over the lazy dog.", "rabbit");

			cipher.Should().NotBeNullOrEmpty();
		}

		[Test]
		[ExpectedException(ExpectedException = typeof(ArgumentException))]
		public void Execute_Empty_Text_Valid_Key_Test()
		{
			var cipher = _encoder.Execute(string.Empty, "rabbit");
		}

		[Test]
		[ExpectedException(ExpectedException = typeof(ArgumentException))]
		public void Execute_Empty_Key_Valid_Text_Test()
		{
			var cipher = _encoder.Execute("rabbit", string.Empty);
		}
	}
}
