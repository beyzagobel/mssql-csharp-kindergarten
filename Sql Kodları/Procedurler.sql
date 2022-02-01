
use AnaOkulu
go
create proc SinifA
as
begin

select TC,Ad,Soyad,n.OgrNot from Ogrenci o Left Outer Join Notlar n on
o.TC=n.OgrenciTC where Sinif like 'A'

end


use AnaOkulu
go
create proc SinifB
as
begin

select TC,Ad,Soyad,n.OgrNot from Ogrenci o Left Outer Join Notlar n on
o.TC=n.OgrenciTC where Sinif like 'B'

end


use AnaOkulu
go
create proc SinifC
as
begin

Select TC,Ad,Soyad,n.OgrNot from Ogrenci o Left Outer Join Notlar n on
o.TC=n.OgrenciTC where Sinif like 'C'

end



use AnaOkulu
go
create proc VeliProc
as
begin

Select o.TC,o.Ad,o.Soyad,n.OgrNot from Notlar n Inner Join Ogrenci o on 
o.TC=n.OgrenciTC Inner Join Veli v on o.Soyad=v.Soyad 


end



