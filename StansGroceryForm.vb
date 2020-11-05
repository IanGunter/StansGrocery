'Ian Gunter
'RCET 0265
'StansGrocery
'Fall 2020
'https://github.com/IanGunter/StansGrocery.git

Option Strict On
Option Compare Text
Option Explicit On


Public Class StansGroceryForm

    Dim tempdata() As String
    Dim i As Integer
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If LookUpTextBox.Text = "zzz" Then
            Me.Close()
        End If

        tempdata = Split(My.Resources.GroceryList, vbNewLine)

        MsgBox(tempdata(i))
        i += 1



    End Sub

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreenForm.Show()

    End Sub



End Class
