CREATE TABLE [Organization](
	[OrganizationKey] [int] IDENTITY(1,1) NOT NULL,
	[ParentOrganizationKey] [int] NULL,
	[PercentageOfOwnership] [nvarchar](16) NULL,
	[OrganizationName] [nvarchar](50) NULL,
	[CurrencyKey] [int] NULL
)

SET IDENTITY_INSERT Organization ON

INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (1, NULL, N'1', N'AdventureWorks Cycle', 100)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (2, 1, N'1', N'North America Operations', 100)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (3, 14, N'1', N'Northeast Division', 100)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (4, 14, N'1', N'Northwest Division', 100)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (5, 14, N'1', N'Central Division', 100)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (6, 14, N'1', N'Southeast Division', 100)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (7, 14, N'1', N'Southwest Division', 100)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (8, 2, N'.75', N'Canadian Division', 19)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (9, 1, N'1', N'European Operations', 36)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (10, 1, N'.75', N'Pacific Operations', 6)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (11, 9, N'.50', N'France', 36)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (12, 9, N'.25', N'Germany', 36)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (13, 10, N'.50', N'Australia', 6)
INSERT [dbo].[Organization] ([OrganizationKey], [ParentOrganizationKey], [PercentageOfOwnership], [OrganizationName], [CurrencyKey]) VALUES (14, 2, N'1', N'USA Operations', 100)

SET IDENTITY_INSERT Organization OFF

SELECT * FROM Organization



CREATE TABLE [REF_TABLE](
	[ORGN_ID] [int] IDENTITY(1000,1) NOT NULL,
	[ORGN_NAME] [varchar](30) NULL
) ON [PRIMARY]


INSERT [dbo].[REF_TABLE] VALUES (N'Northeast Division')
INSERT [dbo].[REF_TABLE] VALUES (N'France dIVISION')
INSERT [dbo].[REF_TABLE] VALUES ( N'USA Operation')
INSERT [dbo].[REF_TABLE] VALUES ( N'German Division')
INSERT [dbo].[REF_TABLE] VALUES ( N'cENtRAl Division')
INSERT [dbo].[REF_TABLE] VALUES ( N'Division')

SET IDENTITY_INSERT  [REF_TABLE] OFF


SELECT * FROM Organization
SELECT * FROM REF_TABLE




