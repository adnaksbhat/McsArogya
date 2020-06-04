create database arogya;
use arogya;
--select * from users;
create table users
(
	id int identity(1,1) primary key,
	username varchar(255) not null,
	password varchar(255) not null
);
--select * from members;

insert into users values('user','user');

--select * from users;

create table members
(
	id int identity(1,1),
	anum bigint primary key,
	name varchar(255) not null,
	address varchar(255) not null,
	contact bigint not null,
	age bigint,
	aadhar bigint not null,
	rc_type varchar(10) not null,
	mc_status varchar(7) not null,
	blood_group varchar(10) not null,
	occupation varchar(255) not null
);

--select * from members

create table claimants
(
	id int identity(1,1),
	anum bigint primary key,
	name varchar(255) not null,
	age int not null,
	address varchar(255) not null,
	a_card bigint not null,
	contact bigint not null,
	d_desc varchar(255) not null,
	hosp_name varchar(255) not null
);

--select * from claimants;