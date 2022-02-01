USE AnaOkulu

CREATE TABLE Ogrenci
(
TC varchar(11) PRIMARY KEY,
Ad varchar(30) NOT NULL,
Soyad varchar (30) NOT NULL,
DogumTarihi date NOT NULL, 
KayitTarihi date NOT NULL,
Sinif varchar(3) CONSTRAINT ck_sinif CHECK (Sinif IN ('A','B','C') ),
Adres varchar(150) not null,

)


