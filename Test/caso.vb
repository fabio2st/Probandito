Module caso
    Sub main()
        Dim valor As Short
        valor = Console.ReadLine()
        Select Case valor
            Case 1, 5
                Console.WriteLine("es uno")
            Case 2 To 4
                Console.WriteLine("es de 2 a 4")
            Case Is < 0
                Console.WriteLine("es negativo")
        End Select
        Console.ReadKey()
    End Sub
End Module
