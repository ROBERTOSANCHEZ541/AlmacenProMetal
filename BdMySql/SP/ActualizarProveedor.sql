CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarProveedor`(
    IN p_IdProveedor INT,
    IN p_Nombre NVARCHAR(50),
    IN p_Telefono VARCHAR(10),
    IN p_Direccion NVARCHAR(100),
    IN p_RFC CHAR(13)
)
BEGIN
    UPDATE Proveedor
    SET 
        Nombre = p_Nombre,
        Telefono = p_Telefono,
        Direccion = p_Direccion,
        RFC = p_RFC
    WHERE IdProveedor = p_IdProveedor;
END