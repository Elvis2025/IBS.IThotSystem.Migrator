<style>

:root{
    --bg:#020617;
    --bg2:#0f172a;
    --card:#111827cc;
    --border:rgba(148,163,184,.18);
    --primary:#2563eb;
    --secondary:#9333ea;
    --success:#16a34a;
    --text:#f8fafc;
    --muted:#cbd5e1;
}

html{
    scroll-behavior:smooth;
}

body{
    background:linear-gradient(135deg,#020617,#0f172a,#111827);
}

.hero{
    position:relative;
    overflow:hidden;
    text-align:center;
    padding:60px 30px;
    border-radius:28px;
    background:
        radial-gradient(circle at top left,rgba(37,99,235,.35),transparent 30%),
        radial-gradient(circle at bottom right,rgba(147,51,234,.35),transparent 30%),
        rgba(15,23,42,.92);
    border:1px solid rgba(255,255,255,.08);
    box-shadow:
        0 25px 60px rgba(0,0,0,.45),
        inset 0 1px 0 rgba(255,255,255,.04);
    animation:fadeInDown 1s ease;
}

.hero::before{
    content:'';
    position:absolute;
    width:500px;
    height:500px;
    background:radial-gradient(circle,rgba(37,99,235,.20),transparent 70%);
    top:-250px;
    left:-250px;
    animation:floatBlob 12s linear infinite;
}

.hero::after{
    content:'';
    position:absolute;
    width:500px;
    height:500px;
    background:radial-gradient(circle,rgba(147,51,234,.18),transparent 70%);
    bottom:-250px;
    right:-250px;
    animation:floatBlob2 14s linear infinite;
}

.hero h1{
    font-size:58px;
    margin-bottom:12px;
    color:white;
    text-shadow:
        0 0 15px rgba(37,99,235,.55),
        0 0 35px rgba(147,51,234,.45);
    animation:glowPulse 3s infinite;
}

.hero h2{
    color:#cbd5e1;
    font-weight:500;
    margin-bottom:18px;
}

.hero p{
    color:#e2e8f0;
    font-size:18px;
    max-width:850px;
    margin:auto;
    line-height:1.7;
}

.badges{
    margin-top:30px;
}

.badges img{
    margin:6px;
    transition:all .25s ease;
}

.badges img:hover{
    transform:translateY(-4px) scale(1.05);
}

.glow-line{
    height:3px;
    border:none;
    border-radius:999px;
    margin:40px 0;
    background:linear-gradient(
        90deg,
        #2563eb,
        #9333ea,
        #16a34a,
        #2563eb
    );
    background-size:300% 300%;
    animation:gradientMove 4s linear infinite;
}

.glass-card{
    position:relative;
    overflow:hidden;
    margin:28px 0;
    padding:28px;
    border-radius:24px;
    background:rgba(15,23,42,.78);
    backdrop-filter:blur(12px);
    border:1px solid rgba(255,255,255,.08);
    box-shadow:
        0 18px 45px rgba(0,0,0,.35),
        inset 0 1px 0 rgba(255,255,255,.03);
    animation:fadeInUp .9s ease;
}

.glass-card h1,
.glass-card h2,
.glass-card h3{
    color:white;
}

.glass-card p,
.glass-card li{
    color:#dbe4ee;
    line-height:1.7;
}

.feature-grid{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(220px,1fr));
    gap:18px;
    margin-top:25px;
}

.feature-item{
    padding:22px;
    border-radius:20px;
    background:rgba(30,41,59,.75);
    border:1px solid rgba(255,255,255,.08);
    transition:all .25s ease;
}

.feature-item:hover{
    transform:translateY(-6px);
    box-shadow:
        0 18px 35px rgba(37,99,235,.22),
        0 0 18px rgba(147,51,234,.18);
}

.feature-item h3{
    margin-top:0;
}

.code-block{
    border-radius:18px;
    overflow:hidden;
    box-shadow:0 12px 30px rgba(0,0,0,.35);
}

.footer{
    text-align:center;
    padding:40px 20px;
    margin-top:60px;
    border-radius:24px;
    background:rgba(15,23,42,.82);
    border:1px solid rgba(255,255,255,.08);
}

.footer h2{
    color:white;
}

.footer p{
    color:#cbd5e1;
}

@keyframes fadeInDown{
    from{
        opacity:0;
        transform:translateY(-20px);
    }
    to{
        opacity:1;
        transform:translateY(0);
    }
}

@keyframes fadeInUp{
    from{
        opacity:0;
        transform:translateY(25px);
    }
    to{
        opacity:1;
        transform:translateY(0);
    }
}

@keyframes glowPulse{
    0%,100%{
        text-shadow:
            0 0 15px rgba(37,99,235,.55),
            0 0 35px rgba(147,51,234,.35);
    }

    50%{
        text-shadow:
            0 0 30px rgba(37,99,235,.95),
            0 0 55px rgba(147,51,234,.65);
    }
}

@keyframes gradientMove{
    0%{
        background-position:0% 50%;
    }

    100%{
        background-position:100% 50%;
    }
}

@keyframes floatBlob{
    0%{
        transform:translate(0,0);
    }

    50%{
        transform:translate(40px,40px);
    }

    100%{
        transform:translate(0,0);
    }
}

@keyframes floatBlob2{
    0%{
        transform:translate(0,0);
    }

    50%{
        transform:translate(-40px,-30px);
    }

    100%{
        transform:translate(0,0);
    }
}

</style>

<div class="hero">

# ⚡ Excel To SQL Migrator

## 🚀 Fast • Dynamic • Professional

Aplicación profesional para migrar datos desde Excel hacia SQL Server de forma visual, rápida y totalmente configurable.

<div class="badges">

<img src="https://img.shields.io/badge/.NET-9-blue?style=for-the-badge" />
<img src="https://img.shields.io/badge/BLAZOR-SERVER-purple?style=for-the-badge" />
<img src="https://img.shields.io/badge/SQL-SERVER-red?style=for-the-badge" />
<img src="https://img.shields.io/badge/EXCEL-SUPPORTED-16a34a?style=for-the-badge" />
<img src="https://img.shields.io/badge/STATUS-STABLE-success?style=for-the-badge" />

</div>

</div>

<hr class="glow-line"/>

<div class="glass-card">

# 📌 Descripción

Excel To SQL Migrator permite generar automáticamente scripts SQL INSERT a partir de archivos Excel de forma inteligente y configurable.

### 🔍 Detección automática

- 📊 Cantidad de registros
- 📌 Columnas disponibles
- 📄 Nombre del archivo
- 🧩 Mapeo dinámico de columnas

</div>

<div class="glass-card">

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

</div>

<div class="glass-card">

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

</div>

<div class="glass-card">

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

</div>

<div class="glass-card">

# ⚙️ Configuración inteligente

| Configuración | Soportado |
|---|---|
| Campo requerido | ✅ |
| Permitir NULL | ✅ |
| Valor por defecto | ✅ |
| Valor manual | ✅ |
| Desde Excel | ✅ |
| Tipo de dato | ✅ |

</div>

<div class="glass-card">

# 🧬 Tipos de datos soportados

<div class="feature-grid">

<div class="feature-item">

## 🔤 string

Texto y caracteres.

</div>

<div class="feature-item">

## 🔢 int

Números enteros.

</div>

<div class="feature-item">

## 🧮 long

Valores numéricos largos.

</div>

<div class="feature-item">

## 💰 decimal

Valores monetarios y decimales.

</div>

<div class="feature-item">

## 📅 date

Fechas SQL.

</div>

<div class="feature-item">

## ✅ bool

Valores booleanos.

</div>

</div>

</div>

<div class="glass-card">

# 🎨 Diseño UI/UX Senior

<div class="feature-grid">

<div class="feature-item">

## 🌙 Dark Professional

Diseño elegante y moderno.

</div>

<div class="feature-item">

## ⚡ Alto contraste

Excelente legibilidad visual.

</div>

<div class="feature-item">

## 💎 Glassmorphism

Diseño premium con profundidad.

</div>

<div class="feature-item">

## ✨ Animaciones suaves

Experiencia fluida y moderna.

</div>

<div class="feature-item">

## 🧠 UX intuitiva

Enfocada en productividad.

</div>

<div class="feature-item">

## 🧩 Reutilizable

Componentes escalables.

</div>

</div>

</div>

<div class="glass-card">

# 🚀 Tecnologías utilizadas

| Tecnología | Uso |
|---|---|
| .NET 9 | Backend |
| Blazor Server | UI |
| ClosedXML | Lectura Excel |
| SQL Server | Base de datos |
| Bootstrap Icons | Iconografía |
| CSS3 | Diseño UI/UX |

</div>

<div class="glass-card">

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

## 🌍 Abrir aplicación

```text
https://localhost:7100
```

</div>

<div class="glass-card">

# 🧪 Ejemplo práctico

## 📄 Excel

| Nombre | Apellido | Edad |
|---|---|---|
| Elvis | Hernandez | 20 |
| Jose | Perez | 25 |

## ⚙️ Configuración

| Campo SQL | Origen |
|---|---|
| FirstName | Nombre |
| LastName | Apellido |
| Age | Edad |
| TenantId | Manual → 1 |
| IsActive | Manual → true |

## ⚡ Resultado generado

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

</div>

<div class="glass-card">

# 🛡️ Ventajas

<div class="feature-grid">

<div class="feature-item">

## ⚡ Rápido

Generación automática de scripts SQL.

</div>

<div class="feature-item">

## 🧠 Flexible

Mapeo dinámico y configurable.

</div>

<div class="feature-item">

## 🛡️ Seguro

Escape SQL y división automática.

</div>

<div class="feature-item">

## 🔁 Reutilizable

Compatible con múltiples estructuras Excel.

</div>

<div class="feature-item">

## 📊 Escalable

Miles de registros soportados.

</div>

<div class="feature-item">

## 🎯 Profesional

UI moderna y empresarial.

</div>

</div>

</div>

<div class="glass-card">

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

</div>

<div class="glass-card">

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

</div>

<div class="glass-card">

# 💡 Casos de uso

- ✅ Migración de clientes
- ✅ Carga masiva de productos
- ✅ Importación de empleados
- ✅ Migración entre sistemas
- ✅ Configuración inicial de catálogos
- ✅ Seed de datos
- ✅ Integraciones empresariales

</div>

<div class="glass-card">

# 🧠 Filosofía del proyecto

> Automatizar procesos repetitivos y convertir tareas técnicas complejas en experiencias visuales simples, rápidas y profesionales.

</div>

<div class="footer">

# ⚡ Excel To SQL Migrator

## 🚀 Fast • Dynamic • Professional

<br/>

<img src="https://img.shields.io/badge/STATUS-STABLE-success?style=for-the-badge" />
<img src="https://img.shields.io/badge/SQL-SERVER-blue?style=for-the-badge" />
<img src="https://img.shields.io/badge/EXCEL-SUPPORTED-16a34a?style=for-the-badge" />

<br/>
<br/>

👨‍💻 Realizado por Elvis Jesus Hernandez  
📅 Viernes 2026-05-08

</div>
