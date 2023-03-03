//Girilen 10 sayı içinde pozitif ve tek olan sayıların çarpımını yazdıran
//int sayi;
//int sonuc = 1;
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine("{0}.Sayıyı Giriniz;", i);
//    sayi = Convert.ToInt32(Console.ReadLine());
//    if ((sayi > 0) && (sayi % 2 == 1))
//    {
//        sonuc *= sayi;
//    }

//}

//Console.WriteLine("Pozitif ve tek sayıların çarpımı : " + sonuc);
//Console.ReadKey();
Console.Write("1. Sayıyı girin:");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Sayıyı girin:");
int sayi2 = Convert.ToInt32(Console.ReadLine());
for (int i = sayi1; i <= sayi2; i++)
{
    Console.WriteLine(i);
}
Console.ReadKey();

