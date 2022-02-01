USE AnaOkulu

CREATE TABLE Notlar
(
OgrenciTC varchar(11) CONSTRAINT fk_ogrtc FOREIGN KEY REFERENCES Ogrenci(TC)  on delete cascade not null,
OgrNot varchar(1) CONSTRAINT ck_not CHECK (OgrNot LIKE '[1-5]') 
)
