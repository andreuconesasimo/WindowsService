# Windows Service

Generates HTML using xml and xsl every 10 seconds.

In order to install the service, after building the project, in a terminal go to the executable directory and write the following command:

installutil exeName.exe

In order to remove the service, write the following command:

sc delete nombre_servicio

or

installutil nombre_ejecutable /u
