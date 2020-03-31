''' <summary>
''' An interface to develop extensions 
''' </summary>
Public Interface SmokeSignalExtension
    ''' <summary>
    ''' Returns the response to the specified parsable command.
    ''' </summary>
    ''' <param name="Command"></param>
    ''' <returns>An actual string if it could parse it, otherwise null</returns>
    Function Parse(Command As String) As String

    ''' <summary>
    ''' Does something the extension should be doing every second
    ''' </summary>
    Sub Tick()

    ''' <summary>
    ''' Returns the name of the extension
    ''' </summary>
    ''' <returns>The name of the extension</returns>
    Function getName() As String

    ''' <summary>
    ''' Returns the version of the extension
    ''' </summary>
    ''' <returns>Version Number as a String</returns>
    Function getVersion() As String



End Interface
