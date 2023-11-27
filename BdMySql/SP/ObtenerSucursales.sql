CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerSucursales`()
BEGIN
    SELECT IDSucursal, NombreSucursal, Direccion, Ciudad, CodigoPostal, Telefono
    FROM Sucursales;
END