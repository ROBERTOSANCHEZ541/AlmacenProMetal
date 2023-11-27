CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarProducto`(
    IN p_NombreProducto NVARCHAR(255),
    IN p_Precio DECIMAL(10, 2),
    IN p_Stock INT,
    IN p_Descripcion TEXT,
    IN p_IDCategoria INT,
    IN p_IDSucursal INT
)
BEGIN
    INSERT INTO Productos (NombreProducto, Precio, Stock, Descripcion, ID_Categoria, IDSucursal)
    VALUES (p_NombreProducto, p_Precio, p_Stock, p_Descripcion, p_IDCategoria, p_IDSucursal);
END