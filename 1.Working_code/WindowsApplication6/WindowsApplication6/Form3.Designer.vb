<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Month_Calendar
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
        Me.Btn_Month_Show = New System.Windows.Forms.Button()
        Me.Btn_Month_Title = New System.Windows.Forms.Button()
        Me.Btn_go_back_to_main = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Month_Show
        '
        Me.Btn_Month_Show.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Month_Show.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Month_Show.Font = New System.Drawing.Font("Arial Narrow", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Month_Show.Location = New System.Drawing.Point(164, 103)
        Me.Btn_Month_Show.Name = "Btn_Month_Show"
        Me.Btn_Month_Show.Size = New System.Drawing.Size(561, 472)
        Me.Btn_Month_Show.TabIndex = 0
        Me.Btn_Month_Show.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Month_Show.UseVisualStyleBackColor = False
        '
        'Btn_Month_Title
        '
        Me.Btn_Month_Title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_Month_Title.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Month_Title.Font = New System.Drawing.Font("Arial", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Btn_Month_Title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Month_Title.Location = New System.Drawing.Point(164, 30)
        Me.Btn_Month_Title.Name = "Btn_Month_Title"
        Me.Btn_Month_Title.Size = New System.Drawing.Size(561, 67)
        Me.Btn_Month_Title.TabIndex = 1
        Me.Btn_Month_Title.UseVisualStyleBackColor = False
        '
        'Btn_go_back_to_main
        '
        Me.Btn_go_back_to_main.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Btn_go_back_to_main.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_go_back_to_main.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_go_back_to_main.Location = New System.Drawing.Point(344, 605)
        Me.Btn_go_back_to_main.Name = "Btn_go_back_to_main"
        Me.Btn_go_back_to_main.Size = New System.Drawing.Size(185, 86)
        Me.Btn_go_back_to_main.TabIndex = 2
        Me.Btn_go_back_to_main.Text = "Go Back"
        Me.Btn_go_back_to_main.UseVisualStyleBackColor = False
        '
        'Form_Month_Calendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(906, 703)
        Me.Controls.Add(Me.Btn_go_back_to_main)
        Me.Controls.Add(Me.Btn_Month_Title)
        Me.Controls.Add(Me.Btn_Month_Show)
        Me.Name = "Form_Month_Calendar"
        Me.Text = "Month Calendar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Month_Show As System.Windows.Forms.Button
    Friend WithEvents Btn_Month_Title As System.Windows.Forms.Button
    Friend WithEvents Btn_go_back_to_main As System.Windows.Forms.Button
End Class
