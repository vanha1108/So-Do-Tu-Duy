USE [MindMap]
GO
/****** Object:  Table [dbo].[Infor]    Script Date: 6/23/2020 8:35:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Infor](
	[ID] [int] NOT NULL,
	[LocationX] [float] NULL,
	[LocationY] [float] NULL,
	[Witdh] [float] NULL,
	[Height] [float] NULL,
	[Description] [nvarchar](255) NULL,
 CONSTRAINT [PK_Text] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectShape]    Script Date: 6/23/2020 8:35:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectShape](
	[IDPro] [int] NOT NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_ProjectShape] PRIMARY KEY CLUSTERED 
(
	[IDPro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shape]    Script Date: 6/23/2020 8:35:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shape](
	[ID] [int] NOT NULL,
	[NameShape] [nvarchar](255) NULL,
	[LocationX] [float] NULL,
	[LocationY] [float] NULL,
	[Witdh] [float] NULL,
	[Height] [float] NULL,
	[IDPro] [int] NULL,
	[LocationX2] [int] NULL,
	[LocationY2] [int] NULL,
 CONSTRAINT [PK_Shape] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Infor]  WITH CHECK ADD  CONSTRAINT [FK_Text_Shape] FOREIGN KEY([ID])
REFERENCES [dbo].[Shape] ([ID])
GO
ALTER TABLE [dbo].[Infor] CHECK CONSTRAINT [FK_Text_Shape]
GO
ALTER TABLE [dbo].[Shape]  WITH CHECK ADD  CONSTRAINT [FK_Shape_ProjectShape] FOREIGN KEY([IDPro])
REFERENCES [dbo].[ProjectShape] ([IDPro])
GO
ALTER TABLE [dbo].[Shape] CHECK CONSTRAINT [FK_Shape_ProjectShape]
GO
