DROP TABLE champions;


CREATE TABLE champions (

id INTEGER PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(25),
descricao VARCHAR (25),
habilidade_1 VARCHAR (25),
habilidade_2 VARCHAR (25),
habilidade_3 VARCHAR(25),
habilidade_4 VARCHAR(25),
habilidade_5 VARCHAR(25)

);

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, 
habilidade_3, habilidade_4, habilidade_5) VALUES ('Katarina', 'a Lâmina Sinistra',
'Voracidade', 'Lâmina Saltitante', 'Preparação', 'Shunpo', 'Lótus da Morte');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, 
habilidade_3, habilidade_4, habilidade_5) VALUES ('Yasuo', '', 'Estilo do Errante',
'Tempestade de Aço', 'Parede de Vento', 'Espada Ágil', 'Último Suspiro');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, 
habilidade_3, habilidade_4, habilidade_5) VALUES ('Master Yi', 'o Espadachim Wuju',
'Ataque Duplo', '', '', '', '');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, 
habilidade_3, habilidade_4, habilidade_5) VALUES ('Vayne', 'A caçadora N','Caçadora Noturna',
'Rolamento', 'Dardos de Prata', 'Condenar', 'Hora Final');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, 
habilidade_3, habilidade_4, habilidade_5) VALUES ('Lee Sin', 'o Monge Cego',
'Agitação', 'Onda Sônica Ataque Ressonante', 'Proteger Vontade de Ferro',
'Tempestade  Mutilar', '');
SELECT CONCAT (SUBSTRING(habilidade_2, 0, 12), '/') FROM champions
 WHERE id = 5;

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, 
habilidade_3, habilidade_4, habilidade_5) VALUES ('Vi', 'a Defensora de Piltover',
'Blindagem', '', 'Pancada Certeira', 'Força Excessiva', 'Saque e Enterrada');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, 
habilidade_3, habilidade_4, habilidade_5) VALUES ('Diana', 'O Escárnio da Lua', 'Espada de prata Lunar',
'Golpe Crescente', 'Cascata Lívida', 'Colapso Minguante', 'Zenite Lunar');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2, 
habilidade_3, habilidade_4, habilidade_5) VALUES ('A Criança Sombria', 'Piromania',
'Desintegrar', 'Incinerar', 'Escudo Fundido', 'Invocar Tibbers');

INSERT INTO champions (nome, descricao, habilidade_1, habilidade_2,
habilidade_3, habilidade_4, habilidade_5) VALUES ('Aatrox', '', 'Poço de Sangue', 'Voo Sombrio',
'Sede de Sangue / Preço de Sangue', 'Lâminas da afiliação', 'Massacre');


SELECT nome, descricao, habilidade_1, habilidade_2,
habilidade_3, habilidade_4, habilidade_5 FROM champions;
