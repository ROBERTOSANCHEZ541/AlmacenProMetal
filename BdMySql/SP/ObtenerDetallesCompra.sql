CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerDetallesCompra`()
BEGIN
    SELECT DetalleCompraID, CompraID, ProductoID, IDTransporte, Cantidad, PrecioUnitario
    FROM DetallesCompra;
END