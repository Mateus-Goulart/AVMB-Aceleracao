-- Criação da database - Biblioteca;
create database biblioteca;


-- Criação das Tabelas na Ordem de: Categorias, Nacionalidade (origem), Editoras, Autores, Livros, Autores - Livros (Co-Relação);

create table tbl_categorias (
	id_categoria integer constraint id_categoria primary key,
	nome_categoria varchar(30)
);

create table tbl_nacionalidade (
	id_pais integer constraint id_pais primary key,
	nome_pais varchar(30)
);

create table tbl_editora (
	id_editora integer constraint id_editora primary key,
	nome_editora varchar(50)
);

create table tbl_autores (
	id_autor integer constraint id_autor primary key,
	nome_autor varchar(60),
	data_nascimento date,
	origem integer not null,
	foreign key (origem) references tbl_nacionalidade (id_pais)
	
);

create table tbl_livro 
(
	id_livro serial constraint id_livro primary key,
	titulo varchar(100),
	publicacao date,
	editora integer not null,
	categoria integer not null,
	foreign key(editora) references tbl_editora(id_editora),
	foreign key(categoria) references tbl_categorias(id_categoria)
)

create table tbl_livroautor (
	id_livroautor integer constraint id_livroautor primary key,
	livro integer not null,
	autor integer not null,
	foreign key (livro) references tbl_livro(id_livro),
	foreign key (autor) references tbl_autores(id_autor)
);

-- Inserção de Dados;

-- tbl_categorias;
insert into tbl_categorias values (1,'Aventura');
insert into tbl_categorias values (2,'Romance');
insert into tbl_categorias values (3,'Terror');
insert into tbl_categorias values (4,'Ação');
insert into tbl_categorias values (5,'Drama');
insert into tbl_categorias values (6,'Ficção Científica');
insert into tbl_categorias values (7,'Fantasia');
insert into tbl_categorias values (8,'Infantil');
insert into tbl_categorias values (9,'Clássicos');
insert into tbl_categorias values (10,'Contos');
-- tbl_nacionalidade;
insert into tbl_nacionalidade values (1,'Brasil');
insert into tbl_nacionalidade values (2,'Estados Unidos');
insert into tbl_nacionalidade values (3,'Canadá');
insert into tbl_nacionalidade values (4,'Europa');
insert into tbl_nacionalidade values (5,'Japão');
-- tbl_editora
insert into tbl_editora values (1,'Suma');
insert into tbl_editora values (2,'Galera');
insert into tbl_editora values (3,'Zarabatana');
insert into tbl_editora values (4,'HarperCollins');
-- tbl_autores
insert into tbl_autores values (1,'Stephen King','1947-9-21',2);
insert into tbl_autores values (2,'Kami Garcia','1972-3-25',2);
insert into tbl_autores values (3,'Danilo Beyruth','1973-4-23',1);
insert into tbl_autores values (4,'George R. R. Martin','1948-9-20',2);
insert into tbl_autores values (5,'J. R. R. Tolkien','1973-9-2',2);
-- tbl_livro
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('O Iluminado','1977-1-28',1,3);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('O Cemitério (Cemitério Maldito)','1983-11-14',1,3);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('Dezesseis Luas','2009-12-1',2,2);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('Bando de dois','2010-8-5',3,4);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('A Guerra dos Tronos','1966-8-1',1,7);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('A Fúria dos Reis','1988-11-16',1,7);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('A Tormenta de Espadas','2000-8-8',1,7);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('O Senhor dos Anéis: A Sociedade do Anel','1954-7-29',4,7);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('O Senhor dos Anéis: As Duas Torres','1954-11-11',4,7);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('O Senhor dos Anéis: O Retorno do Rei','1955-10-20',4,7);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('O Festim dos Corvos','2005-8-17',1,7);
insert into tbl_livro(titulo,publicacao,editora,categoria) values ('A Dança dos Dragões','2011-7-12',1,7);
-- tbl_livroautor
insert into tbl_livroautor values (1,1,1);
insert into tbl_livroautor values (2,2,1);
insert into tbl_livroautor values (3,3,2);
insert into tbl_livroautor values (4,4,3);
insert into tbl_livroautor values (5,5,4);
insert into tbl_livroautor values (6,6,4);
insert into tbl_livroautor values (7,7,4);
insert into tbl_livroautor values (8,8,5);
insert into tbl_livroautor values (9,9,5);
insert into tbl_livroautor values (10,10,5);
insert into tbl_livroautor values (11,11,4);
insert into tbl_livroautor values (12,12,4);

-- Consultas:

-- Consulta - Id, Titulo, Autor, Data de Publicação, Editora, Categoria - Ordem Alfabetica
select 
	tbl_livroautor.livro, 
	tbl_livro.titulo, 
	tbl_autores.nome_autor, 
	tbl_livro.publicacao, 
	tbl_editora.nome_editora ,
	tbl_categorias.nome_categoria
from 
	tbl_livroautor 
inner join 
	tbl_livro 
on 
	tbl_livroautor.livro = tbl_livro.id_livro
inner join
	tbl_autores
on
	tbl_livroautor.autor = tbl_autores.id_autor
inner join
	tbl_editora
on
	tbl_livro.editora = tbl_editora.id_editora
inner join
	tbl_categorias
on
	tbl_livro.categoria = tbl_categorias.id_categoria
order by tbl_livro.titulo



-- Consulta - d, Titulo, Autor, Data de Publicação, Editora, Categoria 
-- Filtrar por uma Categoria (Fantasia, não há livros de Humor ou Juvenil)
select 
	tbl_livroautor.livro, 
	tbl_livro.titulo, 
	tbl_autores.nome_autor, 
	tbl_livro.publicacao, 
	tbl_editora.nome_editora ,
	tbl_categorias.nome_categoria
from 
	tbl_livroautor 
inner join 
	tbl_livro 
on 
	tbl_livroautor.livro = tbl_livro.id_livro
inner join
	tbl_autores
on
	tbl_livroautor.autor = tbl_autores.id_autor
inner join
	tbl_editora
on
	tbl_livro.editora = tbl_editora.id_editora
inner join
	tbl_categorias
on
	tbl_livro.categoria = tbl_categorias.id_categoria
where 
	tbl_livro.categoria = 7
order by tbl_livro.titulo




-- Consulta - Id, Titulo, Autor, Data de Publicação, Editora, Categoria - Ordem de Autor
select 
	tbl_livroautor.livro, 
	tbl_livro.titulo, 
	tbl_autores.nome_autor, 
	tbl_livro.publicacao, 
	tbl_editora.nome_editora ,
	tbl_categorias.nome_categoria
from 
	tbl_livroautor 
inner join 
	tbl_livro 
on 
	tbl_livroautor.livro = tbl_livro.id_livro
inner join
	tbl_autores
on
	tbl_livroautor.autor = tbl_autores.id_autor
inner join
	tbl_editora
on
	tbl_livro.editora = tbl_editora.id_editora
inner join
	tbl_categorias
on
	tbl_livro.categoria = tbl_categorias.id_categoria
order by tbl_livroautor.autor



-- Consulta - d, Titulo, Autor, Data de Publicação, Editora, Categoria 
-- Filtrar por Ano (2000-2010)
select 
	tbl_livroautor.livro, 
	tbl_livro.titulo, 
	tbl_autores.nome_autor, 
	tbl_livro.publicacao, 
	tbl_editora.nome_editora ,
	tbl_categorias.nome_categoria
from 
	tbl_livroautor 
inner join 
	tbl_livro 
on 
	tbl_livroautor.livro = tbl_livro.id_livro
inner join
	tbl_autores
on
	tbl_livroautor.autor = tbl_autores.id_autor
inner join
	tbl_editora
on
	tbl_livro.editora = tbl_editora.id_editora
inner join
	tbl_categorias
on
	tbl_livro.categoria = tbl_categorias.id_categoria
where 
	tbl_livro.publicacao > '2000-1-1' and tbl_livro.publicacao < '2010-1-1'
order by tbl_livro.titulo




