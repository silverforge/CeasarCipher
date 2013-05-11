using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SilverForge.CeasarCipher.Core
{
	interface IDecoder
	{
		string Execute(string text, string key);
	}
}
