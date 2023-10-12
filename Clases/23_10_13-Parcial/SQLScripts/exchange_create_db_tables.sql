-- CREATE DATABASE exchange;
--USE exchange;

--CREATE TABLE operations (
--    id BIGINT IDENTITY(1,1) PRIMARY KEY,
--    operation_date DATETIME DEFAULT CURRENT_TIMESTAMP,
--    usd_value DECIMAL(18, 2),
--    usd_quantity DECIMAL(18, 2),
--    ars_quantity DECIMAL(18, 2),
--);

--CREATE TABLE users(
--	id BIGINT IDENTITY(1,1) PRIMARY KEY, -- Quitar y convertir username en primary key? O compuesta?
--	username NVARCHAR(20),
--	password NVARCHAR(20),
--	nickname NVARCHAR(20)
--);

 --INSERT INTO users (username,password,nickname)  
 --values ('izo','izo2023','Izo'),
--		('mauricio','mauri123','Mauricio');
--		('santi','santi123','Santiago)

-- SELECT * FROM users;