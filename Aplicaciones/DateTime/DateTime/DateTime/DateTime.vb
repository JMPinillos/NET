Imports System

Module DateTime
    Sub Main(args As String())
        
        ' CONSTRUCTOR DateTime: YEAR, MONTH, DAY, HOUR, MIN, SEC
        Dim date1 As New Date (2012, 12, 16, 12, 0, 0)
        
        ' INICIALIZAR UN NUEVO DateTime
        Dim date2 As Date = #12/16/2012 12:00:52AM#
        
        ' USANDO PROPIEDADES
        Dim date3 As Date = Date.Now
        Dim date4 As Date = Date.UtcNow
        Dim date5 As Date = Date.Today
        
        ' IMPRIMIMOS LOS DATOS POR PANTALLA
        Console.WriteLine(date1)
        Console.WriteLine(date2)
        Console.WriteLine(date3)
        Console.WriteLine(date4)
        Console.WriteLine(date5)
        
        ' OBTENCIÓN DE HORA ACTUAL
        Console.WriteLine("Hora actual: " + Date.Now.ToLongTimeString())
        
        ' OBTENCIÓN DE FECHA ACTUAL
        Dim dt As Date = Date.Today
        Console.WriteLine("Hora actual: {0}", dt)
        
        ' FORMATEAR FECHAS
        Console.WriteLine("Descubrimiento de américa:")
        
        Dim descubrimiento As New Date(1492, 10, 12, 0, 0, 0)
        
        Console.WriteLine("Format 'd:'" & descubrimiento.ToString("d"))
        Console.WriteLine("Format 'D:'" & descubrimiento.ToString("D"))
        Console.WriteLine("Format 't:'" & descubrimiento.ToString("t"))
        Console.WriteLine("Format 'T:'" & descubrimiento.ToString("T"))
        Console.WriteLine("Format 'f:'" & descubrimiento.ToString("f"))
        Console.WriteLine("Format 'F:'" & descubrimiento.ToString("F"))
        Console.WriteLine("Format 'g:'" & descubrimiento.ToString("g"))
        Console.WriteLine("Format 'G:'" & descubrimiento.ToString("G"))
        Console.WriteLine("Format 'M:'" & descubrimiento.ToString("M"))
        Console.WriteLine("Format 'R:'" & descubrimiento.ToString("R"))
        Console.WriteLine("Format 'y:'" & descubrimiento.ToString("y"))
        
    End Sub
End Module
