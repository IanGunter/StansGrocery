'Ian Gunter
'RCET 0265
'StansGrocery
'Fall 2020
'https://github.com/IanGunter/StansGrocery.git

Option Strict On
Option Compare Text
Option Explicit On
Imports System.Text.RegularExpressions

Public Class StansGroceryForm

    Dim lineData() As String
    Dim SeperatedData() As String
    Dim betterSepArray() As String
    Dim FoodArray(0, 2) As String
    Dim i As Integer
    Dim u As Integer
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        If LookUpTextBox.Text = "zzz" Then
            Me.Close()
        End If

        lineData = Split(My.Resources.GroceryList, vbNewLine)

        For Each thingy In lineData

            SeperatedData = Split(thingy, $"{Chr(34)},{Chr(34)}")

            betterSepArray = Split(SeperatedData(0), "$$ITM")
            FoodArray(i, u) = betterSepArray(1)
            u += 1
            betterSepArray = Split(SeperatedData(1), "##LOC")
            FoodArray(i, u) = betterSepArray(1)
            u += 1
            betterSepArray = Split(SeperatedData(2), "%%CAT")
            FoodArray(i, u) = betterSepArray(1)
            u = 0
            i += 1
            ReDim Preserve FoodArray
            'betterSepArray = Split(betterSepArray(1), Chr(34))
        Next






    End Sub

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreenForm.Show()

    End Sub



End Class
