using System;


namespace TarabarianTranslator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var translator = new Translator();
            Console.WriteLine("Введите текст, чтобы закончить не вводите ничего");
            while (true)
                {
                    string text = Console.ReadLine();
                    if (text.Length == 0)
                        break;
                    Console.WriteLine(translator.translateWord(text));
                }
        }
    }
}