CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarProveedor`(
    IN p_Nombre NVARCHAR(50),
    IN p_Telefono VARCHAR(10),
    IN p_Direccion NVARCHAR(100),
    IN p_RFC CHAR(13)
)
BEGIN
    INSERT INTO Proveedor (Nombre, Telefono, Direccion, RFC)
    VALUES (p_Nombre, p_Telefono, p_Direccion, p_RFC);
END