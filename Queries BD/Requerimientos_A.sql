USE [DBMUSERS]
GO
/****** Object:  StoredProcedure [dbo].[Requerimientos_A]    Script Date: 2/10/2016 10:34:42 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Requerimientos_A]
		@Titulo					VARCHAR(63),
		@Detalle				VARCHAR(2046),
		@PSAlta					VARCHAR(255),
		@PSSolicitante			VARCHAR(255),
		@Prioridad				VARCHAR(255),
		@FEntrega_Estimada		VARCHAR(8),
		@Carpeta				VARCHAR(255) OUTPUT,
		@Numero					INT OUTPUT
AS

SET NOCOUNT ON;

DECLARE @Estado	VARCHAR(255);

--SELECT	@Carpeta = '\\hlah.adroot.ar\0200255\Gdbm\Requerimientos\';
SELECT	@Carpeta = 'C:\Users\Fabian\Desktop\';

SELECT	@Estado = IIF(@PSAlta NOT IN('ps juan', 'ps pablo'), 'En Aprobacion', 'Activo');

BEGIN TRANSACTION Req_A;

BEGIN TRY
		INSERT INTO dbo.Requerimientos (Titulo, Detalle, PSSolicitante, PSAlta, Prioridad, FEntrega_Estimada, Estado)
				VALUES (@Titulo, @Detalle, @PSSolicitante, @PSAlta, @Prioridad, @FEntrega_Estimada, @Estado);
END TRY
BEGIN CATCH
		ROLLBACK TRANSACTION Req_A;

		RAISERROR('Error generando requerimiento.', 16, 1);

		RETURN	-1;
END CATCH

SELECT	@Numero = MAX(Numero) FROM dbo.Requerimientos;

SELECT	@Carpeta += CONVERT(VARCHAR(8), @Numero) + ' - ' + @Titulo;

BEGIN TRY
		UPDATE	dbo.Requerimientos
				SET		Carpeta = @Carpeta
				WHERE	Numero = @Numero;
END TRY
BEGIN CATCH
		ROLLBACK TRANSACTION Req_A;

		RAISERROR('Error generando carpeta de requerimiento.', 16, 1);

		RETURN	-1;
END CATCH

COMMIT TRANSACTION Req_A;


RETURN	0;