using System.ComponentModel.Composition;
using Caliburn.Micro;
using SilverForge.CeasarCipher.Interfaces;

namespace SilverForge.CeasarCipher.ViewModels
{
	[Export]
	public class DecoderViewModel : Screen, IViewModel
	{
		private string _password;
		public string Password
		{
			get { return _password; }
			set
			{
				_password = value;
				NotifyOfPropertyChange(() => Password);
			}
		}
	}
}
