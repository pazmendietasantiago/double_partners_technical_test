CREATE OR ALTER   PROCEDURE [dbo].[getPersons] @page INT, @registersPerPage INT
AS
BEGIN
    SELECT [id],
           [nombres],
           [apellidos],
           [nombreCompleto],
           [tipoIdentificacion],
           [identificacion],
           [email],
           [identificacionCompleta],
           [fechaCreacion]
    FROM [dbo].Personas
    ORDER BY [id] DESC
    OFFSET (@page - 1) * @registersPerPage ROWS FETCH NEXT @registersPerPage ROWS ONLY
END;
GO