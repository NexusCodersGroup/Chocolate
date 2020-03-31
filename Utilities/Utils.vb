Imports BasicRender

''' <summary>
''' General Utilities for SmokeSignal
''' </summary>
Public Class Utils

    ''' <summary>
    ''' Prints the requested text to the console
    ''' </summary>
    ''' <param name="ConsoleMSG">The message to the console</param>
    ''' <param name="ConsColor">Color u want to do it in</param>
    Public Shared Sub ToConsole(ByVal ConsoleMSG As String, Optional ConsColor As ConsoleColor = ConsoleColor.Gray)
        SetPos(0, 29)
        Dim origColor = Console.ForegroundColor
        Color(ConsColor)
        Console.WriteLine("[" & DateTime.Now.ToString & "] " & ConsoleMSG)
        Color(origColor)
        AddToFile("ViBEServer.log", "[" & DateTime.Now.ToString & "] " & ConsoleMSG)
    End Sub

    ''' <summary>
    ''' Prints the requested text to the console
    ''' </summary>
    ''' <param name="ConsoleMSG">Message</param>
    ''' <param name="Ex">Exception</param>
    Public Shared Sub ErrorToConsole(ByVal ConsoleMSG As String, Ex As Exception)
        SetPos(0, 29)
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("-------------------------------------------------------------------------------")
        Console.ForegroundColor = ConsoleColor.Black
        Console.BackgroundColor = ConsoleColor.Red
        Console.WriteLine("ERROR: " & ConsoleMSG)
        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("-------------------------------------------------------------------------------")
        Console.WriteLine(Ex.StackTrace)
        Console.WriteLine("-------------------------------------------------------------------------------")
        Console.ForegroundColor = ConsoleColor.Gray
    End Sub

    ''' <summary>
    ''' Overwrites the specified file with the specified text
    ''' </summary>
    ''' <param name="path">Path to the File</param>
    ''' <param name="what">Text to overwrite with</param>
    Public Shared Sub ToFile(ByVal path As String, ByVal what As String)
        FileOpen(50, path, OpenMode.Output)
        PrintLine(50, what)
        FileClose(50)
    End Sub

    ''' <summary>
    ''' Appends the specified text to the specified file
    ''' </summary>
    ''' <param name="Path"></param>
    ''' <param name="What"></param>
    Public Shared Sub AddToFile(Path As String, What As String)
        FileOpen(50, Path, OpenMode.Append)
        PrintLine(50, What)
        FileClose(50)
    End Sub

    ''' <summary>
    ''' Returns the first line from a file
    ''' </summary>
    ''' <param name="Path"></param>
    Public Shared Function ReadFromFile(Path As String) As String
        FileOpen(50, Path, OpenMode.Input)
        Dim TheReturn As String = LineInput(50)
        FileClose(50)
        Return TheReturn
    End Function

    Public Shared Sub Spinner(left As Integer, top As Integer)
        Static SpinnerPos As Integer
        If IsNothing(SpinnerPos) Then SpinnerPos = 0

        SetPos(left, top)

        Select Case SpinnerPos
            Case 0
                Echo("|")
            Case 1
                Echo("/")
            Case 2
                Echo("-")
            Case 3
                Echo("\")
                SpinnerPos = -1
        End Select
        SpinnerPos = SpinnerPos + 1

        SetPos(left, top)

    End Sub


End Class
