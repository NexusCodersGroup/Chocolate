Imports Utils
''' <summary>
''' Dummy extension for demonstration purposes 
''' </summary>
Public Class DummyExtension
    ''Specify that we're implementing SmokeSignalExtension
    Implements SmokeSignalExtension

    ''' <summary>
    ''' The name of the extension
    ''' </summary>
    Public Const EXTENSION_NAME = "Dummy extension"
    Public Const EXTENSION_VERS = "1.0"

    Public Sub New()
        ''Here's where initialization goes.
        ''If your extension requires the use of a settings file, you can read it here, and set the values here.
        ''additionally if you need to setup any arrays or cosas asi, now is the time.
    End Sub

    Public Function Parse(Command As String) As String Implements SmokeSignalExtension.Parse

        ''Here your extension can parse a command, and do what it needs to do.
        If Command = "CONNECTED" Then

            ''Remember to specify your extension has successfully parsed the command, and is doing something.
            ToConsole("Classic Packet, replied.")

            ''Whatever you return from this function will be sent back to the client who sent the command.
            Return "You've connected to the server! Congrats."
        End If

        ''If you return "", the server will assume this extension could not parse the command, and will try to parse it
        ''with another extension
        Return ""
    End Function

    Public Sub Tick() Implements SmokeSignalExtension.Tick
        ''Here's where things that need to occur each second can be done.
    End Sub

    Public Function getName() As String Implements SmokeSignalExtension.getName
        Return EXTENSION_NAME
    End Function

    Public Function getVersion() As String Implements SmokeSignalExtension.getVersion
        Return EXTENSION_VERS
    End Function

End Class
