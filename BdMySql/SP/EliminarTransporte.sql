CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarTransporte`(
    IN p_IDTransporte INT
)
BEGIN
    DELETE FROM Transporte
    WHERE IDTransporte = p_IDTransporte;
END