CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerCategorias`()
BEGIN
    SELECT id_Categoria, Tipo_Categoria
    FROM Categoria;
END