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
GO

DROP PROCEDURE uspListarEspecialidadesPorNombre;
GO
CREATE PROCEDURE uspListarEspecialidadesPorNombre
@nombre VARCHAR(100)
AS
BEGIN
	SELECT IIDESPECIALIDAD, NOMBRE, DESCRIPCION
	FROM Especialidad
	WHERE NOMBRE LIKE @nombre + '%'
END
GO

EXEC uspListarEspecialidadesPorNombre "a"