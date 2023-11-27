CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarSucursal`(
    IN p_IDSucursal INT,
    IN p_NombreSucursal NVARCHAR(100),
    IN p_Direccion NVARCHAR(255),
    IN p_Ciudad NVARCHAR(50),
    IN p_CodigoPostal NVARCHAR(10),
    IN p_Telefono NVARCHAR(15)
)
BEGIN
    UPDATE Sucursales
    SET
        NombreSucursal = p_NombreSucursal,
        Direccion = p_Direccion,
        Ciudad = p_Ciudad,
        CodigoPostal = p_CodigoPostal,
        Telefono = p_Telefono
    WHERE IDSucursal = p_IDSucursal;
END