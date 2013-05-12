namespace SilverForge.CeasarCipher.Core
{
	public interface IDecoder
	{
		string Execute(string text, string key);
	}
}
