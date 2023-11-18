using System;
namespace odev_1
{
    class program
    {
        public static void Main(string[] args)
        {

            //GOREV-1 (Kullanicinin girdiği ve girdiği çift sayilari yazdiran program)
            Console.Write("Pozitif bir sayi adedi girin: ");

            string sayiAdedi = Console.ReadLine();

            if (int.TryParse(sayiAdedi, out int x) && x > 0)
            {
                int[] sayiDizisi = new int[x];
                for (int i = 0; i < x; i++)
                {
                    Console.Write($"{i + 1}. sayi giriniz");
                    string girilenSayi = Console.ReadLine();

                    if (int.TryParse(girilenSayi, out int y) && y > 0)
                    {
                        sayiDizisi[i] = y;
                    }
                    else
                    {
                        Console.WriteLine($"Gecerli ya da pozitif bir sayi girmediniz {i + 1}");
                        i--;
                    }
                }

                Console.WriteLine("Girdiginiz cift sayilar: ");
                foreach (var y in sayiDizisi)
                {
                    if (y % 2 == 0)
                    {
                        Console.WriteLine(y);
                    }
                }
            }
            else
            {
                Console.WriteLine("Gecerli sayi girmediniz");

            }
        }
    }
}