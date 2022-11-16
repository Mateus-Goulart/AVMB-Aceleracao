create table tbl_medicos(
	id_medico integer constraint fk_id_crm primary key,
	crm integer not null,
	nome varchar(30),
	telefone varchar(16),
	especialidade varchar(50)
);

insert into tbl_medicos values (1,3003033,'Manoel Silveira','(55)99999-9999','Cirurgião');

create table tbl_contatos(
	id_contato integer constraint fk_id_contato primary key,
	nome varchar(30),
	telefone varchar(16),
	data_nascimento date,
	endereço text,
	cpf varchar(15)	
);

insert into tbl_contatos values (1,'Mariana Álves','(55)92222-2222','1983-10-11','Rua Doutor Bozano, Maria Noal, Caxias do Sul - RS','000.000.000-00');

create table tbl_prontuario(
	id_paciente serial constraint fk_id_paciente primary key,
	nome varchar(30),
	data_nascimento date,
	peso numeric,
	altura numeric,
	fk_medico integer not null,
	fk_familiar_mae integer not null,
	foreign key (fk_medico) references tbl_medicos (id_medico),
	foreign key (fk_familiar_mae) references tbl_contatos (id_contato)
);

insert into tbl_prontuario values (1,'Marcos Álves','2022-10-30',7.5,0.5,1,1);

create table tbl_berco(
	id_berco integer constraint fk_id_berco primary key,
	nome integer not null,
	fk_contato integer not null,
	fk_medico integer not null,
	foreign key (fk_contato) references tbl_contatos (id_contato),
	foreign key (fk_medico) references tbl_medicos (id_medico),
	foreign key (nome) references tbl_prontuario (id_paciente)
);

insert into tbl_berco values (12,1,1,1);