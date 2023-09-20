namespace TarabarianTranslator
{
	public class Translator
	{
		private string vowels;
		private string symbols;


		public Translator()
		{
			vowels = "ёуеыаоэяию";
			symbols = ".,/:\\; !@#$%^&*()_+=-?%";
        }

		private string getWord()
		{
			Console.Write("Введите слово -> ");
			return Console.ReadLine();
		}

		private char getSymbol()
		{
            Console.Write("Введите разделяющий символ -> ");
            return Convert.ToChar(Console.ReadLine());
        }

		private string translateToTarabarian(string ruWord, char symbol)
		{
			string tbWord = "";
			for (int i = 0; i < ruWord.Length; i++)
			{
				if (vowels.Contains(ruWord[i]))
				{
					tbWord += $"{ruWord[i]}{symbol}{ruWord[i]}";
				}
				else
					tbWord += ruWord[i];
			}
			return tbWord;
		}

		private string translateToRussian(string tbWord, char sym)
		{
			string ruWord = "";
			for (int i = 0; i < tbWord.Length; i++)
			{
				ruWord += tbWord[i];
				if (isVowel(tbWord[i]))
					i += 2;
			}
			return ruWord;

		}

		private (string, char) defineType(string word)
		{
			char symbol = (char)0;
			for (int i = 0; i < word.Length - 2; i++)
			{
				if (isVowel(word[i]) && word[i] == word[i + 2]) {
					symbol = word[i + 1];
					i += 2;
				} else if (isVowel(word[i]) && word[i] != word[i + 2])
                {
					return ("russian", (char)0);
				}
			}
			return ("tarabarian", symbol);
		}

		private bool isVowel(char letter)
		{
			return (vowels.Contains(letter));
		}

		public string translateWord(string word)
		{
			(string lang, char sym) = defineType(word);
			if (lang == "russian")
			{
				sym = getSymbol();
				return translateToTarabarian(word, sym);
			}
			return translateToRussian(word, sym);
		}
	}
}

