Public Class frmPreviousWins
    Private Sub btnPreviousWins_Click(sender As Object, e As EventArgs) Handles btnPreviousWins.Click
        'after the user sees the previous wins, they will be able to select what game to play
        frmSelection2.Show()
        Me.Hide()

    End Sub

    Private Sub btnShowData_Click(sender As Object, e As EventArgs) Handles btnShowData.Click
        'Show Data for user on list box
        Dim ShowData As String
        FileOpen(fileNum, previousWinFile, OpenMode.Input)
        lstWins.Items.Clear()
        While Not EOF(fileNum)
            ShowData = LineInput(fileNum)
            lstWins.Items.Add(ShowData)
        End While
        FileClose(fileNum)

    End Sub
End Class