USE [DBMUSERS]
GO
/****** Object:  StoredProcedure [dbo].[Solicitantes_L]    Script Date: 2/10/2016 10:34:47 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[Solicitantes_L]
AS

SET NOCOUNT ON;

SELECT	SolicitantePS,
		SolicitanteNombre
		FROM	dbo.Solicitantes;


RETURN	0;