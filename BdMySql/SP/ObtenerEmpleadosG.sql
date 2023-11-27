CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerEmpleadosG`()
BEGIN
    SELECT
        IdEmpleado,
        Nombre,
        Edad,
        CAST(AES_DECRYPT(RFC, 'R0bert541') AS CHAR) AS RFC_Desencriptado,
        Telefono,
        CURP,
        NSS,
        Puesto,
        IDSucursal
    FROM Empleado;
END