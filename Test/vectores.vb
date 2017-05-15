Module vectores
    Sub main()
        Dim numbers = New Integer() {1, 2, 4, 8}
        For x = 0 To numbers.Length - 1
            numbers(x) = numbers(x) * 2
        Next
        For Each number As Integer In numbers
            Console.WriteLine(number)
        Next

        Dim matrix = New Integer(5, 3) {{1, 2, 9}, {3, 4}, {5, 6}, {7, 8}}

        For x = 0 To matrix.GetLength(0) - 1
            For y = 0 To matrix.Rank - 1
                Console.WriteLine(matrix(x, y))
            Next
        Next

        For y = 0 To matrix.Rank - 1
            For x = 0 To matrix.GetLength(1) - 1
                Console.WriteLine(matrix(x, y))
            Next
        Next

        For Each number As Integer In matrix
            Console.WriteLine(number)
        Next

        Console.ReadKey()

    End Sub
End Module
