DROP TABLE IF EXISTS #UsuariosTemp

SELECT 
IdUsuario, Usuario, Clave, Rol, Estado INTO #UsuariosTemp
FROM (
VALUES
(1, 'admin', 'admin', 1, 1)
)AS TEMP (IdUsuario, Usuario, Clave, Rol, Estado)


----ACTUALIZAR DATOS---
UPDATE P SET
  P.Usuario = TM.Usuario,
  P.Clave = TM.Clave,
  P.Rol = TM.Rol,
  P.Estado = TM.Estado
FROM Usuarios P
INNER JOIN #UsuariosTemp TM
    ON P.IdUsuario= TM.IdUsuario


----INSERTAR DATOS---

INSERT INTO Usuarios (
Usuario, Clave, Rol, Estado)
SELECT
Usuario, Clave, Rol, Estado
FROM #UsuariosTemp
/*EXCEPT
SELECT
Usuario, Clave, Rol, Estado
FROM Usuarios
*/
GO