#WebApi ToDoList
Se crean las APIs necesarias para crear, modificar un listado de tareas.


##Instalaciones
Paso 1: Configurar base de datos.

1.1.Instalar SQL Server Express
2. 1.1.Instalar SQL server management Studio
3. 1.2 Abrir SQL Server management Studio
   2. Conectarse al Servidor de Base de datos 
     -Servidor remoto: tener credenciales (Login y password)
	 -Servidor local: click en conectar
2.  2.1. Se sugiere crear una base de datos nueva llamada "ToDoList_DB" , pero, se puede usar una base de datos existente
          Ejecutar el siguiente comando
          CREATE DATABASE ToDoList_DB;
   
   
4. 3. Click derecho sobre la base de datos (ToDoList_DB u otra)y escoger la opción New Query.
   4.1. Tomar los scripts para las tablas tasks y users desde el proyecto en la ruta WebApi.ToDoList/WebApi.ToDoList.SQL/Tables/
   Tasks.sql
   Users.sql
   
   2. Tomas los scripts de los Stored procedures de la ruta del proyecto en la ruta WebApi.ToDoList/WebApi.ToDoList.SQL/Stored Procedures/
      pr_task_assignUser.sql
	  pr_task_changeStatus.sql
	  pr_task_list.sql
	  pr_task_removeUser.sql
	  pr_task_save.sql
	  pr_task_update.sql
	  pr_user_list.sql
	  pr_user_save.sql
	  
	  
Paso 2: Configurar WebAPi 
3.1 En el proyecto, se busca el archivo web.config, ubicado en: WebApi.ToDoList/WebApi.ToDoList/
   Se modifica el connectionString existente por defecto:
    <add name="WebApiToDoList_DB" connectionString="Data Source=DESKTOP-D106UMJ\MSSQLSERVER01;Initial Catalog=ToDoList_DB;Integrated Security=True;" providerName="System.Data.SqlClient" />
  
  3.2. El atributo "Source" se debe cambiar, se puede usar un servidor local o remoto donde se encuentre la base de datos.
  3.3. En el atributo llamado Catalog se debe colocar el mismo nombre usado en el paso 2.1, teniendo en cuenta que puede ser una base de datos nueva o existente.
  3.4. En caso de usar una base de datos remota, se deben agregar los siguientes parametros.
    –User ID: nombre de usuario del servidor de base de datos.
    –Password: contraseña de acceso al servidor de base de datos.
	
El connectionString debe ser similar al siguiente:
<add name="WebApiToDoList_DB" connectionString="Data Source=DESKTOP-D106UMJ\MSSQLSERVER01;User ID=admin;Password=abc123$ ;Initial Catalog=ToDoList_DB;Integrated Security=True;" providerName="System.Data.SqlClient" />
	
	
Paso 3: Desplegar proyecto en Servidor Web IIS(Internet Information Services)
	 Se recomiendan los pasos del siguiente enlace: https://www.c-sharpcorner.com/UploadFile/2b481f/how-to-host-Asp-Net-web-api-on-iis-server/
	 
  
  
