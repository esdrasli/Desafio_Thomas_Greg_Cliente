USE master;
GO
CREATE DATABASE ClientesDB;
GO
USE ClientesDB;
GO

-- Crie a tabela Cliente
CREATE TABLE Cliente (
    ID INT PRIMARY KEY,
    Nome NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) UNIQUE NOT NULL,
    Logotipo VARBINARY(MAX)
);
GO

-- Crie a tabela Logradouro
CREATE TABLE Logradouro (
    ID INT PRIMARY KEY,
    ClienteID INT FOREIGN KEY REFERENCES Cliente(ID),
    Logradouro NVARCHAR(255) NOT NULL
);
GO

-- Crie a tabela Endereco
CREATE TABLE Endereco (
    ClienteID INT FOREIGN KEY REFERENCES Cliente(ID),
    LogradouroID INT FOREIGN KEY REFERENCES Logradouro(ID)
);
GO

INSERT INTO Cliente (ID, Nome, Email, Logotipo) VALUES
(1, 'Cliente 1', 'cliente1@example.com', NULL),
(2, 'Cliente 2', 'cliente2@example.com', NULL),
(3, 'Cliente 3', 'cliente3@example.com', NULL),
(4, 'Cliente 4', 'cliente4@example.com', NULL),
(5, 'Cliente 5', 'cliente5@example.com', NULL),
(6, 'Cliente 6', 'cliente6@example.com', NULL),
(7, 'Cliente 7', 'cliente7@example.com', NULL),
(8, 'Cliente 8', 'cliente8@example.com', NULL),
(9, 'Cliente 9', 'cliente9@example.com', NULL),
(10, 'Cliente 10', 'cliente10@example.com', NULL);
GO

CREATE PROCEDURE DeleteLogradouro
    @ClienteId INT,
    @LogradouroId INT
AS
BEGIN
    DELETE FROM Logradouro
    WHERE ClienteId = @ClienteId AND ID = @LogradouroId;
END;
