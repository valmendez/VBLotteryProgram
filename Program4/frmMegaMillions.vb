Public Class frmMegaMillions
    Private Sub btnMegaMillionsOK_Click(sender As Object, e As EventArgs) Handles btnMegaMillionsOK.Click
        '6 numbers in array for USER INPUT (0, 1, 2, 3, 4, 5)
        Dim Fantasy5Numbers(4) As Integer 'was 5
        Dim Megaball(0) As Integer 'this will be the last number
        Dim initialPrize As Double = 20000000 'prize starts at 20 million!


        'user Input
        Fantasy5Numbers(0) = CInt(txt1MegaMillions.Text)
        Fantasy5Numbers(1) = CInt(txt2MegaMillions.Text)
        Fantasy5Numbers(2) = CInt(txt3MegaMillions.Text)
        Fantasy5Numbers(3) = CInt(txt4MegaMillions.Text)
        Fantasy5Numbers(4) = CInt(txt5MegaMillions.Text)
        Megaball(0) = CInt(txt6MegaMillions.Text)



        'variables for LOTTERY GENERATOR (gets random numbers)
        Dim random As New Random()
        Dim jackpot As Double = 50000 * Megaball.Last + initialPrize

        'an array of numbers that are (1 - 70)
        Dim lotteryNum As Int32() = Enumerable.Range(1, 70 + 1).ToArray

        'an array of numbers that are (1 - 25)
        Dim MegalotteryNum As Int32() = Enumerable.Range(1, 25 + 1).ToArray

        'random shuffle (usually no repeats)
        lotteryNum = lotteryNum.OrderBy(Function(r) random.Next).ToArray  '!
        MegalotteryNum = MegalotteryNum.OrderBy(Function(r) random.Next).ToArray

        ' The first 5 winning numbers (0, 1, 2, 3, 4) for this drawing:
        Dim winners = lotteryNum.Take(5).ToArray()
        ' The last number will have 1 number (0) for this drawing:
        Dim MegaWinNum = MegalotteryNum.Take(1).ToArray()

        'user can not enter a number that is greater than 70 and Megaball should not be greater than 25!
        If Fantasy5Numbers.Max > 70 And Megaball.Max > 25 Then
            MessageBox.Show("For your first 4 numbers, you can not enter a number higher than 70. For your last number, you can not enter a number higher than 25. Try again")

        Else 'the player can continue to play


            MessageBox.Show("The numbers you entered are: " & Fantasy5Numbers(0) & ", " & Fantasy5Numbers(1) & ", " & Fantasy5Numbers(2) & ", " & Fantasy5Numbers(3) & ", " & Fantasy5Numbers(4) & ", " & Megaball(0))

            'TEST
            'winners(0) = 1
            'winners(1) = 2
            'winners(2) = 3
            'winners(3) = 4
            'winners(4) = 5
            ' MegaWinNum(0) = 6

            'Tell user if they won the lottery
            If Fantasy5Numbers(0) = winners(0) And Fantasy5Numbers(1) = winners(1) And Fantasy5Numbers(2) = winners(2) And Fantasy5Numbers(3) = winners(3) And Fantasy5Numbers(4) = winners(4) And Megaball(0) = MegaWinNum(0) Then
                MessageBox.Show("Congratulations! You have won: $" & jackpot & " jackpot!")

                'this works :)
                GameName = "MegaMillions"
                MessageBox.Show(GameName)
                WinningNumbers = winners(0) & ", " & winners(1) & ", " & winners(2) & ", " & winners(3) & ", " & winners(4) & ", " & MegaWinNum(0)
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
                MessageBox.Show("Sorry, the Winning Numbers are: " & winners(0) & ", " & winners(1) & ", " & winners(2) & ", " & winners(3) & ", " & winners(4) & ", " & MegaWinNum(0))

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

    Private Sub btnQuickpick4_Click(sender As Object, e As EventArgs) Handles btnQuickpick4.Click
        'variables
        Dim random As New Random()

        'there will be only 5 numbers in the array (0, 1, 2, 3, 4)
        Dim randPick(4) As Integer

        'print the array of 3 numbers one by one(loop)
        For i = 0 To 4

            'create random numbers. must be (1 - 70)!
            randPick(i) = random.Next(1, 70 + 1)

        Next


        'there will be only 1 number in the array (0)
        Dim randLastNum(0) As Integer

        'print the array of 1 numbers one by one(loop)
        For i = 0 To 0

            'create random numbers. must be (1 - 25)!
            randLastNum(i) = random.Next(1, 25 + 1)

        Next

        'Display random numbers for user
        Dim firstNum As Integer = randPick(0)
        Dim secondNum As Integer = randPick(1)
        Dim thirdNum As Integer = randPick(2)
        Dim fourthNum As Integer = randPick(3)
        Dim fifthNum As Integer = randPick(4)
        Dim Megaball As Integer = randLastNum(0)

        txt1MegaMillions.Text = firstNum
        txt2MegaMillions.Text = secondNum
        txt3MegaMillions.Text = thirdNum
        txt4MegaMillions.Text = fourthNum
        txt5MegaMillions.Text = fifthNum
        txt6MegaMillions.Text = Megaball
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class