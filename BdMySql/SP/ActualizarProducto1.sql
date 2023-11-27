CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarProducto1`(
  IN  p_IdArticulo INT,
   in p_NombreProducto NVARCHAR(255),
   in p_Precio DECIMAL(10, 2),
   in p_Stock INT
    )
BEGIN
    UPDATE Productos
    SET 
        NombreProducto = p_NombreProducto,
        Precio =p_Precio,
        Stock = p_Stock
    WHERE IdArticulo = p_IdArticulo;
END