create database teste;
use teste;

create table clientes(
id int auto_increment,
nome varchar(100),
primary key (id)
);

create table funcionarios(
id int auto_increment,
nome varchar(100),
primary key (id)
);

create table produtos(
id int auto_increment,
nome varchar(100),
valor double(6, 2),
primary key (id)
);

create table vendas(
id int auto_increment,
idCliente int,
idProduto int,
idFuncionario int,
primary key (id),
foreign key (idCliente) references clientes(id),
foreign key (idProduto) references produtos(id),
foreign key (idFuncionario) references funcionarios(id)
);