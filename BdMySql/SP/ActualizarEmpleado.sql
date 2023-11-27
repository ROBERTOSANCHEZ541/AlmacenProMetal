CREATE DEFINER=`root`@`localhost` PROCEDURE `ActualizarEmpleado`(
    IN p_IdEmpleado INT,
    IN p_Nombre NVARCHAR(50),
    IN p_Edad INT,
    IN p_RFC NVARCHAR(50),
    IN p_Telefono VARCHAR(10),
    IN p_CURP VARCHAR(18),
    IN p_NSS CHAR(11),
    IN p_Puesto NVARCHAR(100),
    IN p_IDSucursal INT
)
BEGIN
    UPDATE Empleado
    SET
        Nombre = p_Nombre,
        Edad = p_Edad,
        RFC = AES_ENCRYPT(p_RFC, 'TuContraseña'),
        Telefono = p_Telefono,
        CURP = p_CURP,
        NSS = p_NSS,
        Puesto = p_Puesto,
        IDSucursal = p_IDSucursal
    WHERE IdEmpleado = p_IdEmpleado;
END