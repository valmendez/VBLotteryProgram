Imports System.Collections.Concurrent
Imports System.Drawing.Text
Imports System.Globalization
Imports System.IO

Public Class frmVerification1

    'textfile important variables
    Public GameName As String
    Public WinningNumbers As String
    Public WinAmount As Double
    Public WinDate As String
    Public previousWinFile As String = "Program6.txt"
    Public jackpotFile As String = "Program6Pot.txt"
    Public previousJackpot As Double
    Public fileNum As Integer = FreeFile() 'use this instead of using a file number for different files


    Private Sub btnAge_Click(sender As Object, e As EventArgs) Handles btnAge.Click

        'variables
        Dim currentDate As Integer
        Dim DateofBirth As Integer
        Dim Age As Integer

        'calculate age of user
        currentDate = Date.Today.Year
        DateofBirth = DateTimePicker1.Value.Year
        Age = currentDate - DateofBirth
        MessageBox.Show("Your age is: " & Age)

        'If user is 18 years old or older, they will be allowed to play
        If Age >= 18 Then
            frmPreviousWins.Show()
            Me.Hide()
        Else
            MessageBox.Show("Sorry, You are not old enough to play")
        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
