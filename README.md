#  📍 01_ Main Subjects

**Proje Amacı**: C# dilindeki temel programlama konularını öğretmek.

**Yazdırma Komutları**: Kullanıcıya bilgi vermek için Console.Write ve Console.WriteLine kullanımı.

**String Değişkenler**: Müşteri bilgilerini depolamak ve yönetmek için string veri tipi kullanımı.

**Integer Değişkenler**: Ürün fiyatları ve siparişlerin hesaplanması için integer veri tipi ile işlemler.

**Hedef Kitle**: C#'a yeni başlayanlar için temel kavramları öğrenme ve uygulama imkanı.

---

# 📍 02_Variables


**Proje Amacı:** C# dilinde değişken türlerini ve kullanıcıdan veri almayı öğretmek.
    
**Double Değişkenler:** Ürün fiyatları ve gramaj hesaplamaları.
    
**Char Değişkenler:** Tek karakter depolama.
    
**String Girdisi:** Yolcu bilgileri (isim, soyisim, yaş, adres, TC kimlik numarası) alma.
    
**Integer Girdisi:** Ürün sayıları ile toplam fiyat hesaplama.
    
**Double Girdisi:** Sınav notları ile ortalama hesaplama.

**Char Girdisi:** Cinsiyet seçimi.

---

# 📍 03_MakingDecision

----------

**Amaç:** C# dilinde karar yapıları ile kullanıcı etkileşimini öğretmek.
    
**If-Else:** Şifre, başkent, sayı, sınav notu, şehir ve kullanıcı adı doğrulama.

**Mod İşlemleri:** Sayının 5'e bölümünden kalanı ve çift/tek kontrolü.

**Char Değişkenleri:** Takım sembolüne göre isim belirleme.

**Örnek Uygulama:** Restoran menüsü seçimi.

**Switch-Case:** Ay numarasına göre ay ismi ve hesap makinesi işlemleri.

---


# 📍 04_Loops

Bu C# kodu, döngülerin kullanımını göstermek için tasarlanmıştır. For döngüsü, 0'dan 9'a kadar sayıları yazdırırken, while döngüsü kullanıcıdan alınan sayıları -1 girilene kadar yazdırır. Do-while döngüsü, kullanıcıdan bir sayı alır ve bu sayıyı en az bir kez yazar, ardından -1 ile sonlanır. Son olarak, foreach döngüsü bir dizi içindeki isimleri sırayla konsola yazdırır. Bu kod, döngülerin program akışını kontrol etme ve tekrarlayan işlemleri gerçekleştirme amacını taşır.


# 📍 05_Loop With Stars


**Alt Alta 10 Yıldız**: Bir for döngüsü ile her satıra bir yıldız yazdırır.

**Yan Yana 10 Yıldız**: Bir for döngüsü ile aynı satıra 10 yıldız yazdırır.

**10x10 Yıldız**: İki iç içe for döngüsü kullanarak, 10 satırda her satıra 10 yıldız yazdırır.

**Dik Üçgen**: Bir dik üçgen oluşturur; her satırda bir artan sayıda yıldız yazdırılır.

**Ters Dik Üçgen**: Ters dik üçgen oluşturur; her satırda azalan sayıda yıldız yazdırılır.

**Dik ve Ters Üçgen Beraber**: Hem dik hem de ters üçgeni ardışık olarak yazdırır.

**Baklava Dilimi**: Üst ve alt üçgenlerin birleşimi ile baklava dilimi şeklini oluşturur.

**Piramit**: Bir piramit şekli oluşturur; her satırda ortalanmış yıldızlar yer alır.

**Ters Piramit**: Ters bir piramit şekli oluşturarak, en üstte daha fazla yıldızla başlayıp altta azalan bir düzen sağlar.

# 📍06_ Arrays


**Temel Dizi Örnekleri**: Farklı diziler tanımlanarak elemanlarına erişim sağlanmıştır.

**Dizideki Tüm Elemanları Listeleme**: `for` döngüsü ile dizinin tüm elemanları veya belirli koşulları (3'e bölünebilenler gibi) yazdırılmıştır.

**Dizi Metodları**: `IndexOf`, `Max()` ve `Min()` gibi metodlarla dizideki belirli elemanlar ve değerler bulunmuştur.

**Kullanıcıdan Değer Alma**: Kullanıcıdan şehir isimleri alınarak dizide saklanmış, sayılar toplanmış ve çift/tek sayılar ayrıştırılmıştır.


# 📍07_ Foreach

Bu C# kodu, `foreach` döngüsünü kullanarak diziler ve listelerle işlem yapmayı gösterir. Ayrıca, bir sınav uygulamasıyla kullanıcıdan öğrenci isimleri ve 3 sınav notu alır. Her öğrencinin not ortalamasını hesaplar ve 50 puan üzerindekileri "geçti", altındakileri "kaldı" olarak değerlendirir.

# 📍08_ Methods


-   **Void Metotlar**:
    
    -   `CustomerList()` ve `Sum()` metotları, geri değer döndürmeden çalışır. İlk metot, müşteri isimlerini listeler; ikincisi, iki sayının toplamını gösterir.
-   **Parametreli Void Metotlar**:
    
    -   `WriteMethod(string customerName)` ve `CustomerCard(string name, string surname)` metotları, bir veya daha fazla parametre alır ve bu parametrelerle işlem yapar.
-   **Geri Değer Döndüren Metotlar**:
    
    -   `CustomerName()` ve `StudentCard()` metotları, bir string döndürür. Birincisi sabit bir müşteri adı, ikincisi ise isim ve soyadı birleştirir.
-   **Geri Değer Döndüren Parametreli Metotlar**:
    
    -   `CountryCard(string countryName, string capital, string flagColor)` metodu, ülke, başkent ve bayrak rengini alarak bilgileri birleştirip döner.
    -   `Sum(int number1, int number2)` metodu, iki sayıyı toplar ve sonucu döndürür.
-   **Örnek Uygulama**:
    
    -   `Examresult(string student, int exam1, int exam2, int exam3)` metodu, bir öğrencinin üç sınav notunu alır, ortalamasını hesaplar ve öğrencinin sınavı geçip geçmediğini belirtir.
