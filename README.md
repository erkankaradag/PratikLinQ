# PratikLinQ

Bu proje, **C# LINQ** kullanarak bir **sayı listesi** üzerinde çeşitli sorgular gerçekleştirmektedir.

## 🚀 Özellikler
- **Çift Sayılar**: Listedeki çift sayılar filtrelenir.
- **Tek Sayılar**: Listedeki tek sayılar filtrelenir.
- **Negatif Sayılar**: Negatif sayılar listelenir.
- **Pozitif Sayılar**: Pozitif sayılar listelenir.
- **Belirli Aralıktaki Sayılar**: 30 ile 45 arasında olan sayılar seçilir.
- **Sayıların Karesi**: Listedeki her bir sayının karesi hesaplanır.

## 🛠 Kullanılan Teknolojiler
- **C#**
- **.NET Framework**
- **LINQ (Language Integrated Query)**

## 📌 Kod Açıklaması

```csharp
List<int> sayilar = new List<int> { -25, 30, 92, 65, -51, 38, 43, -86, 99, 100 };

var ciftSayilar = sayilar.Where(x => x % 2 == 0);
var tekSayilar = sayilar.Where(y => y % 2 != 0);  
var negatifSayilar = sayilar.Where(z => z < 0);
var pozitifSayilar = sayilar.Where(w => w > 0);
var kosul = sayilar.Where(k => k > 30 && k < 45);
var kareler = sayilar.Select(x => x * x);
```

## 📥 Kurulum ve Kullanım

1. **Projeyi klonlayın:**
   ```sh
   git clone https://github.com/kullanici/pratik-linq.git
   ```
2. **Visual Studio veya herhangi bir C# IDE’sinde açın.**
3. **Programı çalıştırın.**

## 📝 Lisans
Bu proje **MIT Lisansı** altında sunulmaktadır.

