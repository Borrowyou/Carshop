USE [CarShop]
GO

/****** Object:  StoredProcedure [dbo].[SP_GEN_ID]    Script Date: 03/20/2016 16:34:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GEN_ID]
	@GENERATOR_NAME VARCHAR(32),
	@GENERATOR_STEP INTEGER,
	@NEW_VALUE INTEGER OUTPUT

AS
BEGIN
	DECLARE @GEN_ID INTEGER;
	
	BEGIN TRANSACTION GEN_ID
	SET	TRANSACTION ISOLATION LEVEL SERIALIZABLE
	
	SET @NEW_VALUE = (SELECT GENERATOR_VALUE
					  FROM GENERATORS 
					  WHERE GENERATOR_NAME = @GENERATOR_NAME);
					  
	SET @NEW_VALUE = @NEW_VALUE + @GENERATOR_STEP
	
	UPDATE GENERATORS
	SET GENERATOR_VALUE = @NEW_VALUE
	WHERE GENERATOR_NAME = @GENERATOR_NAME
	
	COMMIT TRANSACTION GEN_ID
END

GO

