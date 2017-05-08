Module metodos
    Enum operaciones
        suma
        resta
        multiplicacion
        division
    End Enum

    Sub main()
        Console.WriteLine(calcular(10, 5))
        Console.WriteLine(calcular(operaciones.suma, 10, 5))
        Console.WriteLine(calcular(operaciones.suma, 10, 5, 3))
        Console.ReadKey()
    End Sub

    Private Function calcular(x As Single, y As Single) As Double
        Return calcular(operaciones.suma, x, y)
    End Function

    Private Function calcular(operacion As operaciones, x As Single, y As Single) As Double
        Select Case operacion
            Case operaciones.suma
                Return x + y
        End Select

    End Function

    Private Function calcular(operacion As operaciones, x As Single, y As Single, z As Single) As Double
        Return calcular(operacion, calcular(operacion, x, y), z)
    End Function
End Module
