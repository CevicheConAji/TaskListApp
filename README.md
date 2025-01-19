# Lista de Tareas en .NET MAUI

Bienvenido al proyecto **Lista de Tareas en .NET MAUI**, una aplicación multiplataforma diseñada para ayudar a los usuarios a gestionar sus tareas de manera eficiente. Este proyecto es un ejemplo de cómo implementar el patrón MVVM en .NET MAUI con funcionalidades completas de gestión de tareas.

## Características

- **Añadir tareas**: Crea nuevas tareas con facilidad.
- **Eliminar tareas**: Elimina tareas que ya no son relevantes.
- **Marcar como completadas**: Indica visualmente las tareas completadas con texto tachado.
- **Interfaz responsiva**: Compatible con dispositivos Android, iOS y Windows.
- **Validación**: Evita agregar tareas vacías.
- **Navegación fluida**: Uso de Shell para moverse entre pantallas.

## Tecnologías Utilizadas

- **.NET MAUI**: Framework multiplataforma para aplicaciones nativas.
- **C#**: Lógica de programación.
- **XAML**: Diseño de la interfaz de usuario.
- **MVVM**: Separación entre lógica y vista.
- **ObservableCollection**: Gestión de listas de datos dinámicas.

## Instalación

1. Clona este repositorio en tu máquina local:
   ```bash
   git clone https://github.com/CevicheConAji/TaskListApp
   ```
2. Abre el proyecto en **Visual Studio 2022** o superior.
3. Asegúrate de tener instalados los workloads necesarios para **.NET MAUI**.
4. Compila y ejecuta el proyecto seleccionando tu dispositivo objetivo (emulador o físico).

## Estructura del Proyecto

```plaintext
Proyecto-Lista-Tareas/
├── Models/            # Modelos de datos (e.g., TodoItem.cs)
├── ViewModels/        # Lógica de negocio y enlace de datos
├── Views/             # Interfaces de usuario (MainPage.xaml, AddItemNewWindow.xaml)
├── App.xaml           # Configuración global de la aplicación
├── AppShell.xaml      # Navegación y estructura del Shell
└── Program.cs         # Punto de entrada principal
```

## Uso

### Pantalla Principal
1. Visualiza la lista de tareas existentes.
2. Marca tareas como completadas haciendo clic en la casilla de verificación.
3. Elimina tareas con el botón "Borrar".

### Añadir Nueva Tarea
1. Haz clic en el botón **Añadir tarea**.
2. Escribe el título de la tarea.
3. Opcionalmente, marca la tarea como completada antes de guardarla.

## Capturas de Pantalla

### Pantalla Principal
![Pantalla Principal](ruta/a/la/captura_principal.png)

### Añadir Tarea
![Añadir Tarea](ruta/a/la/captura_añadir_tarea.png)

## Resultados Esperados

- Gestión intuitiva y eficiente de tareas.
- Adaptación fluida en diferentes dispositivos y resoluciones.

## Pruebas

- Pruebas realizadas en emuladores de Android y Windows.
- Validación de entradas vacías al añadir tareas.

## Contribuciones

¡Las contribuciones son bienvenidas! Por favor, sigue estos pasos:

1. Haz un fork del repositorio.
2. Crea una rama con tu nueva funcionalidad:
   ```bash
   git checkout -b nueva-funcionalidad
   ```
3. Realiza los cambios y haz un commit:
   ```bash
   git commit -m "Añadir nueva funcionalidad"
   ```
4. Envía un pull request.

## Licencia

Este proyecto está licenciado bajo la [MIT License](LICENSE).

## Contacto

Para dudas o sugerencias, por favor contacta a:

- Nombre: Piero Zavala Chira
- Email: zavalaChiraPiero@gmail.com
- GitHub: [usuario](https://github.com/CevicheConAji)

---

¡Gracias por visitar este proyecto! Esperamos que sea útil para tus necesidades de desarrollo.

