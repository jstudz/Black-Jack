<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDeal = New System.Windows.Forms.Button()
        Me.btnHit = New System.Windows.Forms.Button()
        Me.btnStand = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPlayersCards = New System.Windows.Forms.Label()
        Me.lblComputersCards = New System.Windows.Forms.Label()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblComputerScore = New System.Windows.Forms.Label()
        Me.lblPlayerTotal = New System.Windows.Forms.Label()
        Me.lblComputerTotal = New System.Windows.Forms.Label()
        Me.lblCompHoleCard = New System.Windows.Forms.Label()
        Me.lblCompX = New System.Windows.Forms.Label()
        Me.lblPlayersBank = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.lblBet = New System.Windows.Forms.Label()
        Me.txtBoxBet = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDeal
        '
        Me.btnDeal.Location = New System.Drawing.Point(12, 222)
        Me.btnDeal.Name = "btnDeal"
        Me.btnDeal.Size = New System.Drawing.Size(101, 37)
        Me.btnDeal.TabIndex = 0
        Me.btnDeal.Text = "Deal Hand"
        Me.btnDeal.UseVisualStyleBackColor = True
        '
        'btnHit
        '
        Me.btnHit.Enabled = False
        Me.btnHit.Location = New System.Drawing.Point(137, 222)
        Me.btnHit.Name = "btnHit"
        Me.btnHit.Size = New System.Drawing.Size(101, 37)
        Me.btnHit.TabIndex = 1
        Me.btnHit.Text = "Hit"
        Me.btnHit.UseVisualStyleBackColor = True
        '
        'btnStand
        '
        Me.btnStand.Enabled = False
        Me.btnStand.Location = New System.Drawing.Point(264, 222)
        Me.btnStand.Name = "btnStand"
        Me.btnStand.Size = New System.Drawing.Size(101, 37)
        Me.btnStand.TabIndex = 2
        Me.btnStand.Text = "Stand"
        Me.btnStand.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Player's Hand:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Computer's Hand:"
        '
        'lblPlayersCards
        '
        Me.lblPlayersCards.AutoSize = True
        Me.lblPlayersCards.Location = New System.Drawing.Point(23, 46)
        Me.lblPlayersCards.Name = "lblPlayersCards"
        Me.lblPlayersCards.Size = New System.Drawing.Size(17, 17)
        Me.lblPlayersCards.TabIndex = 5
        Me.lblPlayersCards.Text = "X"
        Me.lblPlayersCards.Visible = False
        '
        'lblComputersCards
        '
        Me.lblComputersCards.AutoSize = True
        Me.lblComputersCards.Location = New System.Drawing.Point(63, 126)
        Me.lblComputersCards.Name = "lblComputersCards"
        Me.lblComputersCards.Size = New System.Drawing.Size(17, 17)
        Me.lblComputersCards.TabIndex = 7
        Me.lblComputersCards.Text = "X"
        Me.lblComputersCards.Visible = False
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.Location = New System.Drawing.Point(182, 13)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(79, 17)
        Me.lblPlayerScore.TabIndex = 9
        Me.lblPlayerScore.Text = "Player total"
        '
        'lblComputerScore
        '
        Me.lblComputerScore.AutoSize = True
        Me.lblComputerScore.Location = New System.Drawing.Point(182, 88)
        Me.lblComputerScore.Name = "lblComputerScore"
        Me.lblComputerScore.Size = New System.Drawing.Size(110, 17)
        Me.lblComputerScore.TabIndex = 10
        Me.lblComputerScore.Text = "Computer Score"
        '
        'lblPlayerTotal
        '
        Me.lblPlayerTotal.AutoSize = True
        Me.lblPlayerTotal.Location = New System.Drawing.Point(275, 13)
        Me.lblPlayerTotal.Name = "lblPlayerTotal"
        Me.lblPlayerTotal.Size = New System.Drawing.Size(17, 17)
        Me.lblPlayerTotal.TabIndex = 11
        Me.lblPlayerTotal.Text = "X"
        Me.lblPlayerTotal.Visible = False
        '
        'lblComputerTotal
        '
        Me.lblComputerTotal.AutoSize = True
        Me.lblComputerTotal.Location = New System.Drawing.Point(307, 88)
        Me.lblComputerTotal.Name = "lblComputerTotal"
        Me.lblComputerTotal.Size = New System.Drawing.Size(17, 17)
        Me.lblComputerTotal.TabIndex = 12
        Me.lblComputerTotal.Text = "X"
        Me.lblComputerTotal.Visible = False
        '
        'lblCompHoleCard
        '
        Me.lblCompHoleCard.AutoSize = True
        Me.lblCompHoleCard.Location = New System.Drawing.Point(22, 126)
        Me.lblCompHoleCard.Name = "lblCompHoleCard"
        Me.lblCompHoleCard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompHoleCard.Size = New System.Drawing.Size(17, 17)
        Me.lblCompHoleCard.TabIndex = 13
        Me.lblCompHoleCard.Text = "X"
        Me.lblCompHoleCard.Visible = False
        '
        'lblCompX
        '
        Me.lblCompX.AutoSize = True
        Me.lblCompX.Location = New System.Drawing.Point(23, 126)
        Me.lblCompX.Name = "lblCompX"
        Me.lblCompX.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompX.Size = New System.Drawing.Size(25, 17)
        Me.lblCompX.TabIndex = 14
        Me.lblCompX.Text = " X "
        Me.lblCompX.Visible = False
        '
        'lblPlayersBank
        '
        Me.lblPlayersBank.AutoSize = True
        Me.lblPlayersBank.Location = New System.Drawing.Point(23, 181)
        Me.lblPlayersBank.Name = "lblPlayersBank"
        Me.lblPlayersBank.Size = New System.Drawing.Size(95, 17)
        Me.lblPlayersBank.TabIndex = 15
        Me.lblPlayersBank.Text = "Players Bank:"
        '
        'lblBank
        '
        Me.lblBank.AutoSize = True
        Me.lblBank.Location = New System.Drawing.Point(124, 181)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(17, 17)
        Me.lblBank.TabIndex = 16
        Me.lblBank.Text = "X"
        Me.lblBank.Visible = False
        '
        'lblBet
        '
        Me.lblBet.AutoSize = True
        Me.lblBet.Location = New System.Drawing.Point(182, 181)
        Me.lblBet.Name = "lblBet"
        Me.lblBet.Size = New System.Drawing.Size(29, 17)
        Me.lblBet.TabIndex = 17
        Me.lblBet.Text = "Bet"
        '
        'txtBoxBet
        '
        Me.txtBoxBet.Location = New System.Drawing.Point(224, 181)
        Me.txtBoxBet.Name = "txtBoxBet"
        Me.txtBoxBet.Size = New System.Drawing.Size(100, 22)
        Me.txtBoxBet.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 269)
        Me.Controls.Add(Me.txtBoxBet)
        Me.Controls.Add(Me.lblBet)
        Me.Controls.Add(Me.lblBank)
        Me.Controls.Add(Me.lblPlayersBank)
        Me.Controls.Add(Me.lblCompX)
        Me.Controls.Add(Me.lblCompHoleCard)
        Me.Controls.Add(Me.lblComputerTotal)
        Me.Controls.Add(Me.lblPlayerTotal)
        Me.Controls.Add(Me.lblComputerScore)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblComputersCards)
        Me.Controls.Add(Me.lblPlayersCards)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStand)
        Me.Controls.Add(Me.btnHit)
        Me.Controls.Add(Me.btnDeal)
        Me.Name = "Form1"
        Me.Text = "Black Jack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeal As System.Windows.Forms.Button
    Friend WithEvents btnHit As System.Windows.Forms.Button
    Friend WithEvents btnStand As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPlayersCards As System.Windows.Forms.Label
    Friend WithEvents lblComputersCards As System.Windows.Forms.Label
    Friend WithEvents lblPlayerScore As System.Windows.Forms.Label
    Friend WithEvents lblComputerScore As System.Windows.Forms.Label
    Friend WithEvents lblPlayerTotal As System.Windows.Forms.Label
    Friend WithEvents lblComputerTotal As System.Windows.Forms.Label
    Friend WithEvents lblCompHoleCard As System.Windows.Forms.Label
    Friend WithEvents lblCompX As System.Windows.Forms.Label
    Friend WithEvents lblPlayersBank As System.Windows.Forms.Label
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents lblBet As System.Windows.Forms.Label
    Friend WithEvents txtBoxBet As System.Windows.Forms.TextBox

End Class
