CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertarEmpleadoEncriptado`(
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
    DECLARE v_RFCEncriptado VARBINARY(1600);
    SET v_RFCEncriptado = AES_ENCRYPT(p_RFC, 'R0bert541');

    INSERT INTO Empleado (Nombre, Edad, RFC, Telefono, CURP, NSS, Puesto, IDSucursal)
    VALUES (p_Nombre, p_Edad, v_RFCEncriptado, p_Telefono, p_CURP, p_NSS, p_Puesto, p_IDSucursal);
END