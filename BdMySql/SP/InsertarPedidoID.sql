CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarPedidoID`(
    IN p_FechaPedido VARCHAR(10),
    IN p_ClienteID INT,
    OUT p_UltimoID INT
)
BEGIN
    INSERT INTO Pedidos (FechaPedido, ClienteID)
    VALUES (p_FechaPedido, p_ClienteID);
    SET p_UltimoID = LAST_INSERT_ID();
END