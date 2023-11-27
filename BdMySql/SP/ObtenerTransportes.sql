CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerTransportes`()
BEGIN
    SELECT IDTransporte, Nombre, Tipo, CapacidadKg, NumeroPlaca
    FROM Transporte;
END