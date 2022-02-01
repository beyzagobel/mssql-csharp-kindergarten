CREATE TRIGGER tr_SilinenVeli ON Veli
AFTER DELETE
AS
BEGIN
DECLARE @VeliTC varchar(11)
DECLARE @Ad varchar(20)
DECLARE @Soyad varchar(20)
DECLARE @Kullanici_Adi varchar(30)
DECLARE @Sifre varchar(20) 
DECLARE @Adres varchar(150)

SELECT @VeliTC=VeliTC FROM deleted
SELECT @Ad=Ad FROM deleted
SELECT @Soyad=Soyad FROM deleted
SELECT @Kullanici_Adi=Kullanici_Adi FROM deleted
SELECT @Sifre=Sifre FROM deleted
SELECT @Adres=Adres FROM deleted

INSERT INTO SilinenVeli VALUES (@VeliTC,@Ad,@Soyad,@Kullanici_Adi,@Sifre,@Adres)

END

--ALTER TABLE Veli enable trigger tr_SilinenVeli

