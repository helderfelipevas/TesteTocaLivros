CREATE DATABASE tocaLivros

USE tocaLivros

CREATE TABLE Usuario(
	cd_usuario INT NOT NULL identity,
	nm_usuario VARCHAR(50),
	ds_email VARCHAR(50),
	ds_endereco VARCHAR(50),
		CONSTRAINT PK_Usuario PRIMARY KEY (cd_usuario)
)

CREATE TABLE Pedido(
	cd_pedido INT identity,
	nm_produto VARCHAR(50),
	vl_produto VARCHAR(10),
	qt_produto INT,
	cd_usuario_USUARIO INT,
		CONSTRAINT PK_cd_pedido PRIMARY KEY (cd_pedido),
		CONSTRAINT FK_cd_usuario_USUARIO FOREIGN KEY (cd_usuario_USUARIO)
	REFERENCES Usuario(cd_usuario)
)

DROP TABLE Pedido
