Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Ends the program.

        Me.Close()
    End Sub

    Private Sub SignInButton_Click(sender As Object, e As EventArgs) Handles SignInButton.Click
        'Set up the screen to display the department promotions and the welcome message. Hide the sign in controls.

        'Hides and disables sign in controls.
        CheckInGroupBox.Visible = False
        SignInButton.Enabled = False

        'Enable the group of radio buttons
        DepartmentGroupBox.Enabled = True
        'Show the promotions controls
        PromotionTextBox.Visible = True
        ImageVisibleCheckBox.Visible = True
        WelcomeRichTextBox.Visible = True
        'Display the welcome message.
        WelcomeRichTextBox.Text = "Welcome Member #" & MemberIDMaskedTextBox.Text & Environment.NewLine & NameTextBox.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckInGroupBox_Enter(sender As Object, e As EventArgs) Handles CheckInGroupBox.Enter

    End Sub

    Private Sub DepartmentGroupBox_Enter(sender As Object, e As EventArgs) Handles DepartmentGroupBox.Enter

    End Sub

    Private Sub BooksButton_CheckedChanged(sender As Object, e As EventArgs) Handles BooksButton.CheckedChanged
        ' Display the image and promotion for Books.

        DepartmentPictureBox.Image = My.Resources.books
        PromotionTextBox.Text = "Buy two, get the second one for half price."
    End Sub

    Private Sub MusicButton_CheckedChanged(sender As Object, e As EventArgs) Handles MusicButton.CheckedChanged
        ' Display the image and promotion for Music.

        DepartmentPictureBox.Image = My.Resources.music
        PromotionTextBox.Text = "Get a free MP3 download with purchase of a CD."
    End Sub

    Private Sub PeriodicalsButton_CheckedChanged(sender As Object, e As EventArgs) Handles PeriodicalsButton.CheckedChanged
        ' Display the image and promotion for Periodicals.

        DepartmentPictureBox.Image = My.Resources.periodicals
        PromotionTextBox.Text = "Elite members receive 10% off every purchase."
    End Sub

    Private Sub CoffeeButton_CheckedChanged(sender As Object, e As EventArgs) Handles CoffeeButton.CheckedChanged
        ' Display the image and promotion for Coffee.

        DepartmentPictureBox.Image = My.Resources.coffee
        PromotionTextBox.Text = "Celebrate the season with 20% off our speciality drinks!"
    End Sub

    Private Sub ImageVisibleCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ImageVisibleCheckBox.CheckedChanged
        'Set the visibility of the department image.

        DepartmentPictureBox.Visible = ImageVisibleCheckBox.Checked
    End Sub

    Private Sub DepartmentPictureBox_Click(sender As Object, e As EventArgs) Handles DepartmentPictureBox.Click

    End Sub

    Private Sub WelcomeRichTextBox_TextChanged(sender As Object, e As EventArgs) Handles WelcomeRichTextBox.TextChanged

    End Sub

    Private Sub PromotionTextBox_TextChanged(sender As Object, e As EventArgs) Handles PromotionTextBox.TextChanged

    End Sub

    Private Sub MemberIDMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MemberIDMaskedTextBox.MaskInputRejected

    End Sub
End Class
