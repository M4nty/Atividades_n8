--Oi
--Ok ainda bem que é assim
--Esse conjunto de dois codigos cria e utiliza a base de dados]
create database miniProjeto
use miniProjeto

create table categoria
(
	categoria_id int not null identity primary key,
	categoria_nome varchar(50) not null unique,
	categoria_descricao varchar(255) not null,
	categoria_obs varchar(255) not null,
	categoria_status varchar(30) not null
)

select * from categoria

insert into  categoria
	(categoria_nome,categoria_descricao,categoria_obs,categoria_status)
values
	('Ferro','','','Ativo')

insert into  categoria
	(categoria_nome,categoria_descricao,categoria_obs,categoria_status)
values
	('Prata','','','Ativo'),
	('Ouro ','','','Ativo'),
	('Bronze','','','Ativo'),
	('Latão','','','Ativo')

	drop table categoria

select * from categoria
select * from fornecedor

create table fornecedor
(
fornecedor_id int not null identity primary key,
fornecedor_nome varchar(50) not null,
fornecedor_cpfCnpj varchar(18) not null unique,
fornecedor_tipo char(2) not null,
fornecedor_cep char(9) not null,
fornecedor_email varchar(50) not null,
fornecedor_contato varchar(50) not null,
fornecedor_obs varchar(255) null,
fornecedor_status varchar(30) not null
)

create table produto
(produto_id int not null identity primary key,
produto_nome varchar(50) not null,
produto_descricao varchar(50) not null,
produto_id_cat int not null,
produto_id_fornec int not null,
produto_venda_preco decimal(10,2) not null,
produto_compra_preco decimal(10,2) not null,
produto_cadastro date not null default getdate(),
produto_qtd int not null,
produto_obs varchar(255) null,
produto_status varchar(30) not null

constraint FK_PRODUTO_CAT_ID foreign key(produto_id_cat) references categoria(categoria_id),
constraint FK_PROD_FORNEC_ID foreign key(produto_id_fornec) references fornecedor(fornecedor_id)

)

alter table produto drop column produto_cadastro;
alter table produto add produto_cadastro date not null default getdate();

 
 

insert into produto
	(produto_nome,produto_descricao,produto_id_cat,produto_id_fornec,produto_venda_preco,produto_compra_preco,produto_cadastro)
	values
	('Terra refrataria','terra muito braba seloko',2,1,2.75,15.80,10)
select * from produto