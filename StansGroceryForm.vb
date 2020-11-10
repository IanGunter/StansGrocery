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
    Dim i As Integer
    Dim u As Integer
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim match As Match
        Dim Sizer As Integer

        If LookUpTextBox.Text = "zzz" Then
            Me.Close()
        End If

        lineData = Split(My.Resources.GroceryList, vbNewLine)

        For A = 0 To UBound(lineData)
            match = Regex.Match(lineData(i), "ITM")

            If match.Success = True Then
                Sizer += 1


            End If
        Next

        Dim fullArray(Sizer, 2) As String
        Dim foodArray(Sizer) As String

        For Each thingy In lineData

            u = 0
            SeperatedData = Split(thingy, $"{Chr(34)},{Chr(34)}")

            betterSepArray = Split(SeperatedData(0), "$$ITM")
            fullArray(i, u) = betterSepArray(1)
            foodArray(i) = betterSepArray(1)
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

        Array.Sort(foodArray)

        For Variable = 0 To Sizer
            Try

                DisplayListBox.Items.Add(foodArray(Variable))

            Catch Ex As Exception

            End Try

        Next

        'For chungus = 0 To Sizer
        '    For chungnus = 0 To 2
        '        Try
        '            DisplayListBox.Items.Add(fullArray(chungus, chungnus))

        '        Catch Ex As Exception

        '        End Try
        '    Next
        'Next

    End Sub

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SplashScreenForm.Show()

    End Sub



End Class
