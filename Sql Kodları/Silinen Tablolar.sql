CREATE TABLE SilinenOgrenci
(
OgrTC varchar(11) not null,
Ad varchar(30) NOT NULL,
Soyad varchar (30) NOT NULL,
DogumTarihi date NOT NULL, 
KayitTarihi date NOT NULL,
Sinif varchar(3) CONSTRAINT ck_siniff CHECK (Sinif IN ('A','B','C') ),
Adres varchar(150) not null,

)

CREATE TABLE SilinenVeli
(
VeliTC varchar(11) not null,
Ad varchar(30) not null,
Soyad varchar (30) not null,
Kullanici_Adi varchar(30) not null,
Sifre varchar(20) not null ,
Adres varchar(150) ,
)

CREATE TABLE SilinenOgretmen
(
OgretmenTC varchar(11) not null,
Ad varchar(30) NOT NULL,
Soyad varchar (30) NOT NULL,
Sinif varchar(3) CONSTRAINT ck_ogretmensiniff CHECK (Sinif IN ('A','B','C') ),
Kullanici_Adi varchar(30) not null,
Sifre varchar(30) not null,
Adres varchar(150) not null
)


