Imports System

Module Program
    Sub Main(args As String())
        
        ' UTILIZANDO LA CONCATENACIÓN DE CADENAS 
        Dim nombre, apellido, nombreCompleto As String
        
        nombre = "Carlos"
        apellido = "Pérez"
        nombreCompleto = nombre + " " + apellido

        Console.WriteLine("Nombre completo: {0}", nombreCompleto)
        
        ' UTILIZANDO EL CONSTRUCTOR STRING
        Dim letras As Char() = {"H", "o", "l", "a"}
        Dim saludo As New String(letras)
        
        Console.WriteLine("Saludo: {0}", saludo)
        
        ' UTILIZANDO MÉTODOS QUE RETORNAN STRING
        Dim sarray As String()={"Hola", "desde", "Visual", "Basic"}
        Dim mensaje As String = String.Join(" ", sarray)
        
        Console.WriteLine("Mensaje: {0}", mensaje)
        
        ' FORMATEANDO MÉTODOS QUE CONVIERTEN VALORES
        Dim esperar As DateTime = New DateTime(2012, 12, 12, 17, 58, 1)
        Dim chat As String = String.Format("Mensaje enviado a las {0:t} el {0:D}", esperar)
        
        Console.WriteLine("Mensaje: {0}", chat)
        
        ' COMPARAR CADENAS
        Dim str1, str2 As String
        str1 = "Esto es una prueba"
        str2 = "Otra cadena"
        
        If(String.Compare(str1,str2)=0) Then
            Console.WriteLine(str1 + " y " + str2 + " son iguales.")
        Else
            Console.WriteLine(str1 + " y " + str2 + " no son iguales.")
        End If
        
        ' CADENA CONTIENE CADENA
        If(str1.Contains("prueba")) Then
            Console.WriteLine("Se ha encontrado la palabra `prueba`")
        Else
            Console.WriteLine("No se ha encontrado la palabra `prueba`")
        End If
        
        ' OBTENER UNA SUBCADENA
        Dim str3 As String
        str3 = "En un lugar de la mancha, de cuyo nombre no quiero acordarme"
        
        Console.WriteLine(str3)
        
        Dim substr As String = str3.Substring(26)
        
        Console.WriteLine(substr)
        
        ' UNIR CADENAS
        Dim strarray As String () = {"Una", "frase", "en", "un", "array"}
        
        Dim str4 As String = String.Join("-", strarray)
        
        Console.WriteLine(str4)
        
        
    End Sub
End Module
