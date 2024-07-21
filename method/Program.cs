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
Console.WriteLine(ikiye_bolumunden_kalan());


static int iki_sayının_carpımı(int a,int b)
{

    return a * b;

}
iki_sayının_carpımı(4, 5);
//Aşağıdakinden kontrol edilebilir
Console.WriteLine(iki_sayının_carpımı(4, 5));

static void isim_soyisim(string isim, string soyisim)
{

    Console.WriteLine($"Hoş Geldiniz {isim} {soyisim}");


}
isim_soyisim("Sıla", "Sevinç");