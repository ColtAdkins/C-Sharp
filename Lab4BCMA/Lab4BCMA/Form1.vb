Public Class Form1
    Const DISCOUNT_TEN As Decimal = 0.1D
    Const DISCOUNT_TWENTY As Decimal = 0.2D
    Const HAIRCUT As Integer = 60.0
    Const MAKE_OVER As Integer = 125.0
    Const MANI As Integer = 35.0
    Const MAKEUP As Integer = 200.0
    Private ServiceTotalDecimal As Decimal
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles service.TextChanged

    End Sub

    Private Sub none_CheckedChanged(sender As Object, e As EventArgs) Handles none.CheckedChanged

    End Sub

    Private Sub discountTen_CheckedChanged(sender As Object, e As EventArgs) Handles discountTen.CheckedChanged

    End Sub

    Private Sub discountTwenty_CheckedChanged(sender As Object, e As EventArgs) Handles discountTwenty.CheckedChanged

    End Sub

    Private Sub hairStyle_CheckedChanged(sender As Object, e As EventArgs) Handles hairStyle.CheckedChanged

    End Sub

    Private Sub makeOver_CheckedChanged(sender As Object, e As EventArgs) Handles makeOver.CheckedChanged

    End Sub

    Private Sub manicure_CheckedChanged(sender As Object, e As EventArgs) Handles manicure.CheckedChanged

    End Sub

    Private Sub permMakeup_CheckedChanged(sender As Object, e As EventArgs) Handles permMakeup.CheckedChanged

    End Sub

    Private Sub serviceTotal_TextChanged(sender As Object, e As EventArgs) Handles serviceTotal.TextChanged

    End Sub

    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        'Calculates the price of the service
        Dim PriceDecimal, DiscountDecimal, TotalDecimal As Decimal
        If hairStyle.Checked Then
            PriceDecimal = HAIRCUT
        ElseIf makeOver.Checked Then
            PriceDecimal = MAKE_OVER
        ElseIf manicure.Checked Then
            PriceDecimal = MANI
        ElseIf permMakeup.Checked Then
            PriceDecimal = MAKEUP
        End If

        If discountTen.Checked Then
            DiscountDecimal = PriceDecimal * DISCOUNT_TEN
        ElseIf discountTwenty.Checked Then
            DiscountDecimal = PriceDecimal * DISCOUNT_TWENTY
        Else DiscountDecimal = 0
        End If
        TotalDecimal = DiscountDecimal - PriceDecimal
        ServiceTotalDecimal += TotalDecimal
        service.Text = TotalDecimal.ToString("C")
        serviceTotal.Text = ServiceTotalDecimal.ToString("C")

    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        'Clears the services
        serviceTotal.Clear()
        service.Clear()
        hairStyle.Checked = False
        makeOver.Checked = False
        manicure.Checked = False
        permMakeup.Checked = False
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class
