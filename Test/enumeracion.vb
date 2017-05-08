Module enumeracion
    Enum tamaños
        S
        L
        XL
    End Enum

    Sub main()
        Dim valor As UShort
        Dim resultado As tamaños
        valor = Console.ReadLine()
        resultado = CType(valor, tamaños)
        Console.WriteLine(resultado.ToString)
        Console.ReadKey()
    End Sub
End Module
