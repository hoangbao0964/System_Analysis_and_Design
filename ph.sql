drop table tournament
drop table team
drop table Player
drop table point
create table tournament
(
	Keys varchar(10) not null,
	Type varchar(20),
	Name varchar(50),
)
create table team
(
	Keys varchar(10) not null,
	TName varchar(20) not null,
)
create table Player
(
	Keys varchar(10),
    TName varchar(20),
	PName varchar(20),
	KitNum numeric(2),
)
create table point
(
Keys varchar(10),
TName varchar(20),
Round varchar(10),
Point numeric(20) default N'0',
)
---PK
alter table tournament add constraint PK1 Primary Key (Keys) 
alter table team add constraint PK2 Primary Key (TName,Keys)
alter table team add constraint FK1 Foreign Key (Keys) references Tournament(Keys)
alter table player add constraint FK2 Foreign Key(Keys) references Tournament(Keys)
alter table player add constraint FK3 Foreign Key(TName,Keys) references Team(TName,Keys)
alter table point add constraint FK4 foreign key (TName,Keys) references Team(TName,Keys)
insert into tournament values('vippar17', '4 Teams', 'Solo Yasuo') 
insert into tournament values('Yasuo', '8 Teams', 'Solo Yasuo') 
insert into team values('vippar17','Chel')
insert into team values('vippar17','MU')
insert into team values('vippar17','MC')
insert into team values('vippar17','ToT')
insert into team values('Yasuo','ToT')


insert into player values('vippar17','MU','DucPro',2)
insert into player values('vippar17','MU','DucVIP',3)
insert into player values('vippar17','Chel','DucVIP',3)
insert into player values('vippar17','Chel','Du123P',32)
insert into player values('vippar17','Chel;','D121233IP',43)
insert into player values('vippar17','Chel','D213VIP',53)
insert into tournament values('v1223', '16 Teams', 'Solo Yasuo') 
select * from player where keys like 'vippar17' and TName like 'MU'
select * from player where keys like 'vippar17' and TName like 'MU' and KitNum like 2
select * from player where keys like 'vippar17' and TName like 'Chel'
select * from tournament 
insert into point values ('vippar17','MU','1',3)
insert into point values ('vippar17','Chel','1',2)
insert into point values ('vippar17','ToT','1',4)
insert into point values ('vippar17','MC','1',5)

select * from point where keys like 'vippar17'
select * from player where keys like 'vippar17' and TName like 'MU'

select *from team

select p.keys, t.TName, p.Round, p.Point from team as t
inner join point as p
on p.keys = t.keys and p.TName = t.TName
Select * from point Where Keys like 'vippar17' and Round like '2' and TName like'MU'
update point set Point = 5 ,TName='Mcc' where Keys = 'yasuo' and TName = 'Chel' and Round = 2
       select * from point 
	   update team set Team.TName = Point.TName = 'MCC'  where Keys ='vippar17' and TName = 'MC'
select * from point where Keys like 'yasuo' 