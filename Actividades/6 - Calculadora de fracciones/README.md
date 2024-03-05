# Actividad 6 - Calculadora de Fracciones

## Introducción

El desarrollo de la aplicación "Calculadora de Fracciones" es un proyecto diseñado para explorar y profundizar en el dominio de la programación con .NET, específicamente utilizando VB.NET y Windows Forms. Este proyecto no solo busca proporcionar una herramienta útil para operar con fracciones sino que también sirve como un ejercicio práctico en el diseño e implementación de aplicaciones de escritorio, manejo de eventos, interacción con el usuario y lógica de programación orientada a objetos.



## Desarrollo de la Aplicación

### Tecnologías Utilizadas

- **VB.NET**: Como lenguaje de programación, VB.NET ofrece una sintaxis intuitiva y estructuras de control robustas que facilitan la implementación de algoritmos complejos, así como la manipulación de interfaces gráficas de usuario. La orientación a objetos de VB.NET permite estructurar el proyecto de manera clara y modular, utilizando clases para definir las entidades del dominio, como la entidad `Fraccion`.
- **Windows Forms**: Proporciona un marco para el desarrollo de interfaces gráficas de usuario en aplicaciones de escritorio de Windows. Utilizando Windows Forms, se diseñan formularios para cada una de las operaciones de fracciones, desde la captura de datos hasta la visualización de resultados, permitiendo una interacción amigable y directa con el usuario.

 

### Estructura

El proyecto se organiza en torno a varios formularios que representan diferentes vistas y funcionalidades dentro de la aplicación: 



#### Form1

Este formulario actúa como el menú principal de la aplicación. Implementa lógica de control para dirigir al usuario hacia diferentes operaciones con fracciones. Por ejemplo: 

```vb
Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
  If RbtSumDif.Checked Then
    Dim form2 As New Form2()
    form2.Show()
    Me.Close()
  ElseIf RbtDivProd.Checked Then
      ' ...
      ' Otras condiciones
  End If
End Sub
```



#### Form2 y Form3

Estos formularios gestionan las operaciones específicas entre fracciones, como la suma, resta, multiplicación y división. Se valida la entrada del usuario para asegurar datos numéricos y denominadores distintos de cero: 

```vb
Private Sub TxbDen1_Leave(sender As Object, e As EventArgs) Handles TxbDen1.Leave
  If Not IsNumeric(TxbDen1.Text) OrElse Convert.ToInt32(TxbDen1.Text) = 0 Then
    MsgBox("El denominador no puede ser 0", vbExclamation, Title:="¡Atención!")
    TxbDen1.Focus()
  End If
End Sub
```

 

#### ArrayFracciones

Este formulario introduce un enfoque avanzado al pedir al usuario que defina un número de fracciones, las cuales se almacenan en un array y se procesan en conjunto. Aquí se demuestra el manejo de arrays y bucles:

```vb
For i As Integer = 0 To numeroFracciones - 1
	' Lógica para recopilar y procesar cada fracción
Next
```

 

### Implementación

 La implementación de la "Calculadora de Fracciones" subraya la importancia de una arquitectura bien diseñada, mostrando cómo los componentes individuales, formularios, clases y métodos, trabajan conjuntamente para formar una aplicación cohesiva y funcional. La clase `Fraccion` es fundamental en este diseño, encapsulando la lógica específica de las fracciones y permitiendo su fácil manipulación a través de la aplicación.

 

## Conclusiones

Este proyecto es un testimonio del poder y la flexibilidad de VB.NET y Windows Forms para crear aplicaciones de escritorio. A través de este ejercicio, se destacan las capacidades del entorno .NET para el desarrollo rápido de aplicaciones, la importancia de una interfaz de usuario intuitiva y la aplicación de principios de programación orientada a objetos para resolver problemas complejos de manera eficiente.

Este trabajo no solo ha permitido profundizar en la programación con .NET sino que también ha abierto caminos para explorar más sobre arquitecturas de software, diseño de interfaces de usuario y técnicas de programación avanzadas. La experiencia acumulada durante este proyecto sienta las bases para futuros desarrollos y exploraciones en el vasto ecosistema de .NET.
