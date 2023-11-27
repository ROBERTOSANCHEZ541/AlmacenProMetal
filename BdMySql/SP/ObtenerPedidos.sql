CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerPedidos`()
BEGIN
    SELECT PedidoID, FechaPedido, ClienteID
    FROM Pedidos;
END