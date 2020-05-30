<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_loading
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pgr_1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_loading = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pgr_1
        '
        Me.pgr_1.Location = New System.Drawing.Point(36, 98)
        Me.pgr_1.Name = "pgr_1"
        Me.pgr_1.Size = New System.Drawing.Size(877, 49)
        Me.pgr_1.TabIndex = 0
        '
        'lbl_loading
        '
        Me.lbl_loading.AutoSize = True
        Me.lbl_loading.Location = New System.Drawing.Point(459, 41)
        Me.lbl_loading.Name = "lbl_loading"
        Me.lbl_loading.Size = New System.Drawing.Size(59, 17)
        Me.lbl_loading.TabIndex = 1
        Me.lbl_loading.Text = "Loading"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        '
        'frm_loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 198)
        Me.Controls.Add(Me.lbl_loading)
        Me.Controls.Add(Me.pgr_1)
        Me.Name = "frm_loading"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pgr_1 As ProgressBar
    Friend WithEvents lbl_loading As Label
    Friend WithEvents Timer As Timer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        pgr_1.Increment(1)
        If pgr_1.Value = 100 Then
            frm_admin.Show()
            Me.Hide()
        End If
    End Sub
End Class
