using System;
namespace odev_1
{
    class program1
    {
        public static void Main(string[] args)
        {
            //GOREV-2 (Kullanicidan 2 sayi iste, ilk sayi kadar sayi girmesini girdigi sayilar icinde ikinci sayi ile ayni olanları ve tam bolunenleri yazdıran program)

            Console.WriteLine("Lutfen sayi adedi giriniz: ");
            Console.WriteLine("Lutfen sayi adedi giriniz: ");

            string nInput = Console.ReadLine();
            string mInput = Console.ReadLine();

            if (int.TryParse(nInput, out int n) && int.TryParse(mInput, out int m) && n > 0 && m > 0)
            {
                int[] sayiDizisi2 = new int[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i + 1} Bir sayi giriniz: ");
                    string girilenSayi2 = Console.ReadLine();

                    if (int.TryParse(girilenSayi2, out int sayi) && sayi > 0)
                    {
                        sayiDizisi2[i] = sayi;
                    }
                    else
                    {
                        i--;
                    }
                }

                Console.WriteLine("Girilen sayilardan m'e esit veya tam bolunenler: ");
                foreach (var sayi in sayiDizisi2)
                {
                    if (sayi % m == 0)
                    {
                        Console.WriteLine(sayi);
                    }
                }
            }
            else
            {
                Console.WriteLine("Hatali");
            }

        }
    }
}