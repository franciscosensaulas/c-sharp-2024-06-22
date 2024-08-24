DROP TABLE IF EXISTS categorias;
DROP TABLE IF EXISTS clientes;

CREATE TABLE categorias (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL
);

INSERT INTO categorias (nome) VALUES 
('Beleza'),
('Self Care'),
('Frutas'),
('Verdeuras'),
('Limpeza'),
('Churrasco'),
('Medicamentos');

CREATE TABLE clientes (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(250) NOT NULL,
	cpf CHAR(14) NOT NULL,
	email VARCHAR(200) NOT NULL,
	uf CHAR(2) NOT NULL,
	cidade VARCHAR(100) NOT NULL,
	logradouro VARCHAR(150) NOT NULL,
	bairro VARCHAR(100) NOT NULL,
	cep CHAR(10) NOT NULL,
	numero VARCHAR(50) NOT NULL,
	complemento VARCHAR(150) NOT NULL,
	descricao TEXT
);

INSERT INTO clientes (nome, cpf, email, uf, cidade, logradouro, bairro, cep, numero, complemento, descricao) VALUES 
('Brenda Letícia Isabella Carvalho', '508.255.717-31', 'brendaleticiacarvalho@righettorosa.com.br', 'AM', 'Manaus', 'Avenida Carvalho Leal', 'São Francisco', '69079-030', '879', 'Casa Roxa', 'Cliente feliz com sistema');

