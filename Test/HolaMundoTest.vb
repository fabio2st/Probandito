Imports Entidades

Module HolaMundoTest

    Sub Main()
        Dim _holaMundo As HolaMundo
        _holaMundo = New HolaMundo()
        Dim verdadero As Boolean = True
        Dim falso As Boolean = False
        Console.WriteLine("{0} Xor {1}: " & (False Xor True), falso, verdadero)
        'falto comentar
        Console.ReadKey()

    End Sub

End Module
