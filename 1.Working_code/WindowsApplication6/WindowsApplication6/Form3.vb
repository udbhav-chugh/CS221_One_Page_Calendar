Public Class Form_Month_Calendar

    'Function print individual month
    Private Function printMonth(ByVal num As Integer, ByVal year As Integer, ByRef outp As String)
        Dim start, nn As Integer
        start = Form_Main_Calendar.dayNum(1, num, Form_Main_Calendar.year) 'start contains day of first of month num
        nn = Form_Main_Calendar.numberOfDays(num, Form_Main_Calendar.year) 'nn contains number of days in month num

        outp = "  S       M       T       W       T       F        S" & vbLf

        Dim i As Integer
        'Next 5 lines to adjust start space before printing 1
        For i = 1 To start
            outp = outp & "          "
        Next

        outp = outp & " "
        'loop to print dates from 1 to number of days in that month with required spaces
        For i = 1 To nn
            outp = outp & i & "      "
            If i < 10 Then
                outp = outp & "  "
            End If
            start = start + 1
            If start Mod 7 = 0 Then
                outp = outp & vbLf & " "
            End If

        Next
    End Function

    'returns month name corressponding to integer value(1->january,2->February and so on)
    'i stores the month code
    Private Function monthname(ByVal i As Integer) As String
        Dim mname() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}
        Return mname(i - 1)
    End Function
    'Main form function to print corresponding month calendar
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_Month_Title.Text = monthname(Form_Main_Calendar.monInt) & " " & CStr(Form_Main_Calendar.year)
        printMonth(Form_Main_Calendar.monInt, Form_Main_Calendar.year, Btn_Month_Show.Text)
    End Sub

    'Go back button to return to main form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Btn_go_back_to_main.Click
        Form_Main_Calendar.Show()
        Me.Close()
    End Sub
    'End of form3(Month Calendar)
End Class