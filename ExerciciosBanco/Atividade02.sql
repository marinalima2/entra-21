DROP TABLE enderecos;

CREATE TABLE enderecos (

id INTEGER PRIMARY KEY IDENTITY(1,1),
estado VARCHAR(2),
cidade VARCHAR (140),
bairro VARCHAR(120),
cep VARCHAR(10),
logradouro VARCHAR(250),
numero INTEGER, 
complemento TEXT

);



INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AC', 'AC Rio Branco	', 'Ayrton Senna', '69.911-866', 
'Estrada Deputado José Rui da Silveira Lino', '282', 'Casa');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('SC', 'Biguaçu', 'Fundos', '88.161-400', 
'', '995', '');


INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('MG', 'Santa Luzia', 'Padre Miguel', '33.082-050', 
'Rua Buenos Aires', '371', 'Apartamento');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('BA', '', 'São Tomé de
Paripe', '40.800-361', 
'Travessa Luís Hage',  '685', '');


INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('MG', 'Ipatinga', 'Vila Celeste', '', 
'Rua Antônio Boaventura Batista', '645', '');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('RS', 'Passo Fundo', 'Nenê Graeff', '99.030-250', 
'', '154', '');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AM', 'Manaus', 'Petrópolis', '69.079-300', 
'Rua Coronel Ferreira Sobrinho', '264', 'Fundos');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('TO', 'Gurupi', 'Muniz Santana', '77.402-130', 
'Rua Adelmo Aires Negri', '794', '');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AC', '', 'Preventório', '', 
'Beco da Ligação II', '212', 'Bloco B');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AP', 'Santana', 'Comercial', '68.925-073', 
'Rua Calçoene', '648', '');

INSERT INTO enderecos (estado, cidade, bairro, cep, logradouro, numero, complemento)
VALUES('AC', '', 'Preventório', '', 
'Beco da Ligação II', '249', '');


UPDATE enderecos SET estado = 'PB' , cidade = 'Cabedelo', 
bairro = 'Camalaú' , cep ='58.103-052' , logradouro= ' Rua Siqueira Campos', numero = '249', 
complemento = '' WHERE id = 11;

SELECT estado, cidade, bairro, cep, logradouro, numero, complemento FROM enderecos;



