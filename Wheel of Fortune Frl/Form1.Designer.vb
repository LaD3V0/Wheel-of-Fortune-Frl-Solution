<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(55, 167)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(75, 23)
        Me.btnSpin.TabIndex = 102
        Me.btnSpin.Text = "&Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "wheel 26 unsel.png")
        Me.ImageList1.Images.SetKeyName(1, "wheel 25.png")
        Me.ImageList1.Images.SetKeyName(2, "wheel 24.png")
        Me.ImageList1.Images.SetKeyName(3, "wheel 23.png")
        Me.ImageList1.Images.SetKeyName(4, "wheel 22.png")
        Me.ImageList1.Images.SetKeyName(5, "wheel 21.png")
        Me.ImageList1.Images.SetKeyName(6, "wheel 20.png")
        Me.ImageList1.Images.SetKeyName(7, "wheel 19.png")
        Me.ImageList1.Images.SetKeyName(8, "wheel 18.png")
        Me.ImageList1.Images.SetKeyName(9, "wheel 17.png")
        Me.ImageList1.Images.SetKeyName(10, "wheel 16.png")
        Me.ImageList1.Images.SetKeyName(11, "wheel 15.png")
        Me.ImageList1.Images.SetKeyName(12, "wheel 14.png")
        Me.ImageList1.Images.SetKeyName(13, "wheel 13.png")
        Me.ImageList1.Images.SetKeyName(14, "wheel 12.png")
        Me.ImageList1.Images.SetKeyName(15, "wheel 11.png")
        Me.ImageList1.Images.SetKeyName(16, "wheel 10.png")
        Me.ImageList1.Images.SetKeyName(17, "wheel 9.png")
        Me.ImageList1.Images.SetKeyName(18, "wheel 8.png")
        Me.ImageList1.Images.SetKeyName(19, "wheel 7.png")
        Me.ImageList1.Images.SetKeyName(20, "wheel 6.png")
        Me.ImageList1.Images.SetKeyName(21, "wheel 5.png")
        Me.ImageList1.Images.SetKeyName(22, "wheel 4.png")
        Me.ImageList1.Images.SetKeyName(23, "wheel 3.png")
        Me.ImageList1.Images.SetKeyName(24, "wheel 2.png")
        Me.ImageList1.Images.SetKeyName(25, "wheel 1.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Wheel_of_Fortune_Frl.My.Resources.Resources.wheel_1
        Me.PictureBox1.Location = New System.Drawing.Point(198, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(884, 547)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(55, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 104
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1127, 609)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmMain"
        Me.Text = "MainForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSpin As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
End Class
