'Isabella Dougherty
'RCET0265
'Spring 2023
'Accumulate Messages
'https://github.com/IsabellaDougherty/AccumulateMessages.git

Imports System

Module MessageProgram
    Sub Main(args As String())
        'Test.Manual()
        Test.Auto()
    End Sub

    'Clears the messages if needed, does nothing if the string is blank, and adds the new message to a new line of code if it is valid
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
