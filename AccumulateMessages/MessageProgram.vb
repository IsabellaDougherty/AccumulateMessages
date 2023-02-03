
Imports System

Module MessageProgram
    Sub Main(args As String())
        'Test.Manual()
        Test.Auto()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static message As String
        If clear Then
            message = ""
        ElseIf ((newMessage.Length < 1)) Then

        Else
            message += newMessage + "
"
        End If
        Return message
    End Function


End Module
