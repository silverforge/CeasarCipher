﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilverForge.CeasarCipher.Core
{
	
	public class Encoder : IEncoder
	{
		public string Execute(string text, string key)
		{
			if (string.IsNullOrEmpty(text))
				return text;
			if (string.IsNullOrEmpty(key))
				throw new ArgumentNullException("key", "Key is not defined!");

			
			var retValue = new byte[] {};
			var keyposition = 0;
			var textBytes = Encoding.UTF8.GetBytes(text);
			var keyBytes = Encoding.UTF8.GetBytes(key);

			for(var i = 0; i < text.Length; i++)
			{
				if (keyposition >= key.Length)
					keyposition = 0;

				int amount = textBytes[i] + keyBytes[keyposition];
				if (amount > 255)
					amount -= 255;

				retValue[i] = (byte)amount;

				keyposition++;
			}

			return Encoding.UTF8.GetChars(retValue).ToString();
		}
	}
}