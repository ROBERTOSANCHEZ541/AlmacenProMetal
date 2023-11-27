CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarCategoria`(
    IN p_IdCategoria INT,
    IN p_TipoCategoria NVARCHAR(15)
)
BEGIN
    UPDATE Categoria
    SET Tipo_Categoria = p_TipoCategoria
    WHERE id_Categoria = p_IdCategoria;
END