CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerDetallesPedido`()
BEGIN
    SELECT DetalleID, PedidoID, ProductoID, IDTransporte, Cantidad, PrecioUnitario
    FROM DetallesPedido;
END