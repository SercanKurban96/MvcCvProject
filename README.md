# ![mvccvtemplate](https://github.com/user-attachments/assets/40237e6c-09e1-46bc-8baf-4b79716fb185)

👋 Merhabalar, oluşturmuş olduğum bu repo, Udemy'de Murat Yücedağ tarafından hazırlamış olduğu dinamik bir CV sitesinin yapılma aşamaları anlatılmaktadır.<br><br>

📍 Kullanılacak template: https://startbootstrap.com/theme/resume <br><br>

## Projeye ait içerikler;<br>
📌 Tek katmandan oluşan dinamik bir CV projesi olacaktır.<br>
📌 MVC kullanılmıştır.<br>
📌 Veri tabanı olarak MSSQL kullanılmıştır.<br>
📌 ORM aracı olarak Entity Framework, geliştirme yaklaşımı olarak Db First kullanılmıştır.<br>
📌 Admin, kullanıcı girişi ve Cv sitesi olmak üzere üç ayrı tema kullanılacaktır.<br><br>

<hr>

# 🖥️ Bölüm 1: Veri Tabanı ve Tabloların Oluşturulması

![mvcdbcv](https://github.com/user-attachments/assets/a55f4338-cf25-4ff7-a24d-d6143c9da0de)
<br>
Veri tabanımızın ismini DbCv olarak belirledik.<br><br>

![mvccvtblhakkimda](https://github.com/user-attachments/assets/f45d3e8f-9806-41ac-be7d-8bea69a2761d)
<br>
Birinci tablomuzun ismini TblHakkimda olarak belirledik. Burada oluşturacağımız tüm tablolarda ID değerini int olarak belirleyip Primary Key (birincil anahtar) olarak belirliyoruz ve alt tarafta yer alan Identity Spesification değerini de otomatik artan olarak yapmak için Yes seçeneğini işaretliyoruz.<br><br>

![mvccvtbldeneyimlerim](https://github.com/user-attachments/assets/39b8ba05-d265-40f0-b133-8ea6c7f1ac35)
<br>
İkinci tablomuzun ismini TblDeneyimlerim olarak belirledik.<br><br>

![mvccvtblegitimlerim](https://github.com/user-attachments/assets/da322a2a-1bdb-43bc-98c5-fa23fb18c9af)
<br>
Üçüncü tablomuzun ismini TblEgitimlerim olarak belirledik.<br><br>

![mvccvtblyeteneklerim](https://github.com/user-attachments/assets/63090f76-d4f4-4521-9fd1-f8ecb1ce4c23)
<br>
Dördüncü tablomuzun ismini TblYeteneklerim olarak belirledik.<br><br>

![mvccvtblsertifikalarim](https://github.com/user-attachments/assets/1036be39-65d9-4809-8147-ac7f885317c5)
<br>
Beşinci tablomuzun ismini TblSertifikalarim olarak belirledik.<br><br>

![mvccvtbliletisim](https://github.com/user-attachments/assets/a6c30384-b723-439e-85f5-e9143ff62782)
<br>
Altıncı tablomuzun ismini TblIletisim olarak belirledik.<br><br>

![mvccvtbladmin](https://github.com/user-attachments/assets/b18bbc94-8e76-46ab-b6f6-f5e584ef1428)
<br>
Yedinci ve son tablomuzun ismini TblAdmin olarak belirledik.<br><br>

<hr>

# 🖥️ Bölüm 2: Projenin Oluşturulması

![mvccvproject](https://github.com/user-attachments/assets/ee43ceb9-625d-4025-b6ce-6178ed87469f)
<br>
Buradan ASP.NET Web Application (.NET Framework) şablonunu seçiyoruz. Sol tarafta çıkmazsa yukarıda yer alan arama çubuğundan veya alttaki seçeneklerden bulabilirsiniz.<br><br>

![mvccvproject1](https://github.com/user-attachments/assets/9bc32e6a-b605-473b-945b-7ad2c74e6be8)
<br>
Projemizin ismini MvcCvProject olarak belirledik.<br><br>

![mvccvproject2](https://github.com/user-attachments/assets/0b0c3c8b-6052-4b6b-ba6c-8dc807358630)
<br>
Çıkan pencerede direkt MVC seçili olarak gelecektir. Create diyoruz.<br><br>

![mvccvprojectbaslangic](https://github.com/user-attachments/assets/435ed8a7-361a-4d31-8182-32c323a2bd44)
<br>
Projemiz oluşturuldu.<br><br>

![image](https://github.com/user-attachments/assets/ee4dadd0-baaa-48b2-ad70-cdd9c351d2cf)
<br>
Yeni bir Layout oluşturmak için Views klasöründe yer alan Shared klasörüne sağ tıklayıp Add kısmından View olanı seçiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/e84d0d9a-44af-4cda-949b-8deba158a792)
<br>
Çıkan pencerede direkt Add olana tıklıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/9656d249-1ce1-4a98-9c9d-7789aa02d189)
<br>
İsmini _AdminLayout olarak belirledik. Bu Layout kendi başına bir Layout olacağı için aşağıda yer alan Use a layout page kısmında yer alan işareti kaldırıyoruz ve Add diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/f3eee96b-0c60-45d1-a338-a7098cc4b489)
<br>
Burada bir tane model oluşturacağız. İlk olarak Models klasörüne sağ tıklayıp Entity isminde yeni bir klasör oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/b964dc7e-681a-4f69-b0aa-a52007f6d5b8)
<br>
Ardından Entity klasörüne sağ tıklayıp Add kısmından New Item diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/cafc1f0b-3016-463e-bd68-046a302df624)
<br>
Burada sol tarafta yer alan Data kısmını seçiyoruz ve ADO.NET Entity Data Model olanı seçtikten sonra Add diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/5ba11bbf-0c0e-4ab2-8145-2efb366e0e4a)
<br>
Burada direkt Next diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/e4374373-53e6-4441-8406-0499e65c20d9)
<br>
Burada en son yapmış olduğum veri tabanı çıkacaktır. Bunun için oluşturacağımız veri tabanını seçmek için New Connection diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/54c2433d-8330-4d84-af22-e8c1423d3c00)
<br>
Burada SQL veri tabanınızda yer alan sunucu adınızı girdikten sonra veri tabanımızı seçiyoruz ve OK diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/737b27e2-aa3e-4d14-8ef3-d57c9ba7ad7a)
<br>
Artık Entities oluşturma işlemine geçebiliriz. Next diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/f80a6c46-0b2a-47f4-b6b3-b3f08cc45b6e)
<br>
Next diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d7bad249-991a-4b46-9251-8cf6c055b23a)
<br>
Buradaki tüm tabloları seçtikten sonra Finish diyoruz. Model oluşturma süreci biraz uzun olacaktır.<br><br>

![image](https://github.com/user-attachments/assets/172f976d-b7ad-46a6-9aaa-43055803e319)
<br>
Modelimiz bu şekilde oluşturuldu.<br><br>

## ⚙️ Temanın Projeye Eklenmesi

![image](https://github.com/user-attachments/assets/d253eb07-629d-4c46-93b4-3bc0123fecad)
<br>
Controllers klasörüne sağ tıklayıp yeni bir Controller ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/6dbc73a9-7955-4ab6-949f-9bcb9f4e3de6)
<br>
Add diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/e4b7fc75-6a97-43b8-af7f-cd982ea3d601)
<br>
İsmini direkt DefaultController olarak belirleyip Add diyoruz. Burada istediğiniz ismi kullanabilirsiniz.<br><br>

![image](https://github.com/user-attachments/assets/b120c804-130c-437f-b46b-b6eb681c188c)
<br>
Index'e sağ tıklayıp Add kısmından View ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/ef1985bb-304e-4e04-8f05-9d937677f3fa)
<br>
Burada herhangi bir Layout kullanmadan Add diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/8c0932c7-1086-484b-8794-9bc848f0e8cf)
<br>
Tema linkinde yer alan şablonu indirdikten sonra bu klasörü alıp direkt katmanımıza sürüklüyoruz.<br><br>

![image](https://github.com/user-attachments/assets/8d6c9caf-8e1a-473e-97a4-6a9e60bf8034)
<br>
Hazır şablonumuz burada yer aldı.<br><br>

![image](https://github.com/user-attachments/assets/ff6fb8bc-06e8-4ab7-9817-47eb8da91896)
<br>
Şablonun içerisinde yer alan index.html sayfasına tıklıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/3a656c5f-b9ac-4e53-ae47-14921fb0a708)
<br>
Yaklaşık 229 satır yer almaktadır. Burayı olduğu gibi kopyalayıp kendi hazırladığımız index.html sayfasına yapıştırıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/9f58126a-3e38-4e8c-9a43-fc4f15e0f87b)
<br>
Kendi index.html sayfamızı buraya aktarmış olduk.<br><br>

![image](https://github.com/user-attachments/assets/520ddbdc-f499-4aee-b9a5-0e0cd971c06d)
<br>
Programı çalıştırdığımız zaman karşımıza bu şekilde CSS yolları bozuk olarak gösterecektir.<br><br>

### 🧰 Düzeltilecek CSS Yolları:

![image](https://github.com/user-attachments/assets/000c86be-b03f-49cd-ad30-24357451fe99)
<br>
Burada şablonumuzun ismini kullanarak CSS yollarını belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/c94e2ea4-902a-4066-9e0a-9e7f3ed2a0a2)
<br>

![image](https://github.com/user-attachments/assets/417e9475-da6b-4901-99a7-a5013ccfce94)
<br>

![image](https://github.com/user-attachments/assets/cfd397d5-befc-4dd7-8582-9c5d02151696)
<br>
CSS yolları düzelmiş oldu.<br><br>

<hr>

# 🖥️ Bölüm 3: Vitrin Paneli

## ⚙️ Hakkımda Kısmını Listeleme

![image](https://github.com/user-attachments/assets/83582c2e-5321-411b-b0c9-d7992ef60449)
<br>
Burada index.html sayfasında yer alan menüleri türkçeleştirdik.<br><br>

![image](https://github.com/user-attachments/assets/72bb4a58-e9c6-465d-80ed-a6f1c40319a2)
<br>
Burada en üstte using MvcCvProject.Models.Entity kütüphanesini ekliyoruz.<br> 
Ardından DbCvEntities ile bir tane entity oluşturup ismini db olarak belirliyoruz.<br>
Burada Index içerisinde var türünden degerler isminde bir değişken oluşturduk.<br>
Hakkımda tablosunu listelemek için db türünden TblHakkimda tablosunu kullanarak ToList metodunu oluşturduk.<br>
En sonda geriye değer döndürme işlemini gerçekleştirmek için içerisine degerler değişkenini eklemiş olduk.<br><br>

![image](https://github.com/user-attachments/assets/66957d07-9844-49c7-a27a-5abcbb3191ed)
<br>
Index.html sayfasına gelip Hakkımda tablosunu gösterebilmek için using kütüphanesini ve modeli ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d0beff27-c2c1-4246-b7a6-2d2c0160220e)
<br>
About kısmı 48. satırdan itibaren yer almaktadır. Burada işlemlerimizi gerçekleştireceğiz.<br><br>

![image](https://github.com/user-attachments/assets/07713205-d4e2-462e-a8f9-fe9cc1ade977)
<br>
Burada bir tane foreach döngüsü oluşturuyoruz. About kısmı section etiketleri arasında bulunmaktadır. Bu nedenle foreach döngüsü oluştururken section etiketlerinin arasına süslü parantezlerimizi ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/c867536f-1926-404e-a6f6-237b8932f4a8)
<br>
53. satırda Clarence ismi yer almaktaydı. Burada kendi adımızı görüntülemek için foreach döngüsünde oluşturduğumuz item değişkenini burada kullanıyoruz ve oluşturduğumuz Ad sütununu buraya çağırıyoruz. Programı çalıştırdığımız zaman burada Hakkımda kısmı gözükmeyecektir, çünkü veri tabanında herhangi bir veri girmedik. Bunun için verimizi girelim.<br><br>

![image](https://github.com/user-attachments/assets/d530645a-f0a2-48ad-8882-cfd72d7ded98)
<br>
Örnek veri girişimizi bu şekilde yaptık.<br><br>

![image](https://github.com/user-attachments/assets/7fe06bc1-475b-4cfe-811a-1551ce7b82e0)
<br>
İsim burada çıkmış oldu.<br><br>

## ⚙️ Partial View Kullanımı

"Partial View" terimi, genellikle ASP.NET MVC veya Razor Pages projelerinde kullanılan bir kavramdır. Türkçesiyle "Kısmi Görünüm", bir web sayfasının tekrar kullanılabilir parçasıdır. Ana amaç, ortak kullanıcı arayüzü bileşenlerini tek bir yerde tanımlayıp, farklı sayfalarda kullanabilmektir.<br><br>

### ✔️ Partial View Nedir?
ASP.NET MVC'de, bir view dosyasının (örneğin .cshtml) parçası olarak tanımlanan, başka view'lar içinde kullanılabilen bir yapıdır.<br>
Örneğin: Navigasyon menüsü, footer, kullanıcı profil kutusu gibi bileşenler için idealdir.<br><br>

### 🗒️ Ne Zaman Kullanılır?
Aynı HTML bileşenini birçok yerde göstermek gerektiğinde.<br>
Sayfaların belirli kısımlarını modüler hale getirmek istendiğinde.<br>
Sayfa yapısını sade ve okunabilir tutmak için.<br><br>

![image](https://github.com/user-attachments/assets/d63032ef-d75e-4892-8669-7d99a6877e69)
<br>
DefaultController'a gidiyoruz ve Deneyim isminde bir tane PartialView oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/a7cef078-83f2-45b7-b7eb-e7fd0d0185e4)
<br>
Ardından Deneyim'e sağ tıklayıp bir View oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/f80709fa-20c9-48bb-830e-341440fb0621)
<br>
Burada bir partial view oluşturmak için Create as a partial view kısmını seçili hale getiriyoruz ve Add diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/1842e8d2-08e8-4915-92a7-28def9132080)
<br>
Partial View bu şekilde hazırlanmış oldu.<br><br>

![image](https://github.com/user-attachments/assets/2ca79c4d-40f7-4427-b02c-fbdb2ef486cc)
<br>
Örnek bir Partial View kullanımı bu şekildedir. Burada Html.PartialView dedikten sonra DefaultController'da oluşturduğumuz Deneyim isminde PartialView'i buraya yazıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/3f6f4007-8c9c-4e5c-982d-82d52b8c5143)
<br>
Deneyim partial view'e geldiğimizde örnek olması açısından bir yazı yazdık.<br><br>

![image](https://github.com/user-attachments/assets/1501f52d-8921-4254-b89a-9469869dfceb)
<br>
Partial View bu şekilde çağırılmış oldu.<br><br>

## ⚙️ Deneyimleri Listeleme

![image](https://github.com/user-attachments/assets/2c345191-d13a-4674-9dba-8f801a667ea3)
<br>
Burada Deneyim kısmını Partial View haline getirmek için 74. satırda yer alan div class içerisindeki resume-section-content olan kısmın sol tarafındaki ok sembolüne tıklıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/13471f4d-201f-4960-8d5e-757c24fbb640)
<br>
Görünümü küçültmüş olduk. Buradaki küçülttüğümüz kodu kesip Deneyim.html sayfasına yapıştırıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/9bcf97a5-852a-47cf-a5dc-366a8889c230)
<br>
Deneyim.html sayfasındaki kodları buraya aktarmış olduk.<br><br>

![image](https://github.com/user-attachments/assets/46664d83-0de6-4808-9bd4-4b3201e1b75d)
<br>
Ardından kestiğimiz kodları bu kez Html.Partial("Deneyim") içerisine aktarıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/1aa655fb-06f6-47b5-bb15-64884a9e420b)
<br>
Deneyimler bu şekilde karşımıza çıkmış oldu. Şimdi burada kendi deneyimlerimizi ekliyor olacağız. Burada toplamda 4 tane deneyim yer almaktadır. Biz bunlardan sadece birini kullanıyor olacağız. Bunun için foreach döngüsüne ihtiyacımız olacak.<br><br>

![image](https://github.com/user-attachments/assets/76c7db2d-0639-4cbd-9eef-30a3201748d6)
<br>
Sileceğimiz kod kısımlarını küçülterek göstermiş olduk. Burada sadece bir tanesini kullanacağız.<br><br>

![image](https://github.com/user-attachments/assets/7fe314a3-e93e-4723-969b-1c400ee632ef)
<br>
DefaultController'a gelip deneyimleri listeleyecek kodu yazıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/f4cb16d6-3f3a-4100-b5e9-ca008cd3665a)
<br>
Modelimizi ve foreach döngümüzü oluşturduk.<br><br>

![image](https://github.com/user-attachments/assets/a72d3f8a-2fa5-4841-9ed2-adff552bb909)
<br>
Çalıştırdığımız zaman hata verecektir. Index.html sayfasına gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/760cf6da-3146-4e7e-8723-62d3995ea723)
<br>
Burada Html.Partial olan kısmını Html.Action olarak değiştiriyoruz.<br><br>

![image](https://github.com/user-attachments/assets/394dda91-b9c0-4cec-a628-ebe741668c0a)
<br>
Sayfamız bu şekilde gelmiş oldu. Buraya kendi deneyimlerimizi ekliyoruz.<br><br>

⚠️ Partial View'de eğer statik bir yapıysa Partial kullanabiliriz, ancak dinamik bir yapıysa, yani bu kez birkaç farklı tablodan tek bir View sayfası üzerinde veri getirmeye çalışırsak bu kez Action kullanırız.<br><br>

![image](https://github.com/user-attachments/assets/569a7f8e-70b4-4ff8-989c-be61366946b7)
<br>
Deneyim.html sayfasını bu şekilde değiştirmiş olduk. Programı çalıştırırken Index.html üzerinden çalıştırmamız gerekecektir.<br><br>

![image](https://github.com/user-attachments/assets/954072e9-e149-4d06-ba7b-c3261d354243)
<br>
Sayfamız bu şekilde hazırlanmış oldu. Diğer alanlar için de (Eğitimlerim, Sertifikalarım vs...) aynı şekilde uygulanacaktır.<br><br>

### Örnek Proje Görüntüleri

![image](https://github.com/user-attachments/assets/81751d60-7a02-4c41-ae16-d386fee90789)
<br>

![image](https://github.com/user-attachments/assets/d37d0e4b-91eb-40d7-96a8-f71244eedd41)
<br>

![image](https://github.com/user-attachments/assets/fc495db7-230f-4e6a-b09d-ad4e7bc68110)
<br>

![image](https://github.com/user-attachments/assets/b952b42a-83ef-4d9f-8521-e714adf352ab)
<br><br>

## ⚙️ İletişim Paneli

![image](https://github.com/user-attachments/assets/2be39a2b-b732-4575-9665-5e3f1d86baec)
<br>
Burada Iletisim isminde bir Partial View oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/0c8db60a-4c0b-4085-9cb1-e7c14d57cdfe)
<br>
Index.html sayfasına gelip bir tane section class üzerinden id değerini contacts olarak belirliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/e9094715-ddd6-4179-a1a5-6499541435bc)
<br>
Contacts değerini yukarıda yer alan menüye ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/862d4a42-ab43-4af4-a952-f98ec7414229)
<br>
Iletisim formunu bu şekilde hazırlamış olduk.<br><br>

![image](https://github.com/user-attachments/assets/4828ba53-f4dc-44f7-b33d-321e1febe7f2)
<br><br>

## ⚙️ Mesaj Gönderme İşlemi

![image](https://github.com/user-attachments/assets/1694e1e2-3ca4-4ff6-a6aa-b8775d10904f)
<br>
Burada ilk olarak HttpGet ve HttpPost metotlarını kullanıyoruz. Bu metotlar repomda yer alan MvcEducation bölümünde anlatılmıştır.<br><br>

![image](https://github.com/user-attachments/assets/91f1ee9e-0c3a-4595-be7c-14b34e5645e4)
<br>
Iletisim partial sayfasında bir tane form oluşturup metodunu post olarak belirliyoruz. Burada input kısmında yer alan name ise veri tabanında yazdığımız sütunların aynısını buraya yazıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/8dddfc4f-0c26-46ea-af56-24e1bf85e4a0)
<br>

![image](https://github.com/user-attachments/assets/a5e83615-960a-48d1-8825-522c766aaf6f)
<br><br>

<hr>

# 🖥️ Bölüm 4: Admin Teması

Tema linki: https://themewagon.com/themes/adminlte-free-bootstrap-3-html5-admin-panel-template/ <br><br>

![image](https://github.com/user-attachments/assets/8bb47d48-4365-42f3-9f85-ee41bbf28d4c)
<br><br>

## ⚙️ Layout Panelinin Düzenlenmesi
Burada ilk olarak Shared klasörüne bir tane _AdminLayout oluşturmuştuk. Bunun üzerinden gideceğiz.<br><br>

![image](https://github.com/user-attachments/assets/d879f27a-3b0f-4784-9b6b-3fb60cd7f793)
<br>
Sırayla işlemlerimizi yapıyoruz. İlk olarak HakkimdaController isminde bir tane Controller oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/4768169e-4e14-466b-90d2-ba2cc5fc4056)
<br>
Index üzerinden bir View oluşturup _AdminLayout sayfasını kullanacağız.<br><br>

![image](https://github.com/user-attachments/assets/705fe061-efa3-4f7f-aab3-97fba84324e4)
<br>
Buradan Shared klasörü üzerinden _AdminLayout sayfasını seçiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/50f1f8bc-551b-4a64-aad0-83ab5f009421)
<br>
İşlemler tamamlandıktan sonra Add diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/a59a61bf-9c85-4deb-bf37-cd284b0d5ebe)
<br>
Admın temayı katmanımıza atıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/04a7b7ea-abb7-4355-bbf4-1b0d56718fc4)
<br>
_AdminLayout sayfasına örnek kod olarak pages klasörüne ait olan examples klasörüne gelip project-add.html içerisindeki kodları kopyalayıp _AdminLayout sayfasına yapıştırıyoruz. Hata vermemesi için 
geçici olarak en alt sayfaya @RenderBody metodunu ekledik.<br><br>

AdminLayout düzenlenmiş hali projenin metin belgesinde yer almaktadır.<br><br>

## Örnek Tablo Kullanımı

![image](https://github.com/user-attachments/assets/0277e9b7-7555-4b7e-bc67-e51961e4ed85)
<br>
HakkimdaController'a ait Index üzerinden örnek bir tablo oluşturduk.<br><br>

![image](https://github.com/user-attachments/assets/453fe715-cd4f-4c83-bbb7-68a3a0b5421c)
<br>
Sayfanın görünümünü daha düzgün hale getirmek için _AdminLayout'a gelip RenderBody'den önce bir div oluşturuyoruz.<br><br>

<hr>

# 🖥️ Bölüm 5: Repository Design Pattern

Repository Design Pattern (Depo Tasarım Deseni), yazılım geliştirmede kullanılan bir mimari desendir. Veritabanı işlemlerini (CRUD: Create, Read, Update, Delete) soyutlamak için kullanılır. Amaç, veri erişim mantığını uygulama mantığından ayırmaktır. Bu desen sayesinde kod daha okunabilir, sürdürülebilir ve test edilebilir hale gelir.<br><br>

![image](https://github.com/user-attachments/assets/21985615-02ab-48ef-80e7-2018d5d00fe2)
<br>
Katmanımıza Repositories isminde yeni bir klasör oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/e993cb47-6544-40e3-bf03-c7ad5e9bb198)
<br>
Ardından Repositories klasörüne sağ tıklayıp GenericRepository isminde yeni bir class oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/8fd832d3-6772-48d6-b735-9fce03cbf2bf)
<br>
Burada tek bir repository içinde bütün CRUD işlemlerini yapacağız. Bunun için GenericRepository sınıfın içerisine T değerini ekliyoruz. Bu T değeri göndereceğimiz sınıflar olacaktır. Ardından where şartı ekleyip T:class olarak ekliyoruz ve new komutunu ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/9ca07c67-d502-4040-bd5f-a9c32dc32889)
<br>

CRUD işlemleri bu şekildedir.<br><br>

![image](https://github.com/user-attachments/assets/090a09d4-eb9a-474f-b85c-5ef543079d66)
<br>
GenericRepository'den CRUD işlemlerini tamamladıktan sonra diğer işlemlerimiz için (DeneyimRepository, YeteneklerimRepository...) tek tek oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/70043b3b-5f19-467c-af33-358fb99d1927)
<br>
Burada örnek olarak DeneyimRepository oluşturduk. Buradan GenericRepository'den miras aldıktan sonra içerisine TblDeneyimlerim ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d6932af2-fad9-4658-9ff2-da5f2552168b)
<br>
Repositoryleri tanımladıktan sonra DeneyimController oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d126e8b4-8711-4351-bd10-4f792b05bc4e)
<br>
Oluşturduğumuz DeneyimRepository'i buraya çağırıyoruz ve ilk olarak listeleme işlemini yapıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/907c444d-c829-45d3-be39-bb675739571d)
<br>
Ardından Index'e sağ tıklayıp View oluşturuyoruz ve _AdminLayout sayfasını kullanıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/1c179021-e5ad-4034-9f4f-2bcffbb522f0)
<br>
Index sayfasını bu şekilde oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/9fbc5bfc-6bd7-4b81-a0ff-551b07843c44)
<br>
Ekran çıktısı bu şekildedir.<br><br>

![image](https://github.com/user-attachments/assets/1ecd08e7-9b92-4ecd-b99e-7a0886e9f90c)
<br>
Ekleme işlemi bu şekilde olacaktır. Ardından DeneyimEkle'ye tıklayıp yeni bir View oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/d0f322e0-79cb-4006-ab85-651d5d3316fe)
<br>
DeneyimEkle sayfasını bu şekilde oluşturduk.<br><br>

![image](https://github.com/user-attachments/assets/bedff738-4f1e-4346-9869-fc4ec9de0bae)
<br>
Ekran çıktısı bu şekildedir.<br><br>

![image](https://github.com/user-attachments/assets/82c7baba-56b5-408b-ba52-e1c8a626a34f)
<br>
Örnek bir veri girişi yapalım.<br><br>

![image](https://github.com/user-attachments/assets/9dff7271-62be-4ca7-94d7-4cad791cd4a7)
<br>
Veri girişimiz bu şekilde oluşturuldu.<br><br>

![image](https://github.com/user-attachments/assets/6ec6bc6b-d477-47e6-9767-435973d71828)
<br>
Silme işleminden önce GenericRepository'e gidiyoruz ve silinecek olan değeri bulan metotu ekliyoruz. Burada LINQ sorgusu olan Expression'u kullanıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/2ca16086-8fe2-4359-b692-7838b668e2cc)
<br>
DeneyimController'a gelip silme metodunu uyguluyoruz, <strong>ancak burada herhangi bir View oluşturmuyoruz!</strong><br><br>

![image](https://github.com/user-attachments/assets/0e9a7d4b-24c3-4552-adcc-275e4b4b5064)
<br>
Index sayfasına gelip DeneyimSil metoduna ait olan adresi ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/159a288d-6ce0-492b-8f3d-0e79bdfc6ec3)
<br>
Buradan ID 2 olan değeri sildiğimiz zaman silme işlemi başarılı bir şekilde uygulanacaktır.<br><br>

![image](https://github.com/user-attachments/assets/f328e42d-d33a-450d-80d2-5066deb0c104)
<br>
Deneyim geitrme işlemi için HttpGet metodunu kullanıyoruz ve ID değerini bulduruyoruz. Ardından View oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/7f00778d-bdc1-4888-b507-0104e719e962)
<br>
Index sayfasına da silme işleminde olduğu gibi DeneyimGetir metoduna ait olan adresi ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/a86e127c-dec9-45ea-b764-d508f67b14ab)
<br>
Deneyim düzenleme sayfasını bu şekilde tasarladık.<br><br>

![image](https://github.com/user-attachments/assets/e4116aa5-0bd1-44c5-b327-228bdf3911dc)
<br>
Deneyim getirme ve güncelleme işlemleri bu şekilde olacaktır.<br><br>

![image](https://github.com/user-attachments/assets/55060cba-944e-4955-8612-58649a25a7c3)
<br>
DeneyimGetir sayfasında ise form methodunu Post olarak ayarladık.<br><br>

<hr>

# 🖥️ Bölüm 6: Admin Temasında CRUD İşlemleri

![image](https://github.com/user-attachments/assets/2f59035e-b389-4ebb-ae7d-23fb0643eb40)
<br>
YetenekController isminde bir tane Controller oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/0a2be481-700f-4c61-95f1-083bbcda303c)
<br>
Listeleme işlemini bu şekilde yapıyoruz ve Index oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/4233dda2-7c2c-435c-85e8-34e18dade471)
<br>
Burada örnek olarak ilgili template'e gelip pages klasörüne ait olan tables klasörüne geliyoruz. Oradan simple.html sayfasına gidiyoruz. YetenekIndex olarak metin belgesi projede yer almaktadır.<br><br>

![image](https://github.com/user-attachments/assets/8319dd41-d1b1-4300-91ad-56bc50b126dd)
<br>
SQL'e gelip TblYeteneklerim tablosuna Oran isminde yeni bir sütun ekliyoruz ve veri tipini tinyint olarak belirliyoruz. Şimdi bu değeri modelimize yansıtalım.<br><br>

![image](https://github.com/user-attachments/assets/092854d1-2798-4e7b-af23-1335230beab1)
<br>
Models klasörüne gelip oluşturduğumuz Entity klasörüne ait olan modelimize tıklıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/73be4a52-73d9-4311-abf7-0e173b91ff0f)
<br>
Herhangi bir alana sağ tıklayıp Update Model from Database diyoruz.<br><br>

![image](https://github.com/user-attachments/assets/6291aa10-589f-4a6e-b339-fe85baa92097)
<br>
Karşımıza bu şekilde çıkacaktır. Direkt Finish diyoruz ve kaydediyoruz.<br><br>

![image](https://github.com/user-attachments/assets/a8acbcc2-3f73-478a-9d12-fe73931425e0)
<br>
YetenekController Index sayfasını bu şekilde oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/5f87200d-6646-4f06-9c6f-7092cfb5f1c0)
<br>
Değerlerimizi bu şekilde belirledik.<br><br>

![image](https://github.com/user-attachments/assets/0850b7ff-eb92-4c32-8530-39cd46d0485e)
<br>
Progress bar çubuğunda ve labellarda şartlı renklendirme işlemi için en üst kısmına gelip string türünden renk ve labelrenk isminde değişkenlerimizi oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/2e79904c-a6ae-45ca-a863-cb061ff8736b)
<br>
Ardından foreach döngüsünün hemen altına if şartlarımızı belirliyoruz. En sonda div class'ımıza @renk ve @labelrenk atamaları yapıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/e87eaed9-2e33-4ab6-aff8-1e325c6bacbe)
<br>
Progress bar çubukların renkleri ve labelların renkleri oranlara göre belirlenmiştir.<br><br>

![image](https://github.com/user-attachments/assets/a4647560-1859-4bd7-a1bf-5ff965049982)
<br>
Yetenek ekleme işlemi bir öncekinde yaptığımız deneyim ekleme işleminde olduğu gibidir.<br><br>

![image](https://github.com/user-attachments/assets/0daef653-dc87-446f-bf8f-6d4d7547cbea)
<br>
YeniYetenek sayfası bu şekilde oluşturuldu.<br><br>

![image](https://github.com/user-attachments/assets/7b24ea8a-d2ec-4ab0-b628-38bd0d1e9297)
<br>

![image](https://github.com/user-attachments/assets/bd4f3ee2-8627-43e6-bbdb-0fbe9d122f31)
<br>
Ekleme işlemi bu şekildedir.<br><br>

![image](https://github.com/user-attachments/assets/e70b5227-87bf-49e8-840a-b55cd0c182ff)
<br>
Silme ve düzenleme işlemleri Controller'da bu şekildedir.<br><br>

![image](https://github.com/user-attachments/assets/11f1cf70-da74-463c-b731-3a1e07f92c33)
<br>
Yetenek düzenleme sayfası bu şekildedir.<br><br>

<hr>

# 🖥️ Bölüm 7: Eğitim İşlemleri ve Validation Kontrolleri

![image](https://github.com/user-attachments/assets/39cd173c-9aba-4d6e-ad8d-3b1bf0ded837)
<br>
İlk olarak EgitimController isminde yeni bir Controller oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/0deeae75-ae9b-4ee0-b45e-c8dd802449bb)
<br>
Repomuzu buraya çağırıyoruz ve listeleme işlemini oluşturduktan sonra Index'e sağ tıklayıp View ekliyoruz.<br><br>

![image](https://github.com/user-attachments/assets/f6b85335-c47d-4663-a4fd-a8ec95775658)
<br>
Index'imizi bu şekilde oluşturduk. Daha önce yaptığımız Deneyim tarafında yer alan Index'e benzer bir yapıda oluşturduk.<br><br>

![image](https://github.com/user-attachments/assets/8ad49b4e-4316-4741-b350-8209587e39d5)
<br>
Ekleme işlemini şimdilik bu şekilde oluşturduk. EgitimEkle'ye sağ tıklayıp yeni bir View oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/2d3f13d8-38e5-44e6-b9fa-5ee92e34013e)
<br>
EgitimEkle formumuzu bu şekilde oluşturduk.<br><br>

![image](https://github.com/user-attachments/assets/ea5c152e-237d-4e37-b35e-0d599195d217)
<br>
Yeni Eğitim Ekle butonumuza tıklıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/4304afc6-1689-42ef-b705-b1a7568c1be3)
<br>
Buraya hiçbir veri girişi yapmadan direkt Kaydet diyelim.<br><br>

![image](https://github.com/user-attachments/assets/fc1d87a4-e06a-4a40-a04d-aec75095886f)
<br>
Gördüğünüz üzere hiçbir veri girişi yapmadan direkt veriyi kaydetmiş oldu, ancak bu bizim istediğimiz bir durum değil. Burada validation (doğrulama) işlemlerimizi yapacağız. Örnek olarak veri girişi yapılmazsa veya girilen karakter sayısı az ise veriyi eklemeden bir uyarı mesajı vermesini sağlayacağız.<br><br>

![image](https://github.com/user-attachments/assets/ff38ad4b-f86a-43a7-a551-a469518ff331)
<br>
Burada Models klasörüne giderek üzerinde çalışmış olduğumuz TblEgitimlerim sayfasına gidiyoruz.<br><br>

![image](https://github.com/user-attachments/assets/5cae38dd-8c60-440d-8195-bf5393ae0f29)
<br>
TblEgitimlerim sayfası bu şekilde karşımıza çıkacaktır. Burada bir validation işlemi uygulayalım.<br><br>

![image](https://github.com/user-attachments/assets/6d6d3add-cc22-4e78-925d-ca205de7ea62)
<br>
Burada örnek olarak Baslik değerini boş geçmemek için hemen üzerine [Required] ifadesini kullanıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/785fb0cc-5d70-4356-8d93-0ca3aeeb02ba)
<br>
Tekrardan Yeni Eğitim Ekle butonuna basalım ve hiçbir veri girişi yapmadan direkt Kaydet diyelim.<br><br>

![image](https://github.com/user-attachments/assets/8d9f764d-1942-4b0d-b18f-f33d8750de63)
<br>
Gördüğünüz üzere direkt hata ekranı karşımıza çıktı, ama bu hatayı görmek yerine kendimiz hata mesajı oluşturup o hatayı ekranda görebiliriz.<br><br>

![image](https://github.com/user-attachments/assets/6d40be50-d29a-4f09-9de2-a5f3cd62bcb1)
<br>
Burada ilk olarak Validation geçerliliğini sağlamak için ModelState oluşturuyoruz.<br><br>

![image](https://github.com/user-attachments/assets/45ba24bd-8184-407e-8d2e-e2647380592b)
<br>
Ardından Models klasöründe yer alan TblEgitimlerim sayfasına gidip bu kez Required alanından sonra hata mesajı oluşturmak için ErrorMessage komutunu kullanıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/cca8831f-adc2-4306-92fb-8b38a22dffc9)
<br>
EgitimEkle sayfasına gelip bu kez ValidationMessageFor komutunu ekliyoruz. Burada önce Baslik değerini, ikinci değeri ise boş bırakıyoruz. Index üzerinden programımızı çalıştıralım.<br><br>

![image](https://github.com/user-attachments/assets/5b0861c1-35ba-40a9-a958-7cccaa5a029d)
<br>
Kaydet butonuna basalım.<br><br>

![image](https://github.com/user-attachments/assets/411bcba6-50d3-4128-af1a-d292acb6b288)
<br>
Kaydet butonuna bastığımız zaman bize bir hata mesajı verdi. Böylece veriyi kaydetmemiş oldu. İstersek bu hata mesajının rengini değiştirebiliriz.<br><br>

![image](https://github.com/user-attachments/assets/b0315959-ef67-4325-944e-56045d1950f4)
<br>
Renk değişikliği için kullanacağımız komut bu şekildedir.<br><br>

![image](https://github.com/user-attachments/assets/477ac3b3-43c2-4666-8379-7d1371fd4636)
<br>
Bir diğer validation kontrolü ise karakter uzunluğu belirlemedir. Burada StringLength komutunu kullandıktan sonra örneğin 10 olarak belirlediğimiz zaman en fazla 10 karakterlik veri girişi yapabileceğimizi belirtmektedir. Aksi taktirde bize hata mesajını gösterecektir.<br><br>

![image](https://github.com/user-attachments/assets/1714dfdd-93df-4f7d-893e-b01b4b22aef6)
<br>
Egitim silme ve düzenleme işlemleri...<br><br>

![image](https://github.com/user-attachments/assets/bb4fb445-43b0-464f-bafb-028cb7c32269)
<br>
EgitimDuzenle sayfası...<br><br>

<hr>

# 🖥️ Bölüm 8: Sertifika Hobi ve İletişim Sayfaları

![image](https://github.com/user-attachments/assets/3a4e9393-7b7c-4bae-bdef-079731a7bf51)
<br>
SertifikaController oluşturuyoruz ve Index sayfasına yeni bir View ekliyoruz.<br><br>

SertifikaController Index sayfasında yer alan kodlar projenin içerisindedir.<br><br>

![image](https://github.com/user-attachments/assets/f47ab377-0801-4488-88be-68eb015baa5f)
<br>
SQL'e gelip TblSertifikalarim tablosuna Tarih isminde yeni bir sütun ekliyoruz ve modelimize yansıtıyoruz.<br><br>

![image](https://github.com/user-attachments/assets/972d25c5-6f87-4969-81fc-5d8aec07ca8e)
<br>
Sertifika listeleme, ekleme ve silme işlemi...<br><br>

![image](https://github.com/user-attachments/assets/3be353f3-3871-41ac-a8af-5a9914a691ad)
<br>
Sertifika düzenleme işlemi...<br><br>

![image](https://github.com/user-attachments/assets/8bc0de07-c0c1-4cbc-8f9b-b2bd0bcb56f0)
<br>
YeniSertifika sayfası...<br><br>

![image](https://github.com/user-attachments/assets/c8b158ad-8cd4-4972-a3c4-53f87f873c9f)
<br>
Sertifika düzenleme sayfası...<br><br>

![image](https://github.com/user-attachments/assets/dfe896fa-bc41-442a-afa9-5603ea6fd7fc)
<br>
IletisimController oluşturuyoruz.<br><br>

Iletisim'e ait Index kısmındaki kodlar projenin içerisinde yer almaktadır.<br><br>


