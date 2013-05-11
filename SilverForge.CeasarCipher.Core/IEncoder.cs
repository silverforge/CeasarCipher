using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SilverForge.CeasarCipher.Core
{
	public interface IEncoder
	{
		string Execute(string text, string key);
	}
}
