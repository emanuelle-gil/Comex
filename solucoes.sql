CREATE TABLE Clientes(
	ID SERIAL PRIMARY KEY,
	Nome TEXT,
	Email TEXT,
	DataNascimento DATE,
	Cidade TEXT
);

CREATE TABLE Pedidos(
	PedidoID SERIAL PRIMARY KEY,
	DataPedido DATE,
	ValorTotal DECIMAL,
	ClienteID INTEGER,
	FOREIGN KEY (ClienteID) REFERENCES Clientes(ID) 
);

INSERT INTO Clientes (Nome, Email, DataNascimento, Cidade) VALUES
	('Emanuelle', 'manu@gmail.com', '25-06-2003', 'Itacoatiara'),
	('Kayth', 'kayth@gmail.com', '17-09-2003', 'Manaus'),
	('Victor', 'victor@gmail.com', '23-01-2003', 'Manaus');

INSERT INTO Pedidos (DataPedido, ValorTotal, ClienteID) VALUES
	('21-08-2024', '54.89', '1'),
	('22-08-2024', '103.79', '2'),
	('20-08-2024', '17.80', '3');

SELECT * FROM Clientes;
SELECT * FROM Pedidos;

SELECT Nome AS "Nome do Cliente",
       Email
FROM   Clientes;

UPDATE Clientes
SET Email = 'manugil943@gmail.com'
WHERE ID = '1';

UPDATE Pedidos
SET ValorTotal = '64.21'
WHERE PedidoID = '3';

DELETE
FROM Pedidos
WHERE PedidoID = '3';

SELECT * 
FROM Clientes
WHERE Cidade = 'Manaus';

SELECT *
FROM Pedidos
WHERE ValorTotal > 100.00

SELECT Clientes.Nome AS "Nome do Cliente",
       Pedidos.ValorTotal AS "Valor Total do Pedido"
FROM Clientes
INNER JOIN Pedidos ON Clientes.ID = Pedidos.ClienteID

SELECT Clientes.Nome AS "Nome do Cliente",
	   Pedidos.PedidoID AS "ID do Pedido",
       Pedidos.ValorTotal AS "Valor Total do Pedido"
	   FROM Clientes
LEFT JOIN Pedidos ON Pedidos.ClienteID= Clientes.ID;

SELECT *
FROM Clientes
ORDER BY Nome

SELECT *
FROM Pedidos
ORDER BY ValorTotal DESC

