using System;
namespace odev_1
{
    class program2
    {
        public static void Main(string[] args)
        {
            //GOREV-3 (Kullanicidan bir sayi alan ve o sayi kadar kelime isteyen sonunda girilen kelimeleri sondan basa yazdiran program)

            Console.WriteLine("kac adet kelime girmek istersiniz: ");
            string Input = Console.ReadLine();

            if (int.TryParse(Input, out int a) && a > 0)
            {
                string[] kelimeler = new string[a];

                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine($"{i + 1}. Kelime giriniz: ");
                    kelimeler[i] = Console.ReadLine();
                }

                Array.Reverse(kelimeler);
                Console.WriteLine("Girilen kelimeler sondan basa dogru: ");
                foreach (var kelime in kelimeler)
                {
                    Console.WriteLine(kelime);
                }

            }
            else
            {
                Console.WriteLine("HATALI");
            }

        }
    }
}