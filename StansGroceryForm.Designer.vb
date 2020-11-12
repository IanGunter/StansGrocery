<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGroceryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.SelectItemComboBox = New System.Windows.Forms.ComboBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.LookUpLabel = New System.Windows.Forms.Label()
        Me.SelectLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LeftGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.CategoryButton = New System.Windows.Forms.RadioButton()
        Me.AisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopMenuStrip.SuspendLayout()
        Me.LeftGroupBox.SuspendLayout()
        Me.FilterGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.TopMenuStrip.Size = New System.Drawing.Size(625, 24)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileTopMenuItem.Text = "&File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpTopMenuItem
        '
        Me.HelpTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuItem})
        Me.HelpTopMenuItem.Name = "HelpTopMenuItem"
        Me.HelpTopMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.HelpTopMenuItem.Text = "Help"
        '
        'AboutTopMenuItem
        '
        Me.AboutTopMenuItem.Name = "AboutTopMenuItem"
        Me.AboutTopMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutTopMenuItem.Text = "About"
        '
        'searchTextBox
        '
        Me.searchTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.searchTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.searchTextBox.Location = New System.Drawing.Point(82, 49)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(411, 20)
        Me.searchTextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.searchTextBox, "Search for an Item ")
        '
        'SelectItemComboBox
        '
        Me.SelectItemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SelectItemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SelectItemComboBox.FormattingEnabled = True
        Me.SelectItemComboBox.Location = New System.Drawing.Point(82, 72)
        Me.SelectItemComboBox.Name = "SelectItemComboBox"
        Me.SelectItemComboBox.Size = New System.Drawing.Size(218, 21)
        Me.SelectItemComboBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.SelectItemComboBox, "Select the Aisle/ Category of the item needed")
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(306, 72)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(291, 251)
        Me.DisplayListBox.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.DisplayListBox, "Filtered Items appear here ")
        '
        'LookUpLabel
        '
        Me.LookUpLabel.AutoSize = True
        Me.LookUpLabel.Location = New System.Drawing.Point(5, 46)
        Me.LookUpLabel.Name = "LookUpLabel"
        Me.LookUpLabel.Size = New System.Drawing.Size(71, 13)
        Me.LookUpLabel.TabIndex = 4
        Me.LookUpLabel.Text = "Look Up Item"
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Location = New System.Drawing.Point(16, 72)
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(60, 13)
        Me.SelectLabel.TabIndex = 5
        Me.SelectLabel.Text = "Select Item"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(499, 46)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(98, 20)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.Text = "&Search"
        Me.ToolTip1.SetToolTip(Me.SearchButton, "Searches ")
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LeftGroupBox
        '
        Me.LeftGroupBox.Controls.Add(Me.DisplayLabel)
        Me.LeftGroupBox.Location = New System.Drawing.Point(82, 99)
        Me.LeftGroupBox.Name = "LeftGroupBox"
        Me.LeftGroupBox.Size = New System.Drawing.Size(218, 224)
        Me.LeftGroupBox.TabIndex = 7
        Me.LeftGroupBox.TabStop = False
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(3, 16)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(209, 205)
        Me.DisplayLabel.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DisplayLabel, "Displays the item's Location and Category")
        '
        'CategoryButton
        '
        Me.CategoryButton.AutoSize = True
        Me.CategoryButton.Location = New System.Drawing.Point(6, 19)
        Me.CategoryButton.Margin = New System.Windows.Forms.Padding(2)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(67, 17)
        Me.CategoryButton.TabIndex = 9
        Me.CategoryButton.TabStop = True
        Me.CategoryButton.Text = "Category"
        Me.ToolTip1.SetToolTip(Me.CategoryButton, "Filter by Category")
        Me.CategoryButton.UseVisualStyleBackColor = True
        '
        'AisleRadioButton
        '
        Me.AisleRadioButton.AutoSize = True
        Me.AisleRadioButton.Location = New System.Drawing.Point(6, 37)
        Me.AisleRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.AisleRadioButton.Name = "AisleRadioButton"
        Me.AisleRadioButton.Size = New System.Drawing.Size(47, 17)
        Me.AisleRadioButton.TabIndex = 10
        Me.AisleRadioButton.TabStop = True
        Me.AisleRadioButton.Text = "Aisle"
        Me.ToolTip1.SetToolTip(Me.AisleRadioButton, "Filter by Aisle")
        Me.AisleRadioButton.UseVisualStyleBackColor = True
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.CategoryButton)
        Me.FilterGroupBox.Controls.Add(Me.AisleRadioButton)
        Me.FilterGroupBox.Location = New System.Drawing.Point(4, 99)
        Me.FilterGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.FilterGroupBox.Size = New System.Drawing.Size(74, 61)
        Me.FilterGroupBox.TabIndex = 11
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filter By:"
        '
        'StansGroceryForm
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 347)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.LeftGroupBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.LookUpLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.SelectItemComboBox)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "StansGroceryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to Stan's Grocery"
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.LeftGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileTopMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopMenuItem As ToolStripMenuItem
    Friend WithEvents AboutTopMenuItem As ToolStripMenuItem
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents SelectItemComboBox As ComboBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents LookUpLabel As Label
    Friend WithEvents SelectLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents LeftGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents CategoryButton As RadioButton
    Friend WithEvents AisleRadioButton As RadioButton
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
