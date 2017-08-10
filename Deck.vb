Public Class Deck
    '_cards as List(of Card) is building an array of the cards with a suit, name and value to it.
    Dim _cards As New List(Of Card)
    Dim _numOfCardsInDeck As Integer
    'Creates each card and places it in the deck
    Public Sub New()
        Dim suit As String
        Dim name As String
        Dim value As Integer

        'Builds the array for each card giving them a suit
        For i As Integer = 1 To 4
            Select Case i
                Case 1 : suit = "H"
                Case 2 : suit = "D"
                Case 3 : suit = "S"
                Case 4 : suit = "C"
                    'Exception ensures that the program does not crash while creating the new deck
                Case Else : Throw New Exception("Error creating deck")
            End Select

            'Gives the name and value to each of the cards and suits
            For j As Integer = 1 To 13
                Select Case j
                    Case 1
                        name = "A"
                        value = 11
                    Case 11
                        name = "J"
                        value = 10
                    Case 12
                        name = "Q"
                        value = 10
                    Case 13
                        name = "K"
                        value = 10
                    Case Else
                        name = j.ToString
                        value = j
                End Select

                'Adds the card into the _card list at the end of the array
                Dim card As New Card(suit, name, value)
                _cards.Add(card)
            Next
        Next
    End Sub
    'Encapsulates to a read only file so it can be read by the program but not edited
    Public ReadOnly Property Cards As List(Of Card)
        Get
            Return _cards
        End Get
    End Property
    'Encapsulates to a read only file so it can be read by the program but not edited
    Public ReadOnly Property numOfCardsInDeck As Integer
        Get
            Return _cards.Count
        End Get
    End Property
End Class
