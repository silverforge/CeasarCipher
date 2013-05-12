using System;
using System.Windows;
using Caliburn.Micro;
using FirstFloor.ModernUI.Windows;

namespace SilverForge.CeasarCipher
{
	public class CaliburnContentLoader : DefaultContentLoader
	{
		protected override object LoadContent(Uri uri)
		{
			var content = base.LoadContent(uri);
			if (content == null)
				return null;

			var vm = ViewModelLocator.LocateForView(content);
			if (vm == null)
				return content;

			if (content is DependencyObject)
				ViewModelBinder.Bind(vm, content as DependencyObject, null);

			return content;
		}
	}
}
