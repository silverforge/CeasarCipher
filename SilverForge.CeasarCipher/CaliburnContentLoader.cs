using System;
using System.Windows;
using FirstFloor.ModernUI.Windows;

namespace SilverForge.CeasarCipher
{
	public class CaliburnContentLoader : DefaultContentLoader
	{
		protected override object LoadContent(Uri uri)
		{
			var content = base.LoadContent(uri);
			if (content == null)
				return content;

			var vm = Caliburn.Micro.ViewModelLocator.LocateForView(content);
			if (vm == null)
				return content;

			if (content is DependencyObject)
			{
				Caliburn.Micro.ViewModelBinder.Bind(vm, content as DependencyObject, null);
			}
			return content;
		}
	}
}
