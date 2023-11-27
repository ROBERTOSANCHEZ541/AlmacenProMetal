CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarDetallePedido`(
    IN p_PedidoID INT,
    IN p_ProductoID INT,
    IN p_IDTransporte INT,
    IN p_Cantidad INT,
    IN p_PrecioUnitario DECIMAL(10, 2)
)
BEGIN
    INSERT INTO DetallesPedido (PedidoID, ProductoID, IDTransporte, Cantidad, PrecioUnitario)
    VALUES (p_PedidoID, p_ProductoID, p_IDTransporte, p_Cantidad, p_PrecioUnitario);
END