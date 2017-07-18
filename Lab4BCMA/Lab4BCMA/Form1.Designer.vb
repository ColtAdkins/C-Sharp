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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.none = New System.Windows.Forms.RadioButton()
        Me.discountTen = New System.Windows.Forms.RadioButton()
        Me.discountTwenty = New System.Windows.Forms.RadioButton()
        Me.permMakeup = New System.Windows.Forms.RadioButton()
        Me.makeOver = New System.Windows.Forms.RadioButton()
        Me.hairStyle = New System.Windows.Forms.RadioButton()
        Me.manicure = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.service = New System.Windows.Forms.TextBox()
        Me.serviceTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.permMakeup)
        Me.GroupBox1.Controls.Add(Me.hairStyle)
        Me.GroupBox1.Controls.Add(Me.manicure)
        Me.GroupBox1.Controls.Add(Me.makeOver)
        Me.GroupBox1.Location = New System.Drawing.Point(238, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Service"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.none)
        Me.GroupBox2.Controls.Add(Me.discountTen)
        Me.GroupBox2.Controls.Add(Me.discountTwenty)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 111)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Discount"
        '
        'calcBtn
        '
        Me.calcBtn.Location = New System.Drawing.Point(112, 255)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(75, 23)
        Me.calcBtn.TabIndex = 0
        Me.calcBtn.Text = "Calculate"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(216, 284)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 1
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(216, 255)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 2
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'none
        '
        Me.none.AutoSize = True
        Me.none.Location = New System.Drawing.Point(6, 19)
        Me.none.Name = "none"
        Me.none.Size = New System.Drawing.Size(51, 17)
        Me.none.TabIndex = 3
        Me.none.TabStop = True
        Me.none.Text = "None"
        Me.none.UseVisualStyleBackColor = True
        '
        'discountTen
        '
        Me.discountTen.AutoSize = True
        Me.discountTen.Location = New System.Drawing.Point(6, 54)
        Me.discountTen.Name = "discountTen"
        Me.discountTen.Size = New System.Drawing.Size(48, 17)
        Me.discountTen.TabIndex = 4
        Me.discountTen.TabStop = True
        Me.discountTen.Text = "10 %"
        Me.discountTen.UseVisualStyleBackColor = True
        '
        'discountTwenty
        '
        Me.discountTwenty.AutoSize = True
        Me.discountTwenty.Location = New System.Drawing.Point(6, 88)
        Me.discountTwenty.Name = "discountTwenty"
        Me.discountTwenty.Size = New System.Drawing.Size(48, 17)
        Me.discountTwenty.TabIndex = 5
        Me.discountTwenty.TabStop = True
        Me.discountTwenty.Text = "20 %"
        Me.discountTwenty.UseVisualStyleBackColor = True
        '
        'permMakeup
        '
        Me.permMakeup.AutoSize = True
        Me.permMakeup.Location = New System.Drawing.Point(6, 133)
        Me.permMakeup.Name = "permMakeup"
        Me.permMakeup.Size = New System.Drawing.Size(118, 17)
        Me.permMakeup.TabIndex = 6
        Me.permMakeup.TabStop = True
        Me.permMakeup.Text = "Permanent Makeup"
        Me.permMakeup.UseVisualStyleBackColor = True
        '
        'makeOver
        '
        Me.makeOver.AutoSize = True
        Me.makeOver.Location = New System.Drawing.Point(6, 54)
        Me.makeOver.Name = "makeOver"
        Me.makeOver.Size = New System.Drawing.Size(73, 17)
        Me.makeOver.TabIndex = 7
        Me.makeOver.TabStop = True
        Me.makeOver.Text = "Makeover"
        Me.makeOver.UseVisualStyleBackColor = True
        '
        'hairStyle
        '
        Me.hairStyle.AutoSize = True
        Me.hairStyle.Location = New System.Drawing.Point(6, 19)
        Me.hairStyle.Name = "hairStyle"
        Me.hairStyle.Size = New System.Drawing.Size(65, 17)
        Me.hairStyle.TabIndex = 8
        Me.hairStyle.TabStop = True
        Me.hairStyle.Text = "Hairstyle"
        Me.hairStyle.UseVisualStyleBackColor = True
        '
        'manicure
        '
        Me.manicure.AutoSize = True
        Me.manicure.Location = New System.Drawing.Point(6, 94)
        Me.manicure.Name = "manicure"
        Me.manicure.Size = New System.Drawing.Size(69, 17)
        Me.manicure.TabIndex = 9
        Me.manicure.TabStop = True
        Me.manicure.Text = "Manicure"
        Me.manicure.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Current Service:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Total for all services:"
        '
        'service
        '
        Me.service.Location = New System.Drawing.Point(135, 190)
        Me.service.Name = "service"
        Me.service.ReadOnly = True
        Me.service.Size = New System.Drawing.Size(100, 20)
        Me.service.TabIndex = 8
        '
        'serviceTotal
        '
        Me.serviceTotal.Location = New System.Drawing.Point(135, 229)
        Me.serviceTotal.Name = "serviceTotal"
        Me.serviceTotal.ReadOnly = True
        Me.serviceTotal.Size = New System.Drawing.Size(100, 20)
        Me.serviceTotal.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 319)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.service)
        Me.Controls.Add(Me.serviceTotal)
        Me.Controls.Add(Me.calcBtn)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents permMakeup As RadioButton
    Friend WithEvents hairStyle As RadioButton
    Friend WithEvents manicure As RadioButton
    Friend WithEvents makeOver As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents none As RadioButton
    Friend WithEvents discountTen As RadioButton
    Friend WithEvents discountTwenty As RadioButton
    Friend WithEvents calcBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents service As TextBox
    Friend WithEvents serviceTotal As TextBox
End Class
