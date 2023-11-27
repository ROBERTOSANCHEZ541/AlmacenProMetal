CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerClientesF`(IN p_IdCliente INT)
BEGIN
    SELECT IdCliente, Nombre, Email, Telefono
    FROM Cliente
    WHERE IdCliente = p_IdCliente;
END