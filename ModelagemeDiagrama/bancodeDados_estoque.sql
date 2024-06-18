CREATE DATABASE estoque;
USE estoque;
drop database estoque;
-- Criação das tabelas no MySQL

CREATE TABLE LocalizacaoEstoque (
    idLocalizacaoEstoque INTEGER PRIMARY KEY AUTO_INCREMENT
);

CREATE TABLE PessoaFornecedor (
    idPessoaFornecedor INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100),
    email VARCHAR(100),
    cpf CHAR(11),
    data_nascimento DATE,
    cnpj char(11),
    telefone char(11),
    endereco VARCHAR(100)
);


CREATE TABLE Usuario (
    idUsuario INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome_completo VARCHAR(100),
    usuario VARCHAR(100) unique,
    senha VARCHAR(100),
    data_nascimento DATE,
    email VARCHAR(100) 
);

CREATE TABLE Produto (
    idProduto INTEGER PRIMARY KEY AUTO_INCREMENT,
    LocalizacaoEstoque_id INTEGER,
    PessoaFornecedor_idPessoaFornecedor INTEGER,
    nome VARCHAR(100),
    qnt_estoque INTEGER,
    qnt_min INTEGER,
    qnt_atual int,
    FOREIGN KEY (LocalizacaoEstoque_id) REFERENCES LocalizacaoEstoque (idLocalizacaoEstoque),
    FOREIGN KEY (PessoaFornecedor_idPessoaFornecedor) REFERENCES PessoaFornecedor(idPessoaFornecedor)
);

CREATE TABLE Pedido (
    idPedido INTEGER PRIMARY KEY AUTO_INCREMENT,
    pedido VARCHAR(100),
    data_pedido DATE,
    data_entrega DATE,
    quantidade INTEGER,
    preco_unitario DOUBLE,
    valor_total DOUBLE,
    forma_pagamento text
);

CREATE TABLE Produto_has_Pedido (
    Produto_idProduto INTEGER,
    Pedido_idPedido INTEGER,
	data_pedido DATE,
    data_entrega DATE,
    quantidade INTEGER,
    preco_unitario DOUBLE,
    PRIMARY KEY (Produto_idProduto, Pedido_idPedido),
    FOREIGN KEY (Produto_idProduto) REFERENCES Produto(idProduto),
    FOREIGN KEY (Pedido_idPedido) REFERENCES Pedido(idPedido)
);

select * from Produto;
select * from usuario;
select * from pedido;

