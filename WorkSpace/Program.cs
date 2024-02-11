using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        // Degiskenler();

      /*  SelamVer("mert");
        SelamVer();
        Topla(3, 6);
        Topla();

        // diziler / Arrays
        string[] ogrenciler = new string[3];
        ogrenciler[0] = "engin";
        ogrenciler[1] = "ali";
        ogrenciler[2] = "osman";

     

        // dizileri gezer
        foreach (string ogrenci in ogrenciler)
        {
            Console.WriteLine(ogrenci);
        }

        List<string> yenisehirler1 = new List<string> { "Ankara", "İstanbul", "izmir" };
        yenisehirler1.Add("Bursa");
        foreach (string yenisehir in yenisehirler1)
        {
            Console.WriteLine(yenisehir);
        }
      */




        Person person = new Person();
        person.FirstName = "Mert Can";
        person.LastName = "İnam";
        person.NationalIdentity = 116565;
        person.DateOfBirthYear = 2000;

        PttManager pttManager = new PttManager(new PersonManager());

        pttManager.GiveMask(person);







    }

    // = " x" x burada default parametre , parametresiz çağırılan yerlerde x diye kullanılır.
    static void SelamVer(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba " + isim);
    }
    static int Topla( int x = 5 , int y = 7 )
    {
        int sonuc = x + y ;
        Console.WriteLine("Toplam "+ sonuc.ToString() );
        return sonuc ;
    }


}