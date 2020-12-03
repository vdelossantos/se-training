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
	ORDER BY
		OrderDate DESC

RETURN 0