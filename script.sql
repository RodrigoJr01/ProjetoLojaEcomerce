create database dbProjetoLoja;
-- CRIANDO BANCO DE DADOS

use dbProjetoLoja;
 
 -- CRIANDO AS TABELAS DO BANCO DE DADOS
 create table tb_Usuario(
 Id int primary key auto_increment,
 Nome varchar(50) not null,
 Email varchar(50) not null,
 Senha varchar(250) not null,
 Nivel varchar(50) not null
 );
 
 -- CONSULTANDO A TABELA DO BANCO DE DADOS
 
 select * from tb_Usuario;
 
 -- INSERINDO DADOS NA TABELA DO BANCO DE DADOS
 
 insert into tb_Usuario(Nome,Email,Senha,Nivel)values ('Administrador','admin@email.com','123456','Admin')