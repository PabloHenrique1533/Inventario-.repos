create database estoque;
use estoque;
drop database estoque;



-- Criação das tabelas no MySQL

CREATE TABLE LocalizacaoEstoque (
    idLocalizacaoEstoque INTEGER PRIMARY KEY
);

CREATE TABLE Pessoa (
    idPessoa INTEGER PRIMARY KEY,
    nome VARCHAR(100),
    email VARCHAR(100),
    endereco VARCHAR(100)
);

CREATE TABLE Fornecedor (
    idFornecedor INTEGER PRIMARY KEY,
    Pessoa_idPessoa INTEGER,
    cnpj INT,
    telefone INTEGER,
    FOREIGN KEY (Pessoa_idPessoa) REFERENCES Pessoa(idPessoa)
);

CREATE TABLE Usuario (
    idUsuario INTEGER PRIMARY KEY,
    Pessoa_idPessoa INTEGER,
    senha INTEGER,
    nome_completo VARCHAR(100),
    tipo VARCHAR(100),
    cargo VARCHAR(100),
    permissoes_acesso VARCHAR(100),
    FOREIGN KEY (Pessoa_idPessoa) REFERENCES Pessoa(idPessoa)
);

CREATE TABLE Cliente (
    idcliente INTEGER PRIMARY KEY,
    Pessoa_idPessoa INTEGER,
    cpf VARCHAR(100),
    FOREIGN KEY (Pessoa_idPessoa) REFERENCES Pessoa(idPessoa)
);

CREATE TABLE Produto (
    idProduto INTEGER PRIMARY KEY,
    LocalizacaoEstoque_idLocalizacaoEstoque INTEGER,
    Fornecedor_idFornecedor INTEGER,
    nome VARCHAR(100),
    descricao VARCHAR(100),
    preco_compra DOUBLE,
    qnt_estoque INTEGER,
    qnt_min INTEGER,
    categoria VARCHAR(100),
    FOREIGN KEY (LocalizacaoEstoque_idLocalizacaoEstoque) REFERENCES LocalizacaoEstoque(idLocalizacaoEstoque),
    FOREIGN KEY (Fornecedor_idFornecedor) REFERENCES Fornecedor(idFornecedor)
);

CREATE TABLE Pedido (
    idPedido INTEGER PRIMARY KEY,
    cliente_idcliente INTEGER,
    data_pedido DATE,
    data_entrega DATE,
    status_pedido VARCHAR(100),
    valor_total DOUBLE,
    FOREIGN KEY (cliente_idcliente) REFERENCES Cliente(idcliente)
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
    iditem_do_pedido INTEGER PRIMARY KEY,
    Pedido_idPedido INTEGER,
    quantidade INTEGER,
    preco_unitario DOUBLE,
    subtotal DOUBLE,
    FOREIGN KEY (Pedido_idPedido) REFERENCES Pedido(idPedido)
);

CREATE TABLE Relatorio (
    idRelatorio INTEGER PRIMARY KEY,
    Usuario_idUsuario INTEGER,
    tipo VARCHAR(100),
    data_geracao DATE,
    FOREIGN KEY (Usuario_idUsuario) REFERENCES Usuario(idUsuario)
);

select * from relatorio

