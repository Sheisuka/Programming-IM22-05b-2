using System;


namespace TarabarianTranslator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var translator = new Translator();
            Console.WriteLine("Введите текст, чтобы закончить не вводите ничего");
            string text = Console.ReadLine();
            while (text.Length != 0)
            {
                Console.WriteLine(translator.translateWord(text));
                text = Console.ReadLine();
            }
            Console.WriteLine("Завершение");
        }
    }
}