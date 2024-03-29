﻿CREATE TABLE pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	tipo INTEGER,
	preco_unitario DECIMAL(6,2));

CREATE TABLE clientes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(40),
	cpf VARCHAR(14));

CREATE TABLE enderecos(
	id INTEGER PRIMARY KEY IDENTITY(1,1), -- PK
	id_cliente INTEGER NOT NULL, --FK
	cep VARCHAR(9) NOT NULL,
	estado VARCHAR(30) NOT NULL,
	cidade VARCHAR(30) NOT NULL,
	bairro VARCHAR(30) NOT NULL,
	logradouro VARCHAR(40) NOT NULL,
	numero VARCHAR(10) NOT NULL,
	descricao TEXT,

	-- FOREIGN KEY (nome_coluna_tabela_atual) REFERENCES nome_tabela_pai(nome_coluna_pai_pk)
	FOREIGN KEY (id_cliente) REFERENCES clientes(id));

CREATE TABLE pedidos(
	id INTEGER PRIMARY KEY IDENTITY(1,1), -- PK
	id_cliente INTEGER NOT NULL, -- FK
	status TINYINT NOT NULL, -- 0 .. 255
	data_compra DATETIME2,
	data_criacao DATETIME2 NOT NULL,
	);

CREATE TABLE pedido_pecas(
	id INTEGER PRIMARY KEY IDENTITY(1,1), -- PK
	id_peca INTEGER NOT NULL, -- FK tabela pecas
	id_pedido INTEGER NOT NULL, -- FK tabela pedidos
	
	quantidade SMALLINT,

	FOREIGN KEY(id_pedido) REFERENCES pedidos(id),
	FOREIGN KEY(id_peca) REFERENCES pecas(id));

-- TIPOS PEÇAS
-- 1 - SSD
-- 2 - PLACA DE VIDEO
-- 3 - PLACA MÃE
-- 4 - FONTE
-- 5 - MEMÓRIA RAM

INSERT INTO pecas(nome, tipo, preco_unitario) VALUES
('SSD 240 GB', 1, 200),
('SSD 240 M2', 1, 420.39),
('RTX 3090 TI', 2, 9999.90),
('GTX 1060', 2, 1500),
('16GB DDR4 4800Ghrz', 5, 800),
('16GB DDR4 3200Ghz', 5, 350);

INSERT INTO clientes(nome, cpf) VALUES
('Claudio', '070.355.489-73'),
('Cry', '032.599.384-69'),
('Julianã', '123.495.392-02');

INSERT INTO enderecos(id_cliente, estado, cidade, bairro, cep, logradouro, numero) VALUES
(1, 'SC', 'Blumenau', 'Velha', '89070-301', 'Rua Divinópolis', 777),
(2, 'SC', 'Blumenau', 'Velha Grande', '89070-472', 'Morro da Edith', 36),
(3, 'SC', 'Blumenau', 'Judity', 'Sem cep', 'Rua da Kellen', 23);

SELECT id, nome, tipo, preco_unitario FROM pecas;
SELECT id, nome, cpf FROM clientes;
SELECT id, id_cliente, estado, cidade, bairro, cep, logradouro, numero, descricao FROM enderecos;


-- Consulta para listar o nome, cpf e endereço completo do cliente
-- Consulta parte da tabela de clientes fazendo INNER JOIN com a tabela de endereços
SELECT
	c.nome AS 'Cliente',
	c.cpf as 'CPF',
	CONCAT(
		e.estado,  ' - ',
		e.cidade, ' - ',
		e.bairro, ' - ',
		e.logradouro, ' - ',
		e.numero) AS 'Endereço Completo'
	FROM clientes AS c
	INNER JOIN enderecos AS e ON(e.id_cliente = c.id);

-- Consultar os endereços apresentando seu cliente filtrando
-- Por bairos com nome 'Velha'
-- Consulta partindo da tabela de endereços com outra consulta na tabela de clientes
SELECT
	c.nome AS 'Cliente',
	e.bairro as 'Bairro',
	e.logradouro AS 'Logradouro'
	FROM enderecos AS e
	INNER JOIN clientes AS c ON(c.id = e.id_cliente)
	WHERE e.bairro LIKE '%Velha%';

-- STATUS
-- 0 - Carrinho
-- 1 - Aguardando pagamento
-- 2 - Pagamento efetivado
-- 3 - Entrega realizada
INSERT INTO pedidos (id_cliente, [status], data_criacao) VALUES
(1, 0, GETDATE()), -- Pedido para o Cláudio
((SELECT id FROM clientes WHERE nome = 'Cry'), 0, GETDATE()); -- Pedido para o Cry

-- Consultar pedidos listando data da criação formato PT-BR, o status com texto e
-- nome do cliente.[
-- Consulta partindo da tabela de pedido com INNER JOIN em clientes
SELECT
	FORMAT(p.data_criacao, 'dd/MM/yyyy') AS 'Data criação',
	CASE
		WHEN [status] = 0 THEN 'Carrinho'
		WHEN [status] = 1 THEN 'Aguardando pagamento'
		WHEN [status] = 2 THEN 'Pagamento efetivado'
		ELSE 'Entrega realizada'
	END AS 'Status pedido',
	c.nome
	FROM pedidos AS p
	INNER JOIN clientes AS c ON(p.id_cliente = c.id);

UPDATE pedidos SET status = 1 WHERE id = 2;

 --Adicionar as peças ao pedido
SELECT * FROM pecas;

INSERT INTO pedidos_pecas (id_pedido, id_peca, quantidade) VALUES
(1, 2, 2), -- 2 SSDs M2 para o pedido 1
(1, 4, 1), -- 1 GTX 1060 para o pedido 1
(1, 6, 1); -- 1 módulo 16Gb RAM DDR5
-- Alterar o cliente do pedido 1 para o cliente Cry.
UPDATE pedidos SET id_cliente = 2 WHERE id = 1
-- Consultar apresentando nome cliente, nome peça, 
-- quantidade, valor_unitario, total das peças
SELECT 
	pd.id AS 'Código pedido',
	c.nome AS 'Cliente',
	p.nome AS 'Peça',
	pp.quantidade AS 'Quantidade',
	CONCAT('R$ ', p.preco_unitario) AS 'Valor unitário',
	CONCAT('R$ ', p.preco_unitario * pp.quantidade) AS 'Total das peças'
	FROM pedidos_pecas AS pp
	INNER JOIN pecas AS p ON(pp.id_peca = p.id)
	INNER JOIN pedidos AS pd ON(pp.id_pedido = pd.id)
	INNER JOIN clientes AS c ON(pd.id_cliente = c.id);

	INSERT INTO pedidos (id_cliente, data_criacao, status) VALUES
	(1, GETDATE(), 0); -- GETDATE é o mesmo que DateTime.now

	SELECT * FROM pecas;

	INSERT INTO pedido_pecas(id_pedido, id_peca, quantidade) VALUES 
	(3,2,2),
	(3,3,2);

	-- INNER JOIN antes do where

	-- Criado pedido para o Claúdio

	INSERT INTO pedido_pecas(id_pedido, id_peca, quantidade) VALUES 
	(3,2,2), 
	(3,3,2),
	(3,5,4);

	-- Apresentar informações do pedido do claudio

	SELECT 
		p.id AS 'Código Pedido',
		p.status AS 'Status Pedido',
		c.nome AS 'Cliente',
		CONCAT(
		e.estado, '',
		e.cidade, '',
		e.bairro, '',
		e.logradouro, '',
		e.numero, '') AS 'Endereço completo'
		FROM pedidos AS p
		INNER JOIN clientes AS c ON(p.id_cliente = c.id)
		INNER JOIN enderecos AS e ON(c.id = e.id_cliente)
		WHERE p.id_cliente = (SELECT id FROM clientes WHERE cpf = '070.355.489-73');

		-- Efetivar a compra do pedido de Claúdio 

		UPDATE pedidos
		SET 
			status = 2,
			data_efetivacao_compra = '2022-07-12 17:00:00'
			WHERE 
			id = 3;

			-- FROM: diz onde esta partindo
			
			--Consultar peças do pedido do Claúdio

			SELECT 
			p.id AS 'Código Pedido',
			p.status AS 'Status Pedido',
			c.nome AS 'Cliente',
			pec.nome AS 'Peça'
			FROM pedidos AS p 
			INNER JOIN clientes AS c ON(p.id_cliente = c.id)
			INNER JOIN pedido_pecas AS pp ON(p.id = pp.id_pedido)
			INNER JOIN pecas AS pec ON(pp.id_peca = pec.id)
			WHERE p.id_cliente = (SELECT id FROM clientes WHERE cpf = '070.355.489-73');

