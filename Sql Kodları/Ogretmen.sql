USE AnaOkulu

CREATE TABLE Ogretmen
(
OgretmenTC varchar(11) PRIMARY KEY,
Ad varchar(30) NOT NULL,
Soyad varchar (30) NOT NULL,
Sinif varchar(3) CONSTRAINT ck_ogretmensinif CHECK (Sinif IN ('A','B','C') ),
Kullanici_Adi varchar(30) not null,
Sifre varchar(30) not null,
Adres varchar(150) not null,
)
