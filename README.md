#  Chain of Responsibility Tasarım Deseni ve Uygulama Örneği: Kredi Onay Süreci
M&Y Yazılım Eğitim Akademi Danışmanlık bünyesinde Chain of Responsibility Design Pattern öğrenmek için yapılan Projedir.

# Chain of Responsibility Nedir?
Chain of Responsibility (Sorumluluk Zinciri), bir isteği işleyecek nesnelerin hiyerarşik bir zincir oluşturarak işlemesi prensibine dayanan bir tasarım desenidir. 
Bu desen, isteği gönderen nesnenin hangi nesne tarafından işleneceğini bilmeden işlem yapmasını sağlar.
Her nesne, isteği işleyip edemeyeceğini kontrol eder ve gerekirse zincirdeki bir sonraki nesneye ileterek işlemi zincir boyunca yönlendirir.

# Temel Prensipler ve Avantajlar
- ➡️Sorumluluk Zinciri Oluşturma: Farklı yetki seviyelerine sahip banka çalışanlarının oluşturduğu hiyerarşik yapı sayesinde kredi talepleri belirli bir sıra ile değerlendirilir.
- ➡️Esneklik ve Genişletilebilirlik: Yeni kredi onay süreçleri eklenebilir veya mevcut olanlar değiştirilebilir, böylece sistem esnek ve genişletilebilir olur.
- ➡️Nesneler Arası Bağımlılık Azaltma: Her nesne, yalnızca kendi sorumluluk alanındaki işlemleri gerçekleştirir, bu da sistemdeki bağımlılığı azaltır.

💸 Proje Örneği: Banka Kredi Onay Süreci

Bu proje, bir bankanın kredi onay sürecini simüle eder. Müşteriler, çekecekleri kredi miktarını belirterek başvuruda bulunurlar. İşte sürecin adımları:

⌨️ Kredi Talebi Girişi: Müşteri, çekeceği kredi miktarını girer. Bu talep, ilk olarak veznedar gibi düşük yetkili bir banka çalışanına iletilir.

📊 Kredi Değerlendirme ve Yönlendirme: Veznedar, belirli bir kredi onay limitine sahiptir. Eğer müşterinin talebi veznedarın limitini aşıyorsa, talep otomatik olarak daha yüksek yetkili bir çalışana iletilir, örneğin şube müdür yardımcısına.

✅❌ Kredi Onayı veya Reddi: Süreç, müşterinin talep ettiği kredi miktarı yetki seviyesi yeterli bir çalışan tarafından onaylandığında sonlanır.
Eğer talep edilen miktar en üst yetki seviyesinde bile onaylanamazsa, kredi reddedilir.

♟️Örnek Senaryo:
- Müşteri 350.000,00 TL'lik bir kredi talebinde bulunuyor.
- Veznedarın ödeme yapabileceği maksimum miktar 80.000,00 TL olduğu için bu işlemi veznedar gerçekleştirmez. 
- Şube Müdür Yardımcısını maksimum tutar 150.000.00 TL olduğu için bu işlemi Şube Müdür Yardımıcısı gerçekleştiremez.
- Şube Müdürünün maksimum tutar 250.000.00 TL olduğu için bu işlemi Şube Müdürü gerçekleştiremez.
- Bölge Müdürünün maksimum tutar 3600.000.00 TL olduğu için bu işlemi Bölge Müdürü gerçekleştirir.
- Eğer müşteri 80.000,00 TL talep etseydi, bu talep şube müdür yardımcısına yönlendirilirdi, çünkü bu işlem için gerekli olan limit 80.000,00 TL ile 150.000,00 TL arasındadır.

🌍Sonuç
Chain of Responsibility tasarım deseni, kompleks iş süreçlerini yönetmek ve farklı yetki seviyeleri gerektiren işlemleri etkili bir şekilde işlemek için güçlü bir araçtır.
Banka kredi onay süreci gibi senaryolarda bu desen, işlemlerin sıralı ve düzenli bir şekilde yönetilmesini sağlar, böylece sistem daha esnek, genişletilebilir ve bakımı kolay hale gelir.

#Default
   ![d](https://github.com/busenurdmb/ChainOfResponsibility/blob/master/ChainOfResp/wwwroot/%C4%B0simsiz-video-%E2%80%90-Clipchamp-ile-yap%C4%B1ld%C4%B1.gif)
   ![d](https://github.com/busenurdmb/ChainOfResponsibility/blob/master/ChainOfResp/wwwroot/chainvb.png)
