USE [DBMUSERS]
GO
/****** Object:  StoredProcedure [dbo].[Requerimientos_L]    Script Date: 2/10/2016 10:34:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Requerimientos_L]
		@PS						VARCHAR(255),
		@FechaDesde				VARCHAR(8),
		@FechaHasta				VARCHAR(8),
		@Prioridad				VARCHAR(255),
		@Estado					VARCHAR(255)
AS

SET NOCOUNT ON;

DECLARE	@Error			INT,
		@Query			NVARCHAR(4000),
		@QueryParams	NVARCHAR(4000),
		@Filtros		NVARCHAR(4000);

SELECT	@Filtros = '';

SELECT	@Query = '	SELECT	Numero																								AS ''Nro. Req.'',
							Titulo																								AS ''Título'',
							PSSolicitante																						AS ''Solicitante'',
							CONVERT(VARCHAR(10), FAlta, 103)																	AS ''Fecha Alta'',
							PSAlta																								AS ''Asignado A'',
							Prioridad																							AS ''Prioridad'',
							CONVERT(VARCHAR(10), CONVERT(DATETIME, FEntrega_Estimada, 112), 103)								AS ''Fecha Entrega Estimada'',
							IIF(FEntrega_Real IS NULL, '''', CONVERT(VARCHAR(10), CONVERT(DATETIME, FEntrega_Real, 112), 103))	AS ''Fecha Entrega Real'',
							Estado																								AS ''Estado'',
							Carpeta																								AS ''Carpeta de Archivos''
							FROM	dbo.Requerimientos
							WHERE	1 = 1
							<<FILTROS>>
							ORDER BY Numero DESC;';

IF (@PS <> 'TODOS')
BEGIN
		SELECT	@Filtros += ' AND PSAlta = @PS ';
END

IF (@FechaDesde <> '')
BEGIN
		SELECT	@Filtros += ' AND CONVERT(VARCHAR(8), FAlta, 112) >= @FechaDesde ';
END

IF (@FechaHasta <> '')
BEGIN
		SELECT	@Filtros += ' AND CONVERT(VARCHAR(8), FAlta, 112) <= @FechaHasta ';
END

IF (@Prioridad <> 'TODAS')
BEGIN
		SELECT	@Filtros += ' AND Prioridad = @Prioridad ';
END

IF (@Estado <> 'TODOS')
BEGIN
		SELECT	@Filtros += ' AND Estado = @Estado ';
END

SELECT	@Query = REPLACE(@Query, '<<FILTROS>>', @Filtros);

SELECT	@QueryParams = '@PS VARCHAR(255), @FechaDesde VARCHAR(8), @FechaHasta VARCHAR(8), @Prioridad VARCHAR(255), @Estado VARCHAR(255)';

EXECUTE @Error = sp_executesql @Query, @QueryParams,
				@PS				= @PS,
				@FechaDesde		= @FechaDesde,
				@FechaHasta		= @FechaHasta,
				@Prioridad		= @Prioridad,
				@Estado			= @Estado;

IF (@Error <> 0)
BEGIN
		RAISERROR('Error ejecutando query dinámica.', 16, 1);

		RETURN	-1;
END


RETURN	0;