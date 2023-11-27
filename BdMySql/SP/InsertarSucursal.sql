CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarSucursal`(
    IN p_NombreSucursal NVARCHAR(100),
    IN p_Direccion NVARCHAR(255),
    IN p_Ciudad NVARCHAR(50),
    IN p_CodigoPostal NVARCHAR(10),
    IN p_Telefono NVARCHAR(15)
)
BEGIN
    INSERT INTO Sucursales (NombreSucursal, Direccion, Ciudad, CodigoPostal, Telefono)
    VALUES (p_NombreSucursal, p_Direccion, p_Ciudad, p_CodigoPostal, p_Telefono);
END