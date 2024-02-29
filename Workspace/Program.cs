
using Business.Concrete;
using Entities.Concrete;

namespace Workspace;

public class Program
{
    static void Main(string[] args)
    {
       // NewMethod();
       // SelamVer("engin");
       //SelamVer();

 
        //string[] sehirler1 = ["ankara", "izmir", "adana"];

        //foreach (string sehir in sehirler1)
        //{
        //    Console.WriteLine(sehir);
        //}

        //List<string> sehirler2 = new List<string> { "ankara", "izmir", "adana" };//type safe tip güvenli yapı generic yapı
        //sehirler2.Add("istanbul");
        //Console.WriteLine(sehirler2[3]);
        Citizen citizen1 = new Citizen();
        citizen1.FirstName = "Engin";
        citizen1.LastName = "Demiroğ";
        citizen1.NationalIdentity = 123;

        Citizen citizen2 = new Citizen();
        citizen2.FirstName = "Gülfem";
        citizen2.LastName = "Kavak";
        citizen2.DateOfBirthYear = 1998;
        citizen2.NationalIdentity = 27329361902;
        PttManager pttManager = new PttManager(new CitizenManager());
        pttManager.GiveMask(citizen1);

        pttManager.GiveMask(citizen2);

    }

    static void SelamVer(string isim="_")
    {
        Console.WriteLine("Merhaba "+isim);
    }


    private static void NewMethod()
    {
        string ad = "Engin";
        string soyad = "Demirog";
        int dogumYili = 1985;
        long tcNo = 12345678910;

    }

    
}

//Pascal casing
public class Vatandas
{
    public int dogumYili { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public long TcNo { get; set; }

    
}


//SOLID
//Single responsibility her katman her class hatta her if bloğu sadece ve sadece 1 işi yapmalı
//Open/closed principle gelişime açık değişime kapalı(var olana dokunmadan)
//Liskov bir sınıf alt sınıfıyla değiştirildiğinde aynı davranışı sergilemelidir
//Interface segregation principle arayüz ayrımı prensibi 
//Dependency injection yazılım varlıkları (class, modül, fonksiyon vb.) somut sınıflara değil, soyutlamalara bağımlı olmalıdır.