Public Class Liquor
    Implements IVisitable

    Private preTaxPriceValue As Double
    Public ReadOnly Property preTaxPrice() As Double
        Get
            Return preTaxPriceValue
        End Get
    End Property


    Sub New(preTaxPrice As Double)
        Me.preTaxPriceValue = preTaxPrice
    End Sub

    Public Function accept(visitor As IVisitor) As Double Implements IVisitable.accept
        Return visitor.visit(Me)
    End Function
End Class
