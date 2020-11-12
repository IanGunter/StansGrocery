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
    Dim seperatedData() As String
    Dim betterSepArray() As String
    Dim sortedAisles() As String
    Dim sortedcategories() As String
    Dim fullArray2(,) As String
    Dim sizer As Integer

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click

        Dim matched As Match
        Dim goodData As Boolean
        goodData = False
        'closes the program when ZZZ is searched
        If searchTextBox.Text = "zzz" Then
            Me.Close()
        End If

        DisplayListBox.Items.Clear()

        'Display items in the displayListbox when they match a search.
        For n = 0 To sizer
            Try
                matched = Regex.Match(fullArray2(n, 0), searchTextBox.Text, RegexOptions.IgnoreCase)
            Catch ex As Exception
            End Try

            If matched.Success = True Then
                goodData = True
                DisplayListBox.Items.Add(fullArray2(n, 0))
                DisplayLabel.Text = ""
            Else
            End If

        Next
        If goodData = False Then
            DisplayLabel.Text = ("Sorry no matches for " & searchTextBox.Text)
        End If




    End Sub

    Public Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SplashScreenForm.Show()
        Dim match As Match
        Dim i As Integer
        Dim u As Integer


        lineData = Split(My.Resources.GroceryList, vbNewLine)

        'Autosizer used to find how big an Array should be based off counting significant text matches.
        For A = 0 To UBound(lineData)
            match = Regex.Match(lineData(i), "ITM")

            If match.Success = True Then
                sizer += 1
            End If
        Next

        Dim fullArray(sizer, 2) As String

        'Series of arrays that sorts the Data in the text file.
        For Each thingy In lineData
            u = 0
            seperatedData = Split(thingy, $"{Chr(34)},{Chr(34)}")
            betterSepArray = Split(seperatedData(0), "$$ITM")
            fullArray(i, u) = betterSepArray(1)
            u += 1
            betterSepArray = Split(seperatedData(1), "##LOC")
            fullArray(i, u) = betterSepArray(1)
            u += 1
            betterSepArray = Split(seperatedData(2), "%%CAT")
            betterSepArray = Split(betterSepArray(1), Chr(34))
            fullArray(i, u) = betterSepArray(0)

            If i <> sizer Then
                i += 1
            End If
        Next

        'Copy FullArray into FullArray 2 to make a global 
        fullArray2 = fullArray

        'Add Items to listBox
        For Variable = 0 To sizer
            Try
                DisplayListBox.Items.Add(fullArray(Variable, 0))
            Catch Ex As Exception
            End Try
        Next

        DisplayListBox.Sorted = True
        AisleSorter()
        CatSorter()
        CategoryButton.Checked = True

    End Sub

    Sub AisleSorter()
        'Sorts the ailse numbers in numerical order
        Dim Ailes(sizer) As String

        For a = 0 To sizer
            Ailes(a) = fullArray2(a, 1)

            Dim stuff As String = String.Join(",", Ailes)
            Dim dedupe As String = DuplicateRemover(stuff)
            sortedAisles = Regex.Split(dedupe, ",")
            For z = 0 To UBound(sortedAisles)
                sortedAisles(z) = sortedAisles(z).PadLeft(2)
            Next
        Next
        Array.Sort(sortedAisles)
        Console.ReadLine()

    End Sub

    Sub CatSorter()
        'Sort the categories in Alphabetical order
        Dim Category(sizer) As String

        For b = 0 To sizer
            Category(b) = fullArray2(b, 2)

            Dim stuff As String = String.Join(",", Category)
            Dim dedupe As String = DuplicateRemover(stuff)
            sortedcategories = Regex.Split(dedupe, ",")

        Next
        Try
            Array.Sort(sortedcategories)
        Catch ex As Exception

        End Try

    End Sub


    Public Sub CategoryButton_CheckedChanged(sender As Object, e As EventArgs) Handles CategoryButton.CheckedChanged
        'Updates the combobox between Aisle numbers or the Category of the Item  

        If CategoryButton.Checked = True Then
            SelectItemComboBox.Items.Clear()
            SelectItemComboBox.Items.Add("Show All")
            For p = 0 To UBound(sortedcategories)
                SelectItemComboBox.Items.Add(sortedcategories(p))
            Next
            SelectItemComboBox.SelectedItem = "Show All"
        Else
            SelectItemComboBox.Items.Clear()
            SelectItemComboBox.Items.Add("Show All")
            For d = 0 To UBound(sortedAisles)
                SelectItemComboBox.Items.Add(sortedAisles(d))
            Next
            SelectItemComboBox.SelectedItem = "Show All"
        End If

    End Sub

    Function DuplicateRemover(ByVal sInput As String, Optional ByVal sDelimiter As String = ",") As String

        'Removes Duplicate Values in an array.
        Dim varSection As String
        Dim sTemp As String

        For Each varSection In Split(sInput, sDelimiter)
            If InStr(1, sDelimiter & sTemp & sDelimiter, sDelimiter & varSection & sDelimiter, vbTextCompare) = 0 Then
                sTemp = sTemp & sDelimiter & varSection
            End If
        Next varSection

        DuplicateRemover = Mid(sTemp, Len(sDelimiter) + 1)

    End Function

    Private Sub SelectItemComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectItemComboBox.SelectedIndexChanged
        Dim anArray(1) As String
        SelectItemComboBox.SelectedItem.ToString()
        DisplayListBox.Items.Clear()

        'Sort items into into Displaybox based off of aisle or category.
        For s = 0 To sizer
            For f = 0 To 2
                If AisleRadioButton.Checked = True Then
                    If SelectItemComboBox.SelectedItem.ToString() = fullArray2(s, f) Or SelectItemComboBox.SelectedItem.ToString() = " " & fullArray2(s, f) Then
                        DisplayListBox.Items.Add(fullArray2(s, 0))
                    End If
                Else
                    If SelectItemComboBox.SelectedItem.ToString() = fullArray2(s, f) Then
                        DisplayListBox.Items.Add(fullArray2(s, 0))
                    End If
                End If

            Next
            If SelectItemComboBox.SelectedItem.ToString() = "Show All" Then
                Try
                    DisplayListBox.Items.Add(fullArray2(s, 0))
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged

        'Updates the display label with the location when an item is selected.
        For x = 0 To sizer
            If DisplayListBox.SelectedItem.ToString() = fullArray2(x, 0) Then
                DisplayLabel.Text = ("You will find " & fullArray2(x, 0) & " in aisle " & fullArray2(x, 1) & " around the " & fullArray2(x, 2))
            End If
        Next

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutTopMenuItem_Click(sender As Object, e As EventArgs) Handles AboutTopMenuItem.Click
        AboutForm.Show()
    End Sub
End Class
