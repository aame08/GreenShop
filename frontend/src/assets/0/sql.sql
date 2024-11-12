create database greenshop;
use greenshop;

create table Users (
	id_user int auto_increment,
    username varchar(100) not null,
    email_user varchar(100) not null,
    password_user varchar(30) not null,
    primary key (id_user)
);