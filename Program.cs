//DÖNGÜLER VE DİZİLER

//donguler birbirine benzeyen islemleri tekrar etmek için kullanılır
//i= syaçtır

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//diziler

string[] kurslar = new string[] { "birinci kurs", "ikinci kurs", "ucuncu kurs" };
for (int j=0; j<kurslar.Length; j++)
{
    Console.WriteLine(kurslar[j]);
}

//dizi temelli yapıları tek tek dönmeye yarar
//kursları dolaş
//yukarıdaki fonksiyonla aunı çıktıyı verir
//"kurs" ismi her diziyi dolaşmak için verilen takma isimdir

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}