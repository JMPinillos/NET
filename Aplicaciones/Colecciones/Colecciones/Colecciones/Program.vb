Imports System

Module Program
    Sub Main(args As String())
        
        ' CREAR LISTA DE CADENAS
        Dim salmons As New List(Of String)
        
        salmons.Add("chinook")
        salmons.Add("coho")
        salmons.Add("pink")
        salmons.Add("sockeye")
        
        ' ITERAR A LO LARGO DE LA LISTA
        For Each salmon As String In salmons
            Console.Write(salmon & " ")
        Next
        Console.WriteLine()
        
        'OTRA FORMA DE ITERAR
        For i As Integer = 0 To salmons.Count -1
            Console.Write(salmons(i) & " ")
        Next
        Console.WriteLine()
        
        'BORRAR ELEMENTO DE UNA COLECCIÓN ESPECIFICANDO EL OBJETO
        salmons.Remove("coho")
        
        For Each salmon As String In salmons
            Console.Write(salmon & " ")
        Next
        Console.WriteLine()
        
    End Sub
End Module
