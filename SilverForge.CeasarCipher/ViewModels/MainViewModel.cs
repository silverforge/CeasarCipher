﻿using Caliburn.Micro;
using SilverForge.CeasarCipher.Interfaces;
using System.ComponentModel.Composition;

namespace SilverForge.CeasarCipher.ViewModels
{
	[Export(typeof(IMainViewModel))]
	public class MainViewModel : Conductor<IViewModel>, IMainViewModel
	{
	}
}
