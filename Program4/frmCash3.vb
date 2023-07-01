Public Class frmCash3


    Private Sub btnCash3OK_Click(sender As Object, e As EventArgs) Handles btnCash3OK.Click

        '3 numbers in array for USER INPUT
        Dim cash3Numbers(2) As Integer
        Dim initialPrize As Double = 20000000 'prize starts at 20 million!


        'user Input
        cash3Numbers(0) = CInt(txt1Cash3.Text)
        cash3Numbers(1) = CInt(txt2Cash3.Text)
        cash3Numbers(2) = CInt(txt3Cash3.Text)

        'variables for LOTTERY GENERATOR (gets random numbers)
        Dim random As New Random()
        Dim jackpot As Double = 50000 * cash3Numbers.Last + initialPrize

        'an array of numbers that are (0 - 9)
        Dim lotteryNum As Int32() = Enumerable.Range(0, 9 + 1).ToArray

        'random shuffle (usually no repeats)
        lotteryNum = lotteryNum.OrderBy(Function(r) random.Next).ToArray    '!!!!!!!!!!!

        ' ONLY 3 winning numbers (0, 1, 3) for this drawing:
        Dim winners = lotteryNum.Take(3).ToArray()

        'user can not enter a number that is greater than 9!
        If cash3Numbers.Max > 9 Then
            MessageBox.Show("You can not enter a number higher than 9. Try again")

        Else 'if its not higher than 9, the player can continue to play


            MessageBox.Show("The numbers you entered are: " & cash3Numbers(0) & ", " & cash3Numbers(1) & ", " & cash3Numbers(2))

            'TEST
            'winners(0) = 1
            'winners(1) = 2
            'winners(2) = 3

            'MessageBox.Show("the winning numbers are: " & winners(0) & ", " & winners(1) & ", " & winners(2))

            'Tell user if they won the lottery
            If cash3Numbers(0) = winners(0) And cash3Numbers(1) = winners(1) And cash3Numbers(2) = winners(2) Then
                MessageBox.Show("Congratulations! You have won: $" & jackpot & " jackpot!")

                'this works :)
                GameName = "Cash3"
                MessageBox.Show(GameName)
                WinningNumbers = winners(0) & ", " & winners(1) & ", " & winners(2)
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
                MessageBox.Show("Sorry, the Winning Numbers are: " & winners(0) & ", " & winners(1) & ", " & winners(2))

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

    Private Sub btnQuickpick_Click(sender As Object, e As EventArgs) Handles btnQuickpick.Click
        'variables
        Dim random As New Random()

        'there will be only 3 numbers in the array (0, 1, 2)
        Dim randPick(2) As Integer

        'print the array of 3 numbers one by one(loop)
        For i = 0 To 2

            'create random numbers. must be (0 - 9)!
            randPick(i) = random.Next(0, 9 + 1)

        Next

        'Display random numbers for user
        Dim fNum As Integer = randPick(0)
        Dim sNum As Integer = randPick(1)
        Dim tNum As Integer = randPick(2)
        txt1Cash3.Text = fNum
        txt2Cash3.Text = sNum
        txt3Cash3.Text = tNum

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class