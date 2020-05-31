USE [ERP2020]
GO

drop table DocumentacionEmpleado
go

CREATE TABLE [dbo].[DocumentacionEmpleado](
	[idDocumento] [int] identity(1,1) NOT NULL,
	[nombreDocumento] [varchar](80) NOT NULL,
	[fechaEntrega] [date] NOT NULL,
	[documento] [varbinary](max) NULL,
	[estatus] [char](1) NOT NULL,
	[idEmpleado] [int] NOT NULL,
	
 CONSTRAINT [PK_Documentacion] PRIMARY KEY CLUSTERED 
(
	[idDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[DocumentacionEmpleado]  WITH CHECK ADD  CONSTRAINT [FK_DocEmpl_Emp] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleados] ([idEmpleado])
GO

ALTER TABLE [dbo].[DocumentacionEmpleado] CHECK CONSTRAINT [FK_DocEmpl_Emp]
GO


