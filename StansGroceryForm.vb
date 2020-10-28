'Ian Gunter
'RCET 0265
'StansGrocery
'Fall 2020
'




Public Class StansGroceryForm
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If LookUpTextBox.Text = "zzz" Then
            Me.Close()
        End If

    End Sub
End Class
