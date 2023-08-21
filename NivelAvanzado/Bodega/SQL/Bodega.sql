CREATE DATABASE Bodega
GO

USE Bodega
GO

CREATE LOGIN hristochavez
WITH PASSWORD='llamamecochy2023'
GO

CREATE USER hristochavez
FOR LOGIN hristochavez
WITH DEFAULT_SCHEMA=Bodega
GO

ALTER LOGIN [hristochavez] WITH DEFAULT_DATABASE = [Bodega]
GO

CREATE TABLE brand
(
    brand_id INT IDENTITY(1, 1) NOT NULL,
    brand_name VARCHAR(255) NOT NULL,
    CONSTRAINT PK_BrandID PRIMARY KEY (brand_id)
)
GO

CREATE TABLE beer
(
    beer_id INT IDENTITY(1, 1) NOT NULL, 
	beer_name VARCHAR(255) NOT NULL,
    brand_id INT NOT NULL,
    CONSTRAINT PK_BeerID PRIMARY KEY (beer_id),
    CONSTRAINT FK_BrandID FOREIGN KEY (brand_id) REFERENCES Brand(brand_id)
)
GO

INSERT INTO brand (brand_name) 
VALUES ('Backus'), ('Dios Baco'), ('Tupac')
GO

INSERT INTO beer (beer_name, brand_id)
VALUES ('Cristal', 1), ('Duff', 2), ('Mayta', 3)
GO

