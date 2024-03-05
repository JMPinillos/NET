# Actividad 5 - Formulario para rellenar tablas

## Introducción

Este proyecto se centra en el desarrollo de una aplicación de escritorio destinada a facilitar la gestión de datos académicos, específicamente en lo que respecta al registro y almacenamiento de información relacionada con alumnos y docentes dentro de una base de datos de academia. El objetivo es proporcionar una interfaz intuitiva para la inserción de datos a la base de datos y ofrecer una experiencia de usuario eficiente y directa para la administración académica.



## Desarrollo de la Aplicación

### Tecnologías Utilizadas

- **VB.NET**: Seleccionado por su integración natural con el entorno de desarrollo de Microsoft y su facilidad de uso para la creación de aplicaciones de escritorio. VB.NET permite un manejo eficaz de eventos y una manipulación detallada de los controles de la interfaz de usuario.
- **Windows Forms**: Utilizado para construir la interfaz gráfica de usuario (GUI) de la aplicación, facilitando la creación de formularios para la inserción y visualización de datos. Windows Forms soporta una amplia variedad de controles que pueden ser personalizados y adaptados según las necesidades específicas del proyecto.
- **MySQL Connector/NET**: Una biblioteca de ADO.NET que proporciona la funcionalidad necesaria para comunicarse con bases de datos MySQL desde .NET, permitiendo ejecutar comandos SQL, realizar consultas y manejar resultados.

 

### Estructura

La aplicación está estructurada en múltiples formularios, cada uno diseñado para manejar diferentes aspectos de la gestión de datos académicos:



#### Form1

Sirve como el punto de entrada de la aplicación, ofreciendo opciones para insertar datos de alumnos y docentes, así como realizar consultas personalizadas a la base de datos. 



#### Form2 y Form3

Estos formularios están dedicados a la recopilación de datos para alumnos y docentes, respectivamente. Cada formulario contiene campos que corresponden a las columnas de sus respectivas tablas en la base de datos, incluyendo nombre, apellidos, fecha de nacimiento y género.

 

#### Form 4

Proporciona una interfaz para ejecutar consultas SQL personalizadas, permitiendo al usuario interactuar directamente con la base de datos y visualizar los resultados a través de un `DataGridView`.



### Implementación

Cada formulario implementa validaciones de entrada para asegurar que los datos recopilados sean correctos y completos antes de intentar insertarlos en la base de datos. Por ejemplo, el formulario para ingresar datos de alumnos (`Form2`) incluye controles para verificar que todos los campos estén llenos y que los valores ingresados sean del tipo esperado (por ejemplo, numéricos para el género):

```vb
If TxtName.Text = "" Or TxtLastName.Text = "" Or DtpBirthday.Value.ToString = "" Or CbxGender.Text = "" Then
  MsgBox("Debe rellenar todos los campos", vbExclamation, Title:="¡Atención!")
Else
  ' Lógica para insertar datos en la base de datos
End If
```



La interacción con la base de datos se maneja utilizando el MySQL Connector/NET, preparando comandos SQL con parámetros para evitar inyecciones SQL y garantizar la seguridad de los datos:

```vb
Dim comando As New MySqlCommand(query1, conexion)
comando.Parameters.AddWithValue("@nombre", nombre)
' Otros parámetros...
comando.ExecuteNonQuery()
```

  

## Conclusiones

Este proyecto demuestra la versatilidad de VB.NET y Windows Forms para el desarrollo de aplicaciones de gestión de bases de datos orientadas a instituciones académicas. La estructura modular de la aplicación y la implementación de buenas prácticas de programación, como la validación de entradas y el uso de comandos parametrizados, aseguran una base sólida para la expansión y mantenimiento futuro del sistema.

 La capacidad de adaptar y expandir el sistema para incluir más características, como la gestión de cursos, horarios y calificaciones, subraya la importancia de elegir tecnologías y arquitecturas de software adecuadas desde el principio. La experiencia adquirida en este proyecto proporciona una base excelente para enfrentar desafíos más complejos en el desarrollo de software dentro del ámbito educativo y más allá.
