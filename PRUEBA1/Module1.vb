Module Module1

    Sub Main()
        Console.WriteLine("**MENU DE OPERACIONES**")
        Console.WriteLine("Digite el numero correspondiente a la operacion que quieras ejecutar")
        Console.WriteLine("1. Suma")
        Console.WriteLine("2. Resta")
        Console.WriteLine("3. Multiplicar")
        Console.WriteLine("4. Dividir")
        Console.WriteLine("5. Porcentaje")
        Dim opcion As Integer = Console.ReadLine()

        Dim numero1, numero2 As Double

        Select Case opcion
            Case 1
                Console.WriteLine("Ingrese el primer numero a sumar: ")
                numero1 = Console.ReadLine()
                Console.WriteLine("Ingrese el sgundo numero a sumar: ")
                numero2 = Console.ReadLine()
                Console.WriteLine("La suma de los numeros es: " & (numero1 + numero2))
            Case 2
                Console.WriteLine("Ingrese el primer numero a restar: ")
                numero1 = Console.ReadLine()
                Console.WriteLine("Ingrese el sgundo numero a restar: ")
                numero2 = Console.ReadLine()
                Console.WriteLine("La suma de los numeros es: " & (numero1 - numero2))
            Case 3
                Console.WriteLine("Ingrese el primer numero a multiplicar: ")
                numero1 = Console.ReadLine()
                Console.WriteLine("Ingrese el sgundo numero a multiplicar: ")
                numero2 = Console.ReadLine()
                Console.WriteLine("La suma de los numeros es: " & (numero1 * numero2))
            Case 4
                Console.WriteLine("Ingrese el primer numero a dividir: ")
                numero1 = Console.ReadLine()
                Console.WriteLine("Ingrese el sgundo numero a dividir: ")
                numero2 = Console.ReadLine()
                Console.WriteLine("La suma de los numeros es: " & (numero1 / numero2))
            Case 5
                Console.WriteLine("Ingrese el primer numero a sacar el porcentaje: ")
                numero1 = Console.ReadLine()
                Console.WriteLine("Ingrese el porcentaje: ")
                numero2 = Console.ReadLine()
                Console.WriteLine("El " & numero2 & "% de: " & numero1 & " es: " & (numero1 * numero2) / 100)
            Case Else
                Console.WriteLine("La opcion ingresada no es valida")
        End Select


    End Sub

End Module