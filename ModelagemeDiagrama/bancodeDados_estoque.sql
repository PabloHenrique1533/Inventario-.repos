create database estoque;
use estoque;
drop database estoque;

create table Produto
(idProduto integer primary key,
idFornecedor int,
nome varchar(100),
descrição text,
preço_compra decimal(10,2),
qnt_estoque int,
qnt_min int,
categoria varchar(100),
dt_entrada_estoque date,
constraint fornecedor_FK foreign key (idFornecedor) references Fornecedor (idFornecedor));

create table Fornecedor
(idFornecedor integer primary key,
nome varchar(100),
cnpj varchar(14),
endereco varchar(100),
telefone varchar(20),
email varchar(100));

create table Pedido
(idPedido integer primary key,
idUsuario int,
idCliente int,
idProduto int,
data_pedido date,
data_entrega_esperada date,
status_pedido varchar(100),
valor_total decimal(10,2),
constraint usuario_FK foreign key (idUsuario) references usuario (idUsuario),
constraint cliente_FK foreign key (idCliente) references cliente (idCliente),
constraint produto_FK foreign key (idProduto) references Produto (idProduto));

create table Cliente
(idCliente integer primary key,
idEndereco int ,
nome varchar(100),
cpf char(11),
endereco varchar(100),
email varchar(100),
constraint endereco_FK foreign key (idEndereco) references endereco (idEndereco));

create table endereco
(idEndereco integer primary key,
cep char(8),
nome_rua varchar(100),
complemento varchar(100),
numero_casa int);

create table item_do_pedido
(idItem_Pedido integer primary key,
idPedido int,
quantidade int,
preco_unitario decimal(10,2),
subtotal decimal(10,2),
constraint pedido_FK foreign key (idPedido) references Pedido (idPedido));

create table Usuario
(idUsuario integer primary key,
nome_usuario varchar(100),
senha varchar(100),
nome_completo varchar(100),
cargo varchar(100),
permissoes_acesso text);

