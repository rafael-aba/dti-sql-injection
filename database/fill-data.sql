USE [MAIN_DATABASE]
GO

-- users
INSERT INTO dbo.users (permission, username, userHash, cpf, address, insertDate) VALUES 
('admin', 'Batuta', 'hash_does_not_matter', '000-111-222-33', 'Praça da Savassi, 000, Savassi', getdate()),
('user', 'Jezinho', 'J%jAzFPE$Mt&$PF6QuHZ*ra9m!LUW&#8', '111.222.333-44', 'Rua Levindo Lopes, 000, Savassi', getdate()),
('user', 'Joaozinho', '2lTW#g0Rm4X!RNmus8GfCm#606T0jB&$', '123.456.789-01', 'Rua Antônio de Albuqueque, 000, Savassi', getdate()),
('user', 'Colega', 'wQybq&VyhTAInWHIxUgcoj5tFT%A5*@y', '109.876.543-21', 'Avenida Contorno, 000, Savassi', getdate()),
('user', 'usernameHehe', '!rb0@AsXi5ooAl4ZjjXkgZG2TD3^jyuM', '135.792.468-01', 'Avenida Getúlio Vargas, 000, Savassi', getdate()),
('user', 'naoCia', 'AfKP692OfkA1!Gkt$imee6abJJdEvHM7', '555.555.555-55', 'Area 51, USA', getdate())
GO

-- products
INSERT INTO dbo.products (userId, productName, price, sold, insertDate) VALUES 
(2, 'Computador usado', 3000.00, 0, getdate()),
(2, 'Martelo', 10.00, 0, getdate()),
(2, 'Castelo', 1500000.00, 0, getdate()),
(3, 'Rubix Cube', 20.00, 0, getdate()),
(3, 'Plaistashion 6', 1000.00, 0, getdate()),
(3, 'Lapis', 0.99, 0, getdate()),
(5, 'Cartão elo', 100.00, 0, getdate()),
(5, 'Carteira', 10.00, 0, getdate()),
(5, 'Hipogrifo de verdade', 10000.58, 0, getdate()),
(3, '10.000 instagram followers', 100.99, 1, getdate()),
(4, 'Fone de ouvido quase novo', 30.00, 0, getdate()),
(4, 'Escova de dentes usada', 2.00, 1, getdate()),
(6, 'A product that does not exist', 999999.99, 1, getdate())

GO

--sales
INSERT INTO dbo.sales (productId, userIdSeller, userIdBuyer, price, insertDate) VALUES 
(13, 6, 1, 999999.99, getdate()),
(12, 2, 3, 2.00, getdate()),
(10, 5, 4, 1.99, getdate())
GO