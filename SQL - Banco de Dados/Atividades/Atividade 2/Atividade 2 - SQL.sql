
-- Criação de Tabelas

---- Tabela de Médicos
create table tbl_medicos(
	id_medico integer constraint id_medico primary key,
	crm integer not null,
	nome varchar(30),
	telefone varchar(16),
	especialidade varchar(50)
);

--- Tabela de Contatos
create table tbl_contatos(
	id_contato integer constraint id_contato primary key,
	nome varchar(30),
	telefone varchar(16),
	data_nascimento date,
	endereço text,
	cpf varchar(15)	
);

--Tabela da Criança (Prontuario)
create table tbl_prontuario(
	id_paciente serial constraint id_paciente primary key,
	nome varchar(30),
	data_nascimento date,
	peso numeric,
	altura numeric,
	fk_medico integer not null,
	fk_familiar_mae integer not null,
	foreign key (fk_medico) references tbl_medicos (id_medico),
	foreign key (fk_familiar_mae) references tbl_contatos (id_contato)
);

-- Tabela de Berços
create table tbl_berco(
	id_berco integer constraint id_berco primary key,
	nome integer not null,
	fk_contato integer not null,
	fk_medico integer not null,
	foreign key (fk_contato) references tbl_contatos (id_contato),
	foreign key (fk_medico) references tbl_medicos (id_medico),
	foreign key (nome) references tbl_prontuario (id_paciente)
);

-- Inserir dados 

--- Tabela Contatos
insert into tbl_contatos values (1,'Mariana Álves','(55)92222-2222','1983-10-11','Rua Doutor Bozano, Maria Noal, Caxias do Sul - RS','000.000.000-00');

--- Tabela Médicos
insert into tbl_medicos values (1,3003033,'Manoel Silveira','(55)99999-9999','Cirurgião');

--- Tabela Prontuario
insert into tbl_prontuario values (1,'Marcos Álves','2022-10-30',7.5,0.5,1,1);

--- Tabela Berço
insert into tbl_berco values (12,1,1,1);


-----------------------------------Exercicio 2---------------------------------------------

-- Criação de Tabelas

-- Tabela de Clientes
create table tbl_clientes
(
	id_cliente integer constraint id_cliente primary key,
	nome_cliente varchar(50),
	rg integer not null,
	endereço varchar(100),
	terlefone_celular varchar(15)
);

-- Inserir clientes na tabela
insert into tbl_clientes values (1,'Maria da Silva',80392542,'Rua Machado de Alves, 130 - 20340-51 - XX','(55)99999-9999');
insert into tbl_clientes values (2,'George Machado',20451485,'Rua das Canaeiras, 150 - 20441-21 - XX','(55)99999-9999');
insert into tbl_clientes values (3,'Ana Carolina Almeida',23462311,'Rua Machado de Alves, 180 - 20340-51 - XX','(55)99999-9999');
insert into tbl_clientes values (4,'Michael Dornon',63143289,'Rua da Mangueira, 120 - 22471-51 - XX','(55)99999-9999');

-- Tabela de Tipos
create table tbl_tipos
(
	id_tipo integer constraint id_tipo primary key,
	nome_tipo varchar(20)
);

-- Inserir os tipos presentes na tabela
insert into tbl_tipos values (1,'Vaso');
insert into tbl_tipos values (2,'Flor');
insert into tbl_tipos values (3,'Planta');
insert into tbl_tipos values (4,'Fertilizante');
insert into tbl_tipos values (5,'Sementes');
insert into tbl_tipos values (6,'Itens de Jardinagem');

-- Tabela de Produtos
create table tbl_produtos
(
	id_produto integer constraint id_produto primary key,
	nome_produto varchar(40),
	tipo integer not null,
	preco money,
	estoque integer,
	foreign key (tipo) references tbl_tipos (id_tipo)
);

-- Inserir Produtos na Tabela
insert into tbl_produtos values (1,'Sementes de Girassol',5,2.65,500);
insert into tbl_produtos values (2,'Rosa',2,1.65,30);
insert into tbl_produtos values (3,'Girassol',2,2.00,40);
insert into tbl_produtos values (4,'Sementes de Rosa',5,3.20,500);
insert into tbl_produtos values (5,'Vaso Médio para Flores',1,4.20,70);

-- Tabela de Compras
create table tbl_compra 
(
	id_compra serial constraint id_compra primary key,
	cliente integer not null,
	produto integer not null,
	quantidade integer not null,
	foreign key (cliente) references tbl_clientes (id_cliente),
	foreign key (produto) references tbl_produtos (id_produto)
);

-- Inserir Registros de Compras na Tabela
insert into tbl_compra (cliente, produto, quantidade) values (1,2,5);
insert into tbl_compra (cliente, produto, quantidade) values (3,5,1);
insert into tbl_compra (cliente, produto, quantidade) values (2,2,5);
insert into tbl_compra (cliente, produto, quantidade) values (1,5,3);