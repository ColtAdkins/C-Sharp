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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.ChooseWeatherBox = New System.Windows.Forms.GroupBox()
        Me.CloudyButton = New System.Windows.Forms.RadioButton()
        Me.RainyButton = New System.Windows.Forms.RadioButton()
        Me.SnowyButton = New System.Windows.Forms.RadioButton()
        Me.SunnyButton = New System.Windows.Forms.RadioButton()
        Me.WeatherText = New System.Windows.Forms.TextBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WeatherPic = New System.Windows.Forms.PictureBox()
        Me.ChooseWeatherBox.SuspendLayout()
        CType(Me.WeatherPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter your name here: "
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(132, 6)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(176, 20)
        Me.NameBox.TabIndex = 1
        '
        'ChooseWeatherBox
        '
        Me.ChooseWeatherBox.Controls.Add(Me.CloudyButton)
        Me.ChooseWeatherBox.Controls.Add(Me.RainyButton)
        Me.ChooseWeatherBox.Controls.Add(Me.SnowyButton)
        Me.ChooseWeatherBox.Controls.Add(Me.SunnyButton)
        Me.ChooseWeatherBox.Location = New System.Drawing.Point(15, 54)
        Me.ChooseWeatherBox.Name = "ChooseWeatherBox"
        Me.ChooseWeatherBox.Size = New System.Drawing.Size(124, 147)
        Me.ChooseWeatherBox.TabIndex = 2
        Me.ChooseWeatherBox.TabStop = False
        Me.ChooseWeatherBox.Text = "Choose"
        '
        'CloudyButton
        '
        Me.CloudyButton.AutoSize = True
        Me.CloudyButton.Location = New System.Drawing.Point(11, 115)
        Me.CloudyButton.Name = "CloudyButton"
        Me.CloudyButton.Size = New System.Drawing.Size(57, 17)
        Me.CloudyButton.TabIndex = 3
        Me.CloudyButton.TabStop = True
        Me.CloudyButton.Text = "Cloudy"
        Me.CloudyButton.UseVisualStyleBackColor = True
        '
        'RainyButton
        '
        Me.RainyButton.AutoSize = True
        Me.RainyButton.Location = New System.Drawing.Point(11, 92)
        Me.RainyButton.Name = "RainyButton"
        Me.RainyButton.Size = New System.Drawing.Size(52, 17)
        Me.RainyButton.TabIndex = 2
        Me.RainyButton.TabStop = True
        Me.RainyButton.Text = "Rainy"
        Me.RainyButton.UseVisualStyleBackColor = True
        '
        'SnowyButton
        '
        Me.SnowyButton.AutoSize = True
        Me.SnowyButton.Location = New System.Drawing.Point(11, 69)
        Me.SnowyButton.Name = "SnowyButton"
        Me.SnowyButton.Size = New System.Drawing.Size(57, 17)
        Me.SnowyButton.TabIndex = 1
        Me.SnowyButton.TabStop = True
        Me.SnowyButton.Text = "Snowy"
        Me.SnowyButton.UseVisualStyleBackColor = True
        '
        'SunnyButton
        '
        Me.SunnyButton.AutoSize = True
        Me.SunnyButton.Location = New System.Drawing.Point(11, 46)
        Me.SunnyButton.Name = "SunnyButton"
        Me.SunnyButton.Size = New System.Drawing.Size(55, 17)
        Me.SunnyButton.TabIndex = 0
        Me.SunnyButton.TabStop = True
        Me.SunnyButton.Text = "Sunny"
        Me.SunnyButton.UseVisualStyleBackColor = True
        '
        'WeatherText
        '
        Me.WeatherText.BackColor = System.Drawing.Color.White
        Me.WeatherText.Location = New System.Drawing.Point(15, 230)
        Me.WeatherText.Name = "WeatherText"
        Me.WeatherText.Size = New System.Drawing.Size(342, 20)
        Me.WeatherText.TabIndex = 3
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(375, 227)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 292)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Programmed By: Colton Adkins"
        '
        'WeatherPic
        '
        Me.WeatherPic.InitialImage = Global.Lab2B.My.Resources.Resources.Sun1
        Me.WeatherPic.Location = New System.Drawing.Point(170, 54)
        Me.WeatherPic.Name = "WeatherPic"
        Me.WeatherPic.Size = New System.Drawing.Size(259, 167)
        Me.WeatherPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WeatherPic.TabIndex = 6
        Me.WeatherPic.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 328)
        Me.Controls.Add(Me.WeatherPic)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.WeatherText)
        Me.Controls.Add(Me.ChooseWeatherBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ChooseWeatherBox.ResumeLayout(False)
        Me.ChooseWeatherBox.PerformLayout()
        CType(Me.WeatherPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents ChooseWeatherBox As GroupBox
    Friend WithEvents CloudyButton As RadioButton
    Friend WithEvents RainyButton As RadioButton
    Friend WithEvents SnowyButton As RadioButton
    Friend WithEvents SunnyButton As RadioButton
    Friend WithEvents WeatherText As TextBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents WeatherPic As PictureBox
End Class
