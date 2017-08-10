Public Class Form1
    'Public variables using the various classes defined
    Dim deck As Deck
    Dim player As New Player
    Dim computer As New Player
    Dim playersBank As Integer = 1000
    Dim bet As Integer

    Private Sub btnDeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeal.Click
        'Each time you hit "DEAL", a new deck of cards is made. We use one deck
        Dim card As New Card
        deck = New Deck

        bet = txtBoxBet.Text
        txtBoxBet.ReadOnly = True

        'Checks to see if the player bet less than 0 or more than the player's bank
        If bet < 1 Or bet > playersBank Then
            MsgBox("Invaild bet. Please enter a number greater than 0 and less than your Bank")
            txtBoxBet.ReadOnly = False
        Else
            'Dealing the first set of cards to the computer and player
            lblPlayersCards.Visible = True
            lblPlayerTotal.Visible = True

            'Players hand
            card = getCard(deck)
            lblPlayersCards.Text = card.CardSuitAndName
            player.handTotal = card.cardBlackjackValue
            card = getCard(deck)
            lblPlayersCards.Text += String.Concat(" / ", card.CardSuitAndName)
            player.handTotal += card.cardBlackjackValue
            lblPlayerTotal.Text = player.handTotal

            lblComputersCards.Visible = True
            lblCompX.Visible = True
            lblComputerTotal.Visible = False

            'Computers Hand, there is a label hiding one hole card of the computer
            card = getCard(deck)
            lblCompHoleCard.Text = card.CardSuitAndName & " / "
            computer.handTotal = card.cardBlackjackValue
            card = getCard(deck)
            lblComputersCards.Text = card.CardSuitAndName
            computer.handTotal += card.cardBlackjackValue
            lblComputerTotal.Text = computer.handTotal

            btnHit.Enabled = True
            btnStand.Enabled = True
            btnDeal.Enabled = False

            'Checks to see if player, computer, or both got a black jack
            If player.handTotal = 21 And computer.handTotal = 21 Then
                playersBank = playersBank
                lblBank.Text = playersBank
                lblComputerTotal.Visible = True
                lblCompHoleCard.Visible = True
                lblCompX.Visible = False
                MsgBox("Both got Black Jack. Push!")
                btnDeal.Enabled = True
                btnHit.Enabled = False
                btnStand.Enabled = False
            ElseIf player.handTotal = 21 Then
                playersBank = playersBank + (bet * 2)
                lblBank.Text = playersBank
                lblCompHoleCard.Visible = True
                lblCompX.Visible = False
                MsgBox("Black Jack! You win")
                btnDeal.Enabled = True
                btnHit.Enabled = False
                btnStand.Enabled = False
            ElseIf computer.handTotal = 21 Then
                playersBank = playersBank - bet
                lblBank.Text = playersBank
                lblCompHoleCard.Visible = True
                lblCompX.Visible = False
                MsgBox("Computer got Black Jack! You lose")
                btnDeal.Enabled = True
                btnHit.Enabled = False
                btnStand.Enabled = False
            End If
        End If
       

    End Sub
    'Subroutine to pull a card randomly from the deck class
    Private Function getCard(ByRef deck As Deck) As Card
        'Declare the random number variable to pull a random card from the Deck
        Dim randomCard As Random = New Random

        'Pulls a card randomly from the Deck Class
        Dim card As New Card
        card = deck.Cards(randomCard.Next(deck.numOfCardsInDeck))

        'Removes the card after from the deck after using it.
        deck.Cards.Remove(card)
        Return card
    End Function


    Private Sub btnHit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHit.Click
        Dim card As New Card

        'Grabs a new cards from the decks and adds it to the players hand
        card = getCard(deck)
        lblPlayersCards.Text += String.Concat(" / ", card.CardSuitAndName)
        player.handTotal += card.cardBlackjackValue
        lblPlayerTotal.Text = player.handTotal

        'Checks to see if the player busted
        If player.handTotal > 21 Then
            playersBank = playersBank - bet
            lblBank.Text = playersBank
            lblCompX.Visible = False
            lblComputerTotal.Visible = True
            lblCompHoleCard.Visible = True
            MsgBox("You bust")
            btnDeal.Enabled = True
            btnHit.Enabled = False
            btnStand.Enabled = False
        End If
    End Sub

    Private Sub btnStand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStand.Click
        Dim card As New Card

        'Reveals the computer's hole card
        lblCompX.Visible = False
        lblCompHoleCard.Visible = True
        lblComputerTotal.Visible = True

        'The computer will hit while their hand is less than 17
        While computer.handTotal < 17
            card = getCard(deck)
            lblComputersCards.Text += String.Concat(" / ", card.CardSuitAndName)
            computer.handTotal += card.cardBlackjackValue
            lblComputerTotal.Text = computer.handTotal
        End While

        'After the dealer stands (17 or higher), the program will check to see who wins
        If computer.handTotal > 21 Then
            playersBank = playersBank + bet
            lblBank.Text = playersBank
            MsgBox("Computer busted! You win")
        ElseIf computer.handTotal = player.handTotal Then
            playersBank = playersBank
            lblBank.Text = playersBank
            MsgBox("Push!")
        ElseIf computer.handTotal > player.handTotal Then
            playersBank = playersBank - bet
            lblBank.Text = playersBank
            MsgBox("Computer wins")
        Else
            playersBank = playersBank + bet
            lblBank.Text = playersBank
            MsgBox("You win!")
        End If

        'Hit deal for new game, resets all the buttons and bet box
        btnHit.Enabled = False
        btnStand.Enabled = False
        btnDeal.Enabled = True
        txtBoxBet.ReadOnly = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblBank.Text = playersBank
        lblBank.Visible = True
    End Sub
End Class
