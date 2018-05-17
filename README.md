# Windows Service

Generates HTML using xml and xsl

Para instalar el servicio:

installutil nombre_ejecutable --> .exe
(generado al compilar el proyecto)

Para eliminar el servicio:

sc delete nombre_servicio
o
installutil nombre_ejecutable /u