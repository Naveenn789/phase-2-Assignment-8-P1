create database Assesment8

use Assesment8

create table Products
(PId nvarchar(6) primary key ,
PName nvarchar(50) not null,
PPrice float not null,
MnfDate date not null,
ExpDate date not null
)

insert into Products values('P00001','Amaron','16000','05/31/2023','02/12/2025')
insert into Products values('P00002','GMC','2700','11/01/2022','09/19/2029')
insert into Products values('P00003','Mercury','7120','12/07/2019','01/03/2024')
insert into Products values('P00004','castro','900','02/23/2023','06/30/2027')
insert into Products values('P00005','DuraCell','520','05/31/2021','05/12/2025')
insert into Products values('P00006','Ponds','320','01/12/2020','09/17/2026')
insert into Products values('P00007','Fogg ','520','12/19/2022','02/03/2030')
insert into Products values('P00008','popins','150','09/21/2017','11/29/2024')
insert into Products values('P00009','Face Scrub','160','07/07/2023','04/30/2026')
insert into Products values('P00010','Detargent','980','06/15/2022','12/02/2025')

select * from Products
