CREATE DATABASE ProjetoMVC;

USE ProjetoMVC;

CREATE TABLE Usuario
(
	usuario_id INT IDENTITY PRIMARY KEY,
	nome VARCHAR(250) NOT NULL,
	email VARCHAR(250) NOT NULL,
	senha VARCHAR(250) NOT NULL
)

SELECT * FROM Usuario

insert into Usuario (nome, email, senha) values 
('LUCAS', 'lucas@fmail.com', '123');

update Usuario set nome = 'LUCAS ALBERTO'
WHERE usuario_id = 2