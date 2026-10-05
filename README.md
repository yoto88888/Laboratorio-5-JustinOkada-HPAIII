# Laboratorio-5-JustinOkada-HPAIII

# 🖥️ Consultas y Métodos 

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![MySQL](https://img.shields.io/badge/mysql-%2300f.svg?style=for-the-badge&logo=mysql&logoColor=white)

Este repositorio contiene un conjunto de **Aplicaciones de Consola en C#** diseñadas para demostrar conceptos fundamentales de programación estructurada y orientada a objetos, así como la resolución de algoritmos matemáticos y lógicos.

El proyecto destaca por su interactividad mediante la línea de comandos, permitiendo al usuario ejecutar diferentes módulos lógicos y probar interacciones seguras con una base de datos MySQL en un entorno de texto.

## ✨ Características Principales

- **Interfaz de Consola Interactiva:** Menús navegables mediante la línea de comandos que permiten al usuario probar cada algoritmo de forma independiente.
- **Sobrecarga de Métodos:** Implementación de clases que demuestran cómo múltiples funciones pueden compartir el mismo nombre variando sus parámetros (ej. actualizar inventario con diferentes criterios).
- **Algoritmos Recursivos:** Resolución de problemas matemáticos, como el cálculo del factorial de un número, demostrando el uso correcto de casos base y llamadas recursivas.
- **Análisis de Frecuencias:** Uso de colecciones avanzadas (`Dictionary<char, int>`) para procesar cadenas de texto y contabilizar la repetición de caracteres.
- **Conexión Segura a MySQL:** Integración de la consola con una base de datos utilizando comandos parametrizados para evitar inyecciones SQL durante las pruebas de inserción y actualización.

## Capturas para los Problemas
- **Consulta 1**
- <img width="373" height="409" alt="Screenshot 2026-10-05 102834" src="https://github.com/user-attachments/assets/14400581-db16-4f5e-96be-ec4058ea10f1" />
- **Consulta 2**
- <img width="313" height="330" alt="Screenshot 2026-10-05 102851" src="https://github.com/user-attachments/assets/8cae424a-090d-4024-8dee-c5eabe073848" />
- **Consulta 3**
- <img width="524" height="333" alt="Screenshot 2026-10-05 102859" src="https://github.com/user-attachments/assets/e1023fba-8955-4c42-b3a3-2fdb9ac48ada" />
- **Problema 2 Cadenas**
- <img width="942" height="184" alt="Screenshot 2026-10-05 110739" src="https://github.com/user-attachments/assets/99365368-d10a-44ed-ac25-8c198af0f71e" />
- **Problema 3 Metodos Sobrecargados**
- <img width="565" height="323" alt="Screenshot 2026-10-05 110840" src="https://github.com/user-attachments/assets/45329f1b-62ed-4ebb-8ec6-d517fdf2471f" />
- **Problema 4 Recursividad Factorial**
- <img width="587" height="406" alt="Screenshot 2026-10-05 110822" src="https://github.com/user-attachments/assets/4c9cfa74-f0d9-48c6-892b-c94a701e4187" />
- **Problema 5 Frecuencia**
- <img width="1109" height="383" alt="Screenshot 2026-10-05 110804" src="https://github.com/user-attachments/assets/3ac10472-2cf0-445f-8867-4e2c04855b36" />



## 🛠️ Tecnologías y Herramientas

- **Lenguaje:** C# (.NET Core / .NET Framework)
- **Entorno:** Aplicación de Consola (CLI)
- **Base de Datos:** MySQL
- **Librería de Datos:** `MySql.Data` (MySQL Connector/NET)

> *(Espacio reservado para captura de pantalla de la terminal/consola en ejecución)*

## 📂 Arquitectura del Proyecto

El código fuente está estructurado de manera modular para separar cada concepto:

- `Program.cs`: Punto de entrada principal de la aplicación. Contiene el bucle de la consola y el menú interactivo principal.
- `Matematicas.cs`: Clase estática que encapsula los algoritmos lógicos, incluyendo las funciones recursivas (Factorial) y el cálculo de frecuencias.
- `GestorInventario.cs`: Clase que ejemplifica la lógica de negocio y la sobrecarga de métodos.
- `ConexionSegura.cs`: Módulo encargado de gestionar la comunicación con MySQL, enviando consultas desde la consola de forma parametrizada.

## ⚙️ Instalación y Configuración

Sigue estos pasos para ejecutar la aplicación de consola en tu entorno local:

### 1. Requisitos Previos
- Visual Studio (2019 o superior), Visual Studio Code o el SDK de .NET instalado.
- Servidor MySQL local (XAMPP, WAMP, o MySQL Server).

### 2. Base de Datos (Opcional para el módulo DB)
Si deseas probar el módulo de conexión segura, crea la base de datos ejecutando este script:

```sql
CREATE DATABASE pruebas_consola_db;
USE pruebas_consola_db;

CREATE TABLE registros (
    id INT AUTO_INCREMENT PRIMARY KEY,
    dato VARCHAR(100) NOT NULL,
    valor DECIMAL(10,2) NOT NULL
);
```

### 3. Configurar Conexión
Abre el archivo `ConexionSegura.cs` y verifica que la cadena de conexión coincida con tus credenciales:

```csharp
private static string cadenaConexion = "Server=localhost;Database=pruebas_consola_db;Uid=root;Pwd=tu_contraseña;";
```

### 4. Restaurar Paquetes NuGet
Si utilizas la funcionalidad de base de datos, asegúrate de instalar el conector de MySQL mediante la terminal:
```bash
dotnet add package MySql.Data
```

### 5. Ejecutar
Abre una terminal en la ruta del proyecto y ejecuta el siguiente comando para iniciar la aplicación de consola:
```bash
dotnet run
```
*(Alternativamente, presiona `F5` si estás usando Visual Studio).*

---
*Desarrollado como parte de las prácticas fundamentales de programación en C# y algoritmos.*
