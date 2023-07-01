Public Class frmFantasy5
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnFantasy5OK_Click(sender As Object, e As EventArgs) Handles btnFantasy5OK.Click
        '5 numbers in array for USER INPUT (0, 1, 2, 3, 4)
        Dim Fantasy5Numbers(4) As Integer
        Dim initialPrize As Double = 20000000 'prize starts at 20 million!


        'user Input
        Fantasy5Numbers(0) = CInt(txt1Fantasy5.Text)
        Fantasy5Numbers(1) = CInt(txt2Fantasy5.Text)
        Fantasy5Numbers(2) = CInt(txt3Fantasy5.Text)
        Fantasy5Numbers(3) = CInt(txt4Fantasy5.Text)
        Fantasy5Numbers(4) = CInt(txt5Fantasy5.Text)


        'variables for LOTTERY GENERATOR (gets random numbers)
        Dim random As New Random()
        Dim jackpot As Double = 50000 * Fantasy5Numbers.Last + initialPrize

        'an array of numbers that are (0 - 42)
        Dim lotteryNum As Int32() = Enumerable.Range(1, 42 + 1).ToArray

        'random shuffle (usually no repeats)
        lotteryNum = lotteryNum.OrderBy(Function(r) random.Next).ToArray

        ' ONLY 5 winning numbers (0, 1, 2, 3, 4) for this drawing:
        Dim winners = lotteryNum.Take(5).ToArray()

        'user can not enter a number that is greater than 42!
        If Fantasy5Numbers.Max > 42 Then
            MessageBox.Show("You can not enter a number higher than 42. Try again")

        Else 'if its not higher than 42, the player can continue to play


            MessageBox.Show("The numbers you entered are: " & Fantasy5Numbers(0) & ", " & Fantasy5Numbers(1) & ", " & Fantasy5Numbers(2) & ", " & Fantasy5Numbers(3) & ", " & Fantasy5Numbers(4))

            'TEST
            'winners(0) = 1
            'winners(1) = 2
            'winners(2) = 3
            'winners(3) = 4
            'winners(4) = 5


            'Tell user if they won the lottery
            If Fantasy5Numbers(0) = winners(0) And Fantasy5Numbers(1) = winners(1) And Fantasy5Numbers(2) = winners(2) And Fantasy5Numbers(3) = winners(3) And Fantasy5Numbers(4) = winners(4) Then
                MessageBox.Show("Congratulations! You have won: $" & jackpot & " jackpot!")

                'this works :)
                GameName = "Fantasy5"
                MessageBox.Show(GameName)
                WinningNumbers = winners(0) & ", " & winners(1) & ", " & winners(2) & ", " & winners(3) & ", " & winners(4)
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
                MessageBox.Show("Sorry, the Winning Numbers are: " & winners(0) & ", " & winners(1) & ", " & winners(2) & ", " & winners(3) & ", " & winners(4))

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

    Private Sub btnQuickpick3_Click(sender As Object, e As EventArgs) Handles btnQuickpick3.Click
        'variables
        Dim random As New Random()

        'there will be only 5 numbers in the array (0, 1, 2, 3)
        Dim randPick(4) As Integer

        'print the array of 5 numbers one by one(loop)
        For i = 0 To 4

            'create random numbers. must be (1 - 42)! '!!!!!!!!!!!!!!!!!
            randPick(i) = random.Next(1, 42 + 1)

        Next

        'Display random numbers for user
        Dim firstNum As Integer = randPick(0)
        Dim secondNum As Integer = randPick(1)
        Dim thirdNum As Integer = randPick(2)
        Dim fourthNum As Integer = randPick(3)
        Dim fifthNum As Integer = randPick(4)

        txt1Fantasy5.Text = firstNum
        txt2Fantasy5.Text = secondNum
        txt3Fantasy5.Text = thirdNum
        txt4Fantasy5.Text = fourthNum
        txt5Fantasy5.Text = fifthNum
    End Sub
End Class