<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Main_Calendar
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.But_Dec = New System.Windows.Forms.Button()
        Me.But_Nov = New System.Windows.Forms.Button()
        Me.But_Oct = New System.Windows.Forms.Button()
        Me.But_Sep = New System.Windows.Forms.Button()
        Me.But_Aug = New System.Windows.Forms.Button()
        Me.But_Jul = New System.Windows.Forms.Button()
        Me.But_Jun = New System.Windows.Forms.Button()
        Me.But_May = New System.Windows.Forms.Button()
        Me.Btn_Apr = New System.Windows.Forms.Button()
        Me.Btn_Mar = New System.Windows.Forms.Button()
        Me.Btn_Feb = New System.Windows.Forms.Button()
        Me.Btn_Jan = New System.Windows.Forms.Button()
        Me.Btn_Year_Calendar = New System.Windows.Forms.Button()
        Me.Btn_Grid_View = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Btn_Main_title = New System.Windows.Forms.Button()
        Me.Btn_Month_calendar = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Combo_Month_Select = New System.Windows.Forms.ComboBox()
        Me.Lbl_Select_Month = New System.Windows.Forms.Label()
        Me.TextBox_Year_Input = New System.Windows.Forms.TextBox()
        Me.Lbl_Enter_Year = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Help_User = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.But_Dec, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.But_Nov, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.But_Oct, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.But_Sep, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.But_Aug, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.But_Jul, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.But_Jun, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.But_May, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Apr, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Mar, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Feb, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Btn_Jan, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(41, 83)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(996, 642)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'But_Dec
        '
        Me.But_Dec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.But_Dec.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.But_Dec.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Dec.Location = New System.Drawing.Point(750, 431)
        Me.But_Dec.Name = "But_Dec"
        Me.But_Dec.Size = New System.Drawing.Size(243, 208)
        Me.But_Dec.TabIndex = 11
        Me.But_Dec.Text = "             December"
        Me.But_Dec.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.But_Dec.UseVisualStyleBackColor = False
        '
        'But_Nov
        '
        Me.But_Nov.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.But_Nov.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.But_Nov.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Nov.Location = New System.Drawing.Point(501, 431)
        Me.But_Nov.Name = "But_Nov"
        Me.But_Nov.Size = New System.Drawing.Size(243, 208)
        Me.But_Nov.TabIndex = 10
        Me.But_Nov.Text = "             November"
        Me.But_Nov.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.But_Nov.UseVisualStyleBackColor = False
        '
        'But_Oct
        '
        Me.But_Oct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.But_Oct.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.But_Oct.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Oct.Location = New System.Drawing.Point(252, 431)
        Me.But_Oct.Name = "But_Oct"
        Me.But_Oct.Size = New System.Drawing.Size(243, 208)
        Me.But_Oct.TabIndex = 9
        Me.But_Oct.Text = "             October"
        Me.But_Oct.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.But_Oct.UseVisualStyleBackColor = False
        '
        'But_Sep
        '
        Me.But_Sep.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.But_Sep.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.But_Sep.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Sep.Location = New System.Drawing.Point(3, 431)
        Me.But_Sep.Name = "But_Sep"
        Me.But_Sep.Size = New System.Drawing.Size(243, 208)
        Me.But_Sep.TabIndex = 8
        Me.But_Sep.Text = "             September"
        Me.But_Sep.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.But_Sep.UseVisualStyleBackColor = False
        '
        'But_Aug
        '
        Me.But_Aug.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.But_Aug.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.But_Aug.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Aug.Location = New System.Drawing.Point(750, 217)
        Me.But_Aug.Name = "But_Aug"
        Me.But_Aug.Size = New System.Drawing.Size(243, 208)
        Me.But_Aug.TabIndex = 7
        Me.But_Aug.Text = "               August"
        Me.But_Aug.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.But_Aug.UseVisualStyleBackColor = False
        '
        'But_Jul
        '
        Me.But_Jul.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.But_Jul.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.But_Jul.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Jul.Location = New System.Drawing.Point(501, 217)
        Me.But_Jul.Name = "But_Jul"
        Me.But_Jul.Size = New System.Drawing.Size(243, 208)
        Me.But_Jul.TabIndex = 6
        Me.But_Jul.Text = "                 July"
        Me.But_Jul.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.But_Jul.UseVisualStyleBackColor = False
        '
        'But_Jun
        '
        Me.But_Jun.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.But_Jun.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.But_Jun.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_Jun.Location = New System.Drawing.Point(252, 217)
        Me.But_Jun.Name = "But_Jun"
        Me.But_Jun.Size = New System.Drawing.Size(243, 208)
        Me.But_Jun.TabIndex = 5
        Me.But_Jun.Text = "                 June"
        Me.But_Jun.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.But_Jun.UseVisualStyleBackColor = False
        '
        'But_May
        '
        Me.But_May.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.But_May.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.But_May.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.But_May.Location = New System.Drawing.Point(3, 217)
        Me.But_May.Name = "But_May"
        Me.But_May.Size = New System.Drawing.Size(243, 208)
        Me.But_May.TabIndex = 4
        Me.But_May.Text = "                  May"
        Me.But_May.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.But_May.UseVisualStyleBackColor = False
        '
        'Btn_Apr
        '
        Me.Btn_Apr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Apr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Apr.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Btn_Apr.Location = New System.Drawing.Point(750, 3)
        Me.Btn_Apr.Name = "Btn_Apr"
        Me.Btn_Apr.Size = New System.Drawing.Size(243, 208)
        Me.Btn_Apr.TabIndex = 3
        Me.Btn_Apr.Text = "                April"
        Me.Btn_Apr.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Apr.UseVisualStyleBackColor = False
        '
        'Btn_Mar
        '
        Me.Btn_Mar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Mar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Mar.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Mar.Location = New System.Drawing.Point(501, 3)
        Me.Btn_Mar.Name = "Btn_Mar"
        Me.Btn_Mar.Size = New System.Drawing.Size(243, 208)
        Me.Btn_Mar.TabIndex = 2
        Me.Btn_Mar.Text = "                March"
        Me.Btn_Mar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Mar.UseVisualStyleBackColor = False
        '
        'Btn_Feb
        '
        Me.Btn_Feb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Feb.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Feb.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Feb.Location = New System.Drawing.Point(252, 3)
        Me.Btn_Feb.Name = "Btn_Feb"
        Me.Btn_Feb.Size = New System.Drawing.Size(243, 208)
        Me.Btn_Feb.TabIndex = 1
        Me.Btn_Feb.Text = "               February"
        Me.Btn_Feb.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Feb.UseVisualStyleBackColor = False
        '
        'Btn_Jan
        '
        Me.Btn_Jan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Jan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Jan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Btn_Jan.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Jan.Name = "Btn_Jan"
        Me.Btn_Jan.Size = New System.Drawing.Size(243, 208)
        Me.Btn_Jan.TabIndex = 0
        Me.Btn_Jan.Text = "               January"
        Me.Btn_Jan.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Jan.UseVisualStyleBackColor = False
        '
        'Btn_Year_Calendar
        '
        Me.Btn_Year_Calendar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Year_Calendar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Year_Calendar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Year_Calendar.Location = New System.Drawing.Point(1137, 499)
        Me.Btn_Year_Calendar.Name = "Btn_Year_Calendar"
        Me.Btn_Year_Calendar.Size = New System.Drawing.Size(225, 62)
        Me.Btn_Year_Calendar.TabIndex = 1
        Me.Btn_Year_Calendar.Text = "View Year Calendar"
        Me.Btn_Year_Calendar.UseVisualStyleBackColor = False
        '
        'Btn_Grid_View
        '
        Me.Btn_Grid_View.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Grid_View.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Grid_View.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Grid_View.Location = New System.Drawing.Point(1137, 83)
        Me.Btn_Grid_View.Name = "Btn_Grid_View"
        Me.Btn_Grid_View.Size = New System.Drawing.Size(225, 97)
        Me.Btn_Grid_View.TabIndex = 2
        Me.Btn_Grid_View.Text = "Grid View"
        Me.Btn_Grid_View.UseVisualStyleBackColor = False
        '
        'Btn_Exit
        '
        Me.Btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Exit.BackColor = System.Drawing.Color.Gray
        Me.Btn_Exit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Exit.Location = New System.Drawing.Point(1235, 661)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(95, 41)
        Me.Btn_Exit.TabIndex = 3
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = False
        '
        'Btn_Main_title
        '
        Me.Btn_Main_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Main_title.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Main_title.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Btn_Main_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Main_title.Location = New System.Drawing.Point(41, 12)
        Me.Btn_Main_title.Name = "Btn_Main_title"
        Me.Btn_Main_title.Size = New System.Drawing.Size(993, 65)
        Me.Btn_Main_title.TabIndex = 4
        Me.Btn_Main_title.Text = "Welcome To Calendar"
        Me.Btn_Main_title.UseVisualStyleBackColor = False
        '
        'Btn_Month_calendar
        '
        Me.Btn_Month_calendar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Month_calendar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Month_calendar.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Month_calendar.Location = New System.Drawing.Point(1137, 323)
        Me.Btn_Month_calendar.Name = "Btn_Month_calendar"
        Me.Btn_Month_calendar.Size = New System.Drawing.Size(225, 64)
        Me.Btn_Month_calendar.TabIndex = 5
        Me.Btn_Month_calendar.Text = "View Month Calendar"
        Me.Btn_Month_calendar.UseVisualStyleBackColor = False
        '
        'Combo_Month_Select
        '
        Me.Combo_Month_Select.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Combo_Month_Select.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Combo_Month_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_Month_Select.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Month_Select.FormattingEnabled = True
        Me.Combo_Month_Select.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.Combo_Month_Select.Location = New System.Drawing.Point(1137, 287)
        Me.Combo_Month_Select.Name = "Combo_Month_Select"
        Me.Combo_Month_Select.Size = New System.Drawing.Size(225, 30)
        Me.Combo_Month_Select.TabIndex = 6
        '
        'Lbl_Select_Month
        '
        Me.Lbl_Select_Month.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Select_Month.AutoSize = True
        Me.Lbl_Select_Month.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Select_Month.Location = New System.Drawing.Point(1133, 241)
        Me.Lbl_Select_Month.Name = "Lbl_Select_Month"
        Me.Lbl_Select_Month.Size = New System.Drawing.Size(134, 24)
        Me.Lbl_Select_Month.TabIndex = 7
        Me.Lbl_Select_Month.Text = "Select Month"
        '
        'TextBox_Year_Input
        '
        Me.TextBox_Year_Input.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox_Year_Input.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox_Year_Input.Location = New System.Drawing.Point(1137, 471)
        Me.TextBox_Year_Input.Name = "TextBox_Year_Input"
        Me.TextBox_Year_Input.Size = New System.Drawing.Size(225, 22)
        Me.TextBox_Year_Input.TabIndex = 8
        Me.TextBox_Year_Input.Text = "2019"
        '
        'Lbl_Enter_Year
        '
        Me.Lbl_Enter_Year.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Lbl_Enter_Year.AutoSize = True
        Me.Lbl_Enter_Year.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Enter_Year.Location = New System.Drawing.Point(1133, 446)
        Me.Lbl_Enter_Year.Name = "Lbl_Enter_Year"
        Me.Lbl_Enter_Year.Size = New System.Drawing.Size(224, 22)
        Me.Lbl_Enter_Year.TabIndex = 9
        Me.Lbl_Enter_Year.Text = "Enter Year(1583-99999)"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1133, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "(or click any Month Tile)"
        '
        'Help_User
        '
        Me.Help_User.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Help_User.AutoSize = True
        Me.Help_User.BackColor = System.Drawing.Color.Navy
        Me.Help_User.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help_User.ForeColor = System.Drawing.Color.White
        Me.Help_User.Location = New System.Drawing.Point(1167, 661)
        Me.Help_User.Name = "Help_User"
        Me.Help_User.Size = New System.Drawing.Size(37, 38)
        Me.Help_User.TabIndex = 11
        Me.Help_User.Text = "?"
        '
        'Form_Main_Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1480, 834)
        Me.Controls.Add(Me.Help_User)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_Enter_Year)
        Me.Controls.Add(Me.TextBox_Year_Input)
        Me.Controls.Add(Me.Lbl_Select_Month)
        Me.Controls.Add(Me.Combo_Month_Select)
        Me.Controls.Add(Me.Btn_Month_calendar)
        Me.Controls.Add(Me.Btn_Main_title)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.Btn_Grid_View)
        Me.Controls.Add(Me.Btn_Year_Calendar)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form_Main_Calendar"
        Me.Text = "Year Calendar"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents But_Dec As System.Windows.Forms.Button
    Friend WithEvents But_Nov As System.Windows.Forms.Button
    Friend WithEvents But_Oct As System.Windows.Forms.Button
    Friend WithEvents But_Sep As System.Windows.Forms.Button
    Friend WithEvents But_Aug As System.Windows.Forms.Button
    Friend WithEvents But_Jul As System.Windows.Forms.Button
    Friend WithEvents But_Jun As System.Windows.Forms.Button
    Friend WithEvents But_May As System.Windows.Forms.Button
    Friend WithEvents Btn_Apr As System.Windows.Forms.Button
    Friend WithEvents Btn_Mar As System.Windows.Forms.Button
    Friend WithEvents Btn_Feb As System.Windows.Forms.Button
    Friend WithEvents Btn_Jan As System.Windows.Forms.Button
    Friend WithEvents Btn_Year_Calendar As System.Windows.Forms.Button
    Friend WithEvents Btn_Grid_View As System.Windows.Forms.Button
    Friend WithEvents Btn_Exit As System.Windows.Forms.Button
    Friend WithEvents Btn_Main_title As System.Windows.Forms.Button
    Friend WithEvents Btn_Month_calendar As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Combo_Month_Select As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Select_Month As System.Windows.Forms.Label
    Friend WithEvents TextBox_Year_Input As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Enter_Year As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Help_User As System.Windows.Forms.Label

End Class
