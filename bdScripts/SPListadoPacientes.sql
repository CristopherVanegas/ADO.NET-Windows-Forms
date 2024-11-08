------------------------ SP para Listado de Pacientes ------------------------
DROP PROCEDURE uspListarPacientesPrograma;
GO

CREATE PROCEDURE uspListarPacientesPrograma
AS BEGIN
	SELECT IIDPACIENTE, NOMBRE, APPATERNO, APMATERNO, EMAIL, FECHANACIMIENTO, TELEFONOCELULAR
	FROM Paciente WHERE BHABILITADO = 1;
END;
GO
EXEC uspListarPacientesPrograma;

DROP PROCEDURE uspConsultarPacientesProgramaPorNombre;
GO
CREATE PROCEDURE uspConsultarPacientesProgramaPorNombre
@nombre VARCHAR(100)
AS BEGIN
	SELECT IIDPACIENTE, NOMBRE, APPATERNO, APMATERNO, EMAIL, FECHANACIMIENTO, TELEFONOCELULAR
	FROM Paciente WHERE BHABILITADO = 1 AND NOMBRE LIKE '%' + @nombre + '%';
END;
GO

DROP PROCEDURE uspConsultarPacientesProgramaPorApPaterno;
GO
CREATE PROCEDURE uspConsultarPacientesProgramaPorApPaterno
@apPaterno VARCHAR(150)
AS BEGIN
	SELECT IIDPACIENTE, NOMBRE, APPATERNO, APMATERNO, EMAIL, FECHANACIMIENTO, TELEFONOCELULAR
	FROM Paciente WHERE BHABILITADO = 1 AND APPATERNO LIKE '%' + @apPaterno + '%';
END;
GO

DROP PROCEDURE uspConsultarPacientesProgramaPorApMaterno;
GO
CREATE PROCEDURE uspConsultarPacientesProgramaPorApMaterno
@apMaterno VARCHAR(150)
AS BEGIN
	SELECT IIDPACIENTE, NOMBRE, APPATERNO, APMATERNO, EMAIL, FECHANACIMIENTO, TELEFONOCELULAR
	FROM Paciente WHERE BHABILITADO = 1 AND APMATERNO LIKE '%' + @apMaterno + '%';
END;
GO