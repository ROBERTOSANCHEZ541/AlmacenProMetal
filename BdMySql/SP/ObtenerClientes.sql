CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerClientes`()
BEGIN
    SELECT IdCliente, Nombre, Email, Telefono
    FROM Cliente;
END