using System.ComponentModel.Composition;
using Caliburn.Micro;
using SilverForge.CeasarCipher.Core;
using SilverForge.CeasarCipher.Interfaces;

namespace SilverForge.CeasarCipher.ViewModels
{
	[Export]
	public class EncoderViewModel : Screen, IViewModel
	{
		private readonly IEncoder _encoder;
		private string _password;
		private string _text;

		[ImportingConstructor]
		public EncoderViewModel(IEncoder encoder)
		{
			_encoder = encoder;
		}

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
			var cipher = _encoder.Execute(_text, _password);
			Text = cipher;
		}

		public void Reset()
		{
			Password = string.Empty;
			Text = string.Empty;
		}
	}
}
