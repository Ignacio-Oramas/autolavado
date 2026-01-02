  # 🚗 Sistema de Autolavado

  Este es un prototipo de sistema integral de gestión para autolavados desarrollado con ASP.NET Core MVC. La aplicación permite administrar un flujo que va desde el registro de
  clientes y sus vehículos hasta la ejecución y finalización de órdenes de lavado, incluyendo la gestión de empleados y catálogo de servicios. El proposito principal es probar el 
  flujo de trabajo usando c# .net 10.
  
   ## ⚠️ Aclaratorias
  Al ser un prototipo con motivo de probar .net no cumple con:
  * Validaciones basicas, negocio, testing.
  * diseño basico bootstrap.
  * Flujo de trabajo completo.
  * se uso de base un proyecto tutorial de crud de empleados (mvcrud).

  ## 🛠️ Tecnologías Utilizadas

   * Backend: .NET 10.0, ASP.NET Core MVC.
   * ORM: Entity Framework Core (SQL Server).
   * Seguridad: ASP.NET Core Identity (Autenticación y Autorización).
   * Frontend: Bootstrap 5.3.8, FontAwesome 7, jQuery.
   * Paginación: Implementación personalizada de PaginatedList para manejo del lado del servidor.
   * IA: Gemini en modo agente supervisado y como consultor.

  ## 🚀 Características Principales

  📋 Gestión de Órdenes de Lavado
   * Flujo de Estados: Gestión dinámica de estados: Pendiente ➡️ Procesando ➡️ Terminado.
   * Buscador Inteligente: Filtro dinámico de vehículos por cliente mediante AJAX en la creación de órdenes.
   * Cálculo Automático: Asignación automática de precios basada en el catálogo de servicios y registro de fecha/hora en tiempo real.

  👥 Administración de Recursos
   * Módulo de Empleados: Registro detallado con metadatos de creación (usuario que registra y fecha).
   * Gestor de Clientes y Vehículos: Relación uno a muchos entre clientes y sus vehículos (identificados por placa, modelo y color).
   * Catálogo de Servicios: Definición de servicios con precios y duraciones estimadas.

  🔐 Seguridad y UI/UX
   * Identity Personalizado: Sistema de autenticación completamente traducido al español y estilizado con componentes modernos de Bootstrap.
   * Diseño Responsivo: Interfaz adaptada a dispositivos móviles y escritorio usando un sistema de tarjetas (Cards) y Grid System.
   * Paginación Eficiente: Tablas con paginación del lado del servidor (8 registros por página) para optimizar el rendimiento.

  📸 Capturas de Pantalla (Estructura de Vistas)

  El sistema utiliza una interfaz limpia basada en:
   * Index: Tablas con insignias (badges) de colores para estados y botones de acción rápidos.
   * Formularios: Layouts de dos columnas para mejorar la usabilidad.
   * Navegación: Menú lateral y superior con iconos intuitivos de FontAwesome 7.

  ⚙️ Configuración e Instalación

   1. Requisitos: SDK de .NET 10.0 y SQL Server.
   2. Base de Datos:
   1     dotnet ef database update
   3. Ejecución:
   1     dotnet run

  📝 Registro de Cambios (Changelog)

  El desarrollo ha seguido un proceso iterativo documentado detalladamente:
   * Dic 2025: Scaffolding inicial, configuración de Identity y migración a sistema de Autolavado.
   * Ene 2026: Traducción completa al español, integración de AJAX para filtrado de vehículos y despliegue de paginación de servidor.


  ---

  Desarrollado por: Ignacio Oramas (https://github.com/Ignacio-Oramas)
  Proyecto: mvcrud / autolavado (C# .NET)
