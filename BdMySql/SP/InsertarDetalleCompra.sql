CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarDetalleCompra`(
    IN p_CompraID INT,
    IN p_ProductoID INT,
    IN p_IDTransporte INT,
    IN p_Cantidad INT,
    IN p_PrecioUnitario DECIMAL(10, 2)
)
BEGIN
    INSERT INTO DetallesCompra (CompraID, ProductoID, IDTransporte, Cantidad, PrecioUnitario)
    VALUES (p_CompraID, p_ProductoID, p_IDTransporte, p_Cantidad, p_PrecioUnitario);
END