
CREATE TRIGGER tr_SilinenOgrenci ON Ogrenci
AFTER DELETE
AS
BEGIN
DECLARE @TC varchar(11)
DECLARE @Ad varchar(20)
DECLARE @Soyad varchar(20)
DECLARE @DogumTarihi date
DECLARE @KayitTarihi date 
DECLARE @Sinif varchar(3)
DECLARE @Adres varchar(150)

SELECT @TC=TC FROM deleted
SELECT @Ad=Ad FROM deleted
SELECT @Soyad=Soyad FROM deleted
SELECT @DogumTarihi=DogumTarihi FROM deleted
SELECT @KayitTarihi=KayitTarihi FROM deleted
SELECT @Sinif=Sinif FROM deleted
SELECT @Adres=Adres FROM deleted

INSERT INTO SilinenOgrenci VALUES (@TC,@Ad,@Soyad,@DogumTarihi,@KayitTarihi,@Sinif,@Adres)

END


