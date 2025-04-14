# Windows Form Uygulaması

- Görsel Programlama dersi kapsamında yapmış olduğum .Net 8.0 destekli bir windows form uygulamasıdır.
- Bu uygulama kullanıcıdan isim, soyisim, boy, kilo, doğum tarihi alarak vücut kitle indeksi hesaplayıp yorumluyor. Ayrıca doğum zamanına göre burcunu gösterip yorumluyor.
- Tüm bu bilgiler SQLite veritabanına kaydediliyor.
- Ayrıca ana ekranda daha önceden hesaplanmış veritabanında olan kişileri kişi listesinde göstererek istenilen kişinin bilgileri de açılabiliyor.

  ## Veritabanına Erişim:

  - Eğer bilgisayarınızda SQLite kurulu değilse https://sqlitebrowser.org/dl/ sitesinden SQLite için DB Browser son sürümünü indirip kurabilirsiniz.
  - Kurulumdan sonra Visual Studio'da SQLite kütüphanesinin çalışabilmesi için Visual Studio -> Araçlar -> NuGet Paket Yöneticisi -> Çözüm için NuGet paketlerini yönet'e girdikten sonra System.Data.SQLite paketini indirmelisiniz.
  - Bu işlemler sayesinde .sqlite uzantılı sqlite dosyasına erişim sağlabilirsiniz. Böylece uygulama hatasız çalışacaktır.
  - SQLite dosyasına girip tabloyu ve bileşenleri görmek isterseniz BurcYorumUygulamasi\bin\Debug\net8.0-windows klasörü içerisinden ulaşabilirsiniz.

- -----

- It is a .Net 8.0 supported Windows form application that I made as part of the Visual Programming course.
- This application calculates and interprets the body mass index by taking the user's name, surname, height, weight and date of birth. It also shows and interprets the zodiac sign according to the date of birth.
- All this information is saved in the SQLite database.
- In addition, the information of the desired person can be opened by showing the people in the previously calculated database in the person list on the main screen.

  ## Access to the Database:

  - If SQLite is not installed on your computer, you can download and install the latest version of DB Browser for SQLite from https://sqlitebrowser.org/dl/.
  - In order for the SQLite library to work in Visual Studio after installation, you need to enter Visual Studio -> Tools -> NuGet Package Manager -> Manage NuGet packages for solution and then download the System.Data.SQLite package. - Thanks to these operations, you can access the sqlite file with the .sqlite extension. Thus, the application will work without errors.
  - If you want to enter the SQLite file and see the table and components, you can access it from the BurcYorumApplication\bin\Debug\net8.0-windows folder.
