# Arquitectura – MoodUp

## 1. Descripción de la arquitectura

MoodUp utiliza una arquitectura basada en diferentes componentes que trabajan de manera conjunta para proporcionar las funcionalidades de la aplicación.

El sistema está compuesto principalmente por:

- Aplicación web.
- Aplicación móvil.
- Backend o API.
- Base de datos.

La aplicación web y la aplicación móvil funcionan como clientes del sistema y se comunican con el backend mediante una API. El backend se encarga de procesar las solicitudes, gestionar la lógica de la aplicación y realizar las operaciones necesarias sobre la base de datos.

La base de datos almacena la información utilizada por MoodUp, mientras que el backend funciona como intermediario entre las aplicaciones cliente y los datos.

### Flujo general de la arquitectura

```text
┌──────────────────────┐
│    Aplicación Web    │
└──────────┬───────────┘

┌──────────┴───────────┐
│   Aplicación Móvil   │
└──────────────────────┘
           │
           │ API
           │
           ▼
┌──────────────────────┐
│       Backend        │
│       / API          │
└──────────┬───────────┘
           │
           │
           ▼
┌──────────────────────┐
│     Base de datos    │
└──────────────────────┘
           
