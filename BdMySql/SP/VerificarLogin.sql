CREATE DEFINER=`root`@`localhost` PROCEDURE `VerificarLogin`(
    IN p_Nombre NVARCHAR(50),
    IN p_RFCDesencriptado NVARCHAR(50)
)
BEGIN
    DECLARE v_RFCEncriptado VARBINARY(1600);
 SELECT CAST(AES_DECRYPT(RFC, 'R0bert541') AS CHAR) INTO  v_RFCEncriptado
 FROM Empleado
    WHERE Nombre = p_Nombre
    LIMIT 1;
    IF v_RFCEncriptado IS NOT NULL AND CONVERT(v_RFCEncriptado USING utf8mb4) = p_RFCDesencriptado THEN
        -- Login exitoso
        SELECT 'Login exitoso' AS Mensaje, 1 AS Resultado;
    ELSE
        -- Credenciales inválidas
        SELECT 'Credenciales inválidas' AS Mensaje, 0 AS Resultado;
    END IF;
END