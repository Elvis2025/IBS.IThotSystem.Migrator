# ⚡ Excel To SQL Migrator

<div align="center">

## 🧩 Generador dinámico de scripts SQL Server desde Excel

Convierte datos de archivos Excel en scripts `INSERT INTO` listos para ejecutar en SQL Server, de forma rápida, visual y configurable.

</div>

---

## 📌 ¿Por qué se creó?

Este proyecto fue creado para resolver una necesidad común en procesos de migración de datos:

> Tomar información desde archivos Excel y convertirla rápidamente en scripts SQL seguros, organizados y ejecutables.

Muchas veces los datos vienen desde clientes, plantillas manuales, reportes externos o archivos exportados. Crear los `INSERT` manualmente puede ser lento, repetitivo y propenso a errores.

Por eso esta app permite cargar un Excel, mapear columnas, agregar valores manuales y generar automáticamente un archivo `.sql`.

---

## 🎯 ¿Para qué se usa?

Esta aplicación se usa para:

- 📄 Leer datos desde archivos Excel.
- 🧠 Mapear columnas del Excel a campos de una tabla SQL.
- ✍️ Agregar campos manuales que no existen en el Excel.
- 🧱 Generar scripts `INSERT INTO`.
- 💾 Descargar un archivo `.sql`.
- 🛡️ Evitar el error de SQL Server por más de 1000 filas en un solo `INSERT`.
- 🔁 Cambiar la fuente de datos sin perder la configuración de campos.

---

## 🚀 Funcionalidades principales

### 📁 Carga de Excel

Permite cargar archivos:

```text
.xlsx
.xls
.xlsm