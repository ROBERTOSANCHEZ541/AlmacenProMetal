CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarCliente`(
    IN p_Nombre NVARCHAR(50),
    IN p_Email NVARCHAR(255),
    IN p_Telefono VARCHAR(10),
    OUT p_NuevoID INT
)
BEGIN
    INSERT INTO Cliente (Nombre, Email, Telefono)
    VALUES (p_Nombre, p_Email, p_Telefono);
    SET p_NuevoID = LAST_INSERT_ID();
END