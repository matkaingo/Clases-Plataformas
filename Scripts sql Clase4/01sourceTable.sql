/*    ==ScriptingParameters==

    SourceServerVersion : SQL Server 2017 (14.0.3192)
    SourceDatabaseEngineEdition : Microsoft SQL Server Enterprise Edition
    SourceDatabaseEngineType : SQL Server independiente

    TargetServerVersion : SQL Server 2017
    TargetDatabaseEngineEdition : Microsoft SQL Server Enterprise Edition
    TargetDatabaseEngineType : SQL Server independiente
*/

USE [News]
GO

/****** Object:  Table [dbo].[Source]    Script Date: 24/07/2019 4:27:07 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Source](
	[id] [int] NOT NULL,
	[link] [varchar](256) NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Source] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

