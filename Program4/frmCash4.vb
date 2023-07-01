Public Class frmCash4
    Private Sub btnCash4OK_Click(sender As Object, e As EventArgs) Handles btnCash4OK.Click

        '4 numbers in array for USER INPUT
        Dim cash4Numbers(3) As Integer
        Dim initialPrize As Double = 20000000 'prize starts at 20 million!


        'user Input
        cash4Numbers(0) = CInt(txt1Cash4.Text)
        cash4Numbers(1) = CInt(txt2Cash4.Text)
        cash4Numbers(2) = CInt(txt3Cash4.Text)
        cash4Numbers(3) = CInt(txt4Cash4.Text)

        'variables for LOTTERY GENERATOR (gets random numbers)
        Dim random As New Random()
        Dim jackpot As Double = 50000 * cash4Numbers.Last + initialPrize

        'an array of numbers that are (0 - 9)
        Dim lotteryNum As Int32() = Enumerable.Range(0, 9 + 1).ToArray

        'random shuffle (usually no repeats)
        lotteryNum = lotteryNum.OrderBy(Function(r) random.Next).ToArray '!

        ' ONLY 4 winning numbers (0, 1, 2, 3) for this drawing:
        Dim winners = lotteryNum.Take(4).ToArray()

        'user can not enter a number that is greater than 9!
        If cash4Numbers.Max > 9 Then
            MessageBox.Show("You can not enter a number higher than 9. Try again")

        Else 'if its not higher than 9, the player can continue to play


            MessageBox.Show("The numbers you entered are: " & cash4Numbers(0) & ", " & cash4Numbers(1) & ", " & cash4Numbers(2) & ", " & cash4Numbers(3))

            'TEST
            winners(0) = 1
            winners(1) = 2
            winners(2) = 3
            winners(3) = 4

            'MessageBox.Show("the winning numbers are: " & winners(0) & ", " & winners(1) & ", " & winners(2) & ", " & winners(3))

            'Tell user if they won the lottery
            If cash4Numbers(0) = winners(0) And cash4Numbers(1) = winners(1) And cash4Numbers(2) = winners(2) And cash4Numbers(3) = winners(3) Then
                MessageBox.Show("Congratulations! You have won: $" & jackpot & " jackpot!")

                'this works :)
                GameName = "Cash4"
                MessageBox.Show(GameName)
                WinningNumbers = winners(0) & ", " & winners(1) & ", " & winners(2) & ", " & winners(3)
                MessageBox.Show(WinningNumbers)
                WinAmount = jackpot
                MessageBox.Show(jackpot)
                Dim Month As Integer = Date.Today.Month
                Dim Day As Integer = Date.Today.Day
                Dim Year As Integer = Date.Today.Year
                WinDate = Month & "/" & Day & "/" & Year
                MessageBox.Show(WinDate)

                'save all previous wins to the textfile (program6.txt)
                FileOpen(fileNum, previousWinFile, OpenMode.Append)
                PrintLine(fileNum, GameName, WinningNumbers, WinAmount, WinDate)
                FileClose(fileNum)


                'If the jackpot is hit, the prize should be RESET to the initial prize of 20 million...
                jackpot = 0
                FileOpen(fileNum, jackpotFile, OpenMode.Append)
                PrintLine(fileNum, jackpot)
                FileClose(fileNum)


            Else
                MessageBox.Show("Sorry, the Winning Numbers are: " & winners(0) & ", " & winners(1) & ", " & winners(2) & ", " & winners(3))

                'Until a win occurs you should add to the jackpot(50,000 * the last number Of the drawing + Initial jackpot)
                FileOpen(fileNum, jackpotFile, OpenMode.Input)
                'read file
                While Not EOF(fileNum)
                    previousJackpot = Val(LineInput(fileNum))
                End While
                FileClose(fileNum)

                'add the previous jackpot amount to the current jackpot amount
                jackpot += previousJackpot

                'save the new jackpot amount to the file
                FileOpen(fileNum, jackpotFile, OpenMode.Append)
                PrintLine(fileNum, jackpot)
                FileClose(fileNum)

                MessageBox.Show("the current jackpot is: " & jackpot)


            End If

        End If
    End Sub

    Private Sub btnQuickpick2_Click(sender As Object, e As EventArgs) Handles btnQuickpick2.Click
        'variables
        Dim random As New Random()

        'there will be only 4 numbers in the array (0, 1, 2, 3)
        Dim randPick(3) As Integer

        'print the array of 4 numbers one by one(loop)
        For i = 0 To 3

            'create random numbers. must be (0 - 9)!
            randPick(i) = random.Next(0, 9 + 1)

        Next

        'Display random numbers for user
        Dim firstNum As Integer = randPick(0)
        Dim secondNum As Integer = randPick(1)
        Dim thirdNum As Integer = randPick(2)
        Dim fourthNum As Integer = randPick(3)

        txt1Cash4.Text = firstNum
        txt2Cash4.Text = secondNum
        txt3Cash4.Text = thirdNum
        txt4Cash4.Text = fourthNum

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class