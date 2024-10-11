using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double Değişkenler

            //double number;
            //number = 4.15;
            //Console.WriteLine(number);

            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();

            //double applePrice, orangePrice, potatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //potatoPrice = 9.74;

            //Console.WriteLine("--- Elma birim fiyatı:" + applePrice + " TL");
            //Console.WriteLine("--- Portakal birim fiyatı:" + orangePrice + " TL");
            //Console.WriteLine("--- Patates birim fiyatı:" + potatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, potatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //potatoGram = 4.859;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim fiyat: " + applePrice + "- Gramaj: " + appleGram + " toplam tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim fiyat: " + orangePrice + "- Gramaj: " + orangeGram + " toplam tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim fiyat: " + potatoPrice + "- Gramaj: " + potatoGram + " toplam tutar: " + potatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + potatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş toplam tutarı: " + shoppingTotalPrice + " TL");


            #endregion

            #region char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri string Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC kimlik no: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Yolcu Bİlgileri");
            //Console.WriteLine("TC kimlik no: " + passengerIdentityNumber + " Ad Soyad: " + passengerName + " " + passengerSurname + " İlçe/İL: " + passengerDistrict + "/" + passengerCity + " Yaş: " + passengerAge );

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, tvCount;

            //Console.Write("Lütfen alınan ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen alınan bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen alınan televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödenecek tutar: " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("Birinci sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("İkinci sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Üçüncü sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
