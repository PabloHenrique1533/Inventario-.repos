CREATE DATABASE estoque;
USE estoque;
drop database estoque;
-- Criação das tabelas no MySQL

CREATE TABLE LocalizacaoEstoque (
    idLocalizacaoEstoque INTEGER PRIMARY KEY AUTO_INCREMENT
);

CREATE TABLE Pessoa (
    idPessoa INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(100),
    email VARCHAR(100),
    cpf CHAR(11),
    data_nascimento DATE,
    endereco VARCHAR(100)
);

CREATE TABLE Fornecedor (
    idFornecedor INTEGER PRIMARY KEY AUTO_INCREMENT,
    Pessoa_idPessoa INTEGER,
    cnpj char(11),
    telefone char(11),
    FOREIGN KEY (Pessoa_idPessoa) REFERENCES Pessoa(idPessoa)
);

CREATE TABLE Usuario (
    idUsuario INTEGER PRIMARY KEY AUTO_INCREMENT,
    nome_completo VARCHAR(100),
    usuario VARCHAR(100) unique,
    senha VARCHAR(100),
    data_nascimento DATE,
    email VARCHAR(100) 
);

'CREATE TABLE Cliente (
    idcliente INTEGER PRIMARY KEY AUTO_INCREMENT,
    Pessoa_idPessoa INTEGER,
    cpf VARCHAR(100),
    FOREIGN KEY (Pessoa_idPessoa) REFERENCES Pessoa(idPessoa)
);'

CREATE TABLE Produto (
    idProduto INTEGER PRIMARY KEY AUTO_INCREMENT,
    LocalizacaoEstoque_id INTEGER,
    Fornecedor_idFornecedor INTEGER,
    nome VARCHAR(100),
    descricao VARCHAR(100),
    preco_compra DOUBLE,
    qnt_estoque INTEGER,
    qnt_min INTEGER,
    categoria VARCHAR(100),
    FOREIGN KEY (LocalizacaoEstoque_id) REFERENCES LocalizacaoEstoque (idLocalizacaoEstoque),
    FOREIGN KEY (Fornecedor_idFornecedor) REFERENCES Fornecedor(idFornecedor)
);

CREATE TABLE Pedido (
    idPedido INTEGER PRIMARY KEY AUTO_INCREMENT,
    data_pedido DATE,
    data_entrega DATE,
    status_pedido VARCHAR(100),
    valor_total DOUBLE
);

CREATE TABLE Produto_has_Pedido (
    Produto_idProduto INTEGER,
    Pedido_idPedido INTEGER,
    quantidade INTEGER,
    preco_unitario DOUBLE,
    subtotal DOUBLE,
    PRIMARY KEY (Produto_idProduto, Pedido_idPedido),
    FOREIGN KEY (Produto_idProduto) REFERENCES Produto(idProduto),
    FOREIGN KEY (Pedido_idPedido) REFERENCES Pedido(idPedido)
);

CREATE TABLE Item_do_pedido (
    iditem_do_pedido INTEGER PRIMARY KEY AUTO_INCREMENT,
    Pedido_idPedido INTEGER,
    quantidade INTEGER,
    preco_unitario DOUBLE,
    subtotal DOUBLE,
    FOREIGN KEY (Pedido_idPedido) REFERENCES Pedido(idPedido)
);

CREATE TABLE Relatorio (
    idRelatorio INTEGER PRIMARY KEY AUTO_INCREMENT,
    Usuario_idUsuario INTEGER,
    tipo VARCHAR(100),
    data_geracao DATE,
    FOREIGN KEY (Usuario_idUsuario) REFERENCES Usuario(idUsuario)
);

select pessoa.nome, pessoa.email, pessoa.cpf, pessoa.data_nascimento, pessoa.endereco, fornecedor.cnpj, fornecedor.telefone from pessoa left join fornecedor on fornedor.idpessoa = pessoa.idpessoa ;
select * from fornecedor;