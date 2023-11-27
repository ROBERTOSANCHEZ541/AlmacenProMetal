CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarTransporte`(
    IN p_Nombre NVARCHAR(100),
    IN p_Tipo NVARCHAR(50),
    IN p_CapacidadKg INT,
    IN p_NumeroPlaca NVARCHAR(20)
)
BEGIN
    INSERT INTO Transporte (Nombre, Tipo, CapacidadKg, NumeroPlaca)
    VALUES (p_Nombre, p_Tipo, p_CapacidadKg, p_NumeroPlaca);
END