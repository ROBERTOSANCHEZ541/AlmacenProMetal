CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerCompras`()
BEGIN
    SELECT CompraID, FechaCompra, ProveedorID, EmpleadoID
    FROM Compras;
END