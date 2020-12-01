CREATE TABLE [dbo].[Orders] (
	[SenderEmail] [varchar](50) NOT NULL,
	[SenderName] [varchar](50) NOT NULL,
	[RecipientEmail] [varchar](50) NOT NULL,
	[RecipientName] [varchar](50) NOT NULL,
	[Voucher] [varchar](50) NOT NULL,
	[Dedication] [varchar](100) NULL,
	[OrderDate] [datetime] NOT NULL
)