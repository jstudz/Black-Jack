'Holds the value for each hand (computer and user)
Public Class Player
    Dim hand_Total As Integer
    'Sets the hand total to 0 
    Public Sub New()
        hand_Total = 0
    End Sub
    'Encapsulates to a read only file so it can be read by the program but not edited
    Public Property handTotal As Integer
        Get
            Return hand_Total
        End Get
        'Grabs the value from the cards and sets it to the hand total
        Set(ByVal value As Integer)
            hand_Total = value
        End Set
    End Property

End Class
