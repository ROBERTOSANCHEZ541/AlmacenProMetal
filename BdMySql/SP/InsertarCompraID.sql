CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarCompraID`(
    IN p_FechaCompra VARCHAR(10),
    IN p_ProveedorID INT,
    IN p_EmpleadoID INT,
    OUT p_UltimoID INT
)
BEGIN
    INSERT INTO Compras (FechaCompra, ProveedorID, EmpleadoID)
    VALUES (p_FechaCompra, p_ProveedorID, p_EmpleadoID);
    SET p_UltimoID = LAST_INSERT_ID();
END