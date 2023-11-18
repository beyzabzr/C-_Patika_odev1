using System;
namespace odev_1
{
    class program3
    {
        public static void Main(string[] args)
        {
            // GOREV-4 (Kullanıcın girdigi cumlede ki toplam kelime ve harf sayisini yazdiran program)

            Console.WriteLine("Lutfen bir cumle giriniz: ");
            string cumle = Console.ReadLine();

            int harfSayisi = 0;
            int rakamSayisi = 0;

            foreach (char karakter in cumle)
            {
                if (char.IsLetter(karakter)) //IsLetter char degiskeni icinde harf olup olmadigini kontrol eder.
                {
                    harfSayisi++;
                }
                else if (char.IsDigit(karakter)) //ISDigit char degiskeni icinde rakam olup olmadigini kontrol eder.
                {
                    rakamSayisi++;
                }
            }

            Console.WriteLine($"Toplam harf sayisi: {harfSayisi}");
            Console.WriteLine($"Toplam rakam sayisi: {rakamSayisi}");

        }
    }
}