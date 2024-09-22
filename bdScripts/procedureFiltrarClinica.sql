USE Medico;
GO
DROP PROCEDURE uspFiltrarClinicaPorId;
GO

CREATE PROCEDURE uspFiltrarClinicaPorId
@idclinica int
AS
BEGIN
	SELECT IIDCLINICA, NOMBRE, DIRECCION
	FROM Clinica
	WHERE IIDCLINICA=@idclinica
END
GO

EXEC uspFiltrarClinicaPorId 1