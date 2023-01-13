CREATE TABLE [dbo].[Usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](100) NOT NULL,
	[clave] [nvarchar](700) NOT NULL,
	[fechaCreacion] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Usuarios] ADD  DEFAULT (getdate()) FOR [fechaCreacion]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador único del usuario en el sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuarios', @level2type=N'COLUMN',@level2name=N'id'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Identificador que utilizará el usuario para realizar actividades de autenticación' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuarios', @level2type=N'COLUMN',@level2name=N'usuario'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Clave de usuario cifrada' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuarios', @level2type=N'COLUMN',@level2name=N'clave'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de la creaicón del usuario en el sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuarios', @level2type=N'COLUMN',@level2name=N'fechaCreacion'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Guarda la información relacionada a los usuarios que se pueden registrar y autenticar en el sistema' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Usuarios'
GO