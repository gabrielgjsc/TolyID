create table Ficha_Campo(
	Id_Animal serial primary key,
	Nome_Animal varchar(255),
	Peso real,
	Chip integer,
	Local_Captura varchar(255),
	Data_Captura date,
	Horaro_Captura time,
	Equipe_Responsavel varchar(255),
	Contato varchar (255),
	Institição varchar (255),
	Observações text
);
CREATE TABLE Anestesia (
    id_registro SERIAL PRIMARY KEY,
	foreign key (id_registro) references Ficha_Campo (id_animal),
    tipo_anestesico VARCHAR(255),
    dose_anestesico VARCHAR(255),
    via_administracao VARCHAR(255),
    tempo_anestesia VARCHAR(255),
    aplicacao VARCHAR(255),
    inducao VARCHAR(255),
    retorno VARCHAR(255),
    fc VARCHAR(255),
    fr VARCHAR(255),
    oximetria VARCHAR(255),
    temperatura VARCHAR (255)
);
CREATE TABLE Amostras (
    id_registro serial primary key,
	foreign key (id_registro) references Ficha_Campo (id_animal),
    sangue BOOLEAN,
    fezes BOOLEAN,
	pelo BOOLEAN,
    ectoparasitos BOOLEAN,
    sawb BOOLEAN,
	local_da_amostra varchar(255),
	outros text
);
create table Biometria(
	id_registro serial primary key,
    foreign key (id_registro) references Ficha_Campo (id_animal),
	comprimento_total real,
    comprimento_orelha real,
    numero_cintas real,
    comprimento_cabeca real,
    comprimento_cauda real,
    comprimento_mao_sem_unha real,
    largura_cabeca real,
    largura_cauda real,
    comprimento_unha_mao real,
    padrao_escudo_cefalico real,
    comprimento_escudo_escapular real,
    comprimento_pe_sem_unha real,
    comprimento_escudo_cefalico real,
	semicircunferência_escudo_escapular real,
    comprimento_unha_pe real,
    largura_escudo_cefalico real,
    comprimento_escudo_pelvico real,
    comprimento_penis real,
    largura_inter_orbital real,
    semicircunferencia_escudo_pelvico real,
    largura_base_penis real,
    largura_inter_lacrimal real,
    largura_segunda_cinta real,
    comprimento_clitoris real,
	observações text
);

create table cadastro_pessoa (
	id_pessoa serial primary key,
	nome_compleo varchar(255),
	data_nacimeno date,
	endereço varchar(255),
	telefone varchar(255),
	nome_usuario varchar(255),
	email varchar (255),
	senha varchar (255)
);
create table usuario (
	id_usuario serial primary key,
	foreign key (id_usuario) references cadastro_pessoa (id_pessoa),
	nome_usuario varchar(255),
	email varchar(255),
	senha varchar(255)
)