### Resolución de prueba técnica

Este archivo está acompañado de dos directorios:
- **reto-1**: Contiene el código relacionado a la primer prueba expuesta en el documento donde se describen los retos. El ejercicio constaba de crear un sistema full-stack, por lo cual se relaciona API (.NET 6), Fron-End (Angular 15) y los scripts de base de datos.

- **reto-2**: Contiene el código relacionado a la segunda prueba expuesta en el documento donde se describen los retos. El ejercicio constaba de crear una aplicación web que interactuara con la API REST de GitHub, por lo cual se relaciona la app Fron-End (Angular 15) que es todo lo que se requiere para validar el reto.

**Guía de contenido:**

[TOC]

###¿Cómo configurar el ambiente del reto-1?
El código relacionado a este reto se encuentran en la carpeta "double_partners/reto-1/".

Para la configuración del ambiente, es ideal iniciar primeramente por la base de datos. El ejercicio fue dearrollado sobre una instancia de SQL Server 2019 Express, es aconsejable usar la misma versión.

Si ya se cuenta con una instacia instalada, se debe crear la base de datos *double_partners*  (una creación básica es suficiente), en este paso se puede escoger si restaurarla desde el backup adjunto con el nombre "*double_partners_backup.bak*" que se encuentra en el archivo "double_partners_backup.zip" o ejecutar los scripts. Recomendaría, por facilidad ir con la primera opción.

Despues de configurar la base de datos, se puede usar una instancia de Visual Studio, Jetbrains Raider IDE, Visual Studio Code, etc, para cargar el proyecto de la API REST. Tener en cuenta que se debe contar con el ambiente apropiado para ejecutar aplicaciones .NET en su versión 6. Es necesario que se restauren las dependencias antes de realizar la ejecución de la API. Si se cuenta con acceso a la línea de comandos se puede ejecutar 

    dotnet restore

O si el proceso es por medio de Visual Studio se puede aprovechar la UI de Nuget Package Manager.

Por último resta configurar la aplicación front-end, para lo cual sólo basta situarse sobre el proyecto (que se ecuentra el sub-directorio *users-front* ) y ejecutar, por medio de línea de comandos, la instalación de los paquetes de node (sobra decir que se debe contar con Node y Angular CLI instalados en el ambiente) por medio de



    npm i

ó

    npm install

Al terminar, la aplicación estaría lista para su uso. Se relaciona un conjunto de imagenes de referencia en el correo al que se envío el resultado de la prueba técnica, los recursos mencionado tiene por nombre:
- *double_partners_reto-1_login.png* : Presenta el inicio de sesión de la app.
- *double_partners_reto-1_panel_users.png* : Presenta el panel de usuarios
- *double_partners_reto-1_panel_persons.png*  : Presenta el panel de usuarios

###¿Cómo configurar el ambiente del reto-2?
El código relacionado a este reto se encuentran en la carpeta "double_partners/reto-2/".

Este reto sólo consta de una unica aplicación web, para este caso creada con Angular, razón por la que se realiza el mismo procedimiento hecho con la app front-end del ejercicio anterior.

Hay que situarse sobre el proyecto (que se ecuentra el sub-directorio *github-users* ) y ejecutar, por medio de línea de comandos, la instalación de los paquetes de node (sobra decir que se debe contar con Node y Angular CLI instalados en el ambiente) por medio de



    npm i

ó

    npm install

Al terminar, la aplicación estaría lista para su uso. Se relaciona imagen de referencia en el correo al que se envío el resultado de la prueba técnica, el recurso mencionado tiene por nombre *double_partners_reto-2.png* que da un vistazo de la app en ejecución .

###Consideraciones
