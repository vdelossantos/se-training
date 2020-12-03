CREATE PROCEDURE [dbo].[sp_InsertOrder]
	@SenderEmail VARCHAR(50),
    @SenderName VARCHAR(50),
    @RecipientEmail VARCHAR(50),
    @RecipientName VARCHAR(50),
    @Voucher VARCHAR(50),
    @Dedication VARCHAR(100) = ''
AS
	INSERT INTO
		[dbo].[Orders]
	VALUES
		(@SenderEmail, @SenderName, @RecipientEmail, @RecipientName, @Voucher, @Dedication, GETDATE())
RETURN 0