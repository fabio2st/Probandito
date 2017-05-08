Module fechas
    Sub main()
        Dim fecha As Date
        fecha = #1-5-2017 15:23#
        'fecha = Console.ReadLine()
        'dias = Console.ReadLine
        Console.WriteLine(fecha)
        Console.WriteLine("{0:d}", fecha.Date)
        Console.WriteLine(fecha.TimeOfDay)
        Console.WriteLine(fecha.DayOfWeek)

        fecha = New Date(2017, 2, 10, 4, 12, 26)
        Console.WriteLine(fecha)
        fecha = fecha.AddHours(30)
        Console.WriteLine(fecha)
        Console.WriteLine(fecha.CompareTo(Date.Now))
        fecha = fecha.AddMonths(5)
        Console.WriteLine(fecha)
        Console.WriteLine(fecha.CompareTo(Date.Now))

        Dim dia As DayOfWeek
        dia = CType(3, DayOfWeek)
        Console.WriteLine(dia.ToString)

        Console.ReadKey()

    End Sub
End Module
