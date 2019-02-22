Public Class Form_Grid_View

    'returns first three letters of month corresponding to its integer vale=ue(1->Jan,2->Feb and so on)
    Private Function monname(ByVal i As Integer) As String
        Dim mname() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Return mname(i - 1)
    End Function

    'main form function to print grid view
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_title_grid_view.Text = "Welcome To Calendar " & CStr(Form_Main_Calendar.year)
        'first element 1 since when remainder is 0 we need to print in button 7
        'other elements are 0 since we have to start with the corresponding remainder obtained (example- if remainder 2 print in button2
        Dim count() As Integer = {1, 0, 0, 0, 0, 0, 0}
        Dim temp, i, temp2 As Integer

        'get column of every month by using day for first of every month
        For i = 1 To 12
            temp = Form_Main_Calendar.dayNum(1, i, Form_Main_Calendar.year)

            temp2 = temp + (count(temp) * 7)
            count(temp) = count(temp) + 1 'if printed in button 2, next time it should print in button 9

            'Print month name in corresponing button name, Find(...)(0) function generates button number
            ' in which month name needs to be added
            Me.Controls.Find("Button" & CStr(temp2), True)(0).Text = monname(i)

        Next
    End Sub

    'Go back option to return to main form and close this form
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Btn_go_to_main.Click
        Form_Main_Calendar.Show()
        Me.Close()
    End Sub
    'End of form2(Grid View)
End Class