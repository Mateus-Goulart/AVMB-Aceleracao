create table tbl_eras
(
	id_era integer constraint pk_id_era primary key,
	nome_era varchar(15)
);

insert into tbl_eras values (1,'Cretáceo');
insert into tbl_eras values (2,'Jurássico');
insert into tbl_eras values (3,'Triássico');

create table tbl_grupo
(
	id_grupo integer constraint pk_id_grupo primary key,
	nome_grupo varchar(15)
);

insert into tbl_grupo values (1,'Terápodes');
insert into tbl_grupo values (2,'Saurópodes');
insert into tbl_grupo values (3,'Ceratopsídeos');
insert into tbl_grupo values (4,'Estegossauros');
insert into tbl_grupo values (5,'Anquilossauros');
insert into tbl_grupo values (6,'Ornitópodes');

create table tbl_areas 
(
	id_pais integer constraint pk_id_pais primary key,
	nome_pais varchar(20)
);

insert into tbl_areas values (1,'América do Norte');
insert into tbl_areas values (2,'Canadá');
insert into tbl_areas values (3,'China');
insert into tbl_areas values (4,'Mongólia');
insert into tbl_areas values (5,'USA');
insert into tbl_areas values (6,'Tanzânia');

create table tbl_paleontologo
(
	id_paleontologo integer constraint pk_id_paleontologo primary key,
	nome_paleontologo varchar(40)
);

insert into tbl_paleontologo values (1,'Maryanska');
insert into tbl_paleontologo values (2,'Jonh Bell Hatcher');
insert into tbl_paleontologo values (3,'Cientistas Alemães');
insert into tbl_paleontologo values (4,'Museu Americano de História Natural');
insert into tbl_paleontologo values (5,'Othniel Charles March');
insert into tbl_paleontologo values (6,'Barmun Brown');

create table tbl_dinossauros 
(
	id_dinossauro integer constraint pk_id_dinossauro primary key,
	nome_dinossauro varchar(20),
	grupo integer not null,
	toneladas integer,
	ano_descoberta integer,
	descobridor integer not null,
	era integer not null,
	inicio_milhoes integer,
	fim_milhoes integer,
	pais integer not null,
	foreign key (grupo) references tbl_grupo(id_grupo),
	foreign key (descobridor) references tbl_paleontologo(id_paleontologo),
	foreign key (era) references tbl_eras(id_era),
	foreign key (pais) references tbl_areas(id_pais)
);

insert into tbl_dinossauros values (1,'Saichania',5,4,1977,1,1,145,66,4);
insert into tbl_dinossauros values (2,'Tricerátops',3,6,1887,2,1,70,66,2);
insert into tbl_dinossauros values (3,'Kentrossauro',4,2,1909,3,2,201,145,6);
insert into tbl_dinossauros values (4,'Pinacossauro',5,6,1999,4,1,85,75,3);
insert into tbl_dinossauros values (5,'Alossauro',1,3,1877,5,2,155,150,1);
insert into tbl_dinossauros values (6,'Torossauro',3,8,1891,2,1,67,65,5);
insert into tbl_dinossauros values (7,'Anquilossauro',5,8,1906,6,1,66,63,1);