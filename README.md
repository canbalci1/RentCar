# Rent a Car Project


<h5>26.10.2021</h5> 
<p>Bu projede bir araba kiralama sitesi oluşturmaya çalışacağım.</p>
<p>İlk aşamada projenin Business, Data Access ve Entity katmanlarını oluşturarak başladım.</p>
<p>Başlangıçta console ekranı olarak başaladığım projemi daha sonradan bir arayüz ekranı ekleyeceğim.</p>
<br>
<h5>27.10.2021</h5> 
<p>Sql Server tarafında veritabanı oluşturdum.</p>
<p>Generic IEntityRepository altyapsını oluşturdum.</p>
<p>Entity Fremawork altyapısını hazırladım.</p>
<p>Sisteme yeni araçlar eklenmesini sağlayan Add( ) metoduna kurallar yazdım.</p>
<ul><li>Araba ismi minimum 2 karakter olmalı.</li>
  <li>Araba günlük fiyatı 0 dan büyük olmalı.</li></ul>
<br>
<h5>01.11.2021</h5> 
<p>Temel yapıların bir başka projemdede kullanabilmek adına Core katmanı oluşturdum.</p>
<p>IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarını oluşturdum. </p>
<p>Car,Brand,Color sınıflarımı tüm CRUD operasyonlarına hazır hale getirdim. </p>
<p>Oluşturulan Dto yapısı ile arabaları şu bilgiler olacak şekilde listelelendirdim.</p> 
<p>CarName-BrandName-ColorName-DailyPrice </p>
<br>
<h5>09.11.2021</h5>
<p>Core katmanında Results yapılandırması yaptım.</p>
<p>Kullanıcılar,Müşteriler ve Kiralama tablolarını veri tabanında oluşturdum.Bunları birbirleriyle ilişkilendirdim.</p>
<p>C.R.U.D operasyonlarını tüm Entityler için gerçekleştirdim.</p>
<p>Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmesi için gerekli işlemleri gerçekleştirdim.</p>
<br>
<h5>15.11.2021</h5>
<p>WebAPI katmanını kurdum.</p>
<p>Business katmanındaki tüm servislerin Api karşılığını yazdım.</p>
<p>Postman'de test ettim.</p>
