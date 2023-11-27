CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarProducto`(
    IN p_IdArticulo INT,
    IN p_NombreProducto NVARCHAR(255),
    IN p_Precio DECIMAL(10, 2),
    IN p_Stock INT,
    IN p_Descripcion TEXT,
    IN p_IDCategoria INT,
    IN p_IDSucursal INT
)
BEGIN
    UPDATE Productos
    SET 
        NombreProducto = p_NombreProducto,
        Precio = p_Precio,
        Stock = p_Stock,
        Descripcion = p_Descripcion,
        ID_Categoria = p_IDCategoria,
        IDSucursal = p_IDSucursal
    WHERE IdArticulo = p_IdArticulo;
END