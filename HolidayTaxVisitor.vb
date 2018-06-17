Public Class HolidayTaxVisitor
    Implements IVisitor

    Public Function visit(liquor As Liquor) As Double Implements IVisitor.visit
        Return liquor.preTaxPrice * (1 + 0.2)
    End Function

    Public Function visit(necessity As Necessity) As Double Implements IVisitor.visit
        Return necessity.preTaxPrice * (1 + 0.1)
    End Function

    Public Function visit(tobacco As Tobbaco) As Double Implements IVisitor.visit
        Return tobacco.preTaxPrice * (1 + 0.4)
    End Function
End Class
