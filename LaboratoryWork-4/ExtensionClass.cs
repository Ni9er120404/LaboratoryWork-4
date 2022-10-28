using System.Text;
using System.Windows.Controls;

namespace LaboratoryWork_4
{
	internal static class ExtensionClass
	{
		private static readonly string _text = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

		public static string CaesarAlgorithm(this TextBox textBox, string text)
		{
			char[] chars1 = text.ToCharArray();
			char[] chars2 = _text.ToCharArray();
			StringBuilder stringBuilder = new();
			for (int i = 0; i < text.Length; i++)
			{
				for (int j = 0; j < chars2.Length; j++)
				{
					if (chars1[i] == chars2[j])
					{
						if (j == 32)
						{
							chars1[i] = chars2[0];
						}
						else
						{
							chars1[i] = chars2[j + 1];
							stringBuilder.Append(chars1[i]);
							break;
						}
					}
				}
			}

			return stringBuilder.ToString();
		}
	}
}