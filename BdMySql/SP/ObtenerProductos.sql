CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerProductos`()
BEGIN
    SELECT 
        IdArticulo,
        NombreProducto,
        Precio,
        Stock,
        Descripcion,
        ID_Categoria,
        IDSucursal
    FROM Productos;
END