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
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LookUpTextBox = New System.Windows.Forms.TextBox()
        Me.SelectItemComboBox = New System.Windows.Forms.ComboBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.LookUpLabel = New System.Windows.Forms.Label()
        Me.SelectLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LeftGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.AllRadioButton = New System.Windows.Forms.RadioButton()
        Me.CategoryButton = New System.Windows.Forms.RadioButton()
        Me.AisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.TopMenuStrip.SuspendLayout()
        Me.LeftGroupBox.SuspendLayout()
        Me.FilterGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileTopMenuItem, Me.HelpTopMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1250, 48)
        Me.TopMenuStrip.TabIndex = 0
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileTopMenuItem
        '
        Me.FileTopMenuItem.Name = "FileTopMenuItem"
        Me.FileTopMenuItem.Size = New System.Drawing.Size(72, 40)
        Me.FileTopMenuItem.Text = "&File"
        '
        'HelpTopMenuItem
        '
        Me.HelpTopMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTopMenuItem})
        Me.HelpTopMenuItem.Name = "HelpTopMenuItem"
        Me.HelpTopMenuItem.Size = New System.Drawing.Size(85, 40)
        Me.HelpTopMenuItem.Text = "Help"
        '
        'AboutTopMenuItem
        '
        Me.AboutTopMenuItem.Name = "AboutTopMenuItem"
        Me.AboutTopMenuItem.Size = New System.Drawing.Size(214, 44)
        Me.AboutTopMenuItem.Text = "About"
        '
        'LookUpTextBox
        '
        Me.LookUpTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.LookUpTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources
        Me.LookUpTextBox.Location = New System.Drawing.Point(164, 95)
        Me.LookUpTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.LookUpTextBox.Name = "LookUpTextBox"
        Me.LookUpTextBox.Size = New System.Drawing.Size(818, 31)
        Me.LookUpTextBox.TabIndex = 1
        '
        'SelectItemComboBox
        '
        Me.SelectItemComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.SelectItemComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SelectItemComboBox.FormattingEnabled = True
        Me.SelectItemComboBox.Location = New System.Drawing.Point(164, 138)
        Me.SelectItemComboBox.Margin = New System.Windows.Forms.Padding(6)
        Me.SelectItemComboBox.Name = "SelectItemComboBox"
        Me.SelectItemComboBox.Size = New System.Drawing.Size(432, 33)
        Me.SelectItemComboBox.TabIndex = 2
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 25
        Me.DisplayListBox.Location = New System.Drawing.Point(612, 138)
        Me.DisplayListBox.Margin = New System.Windows.Forms.Padding(6)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(578, 479)
        Me.DisplayListBox.TabIndex = 3
        '
        'LookUpLabel
        '
        Me.LookUpLabel.AutoSize = True
        Me.LookUpLabel.Location = New System.Drawing.Point(10, 88)
        Me.LookUpLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LookUpLabel.Name = "LookUpLabel"
        Me.LookUpLabel.Size = New System.Drawing.Size(138, 25)
        Me.LookUpLabel.TabIndex = 4
        Me.LookUpLabel.Text = "Look Up Item"
        '
        'SelectLabel
        '
        Me.SelectLabel.AutoSize = True
        Me.SelectLabel.Location = New System.Drawing.Point(32, 138)
        Me.SelectLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.SelectLabel.Name = "SelectLabel"
        Me.SelectLabel.Size = New System.Drawing.Size(118, 25)
        Me.SelectLabel.TabIndex = 5
        Me.SelectLabel.Text = "Select Item"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(998, 88)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(6)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(196, 38)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.Text = "&Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LeftGroupBox
        '
        Me.LeftGroupBox.Controls.Add(Me.DisplayLabel)
        Me.LeftGroupBox.Location = New System.Drawing.Point(164, 190)
        Me.LeftGroupBox.Margin = New System.Windows.Forms.Padding(6)
        Me.LeftGroupBox.Name = "LeftGroupBox"
        Me.LeftGroupBox.Padding = New System.Windows.Forms.Padding(6)
        Me.LeftGroupBox.Size = New System.Drawing.Size(436, 431)
        Me.LeftGroupBox.TabIndex = 7
        Me.LeftGroupBox.TabStop = False
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(6, 31)
        Me.DisplayLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(418, 394)
        Me.DisplayLabel.TabIndex = 0
        '
        'AllRadioButton
        '
        Me.AllRadioButton.AutoSize = True
        Me.AllRadioButton.Location = New System.Drawing.Point(12, 40)
        Me.AllRadioButton.Name = "AllRadioButton"
        Me.AllRadioButton.Size = New System.Drawing.Size(67, 29)
        Me.AllRadioButton.TabIndex = 8
        Me.AllRadioButton.TabStop = True
        Me.AllRadioButton.Text = "All"
        Me.AllRadioButton.UseVisualStyleBackColor = True
        '
        'CategoryButton
        '
        Me.CategoryButton.AutoSize = True
        Me.CategoryButton.Location = New System.Drawing.Point(12, 75)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(130, 29)
        Me.CategoryButton.TabIndex = 9
        Me.CategoryButton.TabStop = True
        Me.CategoryButton.Text = "Category"
        Me.CategoryButton.UseVisualStyleBackColor = True
        '
        'AisleRadioButton
        '
        Me.AisleRadioButton.AutoSize = True
        Me.AisleRadioButton.Location = New System.Drawing.Point(12, 110)
        Me.AisleRadioButton.Name = "AisleRadioButton"
        Me.AisleRadioButton.Size = New System.Drawing.Size(90, 29)
        Me.AisleRadioButton.TabIndex = 10
        Me.AisleRadioButton.TabStop = True
        Me.AisleRadioButton.Text = "Aisle"
        Me.AisleRadioButton.UseVisualStyleBackColor = True
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.CategoryButton)
        Me.FilterGroupBox.Controls.Add(Me.AisleRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.AllRadioButton)
        Me.FilterGroupBox.Location = New System.Drawing.Point(8, 190)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(148, 155)
        Me.FilterGroupBox.TabIndex = 11
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filter By:"
        '
        'StansGroceryForm
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1250, 667)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.LeftGroupBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.SelectLabel)
        Me.Controls.Add(Me.LookUpLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.SelectItemComboBox)
        Me.Controls.Add(Me.LookUpTextBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Margin = New System.Windows.Forms.Padding(6)
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
    Friend WithEvents LookUpTextBox As TextBox
    Friend WithEvents SelectItemComboBox As ComboBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents LookUpLabel As Label
    Friend WithEvents SelectLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents LeftGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents AllRadioButton As RadioButton
    Friend WithEvents CategoryButton As RadioButton
    Friend WithEvents AisleRadioButton As RadioButton
    Friend WithEvents FilterGroupBox As GroupBox
End Class
