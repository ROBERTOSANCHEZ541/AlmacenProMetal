CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarCliente`(
    IN p_IdCliente INT,
    IN p_Nombre NVARCHAR(50),
    IN p_Email NVARCHAR(255),
    IN p_Telefono VARCHAR(10)
)
BEGIN
    UPDATE Cliente
    SET Nombre = p_Nombre, Email = p_Email, Telefono = p_Telefono
    WHERE IdCliente = p_IdCliente;
END