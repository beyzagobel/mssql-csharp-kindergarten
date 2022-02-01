CREATE TRIGGER tr_SilinenOgretmen ON Ogretmen
AFTER DELETE
AS
BEGIN
DECLARE @OgretmenTC varchar(11)
DECLARE @Ad varchar(20)
DECLARE @Soyad varchar(20)
DECLARE @Sinif varchar(3)
DECLARE @Kullanici_Adi varchar(30)
DECLARE @Sifre varchar(20) 
DECLARE @Adres varchar(150)


SELECT @OgretmenTC=OgretmenTC FROM deleted
SELECT @Ad=Ad FROM deleted
SELECT @Soyad=Soyad FROM deleted
SELECT @Sinif=Sinif FROM deleted
SELECT @Kullanici_Adi=Kullanici_Adi FROM deleted
SELECT @Sifre=Sifre FROM deleted
SELECT @Adres=Adres FROM deleted


INSERT INTO SilinenOgretmen VALUES (@OgretmenTC,@Ad,@Soyad,@Sinif,@Kullanici_Adi,@Sifre,@Adres)

END

