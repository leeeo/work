'Imports System.Threading
'Imports System.Threading.Thread


Public Class testThread

    Dim cThread As clsThread
 
    Dim maxNumber As Integer = 100
    Dim numOfProgress As Integer = 0
    Dim N As Integer
    Dim nChoose As Integer

    Dim newProgressBar As ProgressBar
    Dim newGoStopBox As Button

    Private Sub testThread_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckForIllegalCrossThreadCalls = False

        N = 0
        Me.txtProgNum.Text = 0

        CheckNumber(N)

    End Sub

    Private Sub CheckNumber(temp)

        Dim i As Integer

        N = Val(Me.txtProgNum.Text)

        If N = 0 Then Exit Sub

        For i = temp To N
            Me.Controls.Remove(myProgressBar(i))
            myProgressBar(i) = Nothing
            Me.Controls.Remove(myGoStopBox(i))
            myGoStopBox(i) = Nothing
        Next

        For i = temp To N
            newProgressBar = New ProgressBar
            newProgressBar.Location = New System.Drawing.Point(15, 25 + 45 * i)
            newProgressBar.Size = New System.Drawing.Size(180, 25)
            newProgressBar.Text = "123123"
            newProgressBar.Tag = "myProgressBar" & i.ToString
            newProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

            Me.Controls.Add(newProgressBar)
            myProgressBar(i) = CType(newProgressBar, ProgressBar)
        Next

        For i = temp To N
            newGoStopBox = New Button
            newGoStopBox.Location = New System.Drawing.Point(200, 25 + 45 * i)
            newGoStopBox.Size = New System.Drawing.Size(60, 25)
            newGoStopBox.Text = "Go/Stop"
            newGoStopBox.Tag = "myGoStopBox" & i.ToString
            newGoStopBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

            Me.Controls.Add(newGoStopBox)
            AddHandler newGoStopBox.Click, AddressOf Me.btnGoStop_Click
            myGoStopBox(i) = CType(newGoStopBox, Button)
        Next

        Me.Height = 100 + 45 * (i - 1)

    End Sub

    Private Sub DeleteNumber(temp)

        Dim i As Integer

        N = Val(Me.txtProgNum.Text)

        If N = 0 Then Exit Sub

        For i = temp To N
            Me.Controls.Remove(myProgressBar(i))
            myProgressBar(i) = Nothing
            Me.Controls.Remove(myGoStopBox(i))
            myGoStopBox(i) = Nothing
        Next

        Me.Height = 100 + 45 * (i - 1 - 1)

    End Sub

    Private Sub btnGoStop_Click(sender As Object, e As EventArgs) Handles btnGoStop.Click

        Dim temp As Integer = sender.Bottom / 45 - 1

        If myState(temp) = False Then
            myState(temp) = True
            cThread = New clsThread(Me)
            cThread.goProgressBar(temp)
        Else
            myState(temp) = False
        End If

    End Sub

    Private Function displayProg(numOfProgress)

        If numOfProgress < 1 Or numOfProgress > 100 Then
            MsgBox("0~100까지의 숫자를 선택하세요.")
            If numOfProgress < 0 Then
                numOfProgress = 0
                Me.txtProgNum.Text = 0
            End If
            If numOfProgress > 100 Then
                numOfProgress = 100
                Me.txtProgNum.Text = 100
            End If
            Return False
        End If

        Return True
    End Function

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        Dim temp As Integer = Val(txtProgNum.Text)

        txtProgNum.Text = txtProgNum.Text + 1
        temp = txtProgNum.Text
        myState(temp) = 0
        displayProg(temp)
        CheckNumber(temp)

    End Sub

    Private Function btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click

        Dim temp As Integer = Val(txtProgNum.Text)

        If displayProg(temp) = False Then Return False

        If myState(temp) = 0 Then
            DeleteNumber(temp)
            txtProgNum.Text = temp - 1
        Else
            myState(temp) = 0
            cThread.stopProgressBar(temp)
            DeleteNumber(temp)
            txtProgNum.Text = temp - 1
        End If

        Return True
    End Function

End Class