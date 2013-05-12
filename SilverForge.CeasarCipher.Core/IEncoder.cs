namespace SilverForge.CeasarCipher.Core
{
	public interface IEncoder
	{
		string Execute(string text, string key);
	}
}
