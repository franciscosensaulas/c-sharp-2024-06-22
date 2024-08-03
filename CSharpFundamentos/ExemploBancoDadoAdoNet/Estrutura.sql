-- Apagar o banco de dados caso existir
-- DROP DATABASE IF EXISTS locadora;
-- Criar o banco de dados locadora
-- CREATE DATABASE locadora;
-- Definir o banco de dados que será utilizado
-- USE locadora;
-- Criar tabela de categorias
CREATE TABLE categorias(
	id INT PRIMARY KEY IDENTITY(1,1),
    nome VARCHAR(100), -- VARCHAR é utilizado para texto, definimos que o 
    -- tamanho máximo que será armazenado será de 100 caracteres
    descricao TEXT -- É um texto longo
);

-- PRIMARY KEY: é a chave primária, ou seja, uma chave única nessa tabela, exemplos cpf
-- IDENTITY: faz a coluna ser incrementada automaticamente, ou seja, o id será preenchido
-- com 1, próximo registro será 2.

-- Criar um registro na tabela de categorias
INSERT INTO categorias (nome, descricao) VALUES ('Terror', 'Explore o desconhecido e o sobrenatural com histórias que desafiam seus medos mais profundos e criam uma atmosfera de puro suspense.');

-- Consultar os registros da tabela de categorias
SELECT id, nome, descricao FROM categorias;
