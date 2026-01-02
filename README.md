# WinFormsApp10
SAYI TAHMİN OYUNU

Girişte açılan formda kaydolmak için bir link label mevcut,oradan kullanıcı kaydoluyor.
Eğer kayılıysa kullanıcı adı ve parolayı girip oyun modunu mod formundan seçiyor.Renk Tahmin ve sayı tahmin adlı iki oyun mevcut.
Sayı tahmin oyununda arayüzü c #ile yaptım. Sistem tarafından random olarak oluşturulan sayıları
tahmin etmeye çalışıyoruz. Lbl kalan hak,kalan haklarımızı lbxgecmis gecmiş tahminlermizi gösteriyor .Kalan hak her seferinde 1 azaltılmak üzere on kez deneme şansımız var,
sayıların yerlerini artı eksi ile doğruluğunu bize söylüyor.
Tbx tahmini sıfırlayıp hak sayısını her seferinde başa sarabiliyoruz.Oyun verileri Sql server ortamına çekilerek listelenir.

Rastgele sayı üretme=Random rnd = new Random();
List<int> rakamlar = new List<int>();
 Seçilen sayının daha önce yazılıp yazılmadığını kontrol ederek tekrarsız üretmek için ekledim:
int yeniRakam = rnd.Next(0, 10);
 if (!rakamlar.Contains(yeniRakam)) // Tekrarsız olması için kontrol
 {
     rakamlar.Add(yeniRakam);
 }
public SAYI_TAHMİN_FORM(int secilenHane) buradaki int secilenHane, bu formu daha esnek hale getirmek için yaptım. Ana menüden kullanıcı 3, 4 veya 5 hane seçtiğinde, bu form o parametreye göre açılıyor. Böylece her zorluk seviyesi için ayrı bir form tasarlamak yerine tek formu dinamik kullanıyorum.
Ekrandaki 10 tane rakam butonunu tek bir metoda bağladım.Tüm butonların Click olayını tek bir sayibutonu_click metoduna bağladım. (Button)sender komutuyla, o an hangi butona tıklandığını yakalayıp içindeki metni (rakamı) TextBox'a yazdırıyorum. Bu sayede kod tekrarından kaçınmış oldum.
Renk Tahmin Oyunu 
 Projenin Amacı ve Temel Yapısı
Bu proje, bilgisayar tarafından rastgele seçilen 4 farklı renk kombinasyonunu, kullanıcının en az denemeyle bulmasını amaçlayan bir Windows Forms uygulamasıdır. Yazılım; C#, SQL Server ve .NET mimarisi kullanılarak geliştirilmiştir.
Sınıf Seviyesindeki Değişkenler ve Rolleri
Oyunun durumunu takip etmek için belirli global değişkenler tanımlanmıştır:
    • GizliRenkKodu: Bilgisayarın tuttuğu, oyuncunun bulmaya çalıştığı hedef dizilim (Örn: "KMSY").
    • KalanHak: Oyuncunun deneme sınırını belirleyen sayaç (Varsayılan: 10).
    • Stopwatch oyunSuresi: Oyuncunun kombinasyonu ne kadar sürede bulduğunu ölçen nesne.
    • MevcutRenkler: Oyunda kullanılan geçerli renk kümesi {Kırmızı, Mavi, Yeşil, Sarı}.

 Temel Metotların Açıklaması
A. Yeni Oyun Başlatma (YeniOyunBaslat)
Oyun her başladığında şu işlemler sırayla gerçekleşir:
    1. Rastgelelik: Random sınıfı ile 4 adet benzersiz renk seçilir ve GizliRenkKodu oluşturulur.
    2. Sıfırlama: Kullanıcı arayüzündeki (UI) metin kutuları temizlenir, haklar 10'a set edilir.
    3. Zamanlayıcı: Stopwatch başlatılarak performans ölçümü devreye girer.
B. Renk Giriş Mekanizması (RENKTAHMİN_CLİCK)
Kullanıcı deneyimini kolaylaştırmak için buton bazlı bir giriş sistemi tasarlanmıştır. Bu metot, tıklanan butonun ismini (BTNKIRMIZI vb.) kontrol eder ve metin kutusuna (TXTTAHMİNRENK) ilgili rengin baş harfini ("K") ekler. HaneSayisi kontrolü sayesinde 4 karakterden fazla giriş yapılması engellenir.
C. Algoritmik Değerlendirme (BTNTAHMİNET_Click)
Oyunun en kritik kısmı, kullanıcının tahminini hedef kodla kıyaslayan algoritmadır:
    • Tam Eşleşme (+): Renk hem dizide var hem de yeri doğruysa "artı" puan verilir.
    • Kısmi Eşleşme (-): Renk dizide var ancak yeri yanlışsa "eksi" puan verilir.
    • Kontrol Matrisi: Çift sayımları önlemek için gizliKullanildi ve tahminKullanildi boolean dizileri kullanılır.

Veritabanı Entegrasyonu ve Skor Sistemi
Oyun sadece bir eğlence aracı değil, aynı zamanda verileri saklayan bir sistemdir:
    • SkorKaydet: Oyuncu kazandığında; adı, bitirme süresi ve o anki tarih bilgisi SQL Server üzerindeki Skorlar tablosuna INSERT komutu ile kaydedilir.
    • SkorlariGuncelle: SqlDataAdapter kullanılarak skorlar veritabanından çekilir ve süreye göre (en hızlıdan en yavaşa) DataGridView üzerinde listelenir.
Hata Yönetimi ve Kullanıcı Geri Bildirimi
    • Validasyon: Kullanıcı 4 karakterden az giriş yaparsa MessageBox ile uyarılır.
    • Görsel Uyarılar: Kalan hak 5'in altına düştüğünde hak göstergesi turuncuya, 2'nin altına düştüğünde ise kırmızıya dönerek oyuncuyu uyarır.
    • Try-Catch: Veritabanı bağlantı hataları try-catch blokları ile yakalanarak uygulamanın çökmesi önlenir.
