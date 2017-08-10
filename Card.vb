
Public Class Card
    Dim _suit As String
    Dim _name As String
    Dim _Value As Integer

    Public Sub New()
        _suit = String.Empty
        _name = String.Empty
        _Value = 0
    End Sub
    'Passing the suit, name and value into the Card class from the deck
    Public Sub New(ByVal suit As String, ByVal name As String, ByVal value As Integer)
        _suit = suit
        _name = name
        _Value = value
    End Sub
    'Encapsulates to a read only file so it can be read by the program but not edited
    Public ReadOnly Property CardSuitAndName As String
        Get
            'Puts the name and the suit together
            Return String.Concat(_name, _suit)
        End Get
    End Property
    'Encapsulates to a read only file so it can be read by the program but not edited
    Public ReadOnly Property cardBlackjackValue As Integer
        Get
            Return _Value
        End Get
    End Property
End Class

