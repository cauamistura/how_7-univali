-- Inserts de tipo de Imoveis
INSERT INTO `how7`.`TipoImoveis` (`nome`)
VALUES
('Apartamento'),
('Casa'),
('Comercial'),
('Terreno'),
('Sobrado');

-- Inserts de Imoveis
INSERT INTO `how7`.`Imoveis` (`tipo`, `descricao`)
VALUES
(1, 'Apartamento de 2 quartos no centro'),
(2, 'Casa com 3 quartos e jardim'),
(3, 'Loja comercial no shopping'),
(4, 'Terreno de 500m² na zona rural'),
(5, 'Sobrado com piscina'),
(1, 'Apartamento de luxo com vista para o mar'),
(2, 'Casa térrea com garagem para 2 carros'),
(3, 'Escritório no centro empresarial');

-- Inserts Pagamentos
INSERT INTO `how7`.`Pagamentos` (`imovel`, `data`, `valor`)
VALUES
(1, '2024-01-15', 1200.00),
(2, '2024-01-16', 1500.00),
(3, '2024-01-17', 3000.00),
(4, '2024-01-18', 800.00),
(5, '2024-01-19', 2500.00),
(1, '2024-02-15', 1200.00),
(2, '2024-02-16', 1500.00),
(3, '2024-02-17', 3000.00),
(4, '2024-02-18', 800.00),
(5, '2024-02-19', 2500.00),
(1, '2024-03-15', 1200.00),
(2, '2024-03-16', 1500.00),
(3, '2024-03-17', 3000.00),
(4, '2024-03-18', 800.00),
(5, '2024-03-19', 2500.00),
(1, '2024-04-15', 1200.00),
(2, '2024-04-16', 1500.00),
(3, '2024-04-17', 3000.00),
(4, '2024-04-18', 800.00),
(5, '2024-04-19', 2500.00),
(1, '2024-05-15', 1200.00),
(2, '2024-05-16', 1500.00),
(3, '2024-05-17', 3000.00),
(4, '2024-05-18', 800.00),
(5, '2024-05-19', 2500.00),
(1, '2024-05-20', 1200.00),
(2, '2024-05-21', 1500.00),
(3, '2024-05-22', 3000.00),
(4, '2024-05-23', 800.00),
(5, '2024-05-24', 2500.00);


