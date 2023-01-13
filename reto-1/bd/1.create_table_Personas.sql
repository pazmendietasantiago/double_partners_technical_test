CREATE TABLE [dbo].[Personas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](350) NOT NULL,
	[apellidos] [varchar](350) NOT NULL,
	[identificacion] [varchar](30) NOT NULL,
	[email] [varchar](100) NULL,
	[tipoIdentificacion] [varchar](50) NOT NULL,
	[identificacionCompleta]  AS (concat([tipoIdentificacion],'-',[identificacion])),
	[nombreCompleto]  AS (concat([nombres],' ',[apellidos])),
	[fechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Personas] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador único de la persona en la tabla' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Personas', @level2type=N'COLUMN',@level2name=N'id'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombres completos de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Personas', @level2type=N'COLUMN',@level2name=N'nombres'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Apellidos completos de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Personas', @level2type=N'COLUMN',@level2name=N'apellidos'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Número de identificación del DNI de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Personas', @level2type=N'COLUMN',@level2name=N'identificacion'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Dirección de correo electronico de la persona' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Personas', @level2type=N'COLUMN',@level2name=N'email'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Almacena la información relacionada a las personas vinculadas a la plataforma' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Personas'
GO