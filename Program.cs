internal class Program
{
    public static void Main(string[] args)
    {
        //out parametreler
        string sayi="999";

        bool sonuc=int.TryParse(sayi, out int outSayi);
        if(sonuc)
        {
            Console.WriteLine("Basarili!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Basarisiz!");
        }

        Topla(4, 7,out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        //Metot Overloading
        int ifade= 999;
        EkranaYazdir(ifade);
        EkranaYazdir(ifade.ToString());
        EkranaYazdir("aysegul","eski");

        //Metot imzasi=metotAdi + parametreSayisi+ parametreTipi
    }

    public static int Topla(int a, int b, out int toplam)
    {
        return toplam=a+b;
    }
    public static void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public static void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public static void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    }

}