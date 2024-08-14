<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnStartStop = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtRequests = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnStartStop
        '
        Me.btnStartStop.Location = New System.Drawing.Point(39, 38)
        Me.btnStartStop.Name = "btnStartStop"
        Me.btnStartStop.Size = New System.Drawing.Size(106, 43)
        Me.btnStartStop.TabIndex = 0
        Me.btnStartStop.Text = "Start"
        Me.btnStartStop.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(709, 38)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 43)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtRequests
        '
        Me.txtRequests.Location = New System.Drawing.Point(39, 113)
        Me.txtRequests.Multiline = True
        Me.txtRequests.Name = "txtRequests"
        Me.txtRequests.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRequests.Size = New System.Drawing.Size(776, 919)
        Me.txtRequests.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 1064)
        Me.Controls.Add(Me.txtRequests)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStartStop)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStartStop As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtRequests As TextBox
End Class
