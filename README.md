<!--
GitHub README NO soporta <style> dentro del markdown.
Por eso te imprimió el CSS como texto.

La solución correcta es:
NO usar <style>
y usar solamente HTML inline compatible con GitHub.
-->

<div align="center">

# ⚡ Excel To SQL Migrator

## 🚀 Fast • Dynamic • Professional

Aplicación profesional para migrar datos desde Excel hacia SQL Server de forma visual, rápida y totalmente configurable.

<br/>

<img src="https://img.shields.io/badge/.NET-9-blue?style=for-the-badge" />
<img src="https://img.shields.io/badge/BLAZOR-SERVER-purple?style=for-the-badge" />
<img src="https://img.shields.io/badge/SQL-SERVER-red?style=for-the-badge" />
<img src="https://img.shields.io/badge/EXCEL-SUPPORTED-16a34a?style=for-the-badge" />
<img src="https://img.shields.io/badge/STATUS-STABLE-success?style=for-the-badge" />

<br/>
<br/>

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:2563eb,100:9333ea&height=140&section=header&text=Excel%20To%20SQL%20Migrator&fontSize=34&fontColor=ffffff&animation=fadeIn" />

</div>

---

# 📌 Descripción

Excel To SQL Migrator permite generar automáticamente scripts SQL INSERT a partir de archivos Excel de forma inteligente y configurable.

## 🔍 Detección automática

- 📊 Cantidad de registros
- 📌 Columnas disponibles
- 📄 Nombre del archivo
- 🧩 Mapeo dinámico de columnas

---

# 🧠 Mapeo dinámico de columnas

Puedes mapear cualquier columna del Excel hacia cualquier campo SQL.

| Excel | SQL |
|---|---|
| Nombre | FirstName |
| Edad | Age |

## ⚡ Resultado generado

```sql
INSERT INTO Persons
(
    FirstName,
    Age
)
VALUES
(
    N'Elvis',
    20
);
```

---

# ✍️ Valores manuales

También puedes insertar valores fijos que NO existen en el Excel.

| Campo SQL | Valor |
|---|---|
| TenantId | 1 |
| IsActive | true |

## ⚡ Resultado generado

```sql
INSERT INTO Persons
(
    TenantId,
    IsActive
)
VALUES
(
    1,
    1
);
```

---

# 🛡️ Protección contra límites de SQL Server

SQL Server NO permite más de:

```text
1000 filas por INSERT
```

La aplicación divide automáticamente el script en bloques seguros.

## ⚡ Generación automática segura

```sql
INSERT INTO Table (...)
VALUES (...);

INSERT INTO Table (...)
VALUES (...);

INSERT INTO Table (...)
VALUES (...);
```

## 🚫 Error evitado automáticamente

```text
The number of row value expressions in the INSERT statement exceeds the maximum allowed number of 1000 row values.
```

---

# ⚙️ Configuración inteligente

| Configuración | Soportado |
|---|---|
| Campo requerido | ✅ |
| Permitir NULL | ✅ |
| Valor por defecto | ✅ |
| Valor manual | ✅ |
| Desde Excel | ✅ |
| Tipo de dato | ✅ |

---

# 🧬 Tipos de datos soportados

<div align="center">

| Tipo | Descripción |
|---|---|
| 🔤 string | Texto |
| 🔢 int | Número entero |
| 🧮 long | Número largo |
| 💰 decimal | Decimal |
| 📅 date | Fecha |
| ✅ bool | Booleano |

</div>

---

# 🎨 Diseño UI/UX Senior

<div align="center">

| Característica | Descripción |
|---|---|
| 🌙 Dark Professional | Diseño elegante |
| ⚡ Alto contraste | Mejor legibilidad |
| 💎 Glassmorphism | UI moderna |
| ✨ Animaciones suaves | UX fluida |
| 🧠 Flujo intuitivo | Productividad |
| 🧩 Componentes reutilizables | Escalable |

</div>

---

# 🚀 Tecnologías utilizadas

<div align="center">

| Tecnología | Uso |
|---|---|
| .NET 9 | Backend |
| Blazor Server | UI |
| ClosedXML | Lectura Excel |
| SQL Server | Base de datos |
| Bootstrap Icons | Iconografía |
| CSS3 | Diseño UI/UX |

</div>

---

# 📦 Instalación

## 1️⃣ Restaurar paquetes

```bash
dotnet restore
```

## 2️⃣ Compilar proyecto

```bash
dotnet build
```

## 3️⃣ Ejecutar aplicación

```bash
dotnet run
```

---

# 🌍 Abrir aplicación

```text
https://localhost:7100
```

---

# 🧪 Ejemplo práctico

# 📄 Excel

| Nombre | Apellido | Edad |
|---|---|---|
| Elvis | Hernandez | 20 |
| Jose | Perez | 25 |

---

# ⚙️ Configuración

| Campo SQL | Origen |
|---|---|
| FirstName | Nombre |
| LastName | Apellido |
| Age | Edad |
| TenantId | Manual → 1 |
| IsActive | Manual → true |

---

# ⚡ Resultado generado

```sql
INSERT INTO Persons
(
    FirstName,
    LastName,
    Age,
    TenantId,
    IsActive
)
VALUES
(
    N'Elvis',
    N'Hernandez',
    20,
    1,
    1
),
(
    N'Jose',
    N'Perez',
    25,
    1,
    1
);
```

---

# 🛡️ Ventajas

<div align="center">

| ⚡ Rápido | 🧠 Flexible | 🛡️ Seguro |
|---|---|---|
| Generación automática | Valores manuales | Escape SQL |

| 🔁 Reutilizable | 📊 Escalable | 🎯 Profesional |
|---|---|---|
| Cambia el Excel fácilmente | Miles de registros | UI moderna |

</div>

---

# 📂 Arquitectura

```text
IBS.IThotSystem.Migrator
│
├── Components
│   └── Pages
│       └── ExcelMigration.razor
│
├── Models
│   └── ExcelFieldMap.cs
│
├── Services
│   ├── ExcelReaderService.cs
│   └── SqlGeneratorService.cs
│
├── wwwroot
│   └── app.css
│
├── Program.cs
│
└── README.md
```

---

# 🔮 Mejoras futuras

- 💾 Guardar plantillas
- 🔄 Generar UPDATE
- 🔀 Generar MERGE
- 📊 Preview del Excel
- 🧪 Validaciones visuales
- 🌐 Multi idioma
- 🗄️ Conexión directa SQL Server
- 📈 Dashboard de migraciones
- ☁️ Exportación cloud

---

# 💡 Casos de uso

- ✅ Migración de clientes
- ✅ Carga masiva de productos
- ✅ Importación de empleados
- ✅ Migración entre sistemas
- ✅ Configuración inicial de catálogos
- ✅ Seed de datos
- ✅ Integraciones empresariales

---

# 🧠 Filosofía del proyecto

> Automatizar procesos repetitivos y convertir tareas técnicas complejas en experiencias visuales simples, rápidas y profesionales.

---

<div align="center">

# ⚡ Excel To SQL Migrator

## 🚀 Fast • Dynamic • Professional

<br/>

<img src="https://img.shields.io/badge/STATUS-STABLE-success?style=for-the-badge" />
<img src="https://img.shields.io/badge/SQL-SERVER-blue?style=for-the-badge" />
<img src="https://img.shields.io/badge/EXCEL-SUPPORTED-16a34a?style=for-the-badge" />

<br/>
<br/>

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:9333ea,100:2563eb&height=120&section=footer" />

<br/>

👨‍💻 Realizado por Elvis Jesus Hernandez  
📅 Viernes 2026-05-08

</div>
