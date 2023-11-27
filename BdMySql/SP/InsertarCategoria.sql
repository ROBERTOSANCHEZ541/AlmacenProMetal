CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarCategoria`(
    IN p_TipoCategoria NVARCHAR(15)
)
BEGIN
    INSERT INTO Categoria (Tipo_Categoria)
    VALUES (p_TipoCategoria);
END