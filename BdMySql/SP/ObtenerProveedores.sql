CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerProveedores`()
BEGIN
    SELECT IdProveedor, Nombre, Telefono, Direccion, RFC
    FROM Proveedor;
END