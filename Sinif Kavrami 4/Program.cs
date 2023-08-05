// See https://aka.ms/new-console-template for more information

Console.WriteLine("Calisan Sayisi: {0}", Calisan.Calisansayisi );
Calisan calisan1 = new Calisan("Alp", "IK");
Console.WriteLine("Calisan Sayisi: {0}", Calisan.Calisansayisi);
Calisan calisan2 = new Calisan("Alp", "IK");
Calisan calisan3 = new Calisan("Alp", "IK");
Console.WriteLine("Calisan Sayisi: {0}", Calisan.Calisansayisi);


Console.WriteLine(islemler.topla(5, 6));




class Calisan
{
    private static int calisansayisi;

    public static int Calisansayisi { get => calisansayisi; set => calisansayisi = value; }

    private string ad;
    private string departman;

    static Calisan()
    {
        calisansayisi = 0;
    }

    public Calisan(string ad, string departman)
    {
        this.ad = ad;
        this.departman = departman;
        calisansayisi++;
    }
}

static class islemler
{
    public static long topla(int x, int y)
    {
        return (long)(x + y);
    }
}