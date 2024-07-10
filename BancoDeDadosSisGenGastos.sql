USE DbControleDeGastos;

CREATE TABLE Categoria(
	IdCategoria INT IDENTITY (100, 1) NOT NULL,
	Nome VARCHAR (20) UNIQUE NOT NULL,
	PRIMARY KEY (IdCategoria)
)

CREATE TABLE Cartoes_De_Credito(
	IdCartaoDeCredito INT IDENTITY (100, 1) NOT NULL,
	Nome VARCHAR (20) UNIQUE NOT NULL,
	Vencimento INT NOT NULL,
	PRIMARY KEY (IdCartaoDeCredito)
)

CREATE TABLE Formas_De_Pagamento(
	IdFormaDePagamento INT IDENTITY (100, 1) NOT NULL,
	Nome VARCHAR (20) UNIQUE NOT NULL,
	PRIMARY KEY (IdFormaDePagamento)
)

CREATE TABLE Compras_No_Cartao_De_Credito(
	IdCompraNoCartaoDeCredito INT IDENTITY (100, 1) NOT NULL,
	Nome VARCHAR (50) NOT NULL,
	Parcelas VARCHAR (5) NOT NULL,
	DataDePagamento VARCHAR (10) NOT NULL,
	IdFormaDePagamento INT NOT NULL,
	IdCategoria INT NOT NULL,
	Valor VARCHAR (20) NOT NULL,
	IdCartaoDeCredito INT NOT NULL,
	PRIMARY KEY (IdCompraNoCartaoDeCredito),
	FOREIGN KEY (IdFormaDePagamento) REFERENCES Formas_De_Pagamento (IdFormaDePagamento),
	FOREIGN KEY (IdCategoria) REFERENCES Categoria (IdCategoria),
	FOREIGN KEY (IdCartaoDeCredito) REFERENCES Cartoes_De_Credito (IdCartaoDeCredito)
)

CREATE TABLE Gastos_Fixos(
	IdGastoFixo INT IDENTITY (100, 1) NOT NULL,
	Nome VARCHAR (20) NOT NULL,
	IdCategoria INT NOT NULL,
	DataDePagamento VARCHAR(10) NOT NULL,
	Valor VARCHAR (20) NOT NULL,
	IdFormaDePagamento INT NOT NULL,
	Pago VARCHAR (3) NOT NULL,
	PRIMARY KEY (IdGastoFixo),
	FOREIGN KEY (IdCategoria) REFERENCES Categoria (IdCategoria),
	FOREIGN KEY (IdFormaDePagamento) REFERENCES Formas_De_Pagamento (IdFormaDePagamento)
)



