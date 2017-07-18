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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.capBtn = New System.Windows.Forms.RadioButton()
        Me.espressoBtn = New System.Windows.Forms.RadioButton()
        Me.latteBtn = New System.Windows.Forms.RadioButton()
        Me.icedLatteBtn = New System.Windows.Forms.RadioButton()
        Me.icedCappBtn = New System.Windows.Forms.RadioButton()
        Me.takeoutBox = New System.Windows.Forms.CheckBox()
        Me.amtBox = New System.Windows.Forms.TextBox()
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.clearNxtBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.summaryBtn = New System.Windows.Forms.Button()
        Me.newOrderBtn = New System.Windows.Forms.Button()
        Me.subTotalBox = New System.Windows.Forms.TextBox()
        Me.taxBox = New System.Windows.Forms.TextBox()
        Me.totalBox = New System.Windows.Forms.TextBox()
        Me.quantityBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.quantityBox)
        Me.GroupBox1.Controls.Add(Me.clearNxtBtn)
        Me.GroupBox1.Controls.Add(Me.calcBtn)
        Me.GroupBox1.Controls.Add(Me.amtBox)
        Me.GroupBox1.Controls.Add(Me.takeoutBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.subTotalBox)
        Me.GroupBox2.Controls.Add(Me.taxBox)
        Me.GroupBox2.Controls.Add(Me.totalBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(458, 96)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Due"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tax (if Takeout)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sub Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Item Amount?"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.icedCappBtn)
        Me.GroupBox3.Controls.Add(Me.icedLatteBtn)
        Me.GroupBox3.Controls.Add(Me.latteBtn)
        Me.GroupBox3.Controls.Add(Me.espressoBtn)
        Me.GroupBox3.Controls.Add(Me.capBtn)
        Me.GroupBox3.Location = New System.Drawing.Point(266, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(165, 134)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Coffee Selections"
        '
        'capBtn
        '
        Me.capBtn.AutoSize = True
        Me.capBtn.Location = New System.Drawing.Point(6, 18)
        Me.capBtn.Name = "capBtn"
        Me.capBtn.Size = New System.Drawing.Size(82, 17)
        Me.capBtn.TabIndex = 0
        Me.capBtn.TabStop = True
        Me.capBtn.Text = "Cappuccino"
        Me.capBtn.UseVisualStyleBackColor = True
        '
        'espressoBtn
        '
        Me.espressoBtn.AutoSize = True
        Me.espressoBtn.Location = New System.Drawing.Point(6, 42)
        Me.espressoBtn.Name = "espressoBtn"
        Me.espressoBtn.Size = New System.Drawing.Size(68, 17)
        Me.espressoBtn.TabIndex = 1
        Me.espressoBtn.TabStop = True
        Me.espressoBtn.Text = "Espresso"
        Me.espressoBtn.UseVisualStyleBackColor = True
        '
        'latteBtn
        '
        Me.latteBtn.AutoSize = True
        Me.latteBtn.Location = New System.Drawing.Point(6, 65)
        Me.latteBtn.Name = "latteBtn"
        Me.latteBtn.Size = New System.Drawing.Size(49, 17)
        Me.latteBtn.TabIndex = 2
        Me.latteBtn.TabStop = True
        Me.latteBtn.Text = "Latte"
        Me.latteBtn.UseVisualStyleBackColor = True
        '
        'icedLatteBtn
        '
        Me.icedLatteBtn.AutoSize = True
        Me.icedLatteBtn.Location = New System.Drawing.Point(6, 88)
        Me.icedLatteBtn.Name = "icedLatteBtn"
        Me.icedLatteBtn.Size = New System.Drawing.Size(73, 17)
        Me.icedLatteBtn.TabIndex = 3
        Me.icedLatteBtn.TabStop = True
        Me.icedLatteBtn.Text = "Iced Latte"
        Me.icedLatteBtn.UseVisualStyleBackColor = True
        '
        'icedCappBtn
        '
        Me.icedCappBtn.AutoSize = True
        Me.icedCappBtn.Location = New System.Drawing.Point(6, 111)
        Me.icedCappBtn.Name = "icedCappBtn"
        Me.icedCappBtn.Size = New System.Drawing.Size(106, 17)
        Me.icedCappBtn.TabIndex = 4
        Me.icedCappBtn.TabStop = True
        Me.icedCappBtn.Text = "Iced Cappuccino"
        Me.icedCappBtn.UseVisualStyleBackColor = True
        '
        'takeoutBox
        '
        Me.takeoutBox.AutoSize = True
        Me.takeoutBox.Location = New System.Drawing.Point(14, 37)
        Me.takeoutBox.Name = "takeoutBox"
        Me.takeoutBox.Size = New System.Drawing.Size(72, 17)
        Me.takeoutBox.TabIndex = 7
        Me.takeoutBox.Text = "Takeout?"
        Me.takeoutBox.UseVisualStyleBackColor = True
        '
        'amtBox
        '
        Me.amtBox.Location = New System.Drawing.Point(97, 103)
        Me.amtBox.Name = "amtBox"
        Me.amtBox.ReadOnly = True
        Me.amtBox.Size = New System.Drawing.Size(100, 20)
        Me.amtBox.TabIndex = 8
        '
        'calcBtn
        '
        Me.calcBtn.Location = New System.Drawing.Point(22, 57)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(69, 43)
        Me.calcBtn.TabIndex = 9
        Me.calcBtn.Text = "Calculate Selection"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'clearNxtBtn
        '
        Me.clearNxtBtn.Location = New System.Drawing.Point(113, 57)
        Me.clearNxtBtn.Name = "clearNxtBtn"
        Me.clearNxtBtn.Size = New System.Drawing.Size(72, 43)
        Me.clearNxtBtn.TabIndex = 10
        Me.clearNxtBtn.Text = "Clear For Next Item"
        Me.clearNxtBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(384, 310)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(98, 33)
        Me.exitBtn.TabIndex = 11
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'summaryBtn
        '
        Me.summaryBtn.Location = New System.Drawing.Point(252, 310)
        Me.summaryBtn.Name = "summaryBtn"
        Me.summaryBtn.Size = New System.Drawing.Size(108, 33)
        Me.summaryBtn.TabIndex = 12
        Me.summaryBtn.Text = "Summary"
        Me.summaryBtn.UseVisualStyleBackColor = True
        '
        'newOrderBtn
        '
        Me.newOrderBtn.Location = New System.Drawing.Point(126, 310)
        Me.newOrderBtn.Name = "newOrderBtn"
        Me.newOrderBtn.Size = New System.Drawing.Size(106, 33)
        Me.newOrderBtn.TabIndex = 13
        Me.newOrderBtn.Text = "New Order"
        Me.newOrderBtn.UseVisualStyleBackColor = True
        '
        'subTotalBox
        '
        Me.subTotalBox.Location = New System.Drawing.Point(97, 23)
        Me.subTotalBox.Name = "subTotalBox"
        Me.subTotalBox.ReadOnly = True
        Me.subTotalBox.Size = New System.Drawing.Size(100, 20)
        Me.subTotalBox.TabIndex = 11
        '
        'taxBox
        '
        Me.taxBox.Location = New System.Drawing.Point(99, 48)
        Me.taxBox.Name = "taxBox"
        Me.taxBox.ReadOnly = True
        Me.taxBox.Size = New System.Drawing.Size(100, 20)
        Me.taxBox.TabIndex = 12
        '
        'totalBox
        '
        Me.totalBox.Location = New System.Drawing.Point(99, 71)
        Me.totalBox.Name = "totalBox"
        Me.totalBox.ReadOnly = True
        Me.totalBox.Size = New System.Drawing.Size(100, 20)
        Me.totalBox.TabIndex = 13
        '
        'quantityBox
        '
        Me.quantityBox.Location = New System.Drawing.Point(71, 15)
        Me.quantityBox.Name = "quantityBox"
        Me.quantityBox.Size = New System.Drawing.Size(35, 20)
        Me.quantityBox.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 353)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.summaryBtn)
        Me.Controls.Add(Me.newOrderBtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents amtBox As TextBox
    Friend WithEvents takeoutBox As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents icedCappBtn As RadioButton
    Friend WithEvents icedLatteBtn As RadioButton
    Friend WithEvents latteBtn As RadioButton
    Friend WithEvents espressoBtn As RadioButton
    Friend WithEvents capBtn As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents clearNxtBtn As Button
    Friend WithEvents calcBtn As Button
    Friend WithEvents subTotalBox As TextBox
    Friend WithEvents taxBox As TextBox
    Friend WithEvents totalBox As TextBox
    Friend WithEvents exitBtn As Button
    Friend WithEvents summaryBtn As Button
    Friend WithEvents newOrderBtn As Button
    Friend WithEvents quantityBox As TextBox
End Class
