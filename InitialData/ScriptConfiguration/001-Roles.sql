DROP TABLE IF EXISTS #RolesTemp

SELECT 
IdRol, NombreRol, Usuarios, Roles, Clientes, FichasTecnicas, Peleas, Reportes, Bitacoras, Estado INTO #RolesTemp
FROM (
VALUES
(1, 'Administrador', 1, 1, 1, 1, 1, 1, 1, 1),
(2, 'Asistente', 0, 0, 1, 1, 1, 1, 0, 1)
)AS TEMP (IdRol, NombreRol, Usuarios, Roles, Clientes, FichasTecnicas, Peleas, Reportes, Bitacoras, Estado)


----ACTUALIZAR DATOS---
UPDATE P SET
  P.NombreRol = TM.NombreRol,
  P.Usuarios = TM.Usuarios,
  P.Roles = TM.Roles,
  P.Clientes = TM.Clientes,
  P.FichasTecnicas = TM.FichasTecnicas,
  P.Peleas = TM.Peleas,
  P.Reportes = TM.Reportes,
  P.Bitacoras = TM.Bitacoras,
  P.Estado = TM.Estado
FROM Roles P
INNER JOIN #RolesTemp TM
    ON P.IdRol= TM.IdRol


----INSERTAR DATOS---

INSERT INTO Roles (
NombreRol, Usuarios, Roles, Clientes, FichasTecnicas, Peleas, Reportes, Bitacoras, Estado)
SELECT
NombreRol, Usuarios, Roles, Clientes, FichasTecnicas, Peleas, Reportes, Bitacoras, Estado
FROM #RolesTemp
/*EXCEPT
SELECT
IdRol, NombreRol, Usuarios, Roles, Clientes, FichasTecnicas, Peleas, Bitacoras, Lectura, Estado
FROM Roles
*/
GO