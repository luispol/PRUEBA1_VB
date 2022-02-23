Module Module1

    Sub Main()
        Dim estudia As Boolean = False

        Console.Write("Ingrese el dinero ahorrado: ")
        Console.WriteLine("Esto es un pequeno cambio")
        Dim dineroAhorrado As Double = Console.ReadLine()

        If dineroAhorrado >= 600 Then
            estudia = True
        End If

        If estudia = True Then
            Console.WriteLine("El dinero ahorrado sirve para pagar la universidad")
        Else
            Console.WriteLine("El dinero no sirve para pagar la universidad")
        End If


    End Sub

End Module