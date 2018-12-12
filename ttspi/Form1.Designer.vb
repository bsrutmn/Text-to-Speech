<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.mediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.spkbtn = New System.Windows.Forms.Button()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.mediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mediaPlayer
        '
        Me.mediaPlayer.Enabled = True
        Me.mediaPlayer.Location = New System.Drawing.Point(12, 254)
        Me.mediaPlayer.Name = "mediaPlayer"
        Me.mediaPlayer.OcxState = CType(resources.GetObject("mediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.mediaPlayer.Size = New System.Drawing.Size(375, 48)
        Me.mediaPlayer.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 53)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(375, 195)
        Me.TextBox1.TabIndex = 1
        '
        'spkbtn
        '
        Me.spkbtn.Location = New System.Drawing.Point(405, 124)
        Me.spkbtn.Name = "spkbtn"
        Me.spkbtn.Size = New System.Drawing.Size(75, 23)
        Me.spkbtn.TabIndex = 2
        Me.spkbtn.Text = "OKU"
        Me.spkbtn.UseVisualStyleBackColor = True
        '
        'savebtn
        '
        Me.savebtn.Location = New System.Drawing.Point(405, 164)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(75, 23)
        Me.savebtn.TabIndex = 3
        Me.savebtn.Text = "KAYDET"
        Me.savebtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 343)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.spkbtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.mediaPlayer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.mediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents spkbtn As Button
    Friend WithEvents savebtn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
