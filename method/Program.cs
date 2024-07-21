static void sarkı_sozu()
{
    Console.WriteLine("Ben sigara dumanının altında\r\nYana yana en sonunda kül oldum\r\nSen kibritin hiç yanmayan ucunda\r\nBirinin hayatından geçmiş oldun");
}

sarkı_sozu();


static int ikiye_bolumunden_kalan()
{
    Random rand = new Random();
    return (rand.Next() % 2);

}
ikiye_bolumunden_kalan();
//Aşağıdakinden kontrol edilebilir
//Console.WriteLine(ikiye_bolumunden_kalan());

Console.WriteLine("Lütfen ilk sayıyı giriniz");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı giriniz");
int b = Convert.ToInt32(Console.ReadLine());
static int iki_sayının_carpımı(int sayi1,int sayi2)
{
    return sayi1 * sayi2;

}

iki_sayının_carpımı(a,b);
//Aşağıdakinden kontrol edilebilir
//Console.WriteLine(iki_sayının_carpımı(4, 5));


Console.WriteLine("Lütfen isim giriniz");
string isim = Console.ReadLine();
Console.WriteLine("Lütfen soyisim giriniz");
string soyisim = Console.ReadLine();
static void isim_soyisim(string isim, string soyisim)
{

    Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");


}
isim_soyisim(isim,soyisim);
