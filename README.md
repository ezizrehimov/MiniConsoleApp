# MiniConsoleApp

Tapşırıq:
 Product class
 - No  (product-in nomresi string olaraq saxlaya bilersiz)
 - Name 
 - Price
 - Count (productun sayi)

 IStore interface
 - Products (Product listi)
 - ProductLimit (product-in limiti meselen tutalimki deyiremki marketimde max 100 dene mehsul olsun )
 - Totalİncome (Umumi gelir)
 - AddProduct() - product type-da obyekt qəbul edir və həmin obyekti əgər limit dolmayıbsa və list-də o nömrəli product yoxdursa list-ə əlavə edir
 - SellProduct() - string olaraq no dəyəri qəbul edir və list-də həmin nömrəli product varsa və countu 0 deyilsə onun satır.Satılma zamanı Totalİncome artır, count azalır


Market class - Bu class IStore interface-i implement edir

Layihə run olunduqda bizə aşağıdakı menu göstərilir və bir option seçməyimiz istənilir:
 1. Product əlavə et
 2. Product sat
 3. Productlara bax
 4. Menudan çıx

1 seçildikdə console bizdən productın yaradılması üçün lazım olan datalrı daxil etməyimizi istəməlidir (No, Name, Price, Count).Daha sonra həmin dəyərlər əsasında bir product yaradıb market obyektimizin AddProduct metodunu işə salır.
2 seçildikdə console bizdən satmaq istədiyimiz productın no dəyərini yazmağımızı istəyir.Onu yazdıqdan sonra market obyektimizin Sell metodunu işə salır
3 seçildikdə marketdəki bütün məhsullar console-da göstərilir (adları, qiymətləri,nömrələri və sayları)
Bu 3 seçimdən hər hansı biri seçilsə uyğun proses icra olub bitidkdən sonra yenidən eyni menu pəncərəsi açılmalıdır.
4 seçilərsə menudan çıxır və proqram bitir.
