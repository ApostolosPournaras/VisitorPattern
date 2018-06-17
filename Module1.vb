Module Module1

    Sub Main()

        Dim taxVisitor As New TaxVisitor
        Dim holidayTaxVisitor As New HolidayTaxVisitor

        Dim milk As New Necessity(0.87)
        Dim vodka As New Liquor(9.8)
        Dim cigar As New Tobbaco(12.1)

        Console.WriteLine("--------- Prices with normal taxes ---------")
        Console.WriteLine("Milk: " & taxVisitor.visit(milk))
        Console.WriteLine("Vodka: " & taxVisitor.visit(vodka))
        Console.WriteLine("Cigar: " & taxVisitor.visit(cigar))

        Console.WriteLine("--------- Prices with holiday taxes ---------")
        Console.WriteLine("Milk: " & holidayTaxVisitor.visit(milk))
        Console.WriteLine("Vodka: " & holidayTaxVisitor.visit(vodka))
        Console.WriteLine("Cigar: " & holidayTaxVisitor.visit(cigar))

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop
    End Sub

End Module
