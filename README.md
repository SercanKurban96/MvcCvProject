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

