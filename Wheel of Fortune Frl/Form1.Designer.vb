<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.Button25 = New System.Windows.Forms.Button()
        Me.Button26 = New System.Windows.Forms.Button()
        Me.Button27 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(73, 258)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(73, 206)
        Me.btnSpin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(100, 28)
        Me.btnSpin.TabIndex = 102
        Me.btnSpin.Text = "&Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
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
        Me.PictureBox1.Location = New System.Drawing.Point(201, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1179, 673)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button27)
        Me.GroupBox1.Controls.Add(Me.Button26)
        Me.GroupBox1.Controls.Add(Me.Button25)
        Me.GroupBox1.Controls.Add(Me.Button24)
        Me.GroupBox1.Controls.Add(Me.Button23)
        Me.GroupBox1.Controls.Add(Me.Button22)
        Me.GroupBox1.Controls.Add(Me.Button21)
        Me.GroupBox1.Controls.Add(Me.Button20)
        Me.GroupBox1.Controls.Add(Me.Button19)
        Me.GroupBox1.Controls.Add(Me.Button18)
        Me.GroupBox1.Controls.Add(Me.Button17)
        Me.GroupBox1.Controls.Add(Me.Button16)
        Me.GroupBox1.Controls.Add(Me.Button15)
        Me.GroupBox1.Controls.Add(Me.Button14)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button11)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(201, 729)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 172)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(25, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 24)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Q"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(94, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(25, 24)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "W"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(189, 75)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(25, 24)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "D"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(223, 21)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(25, 24)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "R"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(287, 21)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 24)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "T"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(351, 21)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(25, 24)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Y"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(417, 21)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(25, 24)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "U"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(558, 21)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(25, 24)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "O"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(486, 21)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(25, 24)
        Me.Button10.TabIndex = 8
        Me.Button10.Text = "I"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(632, 21)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(25, 24)
        Me.Button11.TabIndex = 9
        Me.Button11.Text = "P"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(602, 75)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(25, 24)
        Me.Button12.TabIndex = 10
        Me.Button12.Text = "L"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(522, 75)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(25, 24)
        Me.Button13.TabIndex = 11
        Me.Button13.Text = "K"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(451, 75)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(25, 24)
        Me.Button14.TabIndex = 12
        Me.Button14.Text = "J"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(388, 75)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(25, 24)
        Me.Button15.TabIndex = 13
        Me.Button15.Text = "H"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Location = New System.Drawing.Point(317, 75)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(25, 24)
        Me.Button16.TabIndex = 14
        Me.Button16.Text = "G"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(417, 130)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(25, 24)
        Me.Button17.TabIndex = 15
        Me.Button17.Text = "N"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(223, 130)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(25, 24)
        Me.Button18.TabIndex = 16
        Me.Button18.Text = "C"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(351, 130)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(25, 24)
        Me.Button19.TabIndex = 17
        Me.Button19.Text = "B"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Location = New System.Drawing.Point(251, 75)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(25, 24)
        Me.Button20.TabIndex = 18
        Me.Button20.Text = "F"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Location = New System.Drawing.Point(287, 130)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(25, 24)
        Me.Button21.TabIndex = 19
        Me.Button21.Text = "V"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Location = New System.Drawing.Point(159, 130)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(25, 24)
        Me.Button22.TabIndex = 20
        Me.Button22.Text = "X"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Location = New System.Drawing.Point(94, 130)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(25, 24)
        Me.Button23.TabIndex = 21
        Me.Button23.Text = "Z"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Location = New System.Drawing.Point(60, 75)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(25, 24)
        Me.Button24.TabIndex = 22
        Me.Button24.Text = "A"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Location = New System.Drawing.Point(126, 75)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(25, 24)
        Me.Button25.TabIndex = 23
        Me.Button25.Text = "S"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Button26
        '
        Me.Button26.Location = New System.Drawing.Point(159, 21)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(25, 24)
        Me.Button26.TabIndex = 24
        Me.Button26.Text = "E"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(486, 130)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(25, 24)
        Me.Button27.TabIndex = 25
        Me.Button27.Text = "M"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1055)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMain"
        Me.Text = "MainForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSpin As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button27 As Button
    Friend WithEvents Button26 As Button
    Friend WithEvents Button25 As Button
    Friend WithEvents Button24 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
