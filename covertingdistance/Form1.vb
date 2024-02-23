Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded.
        ' It currently does not contain any code.
    End Sub

    Private Sub btnConverttoKM_Click(sender As Object, e As EventArgs) Handles ButtonconverttoKM.Click
        ' This event handler is executed when the "Convert" button is clicked.
        ' It converts miles to kilometers or kilometers to miles based on user input.

        ' Variables declaration
        Dim Input As Decimal ' Variable to store user input (either miles or kilometers)
        Dim Output As Decimal ' Variable to store the converted result
        Dim UserName As String ' Unused variable, possibly for future use

        ' Input
        Input = txtMiles.Text ' Get user input from the text box for miles

        ' Processing
        If rdoKMinput.Checked Then
            ' If user selects kilometers input
            lblInput.Text = "Kilometers" ' Update labels for clarity
            lblOutput.Text = "Miles"
            Output = Input / 1.609 ' Convert miles to kilometers
        End If

        If rdoMInput.Checked Then
            ' If user selects miles input
            lblInput.Text = "Miles" ' Update labels for clarity
            lblOutput.Text = "Kilometers"
            Output = Input * 1.609 ' Convert kilometers to miles
        End If

        ' Output
        txtKM.Text = Output ' Display the converted result in the appropriate text box
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' This event handler is executed when the "Clear" button is clicked.
        ' It clears the text boxes for miles and kilometers.

        ' Variables declaration
        Dim Miles As Decimal ' Variable to store miles
        Dim KM As Decimal ' Variable to store kilometers

        KM = txtKM.Text ' Get user input from the text box for kilometers
        Miles = KM / 1.609 ' Convert kilometers to miles
        txtMiles.Text = Miles ' Display the result in the miles text box
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKMinput.CheckedChanged
        ' This event handler is executed when the "Kilometers" radio button is checked or unchecked.
        ' Currently, it does not contain any code.
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMInput.CheckedChanged
        ' This event handler is executed when the "Miles" radio button is checked or unchecked.
        ' Currently, it does not contain any code.
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles Label.Click
        ' This event handler is executed when the label is clicked.
        ' Currently, it does not contain any code.
    End Sub

    Private Sub txtMiles_TextChanged(sender As Object, e As EventArgs) Handles txtMiles.TextChanged
        ' This event handler is executed when the text in the miles text box is changed.
        ' Currently, it does not contain any code.
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter
        ' This event handler is executed when the group box is entered.
        ' Currently, it does not contain any code.
    End Sub

    Private Sub txtKM_TextChanged(sender As Object, e As EventArgs) Handles txtKM.TextChanged
        ' This event handler is executed when the text in the kilometers text box is changed.
        ' Currently, it does not contain any code.
    End Sub
End Class