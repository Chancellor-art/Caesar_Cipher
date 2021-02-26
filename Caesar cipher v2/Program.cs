using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_cipher_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n░██╗░░░░░░░██╗██████╗░  ███████╗░█████╗░██████╗░");
            Console.WriteLine("░██║░░██╗░░██║██╔══██╗  ██╔════╝██╔══██╗██╔══██╗");
            Console.WriteLine("░╚██╗████╗██╔╝██████╔╝  █████╗░░███████║██████╔");
            Console.WriteLine("░░████╔═████║░██╔═══╝░  ██╔══╝░░██╔══██║██╔═══╝░");
            Console.WriteLine("░░╚██╔╝░╚██╔╝░██║░░░░░  ███████╗██║░░██║██║░░░░░");
            Console.WriteLine("░░░╚═╝░░░╚═╝░░╚═╝░░░░░  ╚══════╝╚═╝░░╚═╝╚═╝░░░░░");

            string text;
            int j = 0;
            int k = 0;
            bool dio = true;

            char[] alfavit = {'а', 'б', 'в', 'г', 'д', 'е', 'є', 'ж', 'з', 'и',
               'ї', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с',
               'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ю', 'я'};

            char[] alfavit_cesar = {'г', 'д', 'е', 'є', 'ж', 'з', 'и',
               'ї', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с',
               'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ь', 'ю', 'я', 'а', 'б', 'в'};

            char r1 = ' ';

            Console.Write("\nВведіть текст для шифрування: ");
            text = Console.ReadLine();

            char[] word = text.ToCharArray();

            Console.Write("Алфавіт: ");
            Console.WriteLine(alfavit);
            Console.Write($"Ключ:    ");
            Console.WriteLine(alfavit_cesar);
            Console.Write("\nКодування завершене:   ");

            while (dio)
            {
                foreach (char hz in alfavit)
                {
                    k++;
                    if (word[j] == hz)
                    {
                        if (k > alfavit.Length - 1) k = alfavit_cesar.Length;
                        Console.Write(alfavit_cesar[k-1]);
                        j++;
                    }
                    else if(word[j] == r1)
                    {
                        Console.Write(r1);
                        j++;
                    }

                    if (j == word.Length)
                    {
                        j = word.Length - 1;
                        k = 0;
                        dio = false;
                    }
                }
                k = 0;
            }
            Console.WriteLine($"\nДекодування завершене: {text}");
            Console.ReadKey();
        }
    }
}
