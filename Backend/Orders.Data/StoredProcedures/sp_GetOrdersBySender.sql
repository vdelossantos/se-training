CREATE PROCEDURE [dbo].[sp_GetOrdersBySender]
	@SenderEmail VARCHAR(50) = ''
AS
	SELECT
		SenderEmail,
		SenderName,
		RecipientEmail,
		RecipientName,
		Voucher,
		Dedication,
		OrderDate
	FROM
		[dbo].[Orders]
	WHERE
		SenderEmail = @SenderEmail

RETURN 0