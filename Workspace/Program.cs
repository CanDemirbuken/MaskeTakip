using Business.Concrete;
using Entities.Concrete;

namespace Workspace
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Variables();

            SelamVer("Can");
            SelamVer("Hede");
            SelamVer("Bidi");
            SelamVer();

            int sonuc = Topla(4, 5);
            int sonuc2 = Topla();

            //Diziler / Arrays
            string ogrenci1 = "Can";
            string ogrenci2 = "Demir";
            string ogrenci3 = "Yaşar";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Can";
            ogrenciler[1] = "Demir";
            ogrenciler[2] = "Yaşar";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);


            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);

            Person person1 = new Person();
            person1.FirstName = "Can";
            person1.LastName = "Demirbüken";
            person1.DateOfBirthYear = 1998;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Yaşar";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara1", "İstanbul1", "İzmir1" };
            yeniSehirler1.Add("Adana1");

            foreach (string sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
        }

        private static void Variables()
        {
            string message = "Merhaba";
            double price = 10000;
            int number = 100;
            bool isAuth = false;

            string name = "Can";
            string surname = "Demirbüken";
            int birthdate = 1998;
            long nationalIdentity = 12345678910;

            Console.WriteLine(price * 1.18);

            Console.WriteLine(price * 1.18);
        }

        static void SelamVer(string isim = "noname")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }
    }

    //pascal casing
    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
