create table tbl_categorias 
(
	id_categoria integer not null,
	tipo_categoria varchar(20),
	PRIMARY KEY (id_categoria)
);

insert into tbl_categorias values (1,'terror');

create table tbl_editora(
	id_editora integer not null,
	nome_editora varchar(20),
	primary key (id_editora)
);

insert into tbl_editora values (1,'Suma');

create table tbl_nacionalidade (
	id_nacionalidade integer CONSTRAINT pk_id_nacionalidade PRIMARY KEY,
	tipo_nacionalidade varchar(10)
);

insert into tbl_nacionalidade values (1,'Americano');

create table tbl_autor (
	id_autor integer CONSTRAINT pk_id_autor PRIMARY KEY,
	nome varchar(30),
	fk_nacionalidade integer not null,
	data_nasc date,
	foreign key (fk_nacionalidade) REFERENCES tbl_nacionalidade(id_nacionalidade)
);

insert into tbl_autor values (1,'Stephen King',1,'1947-9-21');

create table tbl_livro(
	id_livro serial constraint fk_id_livro primary key,
	titulo varchar(50),
	publicação date,
	fk_editora integer not null,
	fk_categoria integer not null,
	foreign key (fk_editora) References tbl_editora(fk_id_editora),
	foreign key (fk_categoria) References tbl_categorias(fk_id_categoria)
);


create table tbl_livroautor(
	id_livroautor integer CONSTRAINT pk_id_livroautor PRIMARY Key,
	fk_livro integer not null,
	fk_autor integer not null,
	foreign key (fk_livro) References tbl_livro(fk_id_livro),
	foreign key (fk_autor) References tbl_autor(fk_id_autor)
);

