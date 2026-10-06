# Mood-Up Backend

Backend desarrollado para el proyecto **Mood-Up**, una aplicación orientada al bienestar emocional que permite a los usuarios registrar e identificar su estado emocional y acceder a recomendaciones personalizadas de películas, series y retos relacionados con su estado de ánimo.

El backend se encarga de proporcionar los servicios necesarios para la comunicación con el frontend, gestionar la información de los usuarios y estados emocionales y realizar las operaciones relacionadas con el contenido y los retos.

Este proyecto fue desarrollado como parte de un proyecto académico universitario.

## 🚀 Funcionalidades

* Registro de usuarios.
* Inicio de sesión.
* Autenticación mediante JWT.
* Registro de estados emocionales.
* Consulta del historial de emociones.
* Recomendación de películas y series según el estado emocional.
* Recomendación de retos y actividades según el estado emocional.
* Gestión de información relacionada con los usuarios y contenidos.
* Comunicación con el frontend mediante servicios de la API.

## 🛠️ Tecnologías utilizadas

* C#
* ASP.NET
* PostgreSQL
* JWT Authentication
* Entity Framework / sistema de migraciones del proyecto

## 🏗️ Arquitectura general

El backend hace parte de la arquitectura de Mood-Up y funciona como intermediario entre el frontend y la base de datos.

```text
Usuario
   │
   ▼
Frontend
React Native / Expo
   │
   │ Solicitudes a la API
   ▼
Backend
ASP.NET / C#
   │
   │ Acceso y gestión de datos
   ▼
PostgreSQL
```

El frontend realiza las solicitudes correspondientes a los servicios del backend. El backend procesa dichas solicitudes, ejecuta la lógica correspondiente y gestiona la información almacenada en PostgreSQL.

## 🗂️ Estructura del proyecto

```text
MoodUP_final/
├── Controlers/
├── DBO/
├── Data/
├── Migrations/
├── Models/
├── Properties/
└── Services/
```

Las carpetas principales cumplen las siguientes funciones:

* **Controlers/**: contiene los controladores encargados de gestionar las solicitudes recibidas por la API.
* **DBO/**: contiene elementos relacionados con el acceso y manejo de datos.
* **Data/**: contiene elementos relacionados con la gestión de datos y configuración.
* **Migrations/**: contiene las migraciones utilizadas para gestionar cambios en la estructura de la base de datos.
* **Models/**: contiene los modelos utilizados para representar la información manejada por el backend.
* **Properties/**: contiene archivos de configuración propios del proyecto.
* **Services/**: contiene servicios que encapsulan la lógica utilizada por las funcionalidades del sistema.

## 🗃️ Base de datos

El backend de Mood-Up utiliza **PostgreSQL** como sistema gestor de base de datos.

La estructura de la base de datos y sus cambios se gestionan mediante las migraciones incluidas en el proyecto.

## 🔗 Servicios principales de la API

El backend proporciona servicios utilizados por el frontend para realizar operaciones como:

* Registro de usuarios.
* Inicio de sesión.
* Registro de emociones.
* Consulta del historial de emociones.
* Consulta de películas y series según la emoción.
* Consulta de retos según la emoción.
* Gestión de calificaciones del contenido.

Estos servicios permiten que el frontend interactúe con la información gestionada por el backend.

## 🛡️ Seguridad

El backend utiliza mecanismos de autenticación para proteger el acceso a las funcionalidades de la aplicación.

Entre los mecanismos utilizados se encuentran:

* Autenticación mediante JWT.
* Protección de rutas y recursos.
* Gestión de las credenciales de los usuarios.

## ⚙️ Instalación

### Requisitos previos

Para ejecutar el backend localmente se requiere:

* Visual Studio.
* .NET compatible con el proyecto.
* PostgreSQL.
* Configuración de la conexión con la base de datos.

### Ejecución del backend

Actualmente, el backend no se encuentra desplegado en un servidor externo y se ejecuta de manera local mediante Visual Studio.

Para ejecutarlo:

1. Abrir el proyecto `MoodUP_final` en Visual Studio.
2. Verificar la configuración de conexión con PostgreSQL.
3. Ejecutar el proyecto desde Visual Studio.
4. Mantener el backend activo mientras el frontend realiza solicitudes a sus servicios.

## 🔗 Comunicación con el frontend

El backend proporciona los servicios consumidos por el frontend de Mood-Up.

La comunicación entre ambos componentes permite realizar operaciones relacionadas con:

* Usuarios.
* Estados emocionales.
* Historial emocional.
* Películas y series.
* Retos.
* Calificaciones.

De esta manera, el frontend se encarga principalmente de la interacción con el usuario, mientras que el backend procesa las solicitudes y gestiona la información.

## 📚 Documentación

La documentación técnica y funcional del proyecto se encuentra organizada en la carpeta `docs/` del repositorio.

```text
docs/
├── requisitos.md
├── arquitectura.md
├── modelo-datos.md
├── documentacion-funcional.md
└── instalacion-configuracion.md
```

La documentación contiene información relacionada con:

* Requisitos funcionales y no funcionales.
* Épicas e historias de usuario.
* Arquitectura del sistema.
* Componentes del frontend y backend.
* Modelo de datos.
* Funcionalidades principales.
* Flujos de usuario.
* Instalación y configuración.
* Control de cambios.

## 🌿 Control de versiones

El proyecto utiliza **Git y GitHub** para gestionar el control de versiones.

Las principales ramas utilizadas son:

* `main`: rama principal del proyecto.
* `prueba-y-error`: rama utilizada para realizar pruebas, modificaciones y correcciones.

Los cambios realizados durante el desarrollo se registran mediante commits, permitiendo mantener una trazabilidad de las modificaciones realizadas sobre el proyecto.

## 📄 Licencia

Proyecto de uso académico.
