# FiyiStack

**Un generador de código low-code, un potente scaffolder y un catalizador de código**

## 📄 Descripción general

FiyiStack es una aplicación de escritorio desarrollada en C#/.NET y WindowsForms, diseñada como un generador y catalizador low-code: un entorno base que permite crear y ampliar rápidamente soluciones web y de escritorio con un mínimo esfuerzo.

FiyiStack permite crear rápidamente aplicaciones CRUD introduciendo un diagrama entidad-relación (DER) en el sistema. Este generador y catalizador de código permite crear las vistas web y de escritorio para manipular tablas de bases de datos.

Si una aplicación típica requiere 10.000 líneas de código, FiyiStack genera entre 6.000 a 7.000. Por cada tabla de la base de datos, FiyiStack genera al menos 5.000 líneas de código para que el CRUD sea funcional.

## 📄 Funcionalidades de los CRUDs generados:
- Agregar y modificar datos, siempre que superen las pruebas disponibles en la entidad.
- Visualizar datos en formato de tabla o cartas (para dispositivos pequeños).
- Exportar datos a formatos PDF, Excel y CSV.
- Importar datos desde un archivo de Excel.
- Realizar acciones masivas para copiar y eliminar.
        
## 🚀 Pasos para usarlo

Siga estos pasos para ejecutar la aplicación localmente:
1. Clona el repositorio.
2. Realiza una copia de seguridad de la base de datos FiyiStackDeskApp.bak con Microsoft SQL Server Management Studio u otro programa similar.
4. Ejecuta el archivo FiyiStackDeskApp.sln con Visual Studio.
5. Restaura los paquetes NuGet.
6. Si deseas depurar, coloca un punto de interrupción en el archivo de inicio, Program.cs.
7. Introduce mis credenciales: USUARIO: novillo.matias1@gmail.com, CONTRASEÑA: z
8. Crea un nuevo proyecto colocando nombre, path del proyecto a generar y seleccionar tipo de generador.
9. Restaura las funciones comunes de SQL desde la carpeta DatabaseBackup/. Estas funciones permiten conectar FiyiStack con la BD de tu aplicación
11. Crea una conexión a la base de datos.
12. Crea una tabla dentro de esa base de datos.
13. Genera

## Generadores en operación:
G1, genera con las siguientes tecnologías: .NET, C#, Blazor, MS SQL Server, EF Core, DI, patrón repositorio, Bootstrap, Js, CSS, HTML
