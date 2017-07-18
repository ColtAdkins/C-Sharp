'Program name: Ch04HandsOn
'Programmer: Colton Adkins
'Program design: calculates amount and accumulates summary information


Public Class Form1
    'Declare module level constants
    Const CAPP_PRICE As Decimal = 2D
    Const ICED_CAPP_PRICE As Decimal = 2.5D
    Const ESPRESSO_PRICE As Decimal = 2.25D
    Const LATTE_PRICE As Decimal = 1.75D
    Const ICED_LATTE_PRICE As Decimal = 2.5D
    Const TAX As Decimal = 0.08D
    'Declare modulate level variables for summary information.
    Private SubtotalDecimal, TotalDecimal, GrandTotalDecimal As Decimal
    Private CustomerCountInteger As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles amtBox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles subTotalBox.TextChanged

    End Sub

    Private Sub quantityBox_TextChanged(sender As Object, e As EventArgs) Handles quantityBox.TextChanged

    End Sub

    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        'When clicked disables the Clear for next item and Takeout boxes
        Dim PriceDecimal, TaxDecimal, ItemAmountDecimal As Decimal
        Dim QuantityInteger As Integer
        'Find the price
        If capBtn.Checked Then
            PriceDecimal = CAPP_PRICE
        ElseIf espressoBtn.Checked Then
            PriceDecimal = ESPRESSO_PRICE
        ElseIf latteBtn.Checked Then
            PriceDecimal = LATTE_PRICE
        ElseIf icedCappBtn.Checked Then
            PriceDecimal = ICED_CAPP_PRICE
        ElseIf icedLatteBtn.Checked Then
            PriceDecimal = ICED_LATTE_PRICE
        End If

        ' Calculates extended price and add to order total.
        Try
            QuantityInteger = Integer.Parse(quantityBox.Text)
            ItemAmountDecimal = PriceDecimal * QuantityInteger
            SubtotalDecimal += ItemAmountDecimal
            If takeoutBox.Checked Then
                TaxDecimal = SubtotalDecimal * TAX
            Else
                TaxDecimal = 0
            End If
            TotalDecimal = SubtotalDecimal + TaxDecimal
            amtBox.Text = ItemAmountDecimal.ToString("C")
            subTotalBox.Text = SubtotalDecimal.ToString("N")
            taxBox.Text = TaxDecimal.ToString("N")
            totalBox.Text = TotalDecimal.ToString("C")
            'Allow a change only for new order.
            takeoutBox.Enabled = False
            'Allow Clear after an order is begun.
            clearNxtBtn.Enabled = True
            newOrderBtn.Enabled = True
        Catch QuantityException As FormatException
            MessageBox.Show("Quantity must be numeric.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With quantityBox
                .Focus()
                .SelectAll()
            End With
        End Try
    End Sub

    Private Sub clearNxtBtn_Click(sender As Object, e As EventArgs) Handles clearNxtBtn.Click
        ' Clears the appropriate controls
        capBtn.Checked = True 'All others are false.
        amtBox.Clear()
        With quantityBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub capBtn_CheckedChanged(sender As Object, e As EventArgs) Handles capBtn.CheckedChanged

    End Sub

    Private Sub espressoBtn_CheckedChanged(sender As Object, e As EventArgs) Handles espressoBtn.CheckedChanged

    End Sub

    Private Sub latteBtn_CheckedChanged(sender As Object, e As EventArgs) Handles latteBtn.CheckedChanged

    End Sub

    Private Sub icedLatteBtn_CheckedChanged(sender As Object, e As EventArgs) Handles icedLatteBtn.CheckedChanged

    End Sub

    Private Sub icedCappBtn_CheckedChanged(sender As Object, e As EventArgs) Handles icedCappBtn.CheckedChanged

    End Sub

    Private Sub taxBox_TextChanged(sender As Object, e As EventArgs) Handles taxBox.TextChanged

    End Sub

    Private Sub totalBox_TextChanged(sender As Object, e As EventArgs) Handles totalBox.TextChanged

    End Sub

    Private Sub newOrderBtn_Click(sender As Object, e As EventArgs) Handles newOrderBtn.Click
        'Clear current order and add the totals
        Dim ReturnDialogResult As DialogResult
        Dim MessageString As String
        'Confirm clear of the current order.
        MessageString = "Clear the current order figures?"
        ReturnDialogResult = MessageBox.Show(MessageString, "Clear order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If ReturnDialogResult = DialogResult.Yes Then  ' User Said Yes
            clearNxtBtn_Click(sender, e) ' Clears the screen fields
            subTotalBox.Clear()
            taxBox.Clear()
            totalBox.Clear()

            'Add to totals.
            'Add only if not a new order/customer.
            If SubtotalDecimal <> 0 Then
                GrandTotalDecimal += TotalDecimal
                CustomerCountInteger += 1
                'Reset totals for next customer.
                SubtotalDecimal = 0
                TotalDecimal = 0
            End If

            'Clear appropriate display items and enable check box.
            With takeoutBox
                .Enabled = True
                .Checked = False

            End With
            clearNxtBtn.Enabled = False
            newOrderBtn.Enabled = False
        End If
    End Sub

    Private Sub summaryBtn_Click(sender As Object, e As EventArgs) Handles summaryBtn.Click
        'Calculate the average and display the totals.
        Dim AverageDecimal As Decimal
        Dim MessageString As String
        If TotalDecimal <> 0 Then
            'Make sure last order is counted.
            newOrderBtn_Click(sender, e)
        End If

        If CustomerCountInteger > 0 Then
            ' Calculate the average.
            AverageDecimal = GrandTotalDecimal / CustomerCountInteger

            'Concatenate the message string.
            MessageString = "Number of Orders:  " &
                CustomerCountInteger.ToString() &
                Environment.NewLine & Environment.NewLine &
                "Total Sales:  " & GrandTotalDecimal.ToString("C") &
                Environment.NewLine & Environment.NewLine &
                "Average Sale:  " & AverageDecimal.ToString("C")
            MessageBox.Show(MessageString, "Coffee Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        'closes the project
        Me.Close()
    End Sub
End Class
