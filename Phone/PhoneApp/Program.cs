using Phone.Domain.Abstractions;
using Phone.Domain.Entities;
using Phone.Domain.Services;
using System;

PhoneService phoneService = new();

Özellikler özellikler = new();
özellikler.Model = "Iphone ";
özellikler.Açıklama = "13 128 GB";
özellikler.Kutuİçeriği = "USB-C Kablosu,SIM Çıkartma İğnesi";

Batarya batarya = new();
batarya.Kapasitesi = 3227;
batarya.Şarj = "USB Kablosu";
batarya.Teknolojisi = "Lithium Ion (Li-Ion)";

Ekran ekran = new();
ekran.Boyutu = 6.1;
ekran.PikselYoğunluğu =460;
ekran.YenilemeHızı = 60;

Kamera kamera= new();
kamera.ArkaKameraÇözünürlük ="12";
kamera.Çözünürlük ="12";
kamera.OdakUzaklıgı =26;

Console.WriteLine("Ürünün Özellikleri");
Console.WriteLine($"Markası:{özellikler.Model}\n Model: {özellikler.Açıklama}\n Kutu İçeriği: {özellikler.Kutuİçeriği}\n ");

Console.WriteLine("Batarya");
Console.WriteLine($"Batarya Kapasitesi:{batarya.Kapasitesi} mAh\n Şarj: {batarya.Şarj}\n Batarya Teknolojisi:{batarya.Teknolojisi}\n ");

Console.WriteLine("Ekran");
Console.WriteLine($"Ekran Boyutu:{ekran.Boyutu}inç \n Piksel Yoğunluğu:{ekran.PikselYoğunluğu} PPI \n Ekran Yenileme Hızı:{ekran.YenilemeHızı} Hz \n");

Console.WriteLine("Kamera");
Console.WriteLine($"Ön Kamera Çözünürlük:{kamera.Çözünürlük} MP\n Arka Kamera Çözünürlük:{kamera.ArkaKameraÇözünürlük} MP\n Odak Uzaklığı:{kamera.OdakUzaklıgı} mm\n");