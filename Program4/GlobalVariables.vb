Module GlobalVariables

    'textfile important variables
    Public GameName As String
    Public WinningNumbers As String
    Public WinAmount As Double
    Public WinDate As String

    Public previousWinFile As String = "Program6.txt"
    Public jackpotFile As String = "Program6Pot.txt"
    Public previousJackpot As Double
    Public fileNum As Integer = FreeFile() 'use this instead of using a file number for different files

End Module
