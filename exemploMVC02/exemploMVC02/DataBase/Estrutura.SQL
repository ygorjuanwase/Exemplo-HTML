﻿DROP TABLE recrutadoras;
CREATE TABLE recrutadoras(
id		INT IDENTITY(1,1) PRIMARY KEY,
nome	VARCHAR(100) NOT NULL,
cpf		CHAR(11) NOT NULL,
tempo_empresa		SMALLINT,
salario		DECIMAL(12,2)
);

INSERT INTO recrutadoras(nome,cpf,tempo_empresa, salario) VALUES
('Doufim', '1234567898', 2, 10000.00),
('Joafim', '32654987784', 3, 20000.00),
('Cafim', '45678912345', 4, 1500.00);