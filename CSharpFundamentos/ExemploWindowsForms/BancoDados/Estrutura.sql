DROP TABLE IF EXISTS vendas_produtos;
DROP TABLE IF EXISTS vendas;
DROP TABLE IF EXISTS vendedores;
DROP TABLE IF EXISTS produtos;
DROP TABLE IF EXISTS categorias;
DROP TABLE IF EXISTS clientes;

CREATE TABLE categorias (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL
);



INSERT INTO categorias (nome) VALUES 
('Beleza'), -- 1
('Self Care'), -- 2
('Frutas'), -- 3
('Verduras'), -- 4
('Limpeza'), -- 5
('Churrasco'), -- 6
('Medicamentos'); -- 7

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

CREATE TABLE produtos(
	id INT PRIMARY KEY IDENTITY(1,1),

	categoria_id INT NOT NULL,

	nome VARCHAR(100) NOT NULL,
	preco_unitario DECIMAL(8,2) NOT NULL,
	habilitado_venda BIT NOT NULL,
	quantidade_estoque SMALLINT NOT NULL,

	FOREIGN KEY(categoria_id) REFERENCES categorias(id)
);

INSERT INTO produtos (nome, categoria_id, preco_unitario, habilitado_venda, quantidade_estoque) VALUES 
('Sabonete Gamer', 2, 15.00, 0, 2),
('Shampoo Gamer com dobro de FPS', 2, 168.47, 1, 150),
('Alcatra Casual', 6, 98.30, 1, 4),

('Sucrelhos', 6, 26.80, 1, 15),
('Pneu gamer', 1, 890.60, 0, 4),
('Maça 2.0', 3, 6.78, 1, 150),

('Cloro Enigmático', 5, 47.90, 1, 73),
('Cupim Gorduroso', 6, 88.88, 1, 64),
('Tomate Gamer', 3, 459.90, 0, 1);

-- Consultar os produtos e sua categoria
SELECT 
	produtos.id AS 'id',
	categorias.nome AS 'categoria',
	produtos.nome AS 'nome'
FROM produtos
	INNER JOIN categorias ON (produtos.categoria_id = categorias.id);


CREATE TABLE vendedores (
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100) NOT NULL,
	usuario VARCHAR(40) NOT NULL,
	senha VARCHAR(250) NOT NULL
);

INSERT INTO vendedores (nome, usuario, senha) VALUES 
('Marcão', 'marquinhos', 'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC'),
('Judity', 'judity', 'C7AD44CBAD762A5DA0A452F9E854FDC1E0E7A52A38015F23F3EAB1D80B931DD472634DFAC71CD34EBC35D16AB7FB8A90C81F975113D6C7538DC69DD8DE9077EC');

CREATE TABLE vendas (
	id INT PRIMARY KEY IDENTITY(1, 1),
	id_cliente INT NOT NULL,
	id_vendedor INT NOT NULL,
	data_hora_abertura DATETIME2 NOT NULL,
	data_hora_fechamento DATETIME2,
	[status] INT NOT NULL,
	motivo_cancelamento VARCHAR(200),
	valor DECIMAL(10, 2),

	FOREIGN KEY (id_cliente) REFERENCES clientes(id),
	FOREIGN KEY (id_vendedor) REFERENCES vendedores(id)
);

CREATE TABLE vendas_produtos(
	id INT PRIMARY KEY IDENTITY(1, 1),
	id_produto INT NOT NULL,
	id_venda INT NOT NULL,
	quantidade INT,

	FOREIGN KEY (id_produto) REFERENCES produtos(id),
	FOREIGN KEY (id_venda) REFERENCES vendas(id),
);


 SELECT 
                    vp.id,
                    vp.quantidade,
                    vp.id_produto,
                    p.nome,
                    p.preco_unitario
                    FROM vendas_produtos AS vp
                    INNER JOIN produtos AS p ON (vp.id_produto = p.id);

SELECT * FROM produtos;