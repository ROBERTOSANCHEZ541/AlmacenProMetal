CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarTransporte`(
    IN p_IDTransporte INT,
    IN p_Nombre NVARCHAR(100),
    IN p_Tipo NVARCHAR(50),
    IN p_CapacidadKg INT,
    IN p_NumeroPlaca NVARCHAR(20)
)
BEGIN
    UPDATE Transporte
    SET 
        Nombre = p_Nombre,
        Tipo = p_Tipo,
        CapacidadKg = p_CapacidadKg,
        NumeroPlaca = p_NumeroPlaca
    WHERE IDTransporte = p_IDTransporte;
END