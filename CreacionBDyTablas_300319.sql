CREATE DATABASE AESEMBD
USE AESEMBD
CREATE TABLE USUARIOS (Id_Usuarios int primary key identity, Nickname varchar(15),
Nombre varchar(20),Ape_Pat varchar(12), Ape_Mat varchar(12), Password varchar(20))
CREATE TABLE EMPRESAS (Id_Empresas int primary key identity, Nombre varchar(50), Logo image,
Lugar varchar(30),TipoPago int, Sindicato varchar(200), Concepto varchar(200), Comentarios varchar(255))
CREATE TABLE Sucursales(Id_Sucursales int primary key,
Id_Empresas int foreign key references Empresas(Id_Empresas) on update cascade on delete cascade,
Nombre varchar(30), Direccion varchar(50))