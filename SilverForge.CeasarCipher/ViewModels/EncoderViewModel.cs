using System.ComponentModel.Composition;
using Caliburn.Micro;
using SilverForge.CeasarCipher.Interfaces;

namespace SilverForge.CeasarCipher.ViewModels
{
	[Export]
	public class EncoderViewModel : Screen, IViewModel
	{
		private string _password;
		private string _text;

		public string Password
		{
			get { return _password; }
			set
			{
				if (value == _password) return;
				_password = value;
				NotifyOfPropertyChange(() => Password);
			}
		}

		public string Text
		{
			get { return _text; }
			set
			{
				if (value == _text) return;
				_text = value;
				NotifyOfPropertyChange(() => Text);
			}
		}

		public void Encode()
		{

		}

		public void Reset()
		{

		}
	}
}
