# FileCreator
## İşleyiş
Program kullanıcıya oluşturmak istediği klasör ismini sorar, kullanıcı klasör ismini seçtikten sonra istenilen klasör düzeni sorulur.(Hangi türde dosyalar oluşturulacağına dair)
Kullanıcı burada belirtilen numaralar ile bir seçim yapar daha sonra istenilen düzene göre dosyalar oluşturulur ve erişim yetkileri tanımlanır.

## İlgili Fonksiyonlar
### createFolder: 
Bu fonksiyon kullanıcının istediği isimde ve seçtiği düzende gerekli adette ve isimde dosyalar oluşturur.
### provideAccsess: 
Bu fonkisyon içerisindeki listede yer alan bilgilere göre  kullanıcıların yetki sınırlarını belirler ve bu sınırlara göre erişim izni verir.
### getInformationAuthority: 
Bu fonksiyon ortak ağlardaki dosyalara erişerek, erişim yetkisi olan kullanıcıların listesini döndürür.


## Geliştirilebilecek Konular

- Ağa erişim yetkisi alındığında, hangi kullanıcıların dosyalara erişim yetkisi olduğunu belirleyebiliriz(getInformationAuthority fonksiyonu ile)
- Eğer klasörlere erişebilecek guruplar halihazırda mevcut ise klasörler oluşturulurken bu kullanıcılar otamatik bir seçimle ayarlanabilir(provideAccsess fonksiyonu modifiye edilerek)


## NOT
Ortak ağa mevcut bilgisiyardan erişim yetkim olmadığı için, oluşturulan dosyalara deneysel olarak erişim yetkisi verilmiştir.

  Programla ilgili ana dosya C#(FileCreator/project/program.cs) dosyasındadır.

