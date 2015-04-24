Imports System
Imports System.Threading

Public Class clsThread
    Dim num As Integer
    Dim gNum As Integer

    Dim thd() As Thread

    'Dim thd As New Thread(AddressOf ThreadProcRun)

    'Dim bState As Boolean = True

    Protected frm As testThread

    Public Sub New(form As Form)
        frm = form
    End Sub

    Public Shared Sub main()

    End Sub

    Public Sub goProgressBar(ByVal num As Integer)

        gNum = num

        ReDim Preserve thd(gNum)

        thd(gNum) = New Thread(AddressOf ThreadProcRun)
        thd(gNum).Start()

    End Sub

    Public Sub stopProgressBar(ByVal num As Integer)

        gNum = num

        'myState(num) = 0
        'thd(num).Abort()
        myRunState(gNum) = False
        If Not thd(gNum) Is Nothing Then thd(gNum).Abort()
        thd(gNum) = Nothing

    End Sub

    Public Sub ThreadProcRun()
        'gNum = num

        myState(gNum) = 1
        'myRunState(gNum) = True
        myRunState(gNum) = True

        While (myState(gNum))
            If myProgressBar(gNum).Value >= 100 Then
                myState(gNum) = -1
            ElseIf myProgressBar(gNum).Value <= 1 Then
                myState(gNum) = 1
            End If

            myProgressBar(gNum).Value = myProgressBar(gNum).Value + myState(gNum)

            Thread.Sleep(100)

            'If frm.barProgress.Value >= 100 Then
            '    myState(gNum) = -1
            'ElseIf frm.barProgress.Value <= 1 Then
            '    myState(gNum) = 1
            'End If

            'frm.barProgress.Value = frm.barProgress.Value + myState(gNum)

        End While
    End Sub

End Class
