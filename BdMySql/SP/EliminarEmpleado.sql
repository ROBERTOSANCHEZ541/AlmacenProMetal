CREATE DEFINER=`root`@`localhost` PROCEDURE `EliminarEmpleado`(
    IN p_IdEmpleado INT
)
BEGIN
    DELETE FROM Empleado
    WHERE IdEmpleado = p_IdEmpleado;
END