using System.ComponentModel.Composition;
using Caliburn.Micro;
using SilverForge.CeasarCipher.Core;
using SilverForge.CeasarCipher.Interfaces;

namespace SilverForge.CeasarCipher.ViewModels
{
	[Export]
	public class DecoderViewModel : Screen, IViewModel
	{
		private readonly IDecoder _decoder;
		private string _password;
		private string _text;

		[ImportingConstructor]
		public DecoderViewModel(IDecoder decoder)
		{
			_decoder = decoder;
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

		public void Decode()
		{
			var text = _decoder.Execute(_text, _password);
			Text = text;
		}

		public void Reset()
		{
			Password = string.Empty;
			Text = string.Empty;
		}
	}
}
