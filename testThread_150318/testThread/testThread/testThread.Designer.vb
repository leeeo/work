<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testThread
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtProgNum = New System.Windows.Forms.TextBox()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.barProgress = New System.Windows.Forms.ProgressBar()
        Me.btnGoStop = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'txtProgNum
        '
        Me.txtProgNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtProgNum.Location = New System.Drawing.Point(15, 25)
        Me.txtProgNum.Name = "txtProgNum"
        Me.txtProgNum.Size = New System.Drawing.Size(64, 21)
        Me.txtProgNum.TabIndex = 3
        Me.txtProgNum.Text = "0"
        '
        'btnMinus
        '
        Me.btnMinus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMinus.Location = New System.Drawing.Point(190, 25)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(75, 23)
        Me.btnMinus.TabIndex = 13
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = true
        '
        'btnPlus
        '
        Me.btnPlus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnPlus.Location = New System.Drawing.Point(100, 25)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(75, 23)
        Me.btnPlus.TabIndex = 12
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = true
        '
        'barProgress
        '
        Me.barProgress.Location = New System.Drawing.Point(15, 120)
        Me.barProgress.Name = "barProgress"
        Me.barProgress.Size = New System.Drawing.Size(180, 25)
        Me.barProgress.TabIndex = 21
        Me.barProgress.Visible = false
        '
        'btnGoStop
        '
        Me.btnGoStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnGoStop.Location = New System.Drawing.Point(200, 120)
        Me.btnGoStop.Name = "btnGoStop"
        Me.btnGoStop.Size = New System.Drawing.Size(60, 25)
        Me.btnGoStop.TabIndex = 22
        Me.btnGoStop.Text = "Go/Stop"
        Me.btnGoStop.UseVisualStyleBackColor = true
        Me.btnGoStop.Visible = false
        '
        'testThread
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 12!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 64)
        Me.Controls.Add(Me.btnGoStop)
        Me.Controls.Add(Me.barProgress)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtProgNum)
        Me.Name = "testThread"
        Me.Text = "testThread"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txtProgNum As System.Windows.Forms.TextBox
    Friend WithEvents btnMinus As System.Windows.Forms.Button
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents barProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents btnGoStop As System.Windows.Forms.Button

End Class
