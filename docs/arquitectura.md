# Arquitectura del sistema - Mood-Up

## 1. Introducción

Mood-Up utiliza una arquitectura compuesta por una aplicación cliente, un backend encargado de la lógica del sistema y una base de datos para el almacenamiento y gestión de la información.

La arquitectura permite separar las responsabilidades de cada componente y establecer una comunicación organizada entre la aplicación y los servicios del backend.

---

## 2. Componentes de la arquitectura

### 2.1 Cliente

El cliente corresponde a la aplicación desarrollada con React Native y Expo. Este componente proporciona la interfaz mediante la cual los usuarios interactúan con las diferentes funcionalidades de Mood-Up.

Entre sus responsabilidades se encuentran:

* Registro e inicio de sesión.
* Selección e identificación del estado emocional.
* Consulta de recomendaciones.
* Visualización de retos y actividades.
* Consulta de frases motivacionales.
* Visualización de contenido audiovisual.
* Calificación del contenido.
* Selección del tema claro u oscuro.
* Consulta del historial emocional.

---

### 2.2 Backend

El backend contiene la lógica de negocio de Mood-Up y se encuentra desarrollado utilizando C# y ASP.NET.

Sus principales responsabilidades son:

* Gestionar las solicitudes realizadas por el cliente.
* Procesar la información de los usuarios.
* Gestionar los estados emocionales.
* Gestionar el historial emocional.
* Obtener y gestionar recomendaciones de contenido.
* Gestionar los retos y actividades.
* Gestionar las calificaciones.
* Controlar la autenticación y autorización de los usuarios.
* Proteger las rutas que requieren autenticación.

---

### 2.3 API

La comunicación entre el cliente y el backend se realiza mediante una API.

La API permite gestionar diferentes operaciones del sistema, entre ellas:

* Registro de usuarios.
* Inicio de sesión.
* Autenticación mediante JWT.
* Gestión de información emocional.
* Consulta del historial emocional.
* Consulta de contenido audiovisual según el estado emocional.
* Consulta de retos y actividades.
* Gestión de calificaciones.

---

### 2.4 Base de datos

Mood-Up utiliza MySQL como sistema gestor de base de datos. La información puede ser administrada mediante phpMyAdmin.

La base de datos permite almacenar y gestionar la información necesaria para el funcionamiento de la aplicación, incluyendo usuarios, emociones, historial emocional, contenido audiovisual, retos y calificaciones.

---

## 3. Flujo de comunicación

El funcionamiento general de la arquitectura sigue el siguiente flujo:

1. El usuario interactúa con la aplicación cliente.
2. El cliente realiza una solicitud al backend mediante la API.
3. El backend recibe y procesa la solicitud.
4. Cuando es necesario, el backend consulta o modifica la información almacenada en MySQL.
5. La base de datos devuelve la información solicitada al backend.
6. El backend procesa la información y genera una respuesta.
7. La respuesta es enviada al cliente.
8. El cliente presenta el resultado al usuario.

De esta manera, el cliente se encarga principalmente de la interacción con el usuario, mientras que el backend gestiona la lógica de negocio y la comunicación con la base de datos.

---

## 4. Seguridad

La autenticación del sistema utiliza JSON Web Token (JWT).

JWT permite gestionar la autenticación de los usuarios y proteger las rutas que requieren autorización. De esta manera, las funcionalidades que contienen información restringida pueden ser utilizadas únicamente por usuarios autenticados.

Además, el sistema contempla mecanismos para proteger las credenciales de los usuarios mediante el manejo seguro de las contraseñas.

---

## 5. Tecnologías utilizadas

| Componente                      | Tecnología   |
| ------------------------------- | ------------ |
| Aplicación cliente              | React Native |
| Entorno de desarrollo móvil     | Expo         |
| Backend                         | C#           |
| Framework backend               | ASP.NET      |
| Autenticación                   | JWT          |
| Base de datos                   | MySQL        |
| Administración de base de datos | phpMyAdmin   |
| Control de versiones            | Git          |
| Repositorio                     | GitHub       |

---

## 6. Estructura técnica

La solución se encuentra organizada separando los componentes del frontend y backend.

### Frontend

El frontend cuenta con una estructura organizada mediante componentes, contexto, hooks, navegación, pantallas, servicios, estilos, tipos y utilidades.

### Backend

El backend se organiza mediante las siguientes carpetas:

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

Esta organización permite separar diferentes responsabilidades dentro del backend y facilita el mantenimiento y evolución del proyecto.

---

## 7. Arquitectura general

De forma general, la arquitectura de Mood-Up puede representarse de la siguiente manera:

```text
┌──────────────────────────┐
│       Usuario            │
└────────────┬─────────────┘
             │
             ▼
┌──────────────────────────┐
│     React Native         │
│         + Expo           │
│        Frontend          │
└────────────┬─────────────┘
             │
             │ API
             ▼
┌──────────────────────────┐
│       ASP.NET            │
│        Backend           │
│          C#              │
│      JWT / Servicios     │
└────────────┬─────────────┘
             │
             ▼
┌──────────────────────────┐
│         MySQL            │
│       Base de datos      │
│       phpMyAdmin         │
└──────────────────────────┘
```

La arquitectura permite mantener separadas la interfaz de usuario, la lógica de negocio y la persistencia de los datos, facilitando la organización y mantenimiento del proyecto.

