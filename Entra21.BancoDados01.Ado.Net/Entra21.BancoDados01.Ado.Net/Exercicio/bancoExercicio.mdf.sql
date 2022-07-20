CREATE TABLE unidade_federativas (
 id INTEGER PRIMARY KEY IDENTITY(1,1),
 nome VARCHAR(30),
 sigla VARCHAR(2)
);

CREATE TABLE cidades (

id INTEGER PRIMARY KEY IDENTITY(1,1),
id_unidade_federativa INTEGER,
FOREIGN KEY(id_unidade_federativa) REFERENCES unidade_federativas(id),
nome VARCHAR(30),
quantidade_habitantes INTEGER,
data_hora_fundacao DATETIME2,
pib DECIMAL(10,2)
);

INSERT INTO cidades (nome, quantidade_habitantes, data_hora_fundacao, pib) VALUES (
'Blumenau', '30000', '2004-01-01 00:00:00', 45000000.00);





