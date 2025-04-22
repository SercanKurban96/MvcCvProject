# ![mvccvtemplate](https://github.com/user-attachments/assets/40237e6c-09e1-46bc-8baf-4b79716fb185)

👋 Merhabalar, oluşturmuş olduğum bu repo, Udemy'de Murat Yücedağ tarafından hazırlamış olduğu dinamik bir CV sitesinin yapılma aşamaları anlatılmaktadır.<br><br>

📍 Kullanılacak template: https://startbootstrap.com/theme/resume <br><br>

## Projeye ait içerikler;<br>
📌 Tek katmandan oluşan dinamik bir CV projesi olacaktır.<br>
📌 MVC kullanılmıştır.<br>
📌 Veri tabanı olarak MSSQL kullanılmıştır.<br>
📌 ORM aracı olarak Entity Framework, geliştirme yaklaşımı olarak Db First kullanılmıştır.<br>
📌 Admin tarafı olacaktır.<br>
📌 Üç ayrı tema kullanılacaktır.<br><br>

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


