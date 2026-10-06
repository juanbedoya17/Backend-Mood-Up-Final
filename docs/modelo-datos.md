# Modelo de datos - Mood-Up

## 1. Introducción

El modelo de datos de Mood-Up define la información necesaria para el funcionamiento de la aplicación y la relación entre los diferentes elementos que intervienen en la experiencia del usuario.

La base de datos utiliza MySQL como sistema gestor y permite almacenar la información relacionada con usuarios, estados emocionales, historial emocional, contenido audiovisual, retos y calificaciones.

---

## 2. Entidades principales

El modelo de datos está compuesto por las siguientes entidades:

* Usuario
* Emoción
* Historial emocional
* Contenido audiovisual
* Reto
* Calificación

---

## 3. Usuario

La entidad **Usuario** representa a las personas que utilizan la aplicación Mood-Up.

Esta entidad permite almacenar la información necesaria para identificar y gestionar a los usuarios del sistema.

Entre sus principales responsabilidades se encuentran:

* Identificar al usuario dentro de la aplicación.
* Permitir el registro e inicio de sesión.
* Gestionar la información necesaria para la autenticación.
* Asociar al usuario con su historial emocional.
* Relacionar al usuario con las calificaciones realizadas sobre el contenido.

---

## 4. Emoción

La entidad **Emoción** representa los diferentes estados emocionales que pueden ser seleccionados o identificados dentro de Mood-Up.

Las emociones son utilizadas como elemento principal para personalizar el contenido y las actividades ofrecidas al usuario.

Esta entidad permite relacionar un estado emocional con:

* Historial emocional.
* Contenido audiovisual.
* Retos.
* Frases y recomendaciones relacionadas con el estado emocional.

---

## 5. Historial emocional

La entidad **Historial emocional** permite registrar los estados emocionales asociados a un usuario a lo largo del tiempo.

Su finalidad es mantener un registro de las emociones identificadas o seleccionadas por el usuario.

Esta información permite:

* Asociar emociones con usuarios.
* Mantener un registro de los estados emocionales.
* Consultar el historial emocional.
* Utilizar la información emocional para personalizar la experiencia.

La relación principal de esta entidad se establece entre el **Usuario** y la **Emoción**.

---

## 6. Contenido audiovisual

La entidad **Contenido audiovisual** representa las películas y series disponibles dentro de Mood-Up.

El contenido puede estar relacionado con diferentes estados emocionales para permitir la generación de recomendaciones personalizadas.

Esta entidad permite gestionar información relacionada con:

* Películas.
* Series.
* Recomendaciones según la emoción.
* Tráileres.
* Calificaciones realizadas por los usuarios.

---

## 7. Reto

La entidad **Reto** representa las actividades o desafíos personalizados que se presentan al usuario.

Los retos pueden estar asociados a diferentes estados emocionales y permiten ofrecer actividades acordes con la experiencia emocional del usuario.

Su finalidad es proporcionar alternativas de interacción y actividades personalizadas dentro de Mood-Up.

---

## 8. Calificación

La entidad **Calificación** representa la valoración realizada por los usuarios sobre el contenido audiovisual.

Esta entidad permite relacionar:

* El usuario que realiza la valoración.
* El contenido audiovisual que recibe la valoración.

Las calificaciones permiten registrar la valoración realizada sobre el contenido disponible en la aplicación.

---

## 9. Relaciones principales

Las entidades del modelo de datos se relacionan para permitir el funcionamiento de las diferentes funcionalidades de Mood-Up.

Las relaciones principales son:

```text
Usuario
   │
   ├──────────► Historial emocional ◄────────── Emoción
   │
   └──────────► Calificación ────────────────► Contenido audiovisual
                                                    │
                                                    │
                                                    ▼
                                                  Emoción

Emoción ───────────────► Reto
```

De esta manera:

* Un **Usuario** puede tener registros en su **Historial emocional**.
* Cada registro del **Historial emocional** se relaciona con una **Emoción**.
* El **Contenido audiovisual** puede estar asociado a diferentes emociones.
* Los **Retos** se relacionan con estados emocionales.
* Un **Usuario** puede realizar **Calificaciones** sobre el contenido audiovisual.

---

## 10. Base de datos

Mood-Up utiliza **MySQL** para la gestión y almacenamiento de los datos.

La administración de la base de datos se realiza mediante **phpMyAdmin**, facilitando la gestión de la información almacenada y la administración del entorno de base de datos.

El modelo permite mantener organizada la información necesaria para las funcionalidades principales de la aplicación y establecer relaciones entre los usuarios, sus estados emocionales y el contenido personalizado.

