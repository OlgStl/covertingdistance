Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConverttoKM_Click(sender As Object, e As EventArgs) Handles ButtonconverttoKM.Click
        'variables
        Dim Input As Decimal
        Dim Output As Decimal
        Dim UserName As String

        'input
        Input = txtMiles.Text


        'processing
        If rdoKMinput.Checked Then
            lblInput.Text = "Kilometers"
            lblOutput.Text = "Miles"
            Output = Input / 1.609
        End If

        If rdoMInput.Checked Then
            lblInput.Text = "Miles"
            lblOutput.Text = "Kilometers"
            Output = Input * 1.609
        End If

        'output
        txtKM.Text = Output

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Miles As Decimal
        Dim KM As Decimal

        KM = txtKM.Text
        Miles = KM / 1.609
        txtMiles.Text = Miles
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKMinput.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMInput.CheckedChanged

    End Sub
End Class
