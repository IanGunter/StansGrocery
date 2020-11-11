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

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        If LookUpTextBox.Text = "zzz" Then
            Me.Close()
        End If

    End Sub

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SplashScreenForm.Show()
        Dim match As Match
        Dim Sizer As Integer
        Dim i As Integer
        Dim u As Integer


        AllRadioButton.Checked = True
        lineData = Split(My.Resources.GroceryList, vbNewLine)

        'Autosizer used to find how big an Array should be based off counting significant text matches.
        For A = 0 To UBound(lineData)
            match = Regex.Match(lineData(i), "ITM")

            If match.Success = True Then
                Sizer += 1
            End If
        Next

        Dim fullArray(Sizer, 2) As String

        For Each thingy In lineData
            u = 0
            SeperatedData = Split(thingy, $"{Chr(34)},{Chr(34)}")
            betterSepArray = Split(SeperatedData(0), "$$ITM")
            fullArray(i, u) = betterSepArray(1)
            u += 1
            betterSepArray = Split(SeperatedData(1), "##LOC")
            fullArray(i, u) = betterSepArray(1)
            u += 1
            betterSepArray = Split(SeperatedData(2), "%%CAT")
            betterSepArray = Split(betterSepArray(1), Chr(34))
            fullArray(i, u) = betterSepArray(0)

            If i <> Sizer Then
                i += 1
            End If
        Next

        For Variable = 0 To Sizer
            Try

                DisplayListBox.Items.Add(fullArray(Variable, 0))
            Catch Ex As Exception

            End Try
        Next
        DisplayListBox.Sorted = True

    End Sub

End Class
