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
        Me.CheckInGroupBox = New System.Windows.Forms.GroupBox()
        Me.MemberIDMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentGroupBox = New System.Windows.Forms.GroupBox()
        Me.BooksButton = New System.Windows.Forms.RadioButton()
        Me.MusicButton = New System.Windows.Forms.RadioButton()
        Me.PeriodicalsButton = New System.Windows.Forms.RadioButton()
        Me.CoffeeButton = New System.Windows.Forms.RadioButton()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SignInButton = New System.Windows.Forms.Button()
        Me.ImageVisibleCheckBox = New System.Windows.Forms.CheckBox()
        Me.PromotionTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentPictureBox = New System.Windows.Forms.PictureBox()
        Me.WelcomeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.CheckInGroupBox.SuspendLayout()
        Me.DepartmentGroupBox.SuspendLayout()
        CType(Me.DepartmentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckInGroupBox
        '
        Me.CheckInGroupBox.Controls.Add(Me.MemberIDMaskedTextBox)
        Me.CheckInGroupBox.Controls.Add(Me.Label5)
        Me.CheckInGroupBox.Controls.Add(Me.Label1)
        Me.CheckInGroupBox.Controls.Add(Me.NameTextBox)
        Me.CheckInGroupBox.Location = New System.Drawing.Point(283, 12)
        Me.CheckInGroupBox.Name = "CheckInGroupBox"
        Me.CheckInGroupBox.Size = New System.Drawing.Size(189, 69)
        Me.CheckInGroupBox.TabIndex = 0
        Me.CheckInGroupBox.TabStop = False
        Me.CheckInGroupBox.Text = "Elite Member Check In"
        '
        'MemberIDMaskedTextBox
        '
        Me.MemberIDMaskedTextBox.Location = New System.Drawing.Point(83, 41)
        Me.MemberIDMaskedTextBox.Mask = "00000"
        Me.MemberIDMaskedTextBox.Name = "MemberIDMaskedTextBox"
        Me.MemberIDMaskedTextBox.Size = New System.Drawing.Size(37, 20)
        Me.MemberIDMaskedTextBox.TabIndex = 6
        Me.MemberIDMaskedTextBox.ValidatingType = GetType(Integer)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Member &ID"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(83, 17)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'DepartmentGroupBox
        '
        Me.DepartmentGroupBox.Controls.Add(Me.BooksButton)
        Me.DepartmentGroupBox.Controls.Add(Me.MusicButton)
        Me.DepartmentGroupBox.Controls.Add(Me.PeriodicalsButton)
        Me.DepartmentGroupBox.Controls.Add(Me.CoffeeButton)
        Me.DepartmentGroupBox.Location = New System.Drawing.Point(22, 12)
        Me.DepartmentGroupBox.Name = "DepartmentGroupBox"
        Me.DepartmentGroupBox.Size = New System.Drawing.Size(239, 105)
        Me.DepartmentGroupBox.TabIndex = 1
        Me.DepartmentGroupBox.TabStop = False
        Me.DepartmentGroupBox.Text = "Department"
        '
        'BooksButton
        '
        Me.BooksButton.AutoSize = True
        Me.BooksButton.Location = New System.Drawing.Point(6, 16)
        Me.BooksButton.Name = "BooksButton"
        Me.BooksButton.Size = New System.Drawing.Size(55, 17)
        Me.BooksButton.TabIndex = 3
        Me.BooksButton.TabStop = True
        Me.BooksButton.Text = "Books"
        Me.BooksButton.UseVisualStyleBackColor = True
        '
        'MusicButton
        '
        Me.MusicButton.AutoSize = True
        Me.MusicButton.Location = New System.Drawing.Point(6, 37)
        Me.MusicButton.Name = "MusicButton"
        Me.MusicButton.Size = New System.Drawing.Size(53, 17)
        Me.MusicButton.TabIndex = 4
        Me.MusicButton.TabStop = True
        Me.MusicButton.Text = "Music"
        Me.MusicButton.UseVisualStyleBackColor = True
        '
        'PeriodicalsButton
        '
        Me.PeriodicalsButton.AutoSize = True
        Me.PeriodicalsButton.Location = New System.Drawing.Point(6, 60)
        Me.PeriodicalsButton.Name = "PeriodicalsButton"
        Me.PeriodicalsButton.Size = New System.Drawing.Size(76, 17)
        Me.PeriodicalsButton.TabIndex = 5
        Me.PeriodicalsButton.TabStop = True
        Me.PeriodicalsButton.Text = "Periodicals"
        Me.PeriodicalsButton.UseVisualStyleBackColor = True
        '
        'CoffeeButton
        '
        Me.CoffeeButton.AutoSize = True
        Me.CoffeeButton.Location = New System.Drawing.Point(6, 83)
        Me.CoffeeButton.Name = "CoffeeButton"
        Me.CoffeeButton.Size = New System.Drawing.Size(75, 17)
        Me.CoffeeButton.TabIndex = 6
        Me.CoffeeButton.TabStop = True
        Me.CoffeeButton.Text = "Coffee Bar"
        Me.CoffeeButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(391, 210)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(213, 273)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SignInButton
        '
        Me.SignInButton.Location = New System.Drawing.Point(391, 149)
        Me.SignInButton.Name = "SignInButton"
        Me.SignInButton.Size = New System.Drawing.Size(75, 23)
        Me.SignInButton.TabIndex = 2
        Me.SignInButton.Text = "Sign In"
        Me.SignInButton.UseVisualStyleBackColor = True
        '
        'ImageVisibleCheckBox
        '
        Me.ImageVisibleCheckBox.AutoSize = True
        Me.ImageVisibleCheckBox.Location = New System.Drawing.Point(173, 183)
        Me.ImageVisibleCheckBox.Name = "ImageVisibleCheckBox"
        Me.ImageVisibleCheckBox.Size = New System.Drawing.Size(88, 17)
        Me.ImageVisibleCheckBox.TabIndex = 3
        Me.ImageVisibleCheckBox.Text = "Image Visible"
        Me.ImageVisibleCheckBox.UseVisualStyleBackColor = True
        Me.ImageVisibleCheckBox.Visible = False
        '
        'PromotionTextBox
        '
        Me.PromotionTextBox.Location = New System.Drawing.Point(12, 230)
        Me.PromotionTextBox.Name = "PromotionTextBox"
        Me.PromotionTextBox.Size = New System.Drawing.Size(284, 20)
        Me.PromotionTextBox.TabIndex = 4
        '
        'DepartmentPictureBox
        '
        Me.DepartmentPictureBox.Image = Global.Lab2A.My.Resources.Resources.books
        Me.DepartmentPictureBox.Location = New System.Drawing.Point(28, 122)
        Me.DepartmentPictureBox.Name = "DepartmentPictureBox"
        Me.DepartmentPictureBox.Size = New System.Drawing.Size(139, 102)
        Me.DepartmentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DepartmentPictureBox.TabIndex = 5
        Me.DepartmentPictureBox.TabStop = False
        Me.DepartmentPictureBox.Visible = False
        '
        'WelcomeRichTextBox
        '
        Me.WelcomeRichTextBox.Location = New System.Drawing.Point(283, 87)
        Me.WelcomeRichTextBox.Name = "WelcomeRichTextBox"
        Me.WelcomeRichTextBox.Size = New System.Drawing.Size(183, 56)
        Me.WelcomeRichTextBox.TabIndex = 6
        Me.WelcomeRichTextBox.Text = ""
        Me.WelcomeRichTextBox.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 262)
        Me.Controls.Add(Me.WelcomeRichTextBox)
        Me.Controls.Add(Me.DepartmentPictureBox)
        Me.Controls.Add(Me.PromotionTextBox)
        Me.Controls.Add(Me.ImageVisibleCheckBox)
        Me.Controls.Add(Me.SignInButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DepartmentGroupBox)
        Me.Controls.Add(Me.CheckInGroupBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.CheckInGroupBox.ResumeLayout(False)
        Me.CheckInGroupBox.PerformLayout()
        Me.DepartmentGroupBox.ResumeLayout(False)
        Me.DepartmentGroupBox.PerformLayout()
        CType(Me.DepartmentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckInGroupBox As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DepartmentGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SignInButton As Button
    Friend WithEvents BooksButton As RadioButton
    Friend WithEvents MusicButton As RadioButton
    Friend WithEvents PeriodicalsButton As RadioButton
    Friend WithEvents CoffeeButton As RadioButton
    Friend WithEvents ImageVisibleCheckBox As CheckBox
    Friend WithEvents PromotionTextBox As TextBox
    Friend WithEvents DepartmentPictureBox As PictureBox
    Friend WithEvents MemberIDMaskedTextBox As MaskedTextBox
    Friend WithEvents WelcomeRichTextBox As RichTextBox
End Class
