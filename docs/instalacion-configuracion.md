
# Instalación y configuración - Mood-Up

## 1. Introducción

Esta documentación describe los requisitos, pasos de instalación, configuración y ejecución necesarios para trabajar con el proyecto Mood-Up, incluyendo el frontend, backend, base de datos y herramientas utilizadas durante el desarrollo.

---

## 2. Prerrequisitos

Antes de ejecutar el proyecto se deben tener instaladas y configuradas las siguientes herramientas:

* Git.
* Node.js y npm.
* Visual Studio.
* MySQL.
* phpMyAdmin.
* Repositorio del frontend.
* Repositorio del backend.

Además, se requiere contar con la configuración correspondiente del frontend, backend y base de datos.

---

## 3. Clonar el proyecto

Para obtener el código fuente se utiliza Git.

El repositorio del frontend utilizado durante el proyecto es:

```text
https://github.com/juanbedoya17/frontend-react-native.git
```

El backend se encuentra en el repositorio correspondiente de Mood-Up.

Una vez obtenido el código fuente, se debe ingresar a la carpeta del proyecto para realizar su configuración.

---

## 4. Instalación del frontend

Después de clonar el repositorio del frontend, se deben instalar las dependencias necesarias mediante npm.

Ejecutar:

```bash
npm install
```

Este comando instala las dependencias requeridas para ejecutar la aplicación.

---

## 5. Ejecución del frontend

Una vez instaladas las dependencias, el proyecto puede iniciarse mediante:

```bash
npm start
```

La aplicación utiliza React Native y Expo para su funcionamiento.

---

## 6. Configuración y ejecución del backend

El backend de Mood-Up está desarrollado utilizando C# y ASP.NET.

Para trabajar con el backend se utiliza Visual Studio.

Los pasos generales son:

1. Obtener el código fuente del backend.
2. Abrir el proyecto en Visual Studio.
3. Verificar la configuración del proyecto.
4. Verificar la conexión con la base de datos.
5. Restaurar las dependencias necesarias.
6. Ejecutar el proyecto desde Visual Studio.

El backend proporciona los servicios necesarios para la comunicación con el frontend y la gestión de la lógica del sistema.

---

## 7. Base de datos

Mood-Up utiliza MySQL como sistema gestor de base de datos y phpMyAdmin como herramienta para su administración.

La base de datos almacena la información necesaria para el funcionamiento del sistema y permite al backend realizar las operaciones correspondientes sobre los datos.

Antes de ejecutar completamente el proyecto se debe verificar que la base de datos se encuentre configurada y disponible.

---

## 8. Configuración general

Para el correcto funcionamiento del proyecto se debe verificar:

* Configuración del frontend.
* Configuración del backend.
* Conexión con MySQL.
* Disponibilidad de la base de datos.
* Dependencias del proyecto.
* Comunicación entre frontend y backend.

La configuración debe corresponder al entorno en el que se ejecutará el proyecto.

---

## 9. Control de versiones

El proyecto utiliza Git y GitHub como herramientas para el control de versiones.

Durante el desarrollo se utilizaron diferentes ramas, entre ellas:

* `main`
* `prueba-y-error`

Los cambios realizados en el proyecto se registraron mediante commits descriptivos, permitiendo realizar seguimiento a las modificaciones efectuadas durante el desarrollo.

El frontend y el backend se gestionan mediante repositorios separados.

---

## 10. Integración continua

El proyecto cuenta con un flujo de integración continua mediante **GitHub Actions**.

La configuración del flujo se encuentra en:

```text
.github/workflows/ci.yml
```

El flujo de integración continua realiza principalmente las siguientes acciones:

1. Configura el entorno de .NET 8.
2. Restaura las dependencias del proyecto.
3. Compila el proyecto.
4. Permite verificar automáticamente que el backend pueda ser construido correctamente.

La ejecución del flujo fue verificada satisfactoriamente durante el desarrollo del proyecto.

---

## 11. Repositorio del backend

El código fuente y la configuración relacionada con el backend se encuentran disponibles en el repositorio de GitHub:

```text
https://github.com/juanbedoya17/Backend-Mood-Up-Final
```

Este repositorio contiene el código del backend, la documentación del proyecto y la configuración correspondiente para la integración continua.

