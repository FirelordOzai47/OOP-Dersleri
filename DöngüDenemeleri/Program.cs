//Girilen 10 sayı içinde pozitif ve tek olan sayıların çarpımını yazdıran
int sayi;
int sonuc = 1;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("{0}.Sayıyı Giriniz;", i);
    sayi = Convert.ToInt32(Console.ReadLine());
    if ((sayi > 0) && (sayi % 2 == 1))
    {
        sonuc *= sayi;
    }
    
}

Console.WriteLine("Pozitif ve tek sayıların çarpımı : " + sonuc);
Console.ReadKey();
    
