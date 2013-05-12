﻿using System.ComponentModel.Composition;
using System.Text;
using CuttingEdge.Conditions;

namespace SilverForge.CeasarCipher.Core
{
	[Export(typeof(IDecoder))]
	public class Decoder : IDecoder
	{
		private readonly Encoding _enc = Encoding.Unicode;

		public string Execute(string text, string key)
		{
			Condition.Requires(text, "text").IsNotNullOrEmpty();
			Condition.Requires(key, "key").IsNotNullOrEmpty();

			var keyposition = 0;
			var textBytes = _enc.GetBytes(text);
			var keyBytes = _enc.GetBytes(key);
			var retValue = new byte[textBytes.Length];

			for (var i = 0; i < textBytes.Length; i++)
			{
				if (keyposition >= key.Length)
					keyposition = 0;

				var amount = textBytes[i] - keyBytes[keyposition];
				if (amount < 0)
					amount += 255;

				retValue[i] = (byte)amount;

				keyposition++;
			}

			Condition.Ensures(retValue.Length, "length of retValue").IsEqualTo(textBytes.Length);

			return _enc.GetString(retValue);
		}
	}
}
