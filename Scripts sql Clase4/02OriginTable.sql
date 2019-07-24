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

/****** Object:  Table [dbo].[Origin]    Script Date: 24/07/2019 4:30:56 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Origin](
	[id] [int] NULL,
	[name] [varchar](50) NULL,
	[link] [varchar](256) NULL,
	[status] [bit] NULL
) ON [PRIMARY]
GO

