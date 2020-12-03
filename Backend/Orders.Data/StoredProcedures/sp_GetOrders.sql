CREATE PROCEDURE [dbo].[sp_GetOrders]
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
	ORDER BY
		OrderDate DESC

RETURN 0